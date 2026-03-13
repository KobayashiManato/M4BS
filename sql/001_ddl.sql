-- ============================================================
-- LeaseM4BS PostgreSQL DDL
-- Access DB -> PostgreSQL 移行用テーブル定義
-- Generated: 2026-03-13
-- ============================================================

BEGIN;

SET search_path TO public;

-- ==========================================================
-- テーブル削除（依存関係の逆順）
-- ==========================================================
DROP TABLE IF EXISTS tc_rec_shri CASCADE;
DROP TABLE IF EXISTS tc_hrel CASCADE;
DROP TABLE IF EXISTS l_ulog CASCADE;
DROP TABLE IF EXISTS l_slog CASCADE;
DROP TABLE IF EXISTS l_bklog CASCADE;
DROP TABLE IF EXISTS t_zei_kaisei CASCADE;
DROP TABLE IF EXISTS t_szei_kmk CASCADE;
DROP TABLE IF EXISTS t_system CASCADE;
DROP TABLE IF EXISTS t_swk_nm CASCADE;
DROP TABLE IF EXISTS t_seq CASCADE;
DROP TABLE IF EXISTS t_opt CASCADE;
DROP TABLE IF EXISTS t_mstk CASCADE;
DROP TABLE IF EXISTS t_kykbnj_seq CASCADE;
DROP TABLE IF EXISTS t_kari_ritu CASCADE;
DROP TABLE IF EXISTS t_holiday CASCADE;
DROP TABLE IF EXISTS t_db_version CASCADE;
DROP TABLE IF EXISTS sec_user CASCADE;
DROP TABLE IF EXISTS sec_kngn_kknri CASCADE;
DROP TABLE IF EXISTS sec_kngn_bknri CASCADE;
DROP TABLE IF EXISTS sec_kngn CASCADE;
DROP TABLE IF EXISTS d_kykm CASCADE;
DROP TABLE IF EXISTS d_kykh CASCADE;
DROP TABLE IF EXISTS d_henl CASCADE;
DROP TABLE IF EXISTS d_henf CASCADE;
DROP TABLE IF EXISTS d_haif CASCADE;
DROP TABLE IF EXISTS d_gson CASCADE;
DROP TABLE IF EXISTS m_swptn CASCADE;
DROP TABLE IF EXISTS m_skti CASCADE;
DROP TABLE IF EXISTS m_skmk CASCADE;
DROP TABLE IF EXISTS m_shho CASCADE;
DROP TABLE IF EXISTS m_rsrvk1 CASCADE;
DROP TABLE IF EXISTS m_rsrvh1 CASCADE;
DROP TABLE IF EXISTS m_rsrvb1 CASCADE;
DROP TABLE IF EXISTS m_mcpt CASCADE;
DROP TABLE IF EXISTS m_lcpt CASCADE;
DROP TABLE IF EXISTS m_koza CASCADE;
DROP TABLE IF EXISTS m_kknri CASCADE;
DROP TABLE IF EXISTS m_hkmk CASCADE;
DROP TABLE IF EXISTS m_hkho CASCADE;
DROP TABLE IF EXISTS m_gsha CASCADE;
DROP TABLE IF EXISTS m_genk CASCADE;
DROP TABLE IF EXISTS m_corp CASCADE;
DROP TABLE IF EXISTS m_bknri CASCADE;
DROP TABLE IF EXISTS m_bkind CASCADE;
DROP TABLE IF EXISTS m_bcat CASCADE;
DROP TABLE IF EXISTS c_szei_kjkbn CASCADE;
DROP TABLE IF EXISTS c_skyak_ho CASCADE;
DROP TABLE IF EXISTS c_settei_idfld CASCADE;
DROP TABLE IF EXISTS c_rcalc CASCADE;
DROP TABLE IF EXISTS c_leakbn CASCADE;
DROP TABLE IF EXISTS c_kkbn CASCADE;
DROP TABLE IF EXISTS c_kjtaisyo CASCADE;
DROP TABLE IF EXISTS c_kjkbn CASCADE;
DROP TABLE IF EXISTS c_chu_hnti CASCADE;
DROP TABLE IF EXISTS c_chuum CASCADE;

-- ==========================================================
-- コードテーブル
-- ==========================================================

-- 注記有無
CREATE TABLE c_chuum (
    chuum_id                            SMALLINT,
    chuum_nm                            VARCHAR(10),
    PRIMARY KEY (chuum_id)
);

-- 注記単位
CREATE TABLE c_chu_hnti (
    chu_hnti_id                         SMALLINT,
    chu_hnti_nm                         VARCHAR(100),
    PRIMARY KEY (chu_hnti_id)
);

-- 計上区分
CREATE TABLE c_kjkbn (
    kjkbn_id                            SMALLINT,
    kjkbn_nm                            VARCHAR(10),
    PRIMARY KEY (kjkbn_id)
);

-- 計上対象
CREATE TABLE c_kjtaisyo (
    kjkbn_id                            SMALLINT,
    kjkbn_nm                            VARCHAR(10),
    PRIMARY KEY (kjkbn_id)
);

-- 契約区分
CREATE TABLE c_kkbn (
    kkbn_id                             SMALLINT,
    kkbn_nm                             VARCHAR(50),
    PRIMARY KEY (kkbn_id)
);

-- リース区分
CREATE TABLE c_leakbn (
    leakbn_id                           SMALLINT,
    leakbn_nm                           VARCHAR(100),
    PRIMARY KEY (leakbn_id)
);

-- 再計算区分
CREATE TABLE c_rcalc (
    rcalc_id                            SMALLINT,
    rcalc_nm                            VARCHAR(10),
    PRIMARY KEY (rcalc_id)
);

-- 設定IDフィールド
CREATE TABLE c_settei_idfld (
    settei_id                           INTEGER,
    val_id                              INTEGER,
    val_short_nm                        VARCHAR(100),
    val_nm                              VARCHAR(100),
    PRIMARY KEY (settei_id, val_id)
);

-- 償却方法
CREATE TABLE c_skyak_ho (
    skyak_ho_id                         SMALLINT,
    skyak_ho_nm                         VARCHAR(10),
    PRIMARY KEY (skyak_ho_id)
);

-- 消費税計上区分
CREATE TABLE c_szei_kjkbn (
    szei_kjkbn_id                       SMALLINT,
    szei_kjkbn_nm                       VARCHAR(50),
    szei_keijo_tmg                      SMALLINT,
    kojo_taisyo                         SMALLINT,
    kgai__tmg                           SMALLINT,
    hosyu_f                             SMALLINT,
    d_order                             SMALLINT,
    PRIMARY KEY (szei_kjkbn_id)
);

-- ==========================================================
-- マスタテーブル
-- ==========================================================

-- 管理部署
CREATE TABLE m_bcat (
    bcat_id                             INTEGER,
    bcat1_cd                            VARCHAR(12),
    bcat1_nm                            VARCHAR(80),
    bcat2_cd                            VARCHAR(12),
    bcat2_nm                            VARCHAR(40),
    bcat3_cd                            VARCHAR(12),
    bcat3_nm                            VARCHAR(40),
    bcat4_cd                            VARCHAR(12),
    bcat4_nm                            VARCHAR(40),
    bcat5_cd                            VARCHAR(12),
    bcat5_nm                            VARCHAR(40),
    genk_id                             INTEGER,
    skti_id                             INTEGER,
    sum1_cd                             VARCHAR(12),
    sum1_nm                             VARCHAR(40),
    sum2_cd                             VARCHAR(12),
    sum2_nm                             VARCHAR(40),
    sum3_cd                             VARCHAR(12),
    sum3_nm                             VARCHAR(40),
    bknri_id                            INTEGER,
    kbf_kb                              BOOLEAN DEFAULT FALSE,
    kbf_fb                              BOOLEAN DEFAULT FALSE,
    kbf_sb                              BOOLEAN DEFAULT FALSE,
    gensonf                             BOOLEAN DEFAULT FALSE,
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (bcat_id)
);

-- 物件種別
CREATE TABLE m_bkind (
    bkind_id                            INTEGER,
    bkind_cd                            VARCHAR(12),
    bkind_nm                            VARCHAR(40),
    bkind2_cd                           VARCHAR(12),
    bkind2_nm                           VARCHAR(40),
    bkind3_cd                           VARCHAR(12),
    bkind3_nm                           VARCHAR(40),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (bkind_id)
);

