Imports System.Windows.Forms

Partial Public Class Form_f_BEPPYO2_REP
    Inherits Form

    Public Property FiscalYear As Integer
    Public Property DtFrom As Date
    Public Property DtTo As Date

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_f_BEPPYO_REP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_FISCAL_YEAR.Text = GetGengoShort(FiscalYear) & "・四・一以後終了事業年度又は連結事業年度分"
    End Sub

    ' [実行]ボタン
    Private Sub cmd_EXECUTE_Click(sender As Object, e As EventArgs) Handles cmd_EXECUTE.Click
        ' todo 印刷物を作成する(FiscalYear, DtFrom, DtToも使う)
    End Sub

    ' [キャンセル]ボタン
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_CANCEL.Click
        Me.Close()
    End Sub

    Private Sub FormKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' エンターキーが押されたら次のコントロールへ移動
        HandleEnterKeyNavigation(Me, e)
    End Sub

    ' 西暦から「令二」や「令八」の形式で取得する
    Private Function GetGengoShort(year As Integer) As String
        Dim dt As New Date(year, 4, 1) ' 年度開始日で判定
        Dim jc As New System.Globalization.JapaneseCalendar()

        ' 元号の1文字目を取得 (令和 -> 令)
        Dim ci As New System.Globalization.CultureInfo("ja-JP")
        ci.DateTimeFormat.Calendar = jc
        Dim gengoName As String = dt.ToString("gg", ci).Substring(0, 1)

        ' 元号の年を取得
        Dim gengoYear As Integer = jc.GetYear(dt)

        ' 数値を漢数字に変換
        Dim kanjiYear As String = ToKanji(gengoYear)

        Return gengoName & kanjiYear
    End Function

    ' 数値を漢数字に変換する（1～99まで対応）
    Private Function ToKanji(num As Integer) As String
        Dim kanji As String() = {"", "一", "二", "三", "四", "五", "六", "七", "八", "九", "十"}

        If num <= 10 Then
            Return kanji(num)
        ElseIf num < 20 Then
            Return "十" & kanji(num Mod 10)
        Else
            Return kanji(num \ 10) & "十" & kanji(num Mod 10)
        End If
    End Function
End Class