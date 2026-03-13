Imports System
Imports System.Configuration
Imports Npgsql

''' <summary>
''' PostgreSQL データベース接続を管理するクラス
''' DAO.Database の代替として使用します
''' </summary>
''' <remarks>
''' このクラスは、従来の Access DAO コードを置き換えるための
''' PostgreSQL 接続管理機能を提供します。
''' 
''' 使用例:
''' Dim connMgr As New DbConnectionManager()
''' Using conn As NpgsqlConnection = connMgr.GetConnection()
'''     ' データベース操作を実行
''' End Using
''' </remarks>
Public Class DbConnectionManager
    Implements IDisposable

    Private _connectionString As String
    Private _disposed As Boolean = False

    ''' <summary>
    ''' デフォルトコンストラクタ
    ''' App.config または Web.config から接続文字列を読み込みます
    ''' </summary>
    Public Sub New()
        _connectionString = GetConnectionString()
    End Sub

    ''' <summary>
    ''' 接続文字列を指定するコンストラクタ
    ''' </summary>
    ''' <param name="connectionString">PostgreSQL 接続文字列</param>
    Public Sub New(connectionString As String)
        If String.IsNullOrWhiteSpace(connectionString) Then
            Throw New ArgumentException("接続文字列を指定してください。", NameOf(connectionString))
        End If
        _connectionString = connectionString
    End Sub

    ''' <summary>
    ''' 設定ファイルから接続文字列を取得します
    ''' </summary>
    ''' <returns>PostgreSQL 接続文字列</returns>
    ''' <remarks>
    ''' App.config の connectionStrings セクションから "LeaseM4BS" という名前の
    ''' 接続文字列を読み込みます。
    ''' 
    ''' 設定例:
    ''' &lt;connectionStrings&gt;
    '''   &lt;add name="LeaseM4BS" 
    '''        connectionString="Host=localhost;Port=5432;Database=lease_m4bs;Username=postgres;Password=yourpassword" 
    '''        providerName="Npgsql" /&gt;
    ''' &lt;/connectionStrings&gt;
    ''' </remarks>
    Public Function GetConnectionString() As String
        Try
            ' App.config から接続文字列を取得
            Dim connStr As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("LeaseM4BS")

            If connStr IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(connStr.ConnectionString) Then
                Return connStr.ConnectionString
            End If

            ' 環境変数からの取得を試みる（クラウド環境対応）
            Dim envConnStr As String = Environment.GetEnvironmentVariable("LEASE_M4BS_CONNECTION_STRING")
            If Not String.IsNullOrWhiteSpace(envConnStr) Then
                Return envConnStr
            End If

            ' デフォルト接続文字列（開発環境用）
            ' 本番環境では必ず設定ファイルまたは環境変数で上書きしてください
            Return "Host=localhost;Port=5432;Database=lease_m4bs;Username=lease_m4bs_user;Password=iltex_mega_pass_m4"

        Catch ex As Exception
            Throw New InvalidOperationException("接続文字列の取得に失敗しました。App.config を確認してください。", ex)
        End Try
    End Function

    ''' <summary>
    ''' PostgreSQL データベースへの接続を取得します
    ''' </summary>
    ''' <returns>開かれた NpgsqlConnection オブジェクト</returns>
    ''' <remarks>
    ''' このメソッドは、DAO.Database.OpenRecordset の代替として使用します。
    ''' 
    ''' 使用例:
    ''' Using conn As NpgsqlConnection = connMgr.GetConnection()
    '''     Using cmd As New NpgsqlCommand("SELECT * FROM tw_M_USER", conn)
    '''         Using reader As NpgsqlDataReader = cmd.ExecuteReader()
    '''             While reader.Read()
    '''                 ' データ処理
    '''             End While
    '''         End Using
    '''     End Using
    ''' End Using
    ''' 
    ''' 注意: 必ず Using ステートメントを使用して、接続を適切に閉じてください。
    ''' </remarks>
    Public Function GetConnection() As NpgsqlConnection
        Try
            Dim connection As New NpgsqlConnection(_connectionString)
            connection.Open()
            Return connection
        Catch ex As NpgsqlException
            Throw New InvalidOperationException($"データベース接続に失敗しました: {ex.Message}", ex)
        Catch ex As Exception
            Throw New InvalidOperationException($"予期しないエラーが発生しました: {ex.Message}", ex)
        End Try
    End Function

    ''' <summary>
    ''' 接続をテストします
    ''' </summary>
    ''' <returns>接続が成功した場合は True、失敗した場合は False</returns>
    Public Function TestConnection() As Boolean
        Try
            Using conn As NpgsqlConnection = GetConnection()
                Return conn.State = ConnectionState.Open
            End Using
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' 接続をテストし、エラーメッセージを返します
    ''' </summary>
    ''' <param name="errorMessage">エラーメッセージ（成功時は空文字列）</param>
    ''' <returns>接続が成功した場合は True、失敗した場合は False</returns>
    Public Function TestConnection(ByRef errorMessage As String) As Boolean
        Try
            Using conn As NpgsqlConnection = GetConnection()
                If conn.State = ConnectionState.Open Then
                    errorMessage = String.Empty
                    Return True
                Else
                    errorMessage = "接続は開かれましたが、状態が Open ではありません。"
                    Return False
                End If
            End Using
        Catch ex As Exception
            errorMessage = $"接続テストに失敗しました: {ex.Message}"
            Return False
        End Try
    End Function

    ''' <summary>
    ''' 現在の接続文字列を取得します（パスワードはマスクされます）
    ''' </summary>
    ''' <returns>マスクされた接続文字列</returns>
    Public Function GetMaskedConnectionString() As String
        Dim builder As New NpgsqlConnectionStringBuilder(_connectionString)
        Return $"Host={builder.Host};Port={builder.Port};Database={builder.Database}"
    End Function

    ' 簡易ロガークラス（Logger.vb）の作成推奨
    Public Shared Sub WriteError(message As String, ex As Exception)
        Dim logFile = "error.log"
        Dim content = $"{DateTime.Now}: {message}{Environment.NewLine}{ex.ToString()}{Environment.NewLine}"
        System.IO.File.AppendAllText(logFile, content)
    End Sub

    ''' <summary>
    ''' リソースを解放します
    ''' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    ''' <summary>
    ''' リソースを解放します（内部実装）
    ''' </summary>
    ''' <param name="disposing">マネージドリソースを解放する場合は True</param>
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not _disposed Then
            If disposing Then
                ' マネージドリソースの解放
                ' 現在は特に解放するリソースはありません
            End If
            _disposed = True
        End If
    End Sub

    ''' <summary>
    ''' デストラクタ
    ''' </summary>
    Protected Overrides Sub Finalize()
        Dispose(False)
        MyBase.Finalize()
    End Sub

End Class