-- 物件分類
CREATE TABLE m_bknri (
    bknri_id                            INTEGER,
    bknri1_cd                           VARCHAR(12),
    bknri1_nm                           VARCHAR(80),
    bknri2_cd                           VARCHAR(12),
    bknri2_nm                           VARCHAR(40),
    bknri3_cd                           VARCHAR(12),
    bknri3_nm                           VARCHAR(40),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (bknri_id)
);

-- 法人
CREATE TABLE m_corp (
    corp_id                             INTEGER,
    corp1_cd                            VARCHAR(12),
    corp1_nm                            VARCHAR(40),
    corp2_cd                            VARCHAR(12),
    corp2_nm                            VARCHAR(40),
    corp3_cd                            VARCHAR(12),
    corp3_nm                            VARCHAR(40),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (corp_id)
);

-- 原価分類
CREATE TABLE m_genk (
    genk_id                             INTEGER,
    genk_cd                             VARCHAR(12),
    genk_nm                             VARCHAR(40),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (genk_id)
);

-- 購入先・業者
CREATE TABLE m_gsha (
    gsha_id                             INTEGER,
    gsha_cd                             VARCHAR(12),
    gsha_nm                             VARCHAR(40),
    biko                                VARCHAR(200),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (gsha_id)
);

-- 返却方法
CREATE TABLE m_hkho (
    hkho_id                             INTEGER,
    hkho_cd                             VARCHAR(12),
    hkho_nm                             VARCHAR(40),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (hkho_id)
);

-- 費用区分
CREATE TABLE m_hkmk (
    hkmk_id                             INTEGER,
    hkmk_cd                             VARCHAR(12),
    hkmk_nm                             VARCHAR(40),
    knjkb_id                            INTEGER,
    sum1_cd                             VARCHAR(12),
    sum1_nm                             VARCHAR(40),
    sum2_cd                             VARCHAR(12),
    sum2_nm                             VARCHAR(40),
    sum3_cd                             VARCHAR(12),
    sum3_nm                             VARCHAR(40),
    hrel_ptn_cd3                        VARCHAR(12),
    hrel_ptn_nm3                        VARCHAR(40),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (hkmk_id)
);

-- 契約管理単位
CREATE TABLE m_kknri (
    kknri_id                            INTEGER,
    kknri1_cd                           VARCHAR(12),
    kknri1_nm                           VARCHAR(40),
    kknri2_cd                           VARCHAR(12),
    kknri2_nm                           VARCHAR(40),
    kknri3_cd                           VARCHAR(12),
    kknri3_nm                           VARCHAR(40),
    corp_id                             INTEGER,
    hrel_ptn_cd4                        VARCHAR(12),
    hrel_ptn_nm4                        VARCHAR(40),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (kknri_id)
);

-- 口座
CREATE TABLE m_koza (
    koza_id                             INTEGER,
    koza_cd                             VARCHAR(12),
    koza_nm                             VARCHAR(40),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (koza_id)
);

-- リース会社・支払先
CREATE TABLE m_lcpt (
    lcpt_id                             INTEGER,
    lcpt1_cd                            VARCHAR(12),
    lcpt1_nm                            VARCHAR(40),
    lcpt2_cd                            VARCHAR(12),
    lcpt2_nm                            VARCHAR(40),
    shime_day_1                         SMALLINT,
    sshri_kn1_1                         SMALLINT,
    shri_day1_1                         SMALLINT,
    sshri_kn2_1                         SMALLINT,
    shri_day2_1                         SMALLINT,
    shime_day_2                         SMALLINT,
    sshri_kn1_2                         SMALLINT,
    shri_day1_2                         SMALLINT,
    sshri_kn2_2                         SMALLINT,
    shri_day2_2                         SMALLINT,
    shime_day_3                         SMALLINT,
    sshri_kn1_3                         SMALLINT,
    shri_day1_3                         SMALLINT,
    sshri_kn2_3                         SMALLINT,
    shri_day2_3                         SMALLINT,
    sai_denomi                          SMALLINT,
    biko                                VARCHAR(200),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    sum1_cd                             VARCHAR(12),
    sum1_nm                             VARCHAR(40),
    sum2_cd                             VARCHAR(12),
    sum2_nm                             VARCHAR(40),
    sum3_cd                             VARCHAR(12),
    sum3_nm                             VARCHAR(40),
    shri_kn_ini                         SMALLINT,
    slkikan_s                           SMALLINT,
    shri_kn_s                           SMALLINT,
    sai_denomi_s                        SMALLINT,
    sai_numerator_s                     SMALLINT,
    slkikan_n                           SMALLINT,
    shri_kn_n                           SMALLINT,
    sai_denomi_n                        SMALLINT,
    sai_numerator_n                     SMALLINT,
    shri_cnt_s_1                        SMALLINT,
    shho_id_s_1                         INTEGER,
    shho_id_n_1                         INTEGER,
    shri_cnt_s_2                        SMALLINT,
    shho_id_s_2                         INTEGER,
    shho_id_n_2                         INTEGER,
    shri_cnt_s_3                        SMALLINT,
    shho_id_s_3                         INTEGER,
    shho_id_n_3                         INTEGER,
    PRIMARY KEY (lcpt_id)
);

-- メーカー
CREATE TABLE m_mcpt (
    mcpt_id                             INTEGER,
    mcpt_cd                             VARCHAR(12),
    mcpt_nm                             VARCHAR(40),
    biko                                VARCHAR(200),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (mcpt_id)
);

-- 物件予備1
CREATE TABLE m_rsrvb1 (
    rsrvb1_id                           INTEGER,
    rsrvb1_cd                           VARCHAR(12),
    rsrvb1_nm                           VARCHAR(40),
    num                                 DOUBLE PRECISION,
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (rsrvb1_id)
);

-- 配賦予備1
CREATE TABLE m_rsrvh1 (
    rsrvh1_id                           INTEGER,
    rsrvh1_cd                           VARCHAR(12),
    rsrvh1_nm                           VARCHAR(40),
    num                                 DOUBLE PRECISION,
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (rsrvh1_id)
);

-- 契約予備1
CREATE TABLE m_rsrvk1 (
    rsrvk1_id                           INTEGER,
    rsrvk1_cd                           VARCHAR(12),
    rsrvk1_nm                           VARCHAR(40),
    num                                 DOUBLE PRECISION,
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (rsrvk1_id)
);

-- 支払方法
CREATE TABLE m_shho (
    shho_id                             INTEGER,
    shho_cd                             VARCHAR(12),
    shho_nm                             VARCHAR(40),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (shho_id)
);

-- 集計区分
CREATE TABLE m_skmk (
    skmk_id                             INTEGER,
    skmk_cd                             VARCHAR(12),
    skmk_nm                             VARCHAR(40),
    knjkb_id                            INTEGER,
    sum1_cd                             VARCHAR(20),
    sum1_nm                             VARCHAR(80),
    sum2_cd                             VARCHAR(20),
    sum2_nm                             VARCHAR(80),
    sum3_cd                             VARCHAR(20),
    sum3_nm                             VARCHAR(80),
    sum4_cd                             VARCHAR(20),
    sum4_nm                             VARCHAR(80),
    sum5_cd                             VARCHAR(20),
    sum5_nm                             VARCHAR(80),
    sum6_cd                             VARCHAR(20),
    sum6_nm                             VARCHAR(80),
    sum7_cd                             VARCHAR(20),
    sum7_nm                             VARCHAR(80),
    sum8_cd                             VARCHAR(20),
    sum8_nm                             VARCHAR(80),
    sum9_cd                             VARCHAR(20),
    sum9_nm                             VARCHAR(80),
    sum10_cd                            VARCHAR(20),
    sum10_nm                            VARCHAR(80),
    sum11_cd                            VARCHAR(20),
    sum11_nm                            VARCHAR(80),
    sum12_cd                            VARCHAR(20),
    sum12_nm                            VARCHAR(80),
    sum13_cd                            VARCHAR(20),
    sum13_nm                            VARCHAR(80),
    sum14_cd                            VARCHAR(20),
    sum14_nm                            VARCHAR(80),
    sum15_cd                            VARCHAR(20),
    sum15_nm                            VARCHAR(80),
    hrel_ptn_cd1                        VARCHAR(12),
    hrel_ptn_nm1                        VARCHAR(40),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (skmk_id)
);

