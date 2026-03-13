' =========================================================
' LoginSession - グローバルユーザーセッション
' Access版 typ_gLogin 構造体に相当
' ログイン成功時にセットし、アプリ全体で参照する
' =========================================================
Imports LeaseM4BS.DataAccess
Imports Npgsql

Public Module LoginSession

    ' --- ユーザー基本情報 ---
    Public LoggedInUserId As Integer = 0
    Public LoggedInUserCd As String = ""
    Public LoggedInUserNm As String = ""

    ' --- 権限グループ情報 (sec_kngn) ---
    Public KngnId As Integer = 0
    Public KngnCd As String = ""
    Public KngnNm As String = ""

    ' --- 権限フラグ (Access版 typ_gLogin の boXxx に相当) ---
    Public AccessKind As Integer = 0       ' 1:全データ変更 2:全データ参照 3:管理単位限定
    Public AccessKindB As Integer = 0      ' 物件管理単位のアクセス種別
    Public IsAdmin As Boolean = False      ' システム管理者権限
    Public CanMasterUpdate As Boolean = False  ' マスタ更新権限
    Public CanFileOutput As Boolean = False    ' ファイル出力権限
    Public CanPrint As Boolean = False         ' 印刷権限
    Public CanLogRef As Boolean = False        ' ログ参照権限
    Public CanApproval As Boolean = False      ' 承認権限

    ''' <summary>
    ''' ログイン成功時に sec_kngn から権限情報を取得してセットする
    ''' </summary>
    Public Sub LoadPermissions(kngnIdParam As Integer)
        Dim crud As New CrudHelper()
        Dim sql As String = "SELECT kngn_id, kngn_cd, kngn_nm, access_kind, access_kind_b, " &
                            "admin, master_update, file_output, print, log_ref, approval " &
                            "FROM sec_kngn WHERE kngn_id = @kngn_id AND history_f = FALSE"
        Dim prms As New List(Of NpgsqlParameter) From {
            New NpgsqlParameter("@kngn_id", kngnIdParam)
        }

        Dim dt = crud.GetDataTable(sql, prms)
        If dt.Rows.Count = 0 Then Return

        Dim row = dt.Rows(0)
        LoginSession.KngnId = kngnIdParam
        LoginSession.KngnCd = If(row("kngn_cd") IsNot DBNull.Value, row("kngn_cd").ToString(), "")
        LoginSession.KngnNm = If(row("kngn_nm") IsNot DBNull.Value, row("kngn_nm").ToString(), "")
        LoginSession.AccessKind = If(row("access_kind") IsNot DBNull.Value, CInt(row("access_kind")), 0)
        LoginSession.AccessKindB = If(row("access_kind_b") IsNot DBNull.Value, CInt(row("access_kind_b")), 0)
        LoginSession.IsAdmin = If(row("admin") IsNot DBNull.Value, CBool(row("admin")), False)
        LoginSession.CanMasterUpdate = If(row("master_update") IsNot DBNull.Value, CBool(row("master_update")), False)
        LoginSession.CanFileOutput = If(row("file_output") IsNot DBNull.Value, CBool(row("file_output")), False)
        LoginSession.CanPrint = If(row("print") IsNot DBNull.Value, CBool(row("print")), False)
        LoginSession.CanLogRef = If(row("log_ref") IsNot DBNull.Value, CBool(row("log_ref")), False)
        LoginSession.CanApproval = If(row("approval") IsNot DBNull.Value, CBool(row("approval")), False)
    End Sub

    ''' <summary>
    ''' ログアウト時にセッション情報をクリアする
    ''' </summary>
    Public Sub Clear()
        LoggedInUserId = 0
        LoggedInUserCd = ""
        LoggedInUserNm = ""
        KngnId = 0
        KngnCd = ""
        KngnNm = ""
        AccessKind = 0
        AccessKindB = 0
        IsAdmin = False
        CanMasterUpdate = False
        CanFileOutput = False
        CanPrint = False
        CanLogRef = False
        CanApproval = False
    End Sub

End Module
