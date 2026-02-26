Imports LeaseM4BS.DataAccess

Partial Public Class Form_BKNRI
    Inherits Form

    Protected _crud As crudHelper = New crudHelper()

    ' -------------------------------------------------------------------------
    ' マスタデータのロード
    ' -------------------------------------------------------------------------
    Protected Sub LoadBknriCombos(cmbBknri2 As ComboBox, cmbBknri3 As ComboBox)
        Dim sqlBknri2 As String = "SELECT DISTINCT bknri2_cd, bknri2_nm " &
                                    "FROM m_bknri " &
                                    "WHERE bknri2_cd <> '' " &
                                    "ORDER BY bknri2_cd;"

        Dim sqlBknri3 As String = "SELECT DISTINCT bknri3_cd, bknri3_nm " &
                                    "FROM m_bknri " &
                                    "WHERE bknri3_cd <> '' " &
                                    "ORDER BY bknri3_cd;"

        cmbBknri2.Bind(sqlBknri2, "bknri2_cd", "bknri2_cd")
        cmbBknri3.Bind(sqlBknri3, "bknri3_cd", "bknri3_cd")

        For Each cmb In {cmbBknri2, cmbBknri3}
            cmb.AdjustSize()
            cmb.SelectedIndex = -1
        Next
    End Sub
End Class