-- 事業体
CREATE TABLE m_skti (
    skti_id                             INTEGER,
    skti_cd                             VARCHAR(12),
    skti_nm                             VARCHAR(40),
    sktsyt                              VARCHAR(40),
    jgsyonm                             VARCHAR(40),
    jgsyopst                            VARCHAR(10),
    jgsyoadr                            VARCHAR(100),
    jgsyotel                            VARCHAR(20),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (skti_id)
);

-- 仕訳パターン
CREATE TABLE m_swptn (
    swptn_id                            INTEGER,
    swptn_cd                            VARCHAR(12),
    swptn_nm                            VARCHAR(40),
    kmk1_cd                             VARCHAR(12),
    kmk1_nm                             VARCHAR(40),
    kmk2_cd                             VARCHAR(12),
    kmk2_nm                             VARCHAR(40),
    kmk3_cd                             VARCHAR(12),
    kmk3_nm                             VARCHAR(40),
    kmk4_cd                             VARCHAR(12),
    kmk4_nm                             VARCHAR(40),
    kmk5_cd                             VARCHAR(12),
    kmk5_nm                             VARCHAR(40),
    kmk6_cd                             VARCHAR(12),
    kmk6_nm                             VARCHAR(40),
    kmk7_cd                             VARCHAR(12),
    kmk7_nm                             VARCHAR(40),
    kmk8_cd                             VARCHAR(12),
    kmk8_nm                             VARCHAR(40),
    kmk9_cd                             VARCHAR(12),
    kmk9_nm                             VARCHAR(40),
    kmk10_cd                            VARCHAR(12),
    kmk10_nm                            VARCHAR(40),
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (swptn_id)
);

-- ==========================================================
-- データテーブル
-- ==========================================================

-- 減損
CREATE TABLE d_gson (
    kykm_id                             DOUBLE PRECISION,
    line_id                             SMALLINT,
    kykh_id                             DOUBLE PRECISION,
    kykh_no                             DOUBLE PRECISION,
    saikaisu                            SMALLINT,
    kykm_no                             DOUBLE PRECISION,
    gson_dt                             TIMESTAMP,
    gson_tmg                            SMALLINT,
    gson_ryo                            DOUBLE PRECISION,
    gson_rkei                           DOUBLE PRECISION,
    gson_nm                             VARCHAR(40),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    PRIMARY KEY (kykm_id, line_id)
);

-- 配賦
CREATE TABLE d_haif (
    kykm_id                             DOUBLE PRECISION,
    line_id                             SMALLINT,
    kykh_id                             DOUBLE PRECISION,
    kykh_no                             DOUBLE PRECISION,
    saikaisu                            SMALLINT,
    kykm_no                             DOUBLE PRECISION,
    haifritu                            DOUBLE PRECISION,
    hkmk_id                             INTEGER,
    h_bcat_id                           INTEGER,
    rsrvh1_id                           INTEGER,
    h_klsryo                            DOUBLE PRECISION,
    h_mlsryo                            DOUBLE PRECISION,
    h_kzei                              DOUBLE PRECISION,
    h_mzei                              DOUBLE PRECISION,
    h_klsryo_zkomi                      DOUBLE PRECISION,
    h_mlsryo_zkomi                      DOUBLE PRECISION,
    h_zokusei1                          VARCHAR(100),
    h_zokusei2                          VARCHAR(100),
    h_zokusei3                          VARCHAR(100),
    h_zokusei4                          VARCHAR(100),
    h_zokusei5                          VARCHAR(100),
    h_create_id                         INTEGER,
    h_create_dt                         TIMESTAMP,
    h_update_id                         INTEGER,
    h_update_dt                         TIMESTAMP,
    PRIMARY KEY (kykm_id, line_id)
);

-- 変更ファイナンス
CREATE TABLE d_henf (
    kykm_id                             DOUBLE PRECISION,
    line_id                             SMALLINT,
    kykh_id                             DOUBLE PRECISION,
    kykh_no                             DOUBLE PRECISION,
    saikaisu                            SMALLINT,
    kykm_no                             DOUBLE PRECISION,
    shri_kn                             SMALLINT,
    sshri_kn                            SMALLINT,
    shri_cnt                            SMALLINT DEFAULT 0,
    shri_dt1                            TIMESTAMP,
    klsryo                              DOUBLE PRECISION,
    zritu                               DOUBLE PRECISION,
    kzei                                DOUBLE PRECISION,
    klsryo_zkomi                        DOUBLE PRECISION,
    shri_en_dt                          TIMESTAMP,
    shho_id                             INTEGER,
    start_dt                            TIMESTAMP,
    end_dt                              TIMESTAMP,
    kikan                               SMALLINT,
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    PRIMARY KEY (kykm_id, line_id)
);

-- 変更リース
CREATE TABLE d_henl (
    kykm_id                             DOUBLE PRECISION,
    line_id                             SMALLINT,
    kykh_id                             DOUBLE PRECISION,
    kykh_no                             DOUBLE PRECISION,
    saikaisu                            SMALLINT,
    kykm_no                             DOUBLE PRECISION,
    shri_kn                             SMALLINT,
    sshri_kn                            SMALLINT,
    shri_cnt                            SMALLINT DEFAULT 0,
    shri_dt1                            TIMESTAMP,
    klsryo                              DOUBLE PRECISION,
    zritu                               DOUBLE PRECISION,
    kzei                                DOUBLE PRECISION,
    klsryo_zkomi                        DOUBLE PRECISION,
    shri_en_dt                          TIMESTAMP,
    shho_id                             INTEGER,
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    PRIMARY KEY (kykm_id, line_id)
);

