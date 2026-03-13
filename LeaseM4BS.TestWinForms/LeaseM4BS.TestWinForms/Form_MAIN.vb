Public Class Form_MAIN
    ' =========================================================
    ' 台帳タブ
    ' =========================================================
    ' [契約書フレックス]
    Private Sub menu_CONTRACT_LIST_Click(sender As Object, e As EventArgs) Handles menu_CONTRACT_LIST.Click
        Dim frm As New Form_f_flx_CONTRACT()

        frm.Show()
    End Sub

    ' [物件フレックス]
    Private Sub menu_BUKN_LIST_Click(sender As Object, e As EventArgs) Handles menu_BUKN_LIST.Click
        Dim frm As New Form_f_flx_BUKN()

        frm.Show()
    End Sub

    ' [物件フレックス（配賦行単位）]
    Private Sub menu_HAIF_Click(sender As Object, e As EventArgs) Handles menu_HAIF.Click
        Dim frm As New Form_f_flx_D_HAIF()

        frm.Show()
    End Sub

    ' [保守フレックス（物件付随保守料）]
    Private Sub menu_HENF_Click(sender As Object, e As EventArgs) Handles menu_HENF.Click
        Dim frm As New Form_f_flx_D_HENF()

        frm.Show()
    End Sub

    ' [減損フレックス]
    Private Sub menu_GSON_Click(sender As Object, e As EventArgs) Handles menu_GSON.Click
        Dim frm As New Form_f_flx_D_GSON()

        frm.Show()
    End Sub

    ' [新規入力]
    Private Sub menu_NEW_CONTRACT_Click(sender As Object, e As EventArgs) Handles menu_NEW_CONTRACT.Click
        Dim frm As New Form_ContractEntry()

        frm.Show()
    End Sub

    ' =========================================================
    ' 月次タブ
    ' =========================================================
    ' [月次支払照合フレックス]
    Private Sub menu_TOUGETSU_JOKEN_Click(sender As Object, e As EventArgs) Handles menu_TOUGETSU_JOKEN.Click
        Dim frm As New Form_f_TOUGETSU_JOKEN()

        frm.ShowDialog()
    End Sub

    ' [月次仕訳計上フレックス]
    Private Sub menu_KEIJO_JOKEN_Click(sender As Object, e As EventArgs) Handles menu_KEIJO_JOKEN.Click
        Dim frm As New Form_f_KEIJO_JOKEN()

        frm.ShowDialog()
    End Sub

    ' =========================================================
    ' 期間タブ
    ' =========================================================
    ' [棚卸明細表]
    Private Sub menu_TANA_JOKEN_Click(sender As Object, e As EventArgs) Handles menu_TANA_JOKEN.Click
        Dim frm As New Form_f_TANA_JOKEN()

        frm.ShowDialog()
    End Sub

    ' [期間リース料支払い明細表]
    Private Sub menu_KLSRYO_JOKEN_Click(sender As Object, e As EventArgs) Handles menu_KLSRYO_JOKEN.Click
        Dim frm As New Form_f_KLSRYO_JOKEN()

        frm.ShowDialog()
    End Sub

    ' [移動物件一覧表]
    Private Sub menu_IDOLST_JOKEN_Click(sender As Object, e As EventArgs) Handles menu_IDOLST_JOKEN.Click
        Dim frm As New Form_f_IDOLST_JOKEN()

        frm.ShowDialog()
    End Sub

    ' [期間費用計上明細表]
    Private Sub menu_KHIYO_JOKEN_Click(sender As Object, e As EventArgs) Handles menu_KHIYO_JOKEN.Click
        Dim frm As New Form_f_KHIYO_JOKEN()

        frm.ShowDialog()
    End Sub

    ' [予算実績集計]
    Private Sub menu_YOSAN_JOKEN_Click(sender As Object, e As EventArgs) Handles menu_YOSAN_JOKEN.Click
        Dim frm As New Form_f_YOSAN_JOKEN()

        frm.ShowDialog()
    End Sub

    ' =========================================================
    ' 決算タブ
    ' =========================================================
    ' [財務諸表注記]
    Private Sub menu_CHUKI_JOKEN_Click(sender As Object, e As EventArgs) Handles menu_CHUKI_JOKEN.Click
        Dim frm As New Form_f_CHUKI_JOKEN()

        frm.ShowDialog()
    End Sub

    ' [リース残高一覧表]
    Private Sub menu_ZANDAKA_JOKEN_Click(sender As Object, e As EventArgs) Handles menu_ZANDAKA_JOKEN.Click
        Dim frm As New Form_f_ZANDAKA_JOKEN()

        frm.ShowDialog()
    End Sub

    ' [リース債務返済明細一覧]
    Private Sub menu_SAIMU_JOKEN_Click(sender As Object, e As EventArgs) Handles menu_SAIMU_JOKEN.Click
        Dim frm As New Form_f_SAIMU_JOKEN()

        frm.ShowDialog()
    End Sub

    ' [別表16（4）]
    Private Sub menu_BEPPYO2_JOKEN_Click(sender As Object, e As EventArgs) Handles menu_BEPPYO2_JOKEN.Click
        Dim frm As New Form_f_BEPPYO2_JOKEN()

        frm.ShowDialog()
    End Sub

    ' =========================================================
    ' マスタタブ
    ' =========================================================
    ' [会社]
    Private Sub menu_CORP_Click(sender As Object, e As EventArgs) Handles menu_CORP.Click
        Dim frm As New Form_f_flx_M_CORP()

        frm.Show()
    End Sub

    ' [契約管理単位]
    Private Sub menu_KKNRI_Click(sender As Object, e As EventArgs) Handles menu_KKNRI.Click
        Dim frm As New Form_f_flx_M_KKNRI()

        frm.Show()
    End Sub

    ' [支払先]
    Private Sub menu_LCPT_Click(sender As Object, e As EventArgs) Handles menu_LCPT.Click
        Dim frm As New Form_f_flx_M_LCPT()

        frm.Show()
    End Sub

    ' [支払方法]
    Private Sub menu_SHHO_Click(sender As Object, e As EventArgs) Handles menu_SHHO.Click
        Dim frm As New Form_f_flx_M_SHHO()

        frm.Show()
    End Sub

    ' [原価区分]
    Private Sub menu_GENK_Click(sender As Object, e As EventArgs) Handles menu_GENK.Click
        Dim frm As New Form_f_flx_M_GENK()

        frm.Show()
    End Sub

    ' [部署]
    Private Sub menu_BCAT_Click(sender As Object, e As EventArgs) Handles menu_BCAT.Click
        Dim frm As New Form_f_flx_M_BCAT()

        frm.Show()
    End Sub

    ' [物件管理単位]
    Private Sub menu_BKNRI_Click(sender As Object, e As EventArgs) Handles menu_BKNRI.Click
        Dim frm As New Form_f_flx_M_BKNRI()

        frm.Show()
    End Sub

    ' [費用区分]
    Private Sub menu_HKMK_Click(sender As Object, e As EventArgs) Handles menu_HKMK.Click
        Dim frm As New Form_f_flx_M_HKMK()

        frm.Show()
    End Sub

    ' [資産区分]
    Private Sub menu_SKMK_Click(sender As Object, e As EventArgs) Handles menu_SKMK.Click
        Dim frm As New Form_f_flx_M_SKMK()

        frm.Show()
    End Sub

    ' [物件種別]
    Private Sub menu_BKIND_Click(sender As Object, e As EventArgs) Handles menu_BKIND.Click
        Dim frm As New Form_f_flx_M_BKIND()

        frm.Show()
    End Sub

    ' [銀行口座]
    Private Sub menu_KOZA_Click(sender As Object, e As EventArgs) Handles menu_KOZA.Click
        Dim frm As New Form_f_flx_M_KOZA()

        frm.Show()
    End Sub

    ' [業者]
    Private Sub menu_GSHA_Click(sender As Object, e As EventArgs) Handles menu_GSHA.Click
        Dim frm As New Form_f_flx_M_GSHA()

        frm.Show()
    End Sub

    ' [メーカー]
    Private Sub menu_MCPT_Click(sender As Object, e As EventArgs) Handles menu_MCPT.Click
        Dim frm As New Form_f_flx_M_MCPT()

        frm.Show()
    End Sub

    ' [廃棄方法]
    Private Sub menu_HKHO_Click(sender As Object, e As EventArgs) Handles menu_HKHO.Click
        Dim frm As New Form_f_flx_M_HKHO()

        frm.Show()
    End Sub

    ' [予備（契約書用）]
    Private Sub menu_RSRVH1_Click(sender As Object, e As EventArgs) Handles menu_RSRVH1.Click
        Dim frm As New Form_f_flx_M_RSRVK1()

        frm.Show()
    End Sub

    ' [予備（物件用）]
    Private Sub menu_RSRVB1_Click(sender As Object, e As EventArgs) Handles menu_RSRVB1.Click
        Dim frm As New Form_f_flx_M_RSRVB1()

        frm.Show()
    End Sub

    ' [追加借入利子率テーブル]
    Private Sub menu_KARI_RITU_Click(sender As Object, e As EventArgs) Handles menu_KARI_RITU.Click
        Dim frm As New Form_f_T_KARI_RITU()

        frm.Show()
    End Sub

    ' [消費税率テーブル]
    Private Sub menu_ZEI_KAISEI_Click(sender As Object, e As EventArgs) Handles menu_ZEI_KAISEI.Click
        Dim frm As New Form_f_T_ZEI_KAISEI()

        frm.Show()
    End Sub

    ' [費用関連テーブル]
    Private Sub menu_HREL_Click(sender As Object, e As EventArgs) Handles menu_HREL.Click
        Dim frm As New Form_fc_TC_HREL()

        frm.Show()
    End Sub

    ' =========================================================
    ' 一括更新タブ
    ' =========================================================
    ' [注記判定再計算]
    Private Sub menu_CHUKI_RECALC_Click(sender As Object, e As EventArgs) Handles menu_CHUKI_RECALC.Click
        Dim frm As New Form_f_CHUKI_RECALC()

        frm.ShowDialog()
    End Sub

    ' [契約書変更情報Excel取込]
    Private Sub menu_IMPORT_CONTRACT_FROM_EXCEL_Click(sender As Object, e As EventArgs) Handles menu_IMPORT_CONTRACT_FROM_EXCEL.Click
        Dim frm As New Form_f_IMPORT_CONTRACT_FROM_EXCEL()

        frm.ShowDialog()
    End Sub

    ' [物件移動]
    Private Sub menu_IMPORT_IDO_FROM_EXCEL_Click(sender As Object, e As EventArgs) Handles menu_IMPORT_IDO_FROM_EXCEL.Click
        Dim frm As New Form_f_IMPORT_IDO_FROM_EXCEL()

        frm.ShowDialog()
    End Sub

    ' [再リース/返却]
    Private Sub menu_IMPORT_SAILEASE_FROM_EXCEL_Click(sender As Object, e As EventArgs) Handles menu_IMPORT_SAILEASE_FROM_EXCEL.Click
        Dim frm As New Form_f_IMPORT_SAILEASE_FROM_EXCEL()

        frm.ShowDialog()
    End Sub

    ' [減損損失の取り込み]
    Private Sub menu_IMPORT_GSON_FROM_EXCEL_Click(sender As Object, e As EventArgs) Handles menu_IMPORT_GSON_FROM_EXCEL.Click
        Dim frm As New Form_f_IMPORT_GSON_FROM_EXCEL()

        frm.ShowDialog()
    End Sub
End Class