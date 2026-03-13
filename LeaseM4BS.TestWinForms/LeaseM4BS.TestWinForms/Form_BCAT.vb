Imports LeaseM4BS.DataAccess

Partial Public Class Form_BCAT
    Inherits Form

    Protected _crud As crudHelper = New crudHelper()

    ' -------------------------------------------------------------------------
    ' マスタデータのロード
    ' -------------------------------------------------------------------------
    Protected Sub LoadBcatCombos(cmbBcat2 As ComboBox, cmbBcat3 As ComboBox, cmbBcat4 As ComboBox, cmbBcat5 As ComboBox)
        Dim sqlBcat2 As String = "SELECT DISTINCT bcat2_cd, bcat2_nm " &
                                    "FROM m_bcat " &
                                    "WHERE bcat2_cd <> '' " &
                                    "ORDER BY bcat2_cd;"

        Dim sqlBcat3 As String = "SELECT DISTINCT bcat3_cd, bcat3_nm " &
                                    "FROM m_bcat " &
                                    "WHERE bcat3_cd <> '' " &
                                    "ORDER BY bcat3_cd;"

        Dim sqlBcat4 As String = "SELECT DISTINCT bcat4_cd, bcat4_nm " &
                                    "FROM m_bcat " &
                                    "WHERE bcat4_cd <> '' " &
                                    "ORDER BY bcat4_cd;"

        Dim sqlBcat5 As String = "SELECT DISTINCT bcat5_cd, bcat5_nm " &
                                    "FROM m_bcat " &
                                    "WHERE bcat5_cd <> '' " &
                                    "ORDER BY bcat5_cd;"

        cmbBcat2.Bind(sqlBcat2, "bcat2_cd", "bcat2_cd")
        cmbBcat3.Bind(sqlBcat3, "bcat3_cd", "bcat3_cd")
        cmbBcat4.Bind(sqlBcat4, "bcat4_cd", "bcat4_cd")
        cmbBcat5.Bind(sqlBcat5, "bcat5_cd", "bcat5_cd")

        For Each cmb In {cmbBcat2, cmbBcat3, cmbBcat4, cmbBcat5}
            cmb.AdjustSize()
            cmb.SelectedIndex = -1
        Next

    End Sub

    Protected Sub LoadGenkCombo(cmbGenk As ComboBox)
        Dim sqlGenk = "SELECT DISTINCT genk_cd, genk_nm " &
                        "FROM m_genk " &
                        "WHERE genk_cd <> '' " &
                        "ORDER BY genk_cd;"

        cmbGenk.Bind(sqlGenk, "genk_cd", "genk_cd")

        cmbGenk.AdjustSize()
        cmbGenk.SelectedIndex = -1
    End Sub

    Protected Sub LoadSumCombos(cmbSum1 As ComboBox, cmbSum2 As ComboBox, cmbSum3 As ComboBox)
        Dim sqlSum1 = "SELECT DISTINCT sum1_cd, sum1_nm " &
                        "FROM m_bcat " &
                        "WHERE sum1_cd <> '' " &
                        "ORDER BY sum1_cd;"

        Dim sqlSum2 = "SELECT DISTINCT sum2_cd, sum2_nm " &
                        "FROM m_bcat " &
                        "WHERE sum1_cd <> '' " &
                        "ORDER BY sum2_cd;"

        Dim sqlSum3 = "SELECT DISTINCT sum3_cd, sum3_nm " &
                        "FROM m_bcat " &
                        "WHERE sum1_cd <> '' " &
                        "ORDER BY sum3_cd;"

        cmbSum1.Bind(sqlSum1, "sum1_cd", "sum1_cd")
        cmbSum2.Bind(sqlSum2, "sum2_cd", "sum2_cd")
        cmbSum3.Bind(sqlSum3, "sum3_cd", "sum3_cd")

        For Each cmb In {cmbSum1, cmbSum2, cmbSum3}
            cmb.AdjustSize()
            cmb.SelectedIndex = -1
        Next
    End Sub

    Protected Sub LoadBknriCombo(cmbBknri As ComboBox)
        Dim sqlBknri As String = "SELECT bknri1_cd, bknri1_nm " &
                                    "FROM m_bknri " &
                                    "WHERE bknri1_cd <> '' " &
                                    "ORDER BY bknri1_cd;"

        cmbBknri.Bind(sqlBknri, "bknri1_cd", "bknri1_cd")
        cmbBknri.AdjustSize()
        cmbBknri.SelectedIndex = -1
    End Sub
End Class