-- 契約ヘッダ
CREATE TABLE d_kykh (
    kykh_id                             DOUBLE PRECISION,
    kykh_no                             DOUBLE PRECISION,
    saikaisu                            SMALLINT,
    update_cnt                          INTEGER DEFAULT 0,
    k_create_id                         INTEGER,
    k_create_dt                         TIMESTAMP,
    k_update_id                         INTEGER,
    k_update_dt                         TIMESTAMP,
    kknri_id                            INTEGER,
    kkbn_id                             SMALLINT,
    lcpt_id                             INTEGER,
    kykbnl                              VARCHAR(30),
    kykbnj                              VARCHAR(30),
    kyak_dt                             TIMESTAMP,
    start_dt                            TIMESTAMP,
    end_dt                              TIMESTAMP,
    lkikan                              SMALLINT,
    kykm_cnt                            INTEGER DEFAULT 0,
    k_suuryo                            INTEGER,
    k_knyukn                            DOUBLE PRECISION,
    ryoritu                             DOUBLE PRECISION,
    k_glsryo                            DOUBLE PRECISION,
    k_klsryo                            DOUBLE PRECISION,
    k_mlsryo                            DOUBLE PRECISION,
    k_slsryo                            DOUBLE PRECISION,
    zritu                               DOUBLE PRECISION,
    k_gzei                              DOUBLE PRECISION,
    k_kzei                              DOUBLE PRECISION,
    k_mzei                              DOUBLE PRECISION,
    k_glsryo_zkomi                      DOUBLE PRECISION,
    k_klsryo_zkomi                      DOUBLE PRECISION,
    k_mlsryo_zkomi                      DOUBLE PRECISION,
    k_ijiknr                            DOUBLE PRECISION,
    k_zanryo                            DOUBLE PRECISION,
    kykm_cnt_kzok                       INTEGER,
    suuryo_kzok                         INTEGER,
    knyukn_kzok                         DOUBLE PRECISION,
    glsryo_kzok                         DOUBLE PRECISION,
    klsryo_kzok                         DOUBLE PRECISION,
    mlsryo_kzok                         DOUBLE PRECISION,
    slsryo_kzok                         DOUBLE PRECISION,
    ijiknr_kzok                         DOUBLE PRECISION,
    zanryo_kzok                         DOUBLE PRECISION,
    shri_kn                             SMALLINT,
    sshri_kn_m                          SMALLINT,
    sshri_kn_1                          SMALLINT,
    sshri_kn_2                          SMALLINT,
    sshri_kn_3                          SMALLINT,
    shri_cnt                            SMALLINT DEFAULT 0,
    shri_dt1                            TIMESTAMP,
    shri_dt2                            TIMESTAMP,
    shri_dt3                            SMALLINT,
    shri_en_dt                          TIMESTAMP,
    mkaisu                              SMALLINT,
    mae_dt                              TIMESTAMP,
    jencho_f                            BOOLEAN DEFAULT FALSE,
    koza_id                             INTEGER,
    shho_m_id                           INTEGER,
    shho_1_id                           INTEGER,
    shho_2_id                           INTEGER,
    shho_3_id                           INTEGER,
    k_henl_f                            BOOLEAN DEFAULT FALSE,
    k_henl_sum                          DOUBLE PRECISION,
    henl_sum_kzok                       DOUBLE PRECISION,
    k_henf_f                            BOOLEAN DEFAULT FALSE,
    kyak_end_f                          BOOLEAN DEFAULT FALSE,
    k_ckaiyk_f                          BOOLEAN DEFAULT FALSE,
    k_rend_dt                           TIMESTAMP,
    k_history_f                         BOOLEAN DEFAULT FALSE,
    k_seigou_f                          BOOLEAN DEFAULT FALSE,
    rsrvk1_id                           INTEGER,
    kyak_nm                             VARCHAR(100),
    k_zokusei1                          VARCHAR(100),
    k_zokusei2                          VARCHAR(100),
    k_zokusei3                          VARCHAR(100),
    k_zokusei4                          VARCHAR(100),
    k_zokusei5                          VARCHAR(100),
    rng_bango                           VARCHAR(30),
    shonin_dt                           TIMESTAMP,
    kiansha                             VARCHAR(20),
    kjkbn_id                            SMALLINT,
    kjkbn_ms_f                          BOOLEAN DEFAULT FALSE,
    skyu_kj_f                           SMALLINT,
    kj_tekiyo_dt                        TIMESTAMP,
    kj_lkikan                           SMALLINT,
    kj_k_slsryo                         DOUBLE PRECISION,
    kj_shri_cnt                         SMALLINT DEFAULT 0,
    k_kjyo_st_dt                        TIMESTAMP,
    k_kjyo_en_dt                        TIMESTAMP,
    PRIMARY KEY (kykh_id)
);

-- 物件明細
CREATE TABLE d_kykm (
    kykm_id                             DOUBLE PRECISION,
    kykh_id                             DOUBLE PRECISION,
    kykh_no                             DOUBLE PRECISION,
    kykm_no                             DOUBLE PRECISION,
    kykm_no_mae                         DOUBLE PRECISION,
    saikaisu                            SMALLINT,
    b_kedaban                           VARCHAR(10),
    bukn_bango1                         VARCHAR(30),
    bukn_bango2                         VARCHAR(30),
    bukn_bango3                         VARCHAR(30),
    b_create_id                         INTEGER,
    b_create_dt                         TIMESTAMP,
    b_update_id                         INTEGER,
    b_update_dt                         TIMESTAMP,
    b_suuryo                            INTEGER,
    suuryo_sum_f                        BOOLEAN DEFAULT FALSE,
    b_knyukn                            DOUBLE PRECISION,
    b_glsryo                            DOUBLE PRECISION,
    b_klsryo                            DOUBLE PRECISION,
    b_mlsryo                            DOUBLE PRECISION,
    b_slsryo                            DOUBLE PRECISION,
    b_gzei                              DOUBLE PRECISION,
    b_kzei                              DOUBLE PRECISION,
    b_mzei                              DOUBLE PRECISION,
    b_glsryo_zkomi                      DOUBLE PRECISION,
    b_klsryo_zkomi                      DOUBLE PRECISION,
    b_mlsryo_zkomi                      DOUBLE PRECISION,
    b_ijiknr                            DOUBLE PRECISION,
    b_zanryo                            DOUBLE PRECISION,
    b_ghassei                           DOUBLE PRECISION,
    b_gnzai_kt                          DOUBLE PRECISION,
    b_syutok                            DOUBLE PRECISION,
    kari_ritu                           DOUBLE PRECISION,
    kari_ritu_ms_f                      BOOLEAN DEFAULT FALSE,
    ksan_ritu                           DOUBLE PRECISION,
    taiyo_nen                           SMALLINT,
    taiyo_nen_ms_f                      BOOLEAN DEFAULT FALSE,
    rslt90p                             DOUBLE PRECISION,
    rslt90p_str                         VARCHAR(10),
    rslt75p                             DOUBLE PRECISION,
    rslt75p_str                         VARCHAR(10),
    leakbn_id                           SMALLINT,
    leakbn_id_ms_f                      BOOLEAN DEFAULT FALSE,
    chuum_id                            SMALLINT,
    chuum_id_ms_f                       BOOLEAN DEFAULT FALSE,
    chu_hnti_id                         SMALLINT,
    b_lb_soneki                         DOUBLE PRECISION,
    lb_chuki_f                          BOOLEAN DEFAULT FALSE,
    hkho_id                             INTEGER,
    hk_dt                               TIMESTAMP,
    hk_gsha_id                          INTEGER,
    b_ckaiyk_f                          BOOLEAN DEFAULT FALSE,
    ckaiyk_dt                           TIMESTAMP,
    ckaiyk_esdt_t                       TIMESTAMP,
    ckaiyk_esdt_h                       TIMESTAMP,
    iyaku_kin                           DOUBLE PRECISION,
    b_henl_f                            BOOLEAN DEFAULT FALSE,
    b_henl_sum                          DOUBLE PRECISION,
    b_henl_sedt                         TIMESTAMP,
    b_henf_f                            BOOLEAN DEFAULT FALSE,
    b_henf_sedt                         TIMESTAMP,
    b_henf_klsryo_new                   DOUBLE PRECISION,
    f_lcpt_id                           INTEGER,
    f_hkmk_id                           INTEGER,
    f_gsha_id                           INTEGER,
    kykbnf                              VARCHAR(30),
    genson_f                            BOOLEAN DEFAULT FALSE,
    b_rend_dt                           TIMESTAMP,
    b_seigou_f                          BOOLEAN DEFAULT FALSE,
    skmk_id                             INTEGER,
    b_bcat_id                           INTEGER,
    ido_dt                              TIMESTAMP,
    b_bcat_id_r1                        INTEGER,
    ido_dt_r1                           TIMESTAMP,
    b_bcat_id_r2                        INTEGER,
    ido_dt_r2                           TIMESTAMP,
    b_bcat_id_r3                        INTEGER,
    ido_dt_r3                           TIMESTAMP,
    k_gsha_id                           INTEGER,
    bkind_id                            INTEGER,
    mcpt_id                             INTEGER,
    rsrvb1_id                           INTEGER,
    b_smdt_fst_sum                      TIMESTAMP,
    b_smdt_lst_sum                      TIMESTAMP,
    b_shdt_fst_sum                      TIMESTAMP,
    b_shdt_lst_sum                      TIMESTAMP,
    setti_dt                            TIMESTAMP,
    bukn_nm                             VARCHAR(100),
    b_zokusei1                          VARCHAR(100),
    b_zokusei2                          VARCHAR(100),
    b_zokusei3                          VARCHAR(100),
    b_zokusei4                          VARCHAR(100),
    b_zokusei5                          VARCHAR(100),
    b_gson_f                            BOOLEAN DEFAULT FALSE,
    rsok_tmg                            SMALLINT,
    gk_calc_kind                        SMALLINT,
    hensai_kind                         SMALLINT,
    ij_kjyo_kind                        SMALLINT,
    gson_tk_kind                        SMALLINT,
    lb_kjyo_kind                        SMALLINT,
    rsok_tmg_ms_f                       BOOLEAN DEFAULT FALSE,
    gk_calc_kind_ms_f                   BOOLEAN DEFAULT FALSE,
    hensai_kind_ms_f                    BOOLEAN DEFAULT FALSE,
    ij_kjyo_kind_ms_f                   BOOLEAN DEFAULT FALSE,
    gson_tk_kind_ms_f                   BOOLEAN DEFAULT FALSE,
    lb_kjyo_kind_ms_f                   BOOLEAN DEFAULT FALSE,
    kjkbn_id                            SMALLINT,
    skyak_ho_id                         SMALLINT,
    kj_flg                              SMALLINT,
    syk_kikan                           SMALLINT,
    kj_kkakaku                          DOUBLE PRECISION,
    kj_ksan_ritu                        DOUBLE PRECISION,
    kj_ho                               SMALLINT,
    kj_b_slsryo                         DOUBLE PRECISION,
    kj_b_ijiknr                         DOUBLE PRECISION,
    kjkbn_ms_f                          BOOLEAN DEFAULT FALSE,
    b_kjyo_en_dt                        TIMESTAMP,
    b_bcat_cd_k                         VARCHAR(12),
    b_bcat_nm_k                         VARCHAR(40),
    b_sairyo                            DOUBLE PRECISION,
    szei_kjkbn_id                       SMALLINT,
    szei_kjkbn_id_ms_f                  BOOLEAN DEFAULT FALSE,
    hszei_kjkbn_id                      SMALLINT,
    hszei_kjkbn_id_ms_f                 BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (kykm_id)
);

-- ==========================================================
-- セキュリティテーブル
-- ==========================================================

-- 権限
CREATE TABLE sec_kngn (
    kngn_id                             INTEGER,
    kngn_cd                             VARCHAR(12),
    kngn_nm                             VARCHAR(40),
    access_kind                         SMALLINT,
    access_kind_b                       SMALLINT,
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    admin                               BOOLEAN DEFAULT FALSE,
    master_update                       BOOLEAN DEFAULT FALSE,
    file_output                         BOOLEAN DEFAULT FALSE,
    print                               BOOLEAN DEFAULT FALSE,
    log_ref                             BOOLEAN DEFAULT FALSE,
    approval                            BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (kngn_id)
);

-- 権限別物件分類
CREATE TABLE sec_kngn_bknri (
    kngn_id                             INTEGER,
    bknri_id                            INTEGER,
    access_kind                         SMALLINT,
    PRIMARY KEY (kngn_id, bknri_id)
);

-- 権限別契約管理単位
CREATE TABLE sec_kngn_kknri (
    kngn_id                             INTEGER,
    kknri_id                            INTEGER,
    access_kind                         SMALLINT,
    PRIMARY KEY (kngn_id, kknri_id)
);

-- ユーザー
CREATE TABLE sec_user (
    user_id                             INTEGER,
    user_cd                             VARCHAR(12),
    user_nm                             VARCHAR(40),
    pwd                                 VARCHAR(255),
    kngn_id                             INTEGER,
    biko                                VARCHAR(100),
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    login_attempts                      SMALLINT,
    pwd_life_time                       SMALLINT,
    pwd_grace_time                      SMALLINT,
    pwd_min                             SMALLINT,
    pwd_moji_chk                        BOOLEAN DEFAULT FALSE,
    pwd_alph_chk                        BOOLEAN DEFAULT FALSE,
    pwd_num_chk                         BOOLEAN DEFAULT FALSE,
    pwd_symbol_chk                      BOOLEAN DEFAULT FALSE,
    pwd_upd_dt                          TIMESTAMP,
    d_first_login                       TIMESTAMP,
    err_ct                              SMALLINT,
    last_err_dt                         TIMESTAMP,
    PRIMARY KEY (user_id)
);

-- ==========================================================
-- システム・設定テーブル
-- ==========================================================

-- DBバージョン
CREATE TABLE t_db_version (
    db_version                          VARCHAR(30),
    PRIMARY KEY (db_version)
);

-- 休日
CREATE TABLE t_holiday (
    id                                  SMALLINT,
    h_date                              TIMESTAMP,
    biko                                VARCHAR(255),
    PRIMARY KEY (id)
);

-- 仮リース料率
CREATE TABLE t_kari_ritu (
    kari_ritu_id                        INTEGER,
    start_dt                            TIMESTAMP,
    kari_ritu                           DOUBLE PRECISION,
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (kari_ritu_id)
);

-- 契約番号採番
CREATE TABLE t_kykbnj_seq (
    "key"                               VARCHAR(30),
    nextval                             DOUBLE PRECISION,
    biko                                VARCHAR(50),
    PRIMARY KEY ("key")
);

-- マスタチェック
CREATE TABLE t_mstk (
    mstk_id                             INTEGER,
    mst_name                            VARCHAR(50),
    update_dt                           TIMESTAMP,
    kind                                SMALLINT,
    local_name                          VARCHAR(50),
    pkeys                               VARCHAR(255),
    compfld                             VARCHAR(30),
    biko                                VARCHAR(30),
    PRIMARY KEY (mstk_id)
);

-- オプション設定
CREATE TABLE t_opt (
    slog                                BOOLEAN DEFAULT FALSE,
    ulog                                BOOLEAN DEFAULT FALSE,
    recopt                              BOOLEAN DEFAULT FALSE,
    cnvlog                              BOOLEAN DEFAULT FALSE,
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0
);

-- 採番管理
CREATE TABLE t_seq (
    field_nm                            VARCHAR(30),
    table_nm                            VARCHAR(30),
    nextval                             DOUBLE PRECISION,
    PRIMARY KEY (field_nm)
);

-- 仕訳名称
CREATE TABLE t_swk_nm (
    swk_kbn                             SMALLINT,
    xxxxcd                              VARCHAR(12),
    swk_nm                              VARCHAR(50),
    swk_ryk                             VARCHAR(20),
    xxxxnm                              VARCHAR(50),
    PRIMARY KEY (swk_kbn)
);

-- システム情報
CREATE TABLE t_system (
    ap_version                          VARCHAR(30),
    customizetype                       VARCHAR(20),
    customizeno                         SMALLINT,
    url                                 VARCHAR(50),
    mail                                VARCHAR(50),
    shipday                             TIMESTAMP,
    tcomment                            VARCHAR(255),
    file_version_mdld                   VARCHAR(30),
    file_version_work                   VARCHAR(30),
    file_version_excel                  VARCHAR(30),
    PRIMARY KEY (ap_version)
);

-- 消費税科目
CREATE TABLE t_szei_kmk (
    zritu                               DOUBLE PRECISION,
    kind                                SMALLINT,
    hreikbn                             SMALLINT,
    leakbn_id                           SMALLINT,
    kjkbn_id                            SMALLINT,
    szei_kjkbn_id                       SMALLINT,
    ptn_cd1                             VARCHAR(12),
    ptn_nm1                             VARCHAR(40),
    ptn_cd2                             VARCHAR(12),
    ptn_nm2                             VARCHAR(40),
    ptn_cd3                             VARCHAR(12),
    ptn_nm3                             VARCHAR(40),
    ptn_cd4                             VARCHAR(12),
    ptn_nm4                             VARCHAR(40),
    zkmk_cd1                            VARCHAR(20),
    zhkmk_nm1                           VARCHAR(40),
    zkmk_cd2                            VARCHAR(20),
    zhkmk_nm2                           VARCHAR(40),
    zkmk_cd3                            VARCHAR(20),
    zhkmk_nm3                           VARCHAR(40)
);

-- 税制改正
CREATE TABLE t_zei_kaisei (
    zei_kaisei_id                       INTEGER,
    teki_dt_from                        TIMESTAMP,
    teki_dt_to                          TIMESTAMP,
    zritu                               DOUBLE PRECISION,
    kkyak_dt_from                       TIMESTAMP,
    kkyak_dt_to                         TIMESTAMP,
    create_id                           INTEGER,
    create_dt                           TIMESTAMP,
    update_id                           INTEGER,
    update_dt                           TIMESTAMP,
    update_cnt                          INTEGER DEFAULT 0,
    history_f                           BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (zei_kaisei_id)
);

-- ==========================================================
-- ログテーブル
-- ==========================================================

-- バックアップログ
CREATE TABLE l_bklog (
    op_dt                               TIMESTAMP,
    op_nm                               VARCHAR(8),
    op_s                                VARCHAR(20),
    op_user_cd                          VARCHAR(12),
    op_user_nm                          VARCHAR(40),
    pc_name                             VARCHAR(40),
    ip_adr                              VARCHAR(100),
    win_user                            VARCHAR(40),
    file_name                           VARCHAR(40),
    folder                              VARCHAR(255),
    pwd                                 VARCHAR(255),
    db_version                          VARCHAR(30),
    PRIMARY KEY (op_dt)
);

-- セッションログ
CREATE TABLE l_slog (
    slog_no                             INTEGER,
    op_st_dt                            TIMESTAMP,
    op_en_dt                            TIMESTAMP,
    op_kbn                              VARCHAR(3),
    op_nm                               VARCHAR(50),
    op_s                                VARCHAR(40),
    op_user_cd                          VARCHAR(12),
    op_user_nm                          VARCHAR(40),
    pc_name                             VARCHAR(40),
    ip_adr                              VARCHAR(100),
    win_user                            VARCHAR(40),
    op_detail1                          VARCHAR(255),
    op_detail2                          TEXT,
    upd_sbt                             VARCHAR(6),
    yobi                                VARCHAR(40),
    PRIMARY KEY (slog_no)
);

-- 更新ログ
CREATE TABLE l_ulog (
    slog_no                             INTEGER,
    ulog_no                             INTEGER,
    tbl_nm                              VARCHAR(40),
    upd_nm                              VARCHAR(4),
    key_nm1                             VARCHAR(50),
    key_val1                            VARCHAR(30),
    key_nm2                             VARCHAR(50),
    key_val2                            VARCHAR(30),
    rec1                                TEXT,
    rec2                                TEXT,
    db_version                          VARCHAR(30),
    recf                                VARCHAR(1),
    yobi                                VARCHAR(40),
    PRIMARY KEY (slog_no, ulog_no)
);

-- ==========================================================
-- トランザクションテーブル
-- ==========================================================

-- 配賦連動
CREATE TABLE tc_hrel (
    ptn_cd1                             VARCHAR(12),
    ptn_nm1                             VARCHAR(40),
    ptn_cd2                             VARCHAR(12),
    ptn_nm2                             VARCHAR(40),
    ptn_cd3                             VARCHAR(12),
    ptn_nm3                             VARCHAR(40),
    ptn_cd4                             VARCHAR(12),
    ptn_nm4                             VARCHAR(40),
    kmk_cd1                             VARCHAR(20),
    kmk_nm1                             VARCHAR(80),
    kmk_cd2                             VARCHAR(20),
    kmk_nm2                             VARCHAR(80),
    kmk_cd3                             VARCHAR(20),
    kmk_nm3                             VARCHAR(80),
    kmk_cd4                             VARCHAR(20),
    kmk_nm4                             VARCHAR(80),
    kmk_cd5                             VARCHAR(20),
    kmk_nm5                             VARCHAR(80),
    kmk_cd6                             VARCHAR(20),
    kmk_nm6                             VARCHAR(80),
    kmk_cd7                             VARCHAR(20),
    kmk_nm7                             VARCHAR(80),
    kmk_cd8                             VARCHAR(20),
    kmk_nm8                             VARCHAR(80),
    kmk_cd9                             VARCHAR(20),
    kmk_nm9                             VARCHAR(80),
    kmk_cd10                            VARCHAR(20),
    kmk_nm10                            VARCHAR(80),
    kmk_cd11                            VARCHAR(20),
    kmk_nm11                            VARCHAR(80),
    kmk_cd12                            VARCHAR(20),
    kmk_nm12                            VARCHAR(80),
    kmk_cd13                            VARCHAR(20),
    kmk_nm13                            VARCHAR(80),
    kmk_cd14                            VARCHAR(20),
    kmk_nm14                            VARCHAR(80),
    kmk_cd15                            VARCHAR(20),
    kmk_nm15                            VARCHAR(80)
);

-- 支払実績
CREATE TABLE tc_rec_shri (
    ktmg                                SMALLINT,
    shri_tuki                           TIMESTAMP,
    shri_dt                             TIMESTAMP,
    shri_r_dt                           TIMESTAMP,
    xxxx1id                             INTEGER,
    xxxx1cd                             VARCHAR(12),
    xxxx1nm                             VARCHAR(80),
    xxxx2id                             INTEGER,
    xxxx2cd                             VARCHAR(12),
    xxxx2nm                             VARCHAR(80),
    xxxx3id                             INTEGER,
    xxxx3cd                             VARCHAR(12),
    xxxx3nm                             VARCHAR(80),
    xxxx4id                             INTEGER,
    xxxx4cd                             VARCHAR(12),
    xxxx4nm                             VARCHAR(80),
    xxxx5id                             INTEGER,
    xxxx5cd                             VARCHAR(12),
    xxxx5nm                             VARCHAR(80),
    siwakekbn                           SMALLINT,
    sum_zkomi_toki                      DOUBLE PRECISION,
    sum_znuki_toki                      DOUBLE PRECISION,
    sum_zei_toki                        DOUBLE PRECISION,
    cnt_reccnt                          INTEGER,
    kihyo_dt                            TIMESTAMP,
    output_dt                           TIMESTAMP,
    sum_zkomi_toki_hiyo                 DOUBLE PRECISION,
    sum_zkomi_toki_sisan                DOUBLE PRECISION,
    計上日                                 TIMESTAMP
);

-- ==========================================================
-- インデックス
-- ==========================================================

CREATE UNIQUE INDEX idx_c_chuum_chuum_nm ON c_chuum (chuum_nm);
CREATE UNIQUE INDEX idx_c_chu_hnti_chu_hnti_nm ON c_chu_hnti (chu_hnti_nm);
CREATE UNIQUE INDEX idx_c_kkbn_kkbn_nm ON c_kkbn (kkbn_nm);
CREATE UNIQUE INDEX idx_c_leakbn_leakbn_nm ON c_leakbn (leakbn_nm);
CREATE UNIQUE INDEX idx_c_rcalc_rcalc_nm ON c_rcalc (rcalc_nm);
CREATE UNIQUE INDEX idx_c_settei_idfld_settei_id_val_id ON c_settei_idfld (settei_id, val_id);
CREATE UNIQUE INDEX idx_c_skyak_ho_skyak_ho_nm ON c_skyak_ho (skyak_ho_nm);
CREATE INDEX idx_c_szei_kjkbn_d_order ON c_szei_kjkbn (d_order);
CREATE INDEX idx_m_bcat_skti_id ON m_bcat (skti_id);
CREATE INDEX idx_m_bcat_bknri_id ON m_bcat (bknri_id);
CREATE INDEX idx_m_bcat_genk_id ON m_bcat (genk_id);
CREATE INDEX idx_m_bcat_create_id ON m_bcat (create_id);
CREATE INDEX idx_m_bcat_update_id ON m_bcat (update_id);
CREATE INDEX idx_m_bkind_create_id ON m_bkind (create_id);
CREATE INDEX idx_m_bkind_update_id ON m_bkind (update_id);
CREATE INDEX idx_m_bknri_create_id ON m_bknri (create_id);
CREATE INDEX idx_m_bknri_update_id ON m_bknri (update_id);
CREATE INDEX idx_m_corp_create_id ON m_corp (create_id);
CREATE INDEX idx_m_corp_update_id ON m_corp (update_id);
CREATE INDEX idx_m_genk_create_id ON m_genk (create_id);
CREATE INDEX idx_m_genk_update_id ON m_genk (update_id);
CREATE INDEX idx_m_gsha_create_id ON m_gsha (create_id);
CREATE INDEX idx_m_gsha_update_id ON m_gsha (update_id);
CREATE INDEX idx_m_hkho_create_id ON m_hkho (create_id);
CREATE INDEX idx_m_hkho_update_id ON m_hkho (update_id);
CREATE INDEX idx_m_hkmk_create_id ON m_hkmk (create_id);
CREATE INDEX idx_m_hkmk_knjkb_id ON m_hkmk (knjkb_id);
CREATE INDEX idx_m_hkmk_update_id ON m_hkmk (update_id);
CREATE INDEX idx_m_kknri_corp_id ON m_kknri (corp_id);
CREATE INDEX idx_m_kknri_create_id ON m_kknri (create_id);
CREATE INDEX idx_m_kknri_update_id ON m_kknri (update_id);
CREATE INDEX idx_m_koza_create_id ON m_koza (create_id);
CREATE INDEX idx_m_koza_update_id ON m_koza (update_id);
CREATE INDEX idx_m_lcpt_shho_id_n_3 ON m_lcpt (shho_id_n_3);
CREATE INDEX idx_m_lcpt_shho_id_s_2 ON m_lcpt (shho_id_s_2);
CREATE INDEX idx_m_lcpt_shho_id_s_1 ON m_lcpt (shho_id_s_1);
CREATE INDEX idx_m_lcpt_shho_id_s_3 ON m_lcpt (shho_id_s_3);
CREATE INDEX idx_m_lcpt_shho_id_n_1 ON m_lcpt (shho_id_n_1);
CREATE INDEX idx_m_lcpt_shho_id_n_2 ON m_lcpt (shho_id_n_2);
CREATE INDEX idx_m_lcpt_create_id ON m_lcpt (create_id);
CREATE INDEX idx_m_lcpt_update_id ON m_lcpt (update_id);
CREATE INDEX idx_m_mcpt_create_id ON m_mcpt (create_id);
CREATE INDEX idx_m_mcpt_update_id ON m_mcpt (update_id);
CREATE INDEX idx_m_rsrvb1_create_id ON m_rsrvb1 (create_id);
CREATE INDEX idx_m_rsrvb1_update_id ON m_rsrvb1 (update_id);
CREATE INDEX idx_m_rsrvh1_create_id ON m_rsrvh1 (create_id);
CREATE INDEX idx_m_rsrvh1_update_id ON m_rsrvh1 (update_id);
CREATE INDEX idx_m_shho_create_id ON m_shho (create_id);
CREATE INDEX idx_m_shho_update_id ON m_shho (update_id);
CREATE INDEX idx_m_skmk_create_id ON m_skmk (create_id);
CREATE INDEX idx_m_skmk_knjkb_id ON m_skmk (knjkb_id);
CREATE INDEX idx_m_skmk_update_id ON m_skmk (update_id);
CREATE INDEX idx_m_skti_create_id ON m_skti (create_id);
CREATE INDEX idx_m_skti_update_id ON m_skti (update_id);
CREATE INDEX idx_m_swptn_create_id ON m_swptn (create_id);
CREATE INDEX idx_m_swptn_update_id ON m_swptn (update_id);
CREATE INDEX idx_d_gson_create_id ON d_gson (create_id);
CREATE INDEX idx_d_gson_kykh_id ON d_gson (kykh_id);
CREATE INDEX idx_d_gson_kykh_no ON d_gson (kykh_no);
CREATE INDEX idx_d_gson_kykm_no ON d_gson (kykm_no);
CREATE INDEX idx_d_gson_update_id ON d_gson (update_id);
CREATE INDEX idx_d_haif_rsrvh1_id ON d_haif (rsrvh1_id);
CREATE INDEX idx_d_haif_hkmk_id ON d_haif (hkmk_id);
CREATE INDEX idx_d_haif_h_bcat_id ON d_haif (h_bcat_id);
CREATE INDEX idx_d_haif_h_create_id ON d_haif (h_create_id);
CREATE INDEX idx_d_haif_h_update_id ON d_haif (h_update_id);
CREATE INDEX idx_d_haif_kykh_id ON d_haif (kykh_id);
CREATE INDEX idx_d_haif_kykh_no ON d_haif (kykh_no);
CREATE INDEX idx_d_haif_kykm_no ON d_haif (kykm_no);
CREATE INDEX idx_d_haif_saikaisu ON d_haif (saikaisu);
CREATE INDEX idx_d_henf_shho_id ON d_henf (shho_id);
CREATE INDEX idx_d_henf_create_id ON d_henf (create_id);
CREATE INDEX idx_d_henf_kykh_id ON d_henf (kykh_id);
CREATE INDEX idx_d_henf_kykh_no ON d_henf (kykh_no);
CREATE INDEX idx_d_henf_kykm_no ON d_henf (kykm_no);
CREATE INDEX idx_d_henf_update_id ON d_henf (update_id);
CREATE INDEX idx_d_henl_shho_id ON d_henl (shho_id);
CREATE INDEX idx_d_henl_create_id ON d_henl (create_id);
CREATE INDEX idx_d_henl_kykh_id ON d_henl (kykh_id);
CREATE INDEX idx_d_henl_kykh_no ON d_henl (kykh_no);
CREATE INDEX idx_d_henl_kykm_no ON d_henl (kykm_no);
CREATE INDEX idx_d_henl_update_id ON d_henl (update_id);
CREATE UNIQUE INDEX idx_d_kykh_kykh_no_saikaisu ON d_kykh (kykh_no, saikaisu);
CREATE INDEX idx_d_kykh_kkbn_id ON d_kykh (kkbn_id);
CREATE INDEX idx_d_kykh_rsrvk1_id ON d_kykh (rsrvk1_id);
CREATE INDEX idx_d_kykh_lcpt_id ON d_kykh (lcpt_id);
CREATE INDEX idx_d_kykh_kknri_id ON d_kykh (kknri_id);
CREATE INDEX idx_d_kykh_shho_m_id ON d_kykh (shho_m_id);
CREATE INDEX idx_d_kykh_shho_1_id ON d_kykh (shho_1_id);
CREATE INDEX idx_d_kykh_shho_2_id ON d_kykh (shho_2_id);
CREATE INDEX idx_d_kykh_koza_id ON d_kykh (koza_id);
CREATE INDEX idx_d_kykh_shho_3_id ON d_kykh (shho_3_id);
CREATE INDEX idx_d_kykh_k_history_f ON d_kykh (k_history_f);
CREATE INDEX idx_d_kykh_kyak_end_f ON d_kykh (kyak_end_f);
CREATE INDEX idx_d_kykh_k_create_id ON d_kykh (k_create_id);
CREATE INDEX idx_d_kykh_k_update_id ON d_kykh (k_update_id);
CREATE INDEX idx_d_kykh_kjkbn_id ON d_kykh (kjkbn_id);
CREATE UNIQUE INDEX idx_d_kykm_kykm_no_saikaisu ON d_kykm (kykm_no, saikaisu);
CREATE INDEX idx_d_kykm_b_bcat_id ON d_kykm (b_bcat_id);
CREATE INDEX idx_d_kykm_b_bcat_id_r2 ON d_kykm (b_bcat_id_r2);
CREATE INDEX idx_d_kykm_b_create_id ON d_kykm (b_create_id);
CREATE INDEX idx_d_kykm_b_update_id ON d_kykm (b_update_id);
CREATE INDEX idx_d_kykm_bkind_id ON d_kykm (bkind_id);
CREATE INDEX idx_d_kykm_chu_hnti_id ON d_kykm (chu_hnti_id);
CREATE INDEX idx_d_kykm_chuum_id ON d_kykm (chuum_id);
CREATE INDEX idx_d_kykm_f_gsha_id ON d_kykm (f_gsha_id);
CREATE INDEX idx_d_kykm_f_hkmk_id ON d_kykm (f_hkmk_id);
CREATE INDEX idx_d_kykm_f_lcpt_id ON d_kykm (f_lcpt_id);
CREATE INDEX idx_d_kykm_hk_gsha_id ON d_kykm (hk_gsha_id);
CREATE INDEX idx_d_kykm_hkho_id ON d_kykm (hkho_id);
CREATE INDEX idx_d_kykm_hszei_kjkbn_id ON d_kykm (hszei_kjkbn_id);
CREATE INDEX idx_d_kykm_ido_dt ON d_kykm (ido_dt);
CREATE INDEX idx_d_kykm_ido_dt_r1 ON d_kykm (ido_dt_r1);
CREATE INDEX idx_d_kykm_ido_dt_r2 ON d_kykm (ido_dt_r2);
CREATE INDEX idx_d_kykm_ido_dt_r3 ON d_kykm (ido_dt_r3);
CREATE INDEX idx_d_kykm_b_ckaiyk_f ON d_kykm (b_ckaiyk_f);
CREATE INDEX idx_d_kykm_kykh_id ON d_kykm (kykh_id);
CREATE INDEX idx_d_kykm_kykh_no ON d_kykm (kykh_no);
CREATE INDEX idx_d_kykm_saikaisu ON d_kykm (saikaisu);
CREATE INDEX idx_d_kykm_k_gsha_id ON d_kykm (k_gsha_id);
CREATE INDEX idx_d_kykm_kjkbn_id ON d_kykm (kjkbn_id);
CREATE INDEX idx_d_kykm_leakbn_id ON d_kykm (leakbn_id);
CREATE INDEX idx_d_kykm_mcpt_id ON d_kykm (mcpt_id);
CREATE INDEX idx_d_kykm_rsrvb1_id ON d_kykm (rsrvb1_id);
CREATE INDEX idx_d_kykm_skmk_id ON d_kykm (skmk_id);
CREATE INDEX idx_d_kykm_skyak_ho_id ON d_kykm (skyak_ho_id);
CREATE INDEX idx_d_kykm_szei_kjkbn_id ON d_kykm (szei_kjkbn_id);
CREATE INDEX idx_sec_kngn_create_id ON sec_kngn (create_id);
CREATE INDEX idx_sec_kngn_update_id ON sec_kngn (update_id);
CREATE INDEX idx_sec_kngn_kknri_kngn_id ON sec_kngn_kknri (kngn_id);
CREATE INDEX idx_sec_kngn_kknri_kknri_id ON sec_kngn_kknri (kknri_id);
CREATE INDEX idx_sec_user_kngn_id ON sec_user (kngn_id);
CREATE INDEX idx_sec_user_create_id ON sec_user (create_id);
CREATE INDEX idx_sec_user_update_id ON sec_user (update_id);
CREATE UNIQUE INDEX idx_t_db_version_db_version ON t_db_version (db_version);
CREATE UNIQUE INDEX idx_t_holiday_id ON t_holiday (id);
CREATE UNIQUE INDEX idx_t_kari_ritu_kari_ritu_id ON t_kari_ritu (kari_ritu_id);
CREATE INDEX idx_t_kari_ritu_create_id ON t_kari_ritu (create_id);
CREATE INDEX idx_t_kari_ritu_update_id ON t_kari_ritu (update_id);
CREATE UNIQUE INDEX idx_t_kykbnj_seq_key ON t_kykbnj_seq (key);
CREATE UNIQUE INDEX idx_t_mstk_mstk_id ON t_mstk (mstk_id);
CREATE INDEX idx_t_opt_create_id ON t_opt (create_id);
CREATE INDEX idx_t_opt_update_id ON t_opt (update_id);
CREATE UNIQUE INDEX idx_t_seq_field_nm ON t_seq (field_nm);
CREATE UNIQUE INDEX idx_t_swk_nm_swk_kbn ON t_swk_nm (swk_kbn);
CREATE UNIQUE INDEX idx_t_system_ap_version ON t_system (ap_version);
CREATE INDEX idx_t_szei_kmk_kjkbn_id ON t_szei_kmk (kjkbn_id);
CREATE INDEX idx_t_szei_kmk_leakbn_id ON t_szei_kmk (leakbn_id);
CREATE INDEX idx_t_szei_kmk_szei_kjkbn_id ON t_szei_kmk (szei_kjkbn_id);
CREATE UNIQUE INDEX idx_t_zei_kaisei_zei_kaisei_id ON t_zei_kaisei (zei_kaisei_id);
CREATE INDEX idx_t_zei_kaisei_create_id ON t_zei_kaisei (create_id);
CREATE INDEX idx_t_zei_kaisei_update_id ON t_zei_kaisei (update_id);
CREATE UNIQUE INDEX idx_l_bklog_op_dt ON l_bklog (op_dt);
CREATE UNIQUE INDEX idx_l_ulog_slog_no_ulog_no ON l_ulog (slog_no, ulog_no);
CREATE INDEX idx_tc_hrel_ptn_cd1_ptn_cd2_ptn_cd3_ptn_cd4 ON tc_hrel (ptn_cd1, ptn_cd2, ptn_cd3, ptn_cd4);
CREATE INDEX idx_tc_rec_shri_xxxx1id ON tc_rec_shri (xxxx1id);
CREATE INDEX idx_tc_rec_shri_xxxx2id ON tc_rec_shri (xxxx2id);
CREATE INDEX idx_tc_rec_shri_xxxx3id ON tc_rec_shri (xxxx3id);
CREATE INDEX idx_tc_rec_shri_xxxx4id ON tc_rec_shri (xxxx4id);
CREATE INDEX idx_tc_rec_shri_xxxx5id ON tc_rec_shri (xxxx5id);

-- ==========================================================
-- テーブルコメント
-- ==========================================================

COMMENT ON TABLE c_chuum IS '注記有無';
COMMENT ON TABLE c_chu_hnti IS '注記単位';
COMMENT ON TABLE c_kjkbn IS '計上区分';
COMMENT ON TABLE c_kjtaisyo IS '計上対象';
COMMENT ON TABLE c_kkbn IS '契約区分';
COMMENT ON TABLE c_leakbn IS 'リース区分';
COMMENT ON TABLE c_rcalc IS '再計算区分';
COMMENT ON TABLE c_settei_idfld IS '設定IDフィールド';
COMMENT ON TABLE c_skyak_ho IS '償却方法';
COMMENT ON TABLE c_szei_kjkbn IS '消費税計上区分';
COMMENT ON TABLE m_bcat IS '管理部署';
COMMENT ON TABLE m_bkind IS '物件種別';
COMMENT ON TABLE m_bknri IS '物件分類';
COMMENT ON TABLE m_corp IS '法人';
COMMENT ON TABLE m_genk IS '原価分類';
COMMENT ON TABLE m_gsha IS '購入先・業者';
COMMENT ON TABLE m_hkho IS '返却方法';
COMMENT ON TABLE m_hkmk IS '費用区分';
COMMENT ON TABLE m_kknri IS '契約管理単位';
COMMENT ON TABLE m_koza IS '口座';
COMMENT ON TABLE m_lcpt IS 'リース会社・支払先';
COMMENT ON TABLE m_mcpt IS 'メーカー';
COMMENT ON TABLE m_rsrvb1 IS '物件予備1';
COMMENT ON TABLE m_rsrvh1 IS '配賦予備1';
COMMENT ON TABLE m_rsrvk1 IS '契約予備1';
COMMENT ON TABLE m_shho IS '支払方法';
COMMENT ON TABLE m_skmk IS '集計区分';
COMMENT ON TABLE m_skti IS '事業体';
COMMENT ON TABLE m_swptn IS '仕訳パターン';
COMMENT ON TABLE d_gson IS '減損';
COMMENT ON TABLE d_haif IS '配賦';
COMMENT ON TABLE d_henf IS '変更ファイナンス';
COMMENT ON TABLE d_henl IS '変更リース';
COMMENT ON TABLE d_kykh IS '契約ヘッダ';
COMMENT ON TABLE d_kykm IS '物件明細';
COMMENT ON TABLE sec_kngn IS '権限';
COMMENT ON TABLE sec_kngn_bknri IS '権限別物件分類';
COMMENT ON TABLE sec_kngn_kknri IS '権限別契約管理単位';
COMMENT ON TABLE sec_user IS 'ユーザー';
COMMENT ON TABLE t_db_version IS 'DBバージョン';
COMMENT ON TABLE t_holiday IS '休日';
COMMENT ON TABLE t_kari_ritu IS '仮リース料率';
COMMENT ON TABLE t_kykbnj_seq IS '契約番号採番';
COMMENT ON TABLE t_mstk IS 'マスタチェック';
COMMENT ON TABLE t_opt IS 'オプション設定';
COMMENT ON TABLE t_seq IS '採番管理';
COMMENT ON TABLE t_swk_nm IS '仕訳名称';
COMMENT ON TABLE t_system IS 'システム情報';
COMMENT ON TABLE t_szei_kmk IS '消費税科目';
COMMENT ON TABLE t_zei_kaisei IS '税制改正';
COMMENT ON TABLE l_bklog IS 'バックアップログ';
COMMENT ON TABLE l_slog IS 'セッションログ';
COMMENT ON TABLE l_ulog IS '更新ログ';
COMMENT ON TABLE tc_hrel IS '配賦連動';
COMMENT ON TABLE tc_rec_shri IS '支払実績';

COMMIT;