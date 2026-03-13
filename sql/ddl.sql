--
-- PostgreSQL database dump
--

-- Dumped from database version 18.1
-- Dumped by pg_dump version 18.1

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: c_chu_hnti; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.c_chu_hnti (
    chu_hnti_id integer NOT NULL,
    chu_hnti_nm character varying(100)
);


--
-- Name: TABLE c_chu_hnti; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.c_chu_hnti IS '固定マスタ：注記判定結果';


--
-- Name: COLUMN c_chu_hnti.chu_hnti_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_chu_hnti.chu_hnti_id IS 'N(2) 注記判定結果ID';


--
-- Name: COLUMN c_chu_hnti.chu_hnti_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_chu_hnti.chu_hnti_nm IS 'V2(100) 注記判定結果名称';


--
-- Name: c_chuum; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.c_chuum (
    chuum_id integer NOT NULL,
    chuum_nm character varying(10)
);


--
-- Name: TABLE c_chuum; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.c_chuum IS '固定マスタ：注記有無';


--
-- Name: COLUMN c_chuum.chuum_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_chuum.chuum_id IS 'N(1) 注記有無ID';


--
-- Name: COLUMN c_chuum.chuum_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_chuum.chuum_nm IS 'V2(10) 注記有無名称';


--
-- Name: c_kjkbn; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.c_kjkbn (
    kjkbn_id integer NOT NULL,
    kjkbn_nm character varying(10)
);


--
-- Name: TABLE c_kjkbn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.c_kjkbn IS '固定マスタ：計上区分';


--
-- Name: COLUMN c_kjkbn.kjkbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_kjkbn.kjkbn_id IS 'N(1) 計上区分ID';


--
-- Name: COLUMN c_kjkbn.kjkbn_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_kjkbn.kjkbn_nm IS 'V2(10) 計上区分名称';


--
-- Name: c_kjtaisyo; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.c_kjtaisyo (
    kjkbn_id integer NOT NULL,
    kjkbn_nm character varying(10)
);


--
-- Name: TABLE c_kjtaisyo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.c_kjtaisyo IS '固定マスタ：計上対象';


--
-- Name: COLUMN c_kjtaisyo.kjkbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_kjtaisyo.kjkbn_id IS 'N(1) 計上区分ID';


--
-- Name: COLUMN c_kjtaisyo.kjkbn_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_kjtaisyo.kjkbn_nm IS 'V2(10) 計上区分名称';


--
-- Name: c_kkbn; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.c_kkbn (
    kkbn_id integer NOT NULL,
    kkbn_nm character varying(50)
);


--
-- Name: TABLE c_kkbn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.c_kkbn IS '固定マスタ：契約区分';


--
-- Name: COLUMN c_kkbn.kkbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_kkbn.kkbn_id IS 'N(2) 契約区分ID';


--
-- Name: COLUMN c_kkbn.kkbn_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_kkbn.kkbn_nm IS 'V2(50) 契約区分名称';


--
-- Name: c_leakbn; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.c_leakbn (
    leakbn_id integer NOT NULL,
    leakbn_nm character varying(100)
);


--
-- Name: TABLE c_leakbn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.c_leakbn IS '固定マスタ：ﾘｰｽ区分';


--
-- Name: COLUMN c_leakbn.leakbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_leakbn.leakbn_id IS 'N(2) ﾘｰｽ区分ID';


--
-- Name: COLUMN c_leakbn.leakbn_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_leakbn.leakbn_nm IS 'V2(100) ﾘｰｽ区分名称';


--
-- Name: c_rcalc; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.c_rcalc (
    rcalc_id integer NOT NULL,
    rcalc_nm character varying(10)
);


--
-- Name: TABLE c_rcalc; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.c_rcalc IS '固定マスタ：利息計算方法';


--
-- Name: COLUMN c_rcalc.rcalc_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_rcalc.rcalc_id IS 'N(2) 利息計算方法ID';


--
-- Name: COLUMN c_rcalc.rcalc_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_rcalc.rcalc_nm IS 'V2(10) 利息計算方法名称';


--
-- Name: c_settei_idfld; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.c_settei_idfld (
    settei_id integer NOT NULL,
    val_id integer NOT NULL,
    val_short_nm character varying(100),
    val_nm character varying(100)
);


--
-- Name: TABLE c_settei_idfld; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.c_settei_idfld IS '固定マスタ：共有初期設定項目値（ID項目用）★2005/02/16';


--
-- Name: COLUMN c_settei_idfld.settei_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_settei_idfld.settei_id IS 'N(9) 設定項目ID';


--
-- Name: COLUMN c_settei_idfld.val_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_settei_idfld.val_id IS 'N(9) 設定値ID';


--
-- Name: COLUMN c_settei_idfld.val_short_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_settei_idfld.val_short_nm IS 'V2(100) 設定値略称';


--
-- Name: COLUMN c_settei_idfld.val_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_settei_idfld.val_nm IS 'V2(100) 設定値名称';


--
-- Name: c_skyak_ho; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.c_skyak_ho (
    skyak_ho_id integer NOT NULL,
    skyak_ho_nm character varying(10)
);


--
-- Name: TABLE c_skyak_ho; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.c_skyak_ho IS '固定マスタ：減価償却方法';


--
-- Name: COLUMN c_skyak_ho.skyak_ho_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_skyak_ho.skyak_ho_id IS 'N(2) 減価償却方法ID';


--
-- Name: COLUMN c_skyak_ho.skyak_ho_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_skyak_ho.skyak_ho_nm IS 'V2(10) 減価償却方法名称';


--
-- Name: c_szei_kjkbn; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.c_szei_kjkbn (
    szei_kjkbn_id integer NOT NULL,
    szei_kjkbn_nm character varying(50),
    szei_keijo_tmg integer,
    kojo_taisyo integer,
    kgai__tmg integer,
    hosyu_f integer,
    d_order integer
);


--
-- Name: TABLE c_szei_kjkbn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.c_szei_kjkbn IS '固定マスタ：消費税計上区分 2009/01/20';


--
-- Name: COLUMN c_szei_kjkbn.szei_kjkbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_szei_kjkbn.szei_kjkbn_id IS 'N(1) 消費税計上区分ID';


--
-- Name: COLUMN c_szei_kjkbn.szei_kjkbn_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_szei_kjkbn.szei_kjkbn_nm IS 'V2(50) 消費税計上区分名称';


--
-- Name: COLUMN c_szei_kjkbn.szei_keijo_tmg; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_szei_kjkbn.szei_keijo_tmg IS 'N(1) 消費税計上タイミング';


--
-- Name: COLUMN c_szei_kjkbn.kojo_taisyo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_szei_kjkbn.kojo_taisyo IS 'N(1) 控除対象';


--
-- Name: COLUMN c_szei_kjkbn.kgai__tmg; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_szei_kjkbn.kgai__tmg IS 'N(1) 控除対象外の場合の損金算入タイミング';


--
-- Name: COLUMN c_szei_kjkbn.hosyu_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_szei_kjkbn.hosyu_f IS 'N(1) 保守使用フラグ';


--
-- Name: COLUMN c_szei_kjkbn.d_order; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.c_szei_kjkbn.d_order IS 'N(1) 表示順 2009/03/11';


--
-- Name: d_gson; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.d_gson (
    kykm_id double precision NOT NULL,
    line_id integer NOT NULL,
    kykh_id double precision NOT NULL,
    kykh_no double precision,
    saikaisu integer,
    kykm_no double precision,
    gson_dt timestamp without time zone NOT NULL,
    gson_tmg integer NOT NULL,
    gson_ryo double precision NOT NULL,
    gson_rkei double precision NOT NULL,
    gson_nm character varying(40),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone
);


--
-- Name: TABLE d_gson; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.d_gson IS '台帳：減損★2005/02/24';


--
-- Name: COLUMN d_gson.kykm_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.kykm_id IS 'N(15) 契約明細ID';


--
-- Name: COLUMN d_gson.line_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.line_id IS 'N(4) 行ID';


--
-- Name: COLUMN d_gson.kykh_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.kykh_id IS 'N(15) 契約ID';


--
-- Name: COLUMN d_gson.kykh_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.kykh_no IS 'N(15) 契約No';


--
-- Name: COLUMN d_gson.saikaisu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.saikaisu IS 'N(2) 再ﾘｰｽ回数';


--
-- Name: COLUMN d_gson.kykm_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.kykm_no IS 'N(15) 契約明細No';


--
-- Name: COLUMN d_gson.gson_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.gson_dt IS 'D 減損処理年月';


--
-- Name: COLUMN d_gson.gson_tmg; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.gson_tmg IS 'N(1) 処理ﾀｲﾐﾝｸﾞ 0:月度末 1:月度初';


--
-- Name: COLUMN d_gson.gson_ryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.gson_ryo IS 'N(15) 減損損失';


--
-- Name: COLUMN d_gson.gson_rkei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.gson_rkei IS 'N(15) 減損損失累計額相当額';


--
-- Name: COLUMN d_gson.gson_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.gson_nm IS 'V2(40) 減損処理名';


--
-- Name: COLUMN d_gson.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN d_gson.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.create_dt IS 'D 作成日時';


--
-- Name: COLUMN d_gson.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN d_gson.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_gson.update_dt IS 'D 更新日時';


--
-- Name: d_haif; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.d_haif (
    kykm_id double precision NOT NULL,
    line_id integer NOT NULL,
    kykh_id double precision NOT NULL,
    kykh_no double precision,
    saikaisu integer,
    kykm_no double precision,
    haifritu double precision NOT NULL,
    hkmk_id integer NOT NULL,
    h_bcat_id integer NOT NULL,
    rsrvh1_id integer NOT NULL,
    h_klsryo double precision,
    h_mlsryo double precision,
    h_kzei double precision,
    h_mzei double precision,
    h_klsryo_zkomi double precision,
    h_mlsryo_zkomi double precision,
    h_zokusei1 character varying(100),
    h_zokusei2 character varying(100),
    h_zokusei3 character varying(100),
    h_zokusei4 character varying(100),
    h_zokusei5 character varying(100),
    h_create_id integer NOT NULL,
    h_create_dt timestamp without time zone,
    h_update_id integer NOT NULL,
    h_update_dt timestamp without time zone
);


--
-- Name: TABLE d_haif; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.d_haif IS '台帳：配賦';


--
-- Name: COLUMN d_haif.kykm_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.kykm_id IS 'N(15) 契約明細ID';


--
-- Name: COLUMN d_haif.line_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.line_id IS 'N(4) 行ID';


--
-- Name: COLUMN d_haif.kykh_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.kykh_id IS 'N(15) 契約ID';


--
-- Name: COLUMN d_haif.kykh_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.kykh_no IS 'N(15) 契約No';


--
-- Name: COLUMN d_haif.saikaisu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.saikaisu IS 'N(2) 再ﾘｰｽ回数';


--
-- Name: COLUMN d_haif.kykm_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.kykm_no IS 'N(15) 契約明細No';


--
-- Name: COLUMN d_haif.haifritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.haifritu IS 'N(11,8) 配賦率';


--
-- Name: COLUMN d_haif.hkmk_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.hkmk_id IS 'N(9) 費用科目ID';


--
-- Name: COLUMN d_haif.h_bcat_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_bcat_id IS 'N(9) 費用負担部署ID';


--
-- Name: COLUMN d_haif.rsrvh1_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.rsrvh1_id IS 'N(9) 予備ID';


--
-- Name: COLUMN d_haif.h_klsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_klsryo IS 'N(15) 1支払額';


--
-- Name: COLUMN d_haif.h_mlsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_mlsryo IS 'N(15) 前払ﾘｰｽ料';


--
-- Name: COLUMN d_haif.h_kzei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_kzei IS 'N(15) 1支払額消費税';


--
-- Name: COLUMN d_haif.h_mzei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_mzei IS 'N(15) 前払消費税';


--
-- Name: COLUMN d_haif.h_klsryo_zkomi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_klsryo_zkomi IS 'N(15) 1支払額税込み';


--
-- Name: COLUMN d_haif.h_mlsryo_zkomi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_mlsryo_zkomi IS 'N(15) 前払ﾘｰｽ料税込み';


--
-- Name: COLUMN d_haif.h_zokusei1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_zokusei1 IS 'V2(100) 備考1';


--
-- Name: COLUMN d_haif.h_zokusei2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_zokusei2 IS 'V2(100) 備考2';


--
-- Name: COLUMN d_haif.h_zokusei3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_zokusei3 IS 'V2(100) 備考3';


--
-- Name: COLUMN d_haif.h_zokusei4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_zokusei4 IS 'V2(100) 備考4';


--
-- Name: COLUMN d_haif.h_zokusei5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_zokusei5 IS 'V2(100) 備考5';


--
-- Name: COLUMN d_haif.h_create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN d_haif.h_create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_create_dt IS 'D 作成日時';


--
-- Name: COLUMN d_haif.h_update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN d_haif.h_update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_haif.h_update_dt IS 'D 更新日時';


--
-- Name: d_henf; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.d_henf (
    kykm_id double precision NOT NULL,
    line_id integer NOT NULL,
    kykh_id double precision NOT NULL,
    kykh_no double precision,
    saikaisu integer,
    kykm_no double precision,
    shri_kn integer,
    sshri_kn integer,
    shri_cnt integer,
    shri_dt1 timestamp without time zone,
    klsryo double precision,
    zritu double precision,
    kzei double precision,
    klsryo_zkomi double precision,
    shri_en_dt timestamp without time zone,
    shho_id integer NOT NULL,
    start_dt timestamp without time zone,
    end_dt timestamp without time zone,
    kikan integer,
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone
);


--
-- Name: TABLE d_henf; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.d_henf IS '台帳：付随費用台帳';


--
-- Name: COLUMN d_henf.kykm_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.kykm_id IS 'N(15) 契約明細ID';


--
-- Name: COLUMN d_henf.line_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.line_id IS 'N(4) 行ID';


--
-- Name: COLUMN d_henf.kykh_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.kykh_id IS 'N(15) 契約ID';


--
-- Name: COLUMN d_henf.kykh_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.kykh_no IS 'N(15) 契約No';


--
-- Name: COLUMN d_henf.saikaisu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.saikaisu IS 'N(2) 再ﾘｰｽ回数';


--
-- Name: COLUMN d_henf.kykm_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.kykm_no IS 'N(15) 契約明細No';


--
-- Name: COLUMN d_henf.shri_kn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.shri_kn IS 'N(2) 支払間隔';


--
-- Name: COLUMN d_henf.sshri_kn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.sshri_kn IS 'N(2) 〆支払間隔';


--
-- Name: COLUMN d_henf.shri_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.shri_cnt IS 'N(3) 支払回数';


--
-- Name: COLUMN d_henf.shri_dt1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.shri_dt1 IS 'D 初回支払日';


--
-- Name: COLUMN d_henf.klsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.klsryo IS 'N(15) 1支払額';


--
-- Name: COLUMN d_henf.zritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.zritu IS 'N(7,6) 消費税率';


--
-- Name: COLUMN d_henf.kzei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.kzei IS 'N(15) 1支払額消費税';


--
-- Name: COLUMN d_henf.klsryo_zkomi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.klsryo_zkomi IS 'N(15) 1支払額税込み';


--
-- Name: COLUMN d_henf.shri_en_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.shri_en_dt IS 'D 最終支払日';


--
-- Name: COLUMN d_henf.shho_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.shho_id IS 'N(9) 支払方法ID';


--
-- Name: COLUMN d_henf.start_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.start_dt IS 'D 開始日';


--
-- Name: COLUMN d_henf.end_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.end_dt IS 'D 終了日';


--
-- Name: COLUMN d_henf.kikan; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.kikan IS 'N(3) 契約期間';


--
-- Name: COLUMN d_henf.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN d_henf.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.create_dt IS 'D 作成日時';


--
-- Name: COLUMN d_henf.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN d_henf.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henf.update_dt IS 'D 更新日時';


--
-- Name: d_henl; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.d_henl (
    kykm_id double precision NOT NULL,
    line_id integer NOT NULL,
    kykh_id double precision NOT NULL,
    kykh_no double precision,
    saikaisu integer,
    kykm_no double precision,
    shri_kn integer,
    sshri_kn integer,
    shri_cnt integer,
    shri_dt1 timestamp without time zone,
    klsryo double precision,
    zritu double precision,
    kzei double precision,
    klsryo_zkomi double precision,
    shri_en_dt timestamp without time zone,
    shho_id integer NOT NULL,
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone
);


--
-- Name: TABLE d_henl; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.d_henl IS '台帳：変額ﾘｰｽ料（不均等払い）';


--
-- Name: COLUMN d_henl.kykm_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.kykm_id IS 'N(15) 契約明細ID';


--
-- Name: COLUMN d_henl.line_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.line_id IS 'N(4) 行ID';


--
-- Name: COLUMN d_henl.kykh_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.kykh_id IS 'N(15) 契約ID';


--
-- Name: COLUMN d_henl.kykh_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.kykh_no IS 'N(15) 契約No';


--
-- Name: COLUMN d_henl.saikaisu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.saikaisu IS 'N(2) 再ﾘｰｽ回数';


--
-- Name: COLUMN d_henl.kykm_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.kykm_no IS 'N(15) 契約明細No';


--
-- Name: COLUMN d_henl.shri_kn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.shri_kn IS 'N(2) 支払間隔';


--
-- Name: COLUMN d_henl.sshri_kn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.sshri_kn IS 'N(2) 〆支払間隔';


--
-- Name: COLUMN d_henl.shri_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.shri_cnt IS 'N(3) 支払回数';


--
-- Name: COLUMN d_henl.shri_dt1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.shri_dt1 IS 'D 初回支払日';


--
-- Name: COLUMN d_henl.klsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.klsryo IS 'N(15) 1支払額';


--
-- Name: COLUMN d_henl.zritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.zritu IS 'N(7,6) 消費税率';


--
-- Name: COLUMN d_henl.kzei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.kzei IS 'N(15) 1支払額消費税';


--
-- Name: COLUMN d_henl.klsryo_zkomi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.klsryo_zkomi IS 'N(15) 1支払額税込み';


--
-- Name: COLUMN d_henl.shri_en_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.shri_en_dt IS 'D 最終支払日';


--
-- Name: COLUMN d_henl.shho_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.shho_id IS 'N(9) 支払方法ID';


--
-- Name: COLUMN d_henl.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN d_henl.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.create_dt IS 'D 作成日時';


--
-- Name: COLUMN d_henl.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN d_henl.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_henl.update_dt IS 'D 更新日時';


--
-- Name: d_kykh; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.d_kykh (
    kykh_id double precision NOT NULL,
    kykh_no double precision,
    saikaisu integer,
    update_cnt integer NOT NULL,
    k_create_id integer NOT NULL,
    k_create_dt timestamp without time zone,
    k_update_id integer NOT NULL,
    k_update_dt timestamp without time zone,
    kknri_id integer NOT NULL,
    kkbn_id integer NOT NULL,
    lcpt_id integer NOT NULL,
    kykbnl character varying(30),
    kykbnj character varying(30),
    kyak_dt timestamp without time zone,
    start_dt timestamp without time zone,
    end_dt timestamp without time zone,
    lkikan integer,
    kykm_cnt integer,
    k_suuryo integer,
    k_knyukn double precision,
    ryoritu double precision,
    k_glsryo double precision,
    k_klsryo double precision,
    k_mlsryo double precision,
    k_slsryo double precision,
    zritu double precision,
    k_gzei double precision,
    k_kzei double precision,
    k_mzei double precision,
    k_glsryo_zkomi double precision,
    k_klsryo_zkomi double precision,
    k_mlsryo_zkomi double precision,
    k_ijiknr double precision,
    k_zanryo double precision,
    kykm_cnt_kzok integer,
    suuryo_kzok integer,
    knyukn_kzok double precision,
    glsryo_kzok double precision,
    klsryo_kzok double precision,
    mlsryo_kzok double precision,
    slsryo_kzok double precision,
    ijiknr_kzok double precision,
    zanryo_kzok double precision,
    shri_kn integer,
    sshri_kn_m integer,
    sshri_kn_1 integer,
    sshri_kn_2 integer,
    sshri_kn_3 integer,
    shri_cnt integer,
    shri_dt1 timestamp without time zone,
    shri_dt2 timestamp without time zone,
    shri_dt3 integer,
    shri_en_dt timestamp without time zone,
    mkaisu integer,
    mae_dt timestamp without time zone,
    jencho_f boolean NOT NULL,
    koza_id integer NOT NULL,
    shho_m_id integer NOT NULL,
    shho_1_id integer NOT NULL,
    shho_2_id integer NOT NULL,
    shho_3_id integer NOT NULL,
    k_henl_f boolean NOT NULL,
    k_henl_sum double precision,
    henl_sum_kzok double precision,
    k_henf_f boolean NOT NULL,
    kyak_end_f boolean NOT NULL,
    k_ckaiyk_f boolean NOT NULL,
    k_rend_dt timestamp without time zone,
    k_history_f boolean NOT NULL,
    k_seigou_f boolean NOT NULL,
    rsrvk1_id integer NOT NULL,
    kyak_nm character varying(100),
    k_zokusei1 character varying(100),
    k_zokusei2 character varying(100),
    k_zokusei3 character varying(100),
    k_zokusei4 character varying(100),
    k_zokusei5 character varying(100),
    rng_bango character varying(30),
    shonin_dt timestamp without time zone,
    kiansha character varying(20),
    kjkbn_id integer NOT NULL,
    kjkbn_ms_f boolean NOT NULL,
    skyu_kj_f integer NOT NULL,
    kj_tekiyo_dt timestamp without time zone,
    kj_lkikan integer,
    kj_k_slsryo double precision,
    kj_shri_cnt integer,
    k_kjyo_st_dt timestamp without time zone,
    k_kjyo_en_dt timestamp without time zone
);


--
-- Name: TABLE d_kykh; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.d_kykh IS '台帳：契約書';


--
-- Name: COLUMN d_kykh.kykh_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kykh_id IS 'N(15) 契約ID';


--
-- Name: COLUMN d_kykh.kykh_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kykh_no IS 'N(15) 契約No';


--
-- Name: COLUMN d_kykh.saikaisu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.saikaisu IS 'N(2) 再ﾘｰｽ回数';


--
-- Name: COLUMN d_kykh.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.update_cnt IS 'N(9) ﾚｺｰﾄﾞ更新回数';


--
-- Name: COLUMN d_kykh.k_create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN d_kykh.k_create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_create_dt IS 'D 作成日時';


--
-- Name: COLUMN d_kykh.k_update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN d_kykh.k_update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_update_dt IS 'D 更新日時';


--
-- Name: COLUMN d_kykh.kknri_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kknri_id IS 'N(9) 契約管理単位ID';


--
-- Name: COLUMN d_kykh.kkbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kkbn_id IS 'N(2) 契約区分ID';


--
-- Name: COLUMN d_kykh.lcpt_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.lcpt_id IS 'N(9) ﾘｰｽ会社ID';


--
-- Name: COLUMN d_kykh.kykbnl; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kykbnl IS 'V2(30) 契約番号(ﾘｰｽ会社用)';


--
-- Name: COLUMN d_kykh.kykbnj; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kykbnj IS 'V2(30) 契約番号(自社管理用)';


--
-- Name: COLUMN d_kykh.kyak_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kyak_dt IS 'D 契約日';


--
-- Name: COLUMN d_kykh.start_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.start_dt IS 'D 開始日';


--
-- Name: COLUMN d_kykh.end_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.end_dt IS 'D 終了日';


--
-- Name: COLUMN d_kykh.lkikan; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.lkikan IS 'N(3) ﾘｰｽ期間';


--
-- Name: COLUMN d_kykh.kykm_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kykm_cnt IS 'N(5) 契約書明細数 ★2005/04/18 N(4)→N(5) に伴い 整数→長整数';


--
-- Name: COLUMN d_kykh.k_suuryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_suuryo IS 'N(9) 数量';


--
-- Name: COLUMN d_kykh.k_knyukn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_knyukn IS 'N(15) 購入価額';


--
-- Name: COLUMN d_kykh.ryoritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.ryoritu IS 'N(11,8) 料率';


--
-- Name: COLUMN d_kykh.k_glsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_glsryo IS 'N(15) 月額ﾘｰｽ料';


--
-- Name: COLUMN d_kykh.k_klsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_klsryo IS 'N(15) 1支払額';


--
-- Name: COLUMN d_kykh.k_mlsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_mlsryo IS 'N(15) 前払ﾘｰｽ料';


--
-- Name: COLUMN d_kykh.k_slsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_slsryo IS 'N(15) 総額ﾘｰｽ料';


--
-- Name: COLUMN d_kykh.zritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.zritu IS 'N(7,6) 消費税率';


--
-- Name: COLUMN d_kykh.k_gzei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_gzei IS 'N(15) 月額消費税';


--
-- Name: COLUMN d_kykh.k_kzei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_kzei IS 'N(15) 1支払額消費税';


--
-- Name: COLUMN d_kykh.k_mzei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_mzei IS 'N(15) 前払消費税';


--
-- Name: COLUMN d_kykh.k_glsryo_zkomi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_glsryo_zkomi IS 'N(15) 月額ﾘｰｽ料税込み';


--
-- Name: COLUMN d_kykh.k_klsryo_zkomi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_klsryo_zkomi IS 'N(15) 1支払額税込み';


--
-- Name: COLUMN d_kykh.k_mlsryo_zkomi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_mlsryo_zkomi IS 'N(15) 前払ﾘｰｽ料税込み';


--
-- Name: COLUMN d_kykh.k_ijiknr; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_ijiknr IS 'N(15) 維持管理費用';


--
-- Name: COLUMN d_kykh.k_zanryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_zanryo IS 'N(15) 残価保証額';


--
-- Name: COLUMN d_kykh.kykm_cnt_kzok; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kykm_cnt_kzok IS 'N(5) 契約書明細数・継続中 ★2005/04/18 N(4)→N(5) に伴い 整数→長整数';


--
-- Name: COLUMN d_kykh.suuryo_kzok; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.suuryo_kzok IS 'N(9) 数量・継続中';


--
-- Name: COLUMN d_kykh.knyukn_kzok; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.knyukn_kzok IS 'N(15) 購入価額・継続中';


--
-- Name: COLUMN d_kykh.glsryo_kzok; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.glsryo_kzok IS 'N(15) 月額ﾘｰｽ料・継続中';


--
-- Name: COLUMN d_kykh.klsryo_kzok; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.klsryo_kzok IS 'N(15) 1支払額・継続中';


--
-- Name: COLUMN d_kykh.mlsryo_kzok; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.mlsryo_kzok IS 'N(15) 前払ﾘｰｽ料・継続中';


--
-- Name: COLUMN d_kykh.slsryo_kzok; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.slsryo_kzok IS 'N(15) 総額ﾘｰｽ料・継続中';


--
-- Name: COLUMN d_kykh.ijiknr_kzok; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.ijiknr_kzok IS 'N(15) 維持管理費用・継続中';


--
-- Name: COLUMN d_kykh.zanryo_kzok; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.zanryo_kzok IS 'N(15) 残価保証額・継続中';


--
-- Name: COLUMN d_kykh.shri_kn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.shri_kn IS 'N(2) 支払間隔';


--
-- Name: COLUMN d_kykh.sshri_kn_m; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.sshri_kn_m IS 'N(2) 〆支払間隔・前払';


--
-- Name: COLUMN d_kykh.sshri_kn_1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.sshri_kn_1 IS 'N(2) 〆支払間隔・第１回';


--
-- Name: COLUMN d_kykh.sshri_kn_2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.sshri_kn_2 IS 'N(2) 〆支払間隔・第２回';


--
-- Name: COLUMN d_kykh.sshri_kn_3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.sshri_kn_3 IS 'N(2) 〆支払間隔・第３回以降';


--
-- Name: COLUMN d_kykh.shri_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.shri_cnt IS 'N(3) 支払回数';


--
-- Name: COLUMN d_kykh.shri_dt1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.shri_dt1 IS 'D 第1回支払日';


--
-- Name: COLUMN d_kykh.shri_dt2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.shri_dt2 IS 'D 第2回支払日';


--
-- Name: COLUMN d_kykh.shri_dt3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.shri_dt3 IS 'N(2) 第3回以降支払日';


--
-- Name: COLUMN d_kykh.shri_en_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.shri_en_dt IS 'D 最終支払日';


--
-- Name: COLUMN d_kykh.mkaisu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.mkaisu IS 'N(3) 前払回数';


--
-- Name: COLUMN d_kykh.mae_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.mae_dt IS 'D 前払日';


--
-- Name: COLUMN d_kykh.jencho_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.jencho_f IS 'N(1) 自動延長ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykh.koza_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.koza_id IS 'N(9) 銀行口座ID';


--
-- Name: COLUMN d_kykh.shho_m_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.shho_m_id IS 'N(9) 支払方法ID・前払';


--
-- Name: COLUMN d_kykh.shho_1_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.shho_1_id IS 'N(9) 支払方法ID・第１回';


--
-- Name: COLUMN d_kykh.shho_2_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.shho_2_id IS 'N(9) 支払方法ID・第２回';


--
-- Name: COLUMN d_kykh.shho_3_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.shho_3_id IS 'N(9) 支払方法ID・第３回以降';


--
-- Name: COLUMN d_kykh.k_henl_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_henl_f IS 'N(1) 変額ﾘｰｽﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykh.k_henl_sum; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_henl_sum IS 'N(15) 変額ﾘｰｽ料合計額(税抜き)';


--
-- Name: COLUMN d_kykh.henl_sum_kzok; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.henl_sum_kzok IS 'N(15) 変額ﾘｰｽ料合計額・継続中';


--
-- Name: COLUMN d_kykh.k_henf_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_henf_f IS 'N(1) 付随費用ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykh.kyak_end_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kyak_end_f IS 'N(1) 契約終了ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykh.k_ckaiyk_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_ckaiyk_f IS 'N(1) 中途解約ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykh.k_rend_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_rend_dt IS 'D 実際終了日';


--
-- Name: COLUMN d_kykh.k_history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykh.k_seigou_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_seigou_f IS 'N(1) 整合ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykh.rsrvk1_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.rsrvk1_id IS 'N(9) 予備ID';


--
-- Name: COLUMN d_kykh.kyak_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kyak_nm IS 'V2(100) 契約名';


--
-- Name: COLUMN d_kykh.k_zokusei1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_zokusei1 IS 'V2(100) 契約備考1';


--
-- Name: COLUMN d_kykh.k_zokusei2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_zokusei2 IS 'V2(100) 契約備考2';


--
-- Name: COLUMN d_kykh.k_zokusei3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_zokusei3 IS 'V2(100) 契約備考3';


--
-- Name: COLUMN d_kykh.k_zokusei4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_zokusei4 IS 'V2(100) 契約備考4';


--
-- Name: COLUMN d_kykh.k_zokusei5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_zokusei5 IS 'V2(100) 契約備考5';


--
-- Name: COLUMN d_kykh.rng_bango; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.rng_bango IS 'V2(30) 稟議番号';


--
-- Name: COLUMN d_kykh.shonin_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.shonin_dt IS 'D 承認日';


--
-- Name: COLUMN d_kykh.kiansha; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kiansha IS 'V2(20) 起案者';


--
-- Name: COLUMN d_kykh.kjkbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kjkbn_id IS 'N(1) 計上区分ID 2007/11/7 オンバランス対応';


--
-- Name: COLUMN d_kykh.kjkbn_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kjkbn_ms_f IS 'N(1) 資産計上自動設定フラグ 2007/11/7 オンバランス対応';


--
-- Name: COLUMN d_kykh.skyu_kj_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.skyu_kj_f IS 'N(1) 遡及計上ﾌﾗｸﾞ 2007/12/27';


--
-- Name: COLUMN d_kykh.kj_tekiyo_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kj_tekiyo_dt IS 'D 適用日 2008-04-03切替対応';


--
-- Name: COLUMN d_kykh.kj_lkikan; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kj_lkikan IS 'N(3) 切替後ﾘｰｽ期間 2008-04-03切替対応';


--
-- Name: COLUMN d_kykh.kj_k_slsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kj_k_slsryo IS 'N(15) 切替後ﾘｰｽ料総額 2008-04-03切替対応 未使用';


--
-- Name: COLUMN d_kykh.kj_shri_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.kj_shri_cnt IS 'N(3) 切替後支払回数 2008-04-03切替対応';


--
-- Name: COLUMN d_kykh.k_kjyo_st_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_kjyo_st_dt IS 'D 計上開始月 2008-05-26';


--
-- Name: COLUMN d_kykh.k_kjyo_en_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykh.k_kjyo_en_dt IS 'D 計上終了月 2008-05-26';


--
-- Name: d_kykm; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.d_kykm (
    kykm_id double precision NOT NULL,
    kykh_id double precision NOT NULL,
    kykh_no double precision,
    kykm_no double precision,
    kykm_no_mae double precision,
    saikaisu integer,
    b_kedaban character varying(10),
    bukn_bango1 character varying(30),
    bukn_bango2 character varying(30),
    bukn_bango3 character varying(30),
    b_create_id integer NOT NULL,
    b_create_dt timestamp without time zone,
    b_update_id integer NOT NULL,
    b_update_dt timestamp without time zone,
    b_suuryo integer,
    suuryo_sum_f boolean NOT NULL,
    b_knyukn double precision,
    b_glsryo double precision,
    b_klsryo double precision,
    b_mlsryo double precision,
    b_slsryo double precision,
    b_gzei double precision,
    b_kzei double precision,
    b_mzei double precision,
    b_glsryo_zkomi double precision,
    b_klsryo_zkomi double precision,
    b_mlsryo_zkomi double precision,
    b_ijiknr double precision,
    b_zanryo double precision,
    b_ghassei double precision,
    b_gnzai_kt double precision,
    b_syutok double precision,
    kari_ritu double precision,
    kari_ritu_ms_f boolean NOT NULL,
    ksan_ritu double precision,
    taiyo_nen integer,
    taiyo_nen_ms_f boolean NOT NULL,
    rslt90p double precision,
    rslt90p_str character varying(10),
    rslt75p double precision,
    rslt75p_str character varying(10),
    leakbn_id integer NOT NULL,
    leakbn_id_ms_f boolean NOT NULL,
    chuum_id integer NOT NULL,
    chuum_id_ms_f boolean NOT NULL,
    chu_hnti_id integer NOT NULL,
    b_lb_soneki double precision,
    lb_chuki_f boolean NOT NULL,
    hkho_id integer NOT NULL,
    hk_dt timestamp without time zone,
    hk_gsha_id integer NOT NULL,
    b_ckaiyk_f boolean NOT NULL,
    ckaiyk_dt timestamp without time zone,
    ckaiyk_esdt_t timestamp without time zone,
    ckaiyk_esdt_h timestamp without time zone,
    iyaku_kin double precision,
    b_henl_f boolean NOT NULL,
    b_henl_sum double precision,
    b_henl_sedt timestamp without time zone,
    b_henf_f boolean NOT NULL,
    b_henf_sedt timestamp without time zone,
    b_henf_klsryo_new double precision,
    f_lcpt_id integer NOT NULL,
    f_hkmk_id integer NOT NULL,
    f_gsha_id integer NOT NULL,
    kykbnf character varying(30),
    genson_f boolean NOT NULL,
    b_rend_dt timestamp without time zone,
    b_seigou_f boolean NOT NULL,
    skmk_id integer NOT NULL,
    b_bcat_id integer NOT NULL,
    ido_dt timestamp without time zone,
    b_bcat_id_r1 integer NOT NULL,
    ido_dt_r1 timestamp without time zone,
    b_bcat_id_r2 integer NOT NULL,
    ido_dt_r2 timestamp without time zone,
    b_bcat_id_r3 integer NOT NULL,
    ido_dt_r3 timestamp without time zone,
    k_gsha_id integer NOT NULL,
    bkind_id integer NOT NULL,
    mcpt_id integer NOT NULL,
    rsrvb1_id integer NOT NULL,
    b_smdt_fst_sum timestamp without time zone,
    b_smdt_lst_sum timestamp without time zone,
    b_shdt_fst_sum timestamp without time zone,
    b_shdt_lst_sum timestamp without time zone,
    setti_dt timestamp without time zone,
    bukn_nm character varying(100),
    b_zokusei1 character varying(100),
    b_zokusei2 character varying(100),
    b_zokusei3 character varying(100),
    b_zokusei4 character varying(100),
    b_zokusei5 character varying(100),
    b_gson_f boolean NOT NULL,
    rsok_tmg integer NOT NULL,
    gk_calc_kind integer NOT NULL,
    hensai_kind integer NOT NULL,
    ij_kjyo_kind integer NOT NULL,
    gson_tk_kind integer NOT NULL,
    lb_kjyo_kind integer NOT NULL,
    rsok_tmg_ms_f boolean NOT NULL,
    gk_calc_kind_ms_f boolean NOT NULL,
    hensai_kind_ms_f boolean NOT NULL,
    ij_kjyo_kind_ms_f boolean NOT NULL,
    gson_tk_kind_ms_f boolean NOT NULL,
    lb_kjyo_kind_ms_f boolean NOT NULL,
    kjkbn_id integer NOT NULL,
    skyak_ho_id integer NOT NULL,
    kj_flg integer NOT NULL,
    syk_kikan integer,
    kj_kkakaku double precision,
    kj_ksan_ritu double precision,
    kj_ho integer,
    kj_b_slsryo double precision,
    kj_b_ijiknr double precision,
    kjkbn_ms_f boolean NOT NULL,
    b_kjyo_en_dt timestamp without time zone,
    b_bcat_cd_k character varying(12),
    b_bcat_nm_k character varying(40),
    b_sairyo double precision,
    szei_kjkbn_id integer,
    szei_kjkbn_id_ms_f boolean NOT NULL,
    hszei_kjkbn_id integer,
    hszei_kjkbn_id_ms_f boolean NOT NULL,
    act_unit_id integer
);


--
-- Name: TABLE d_kykm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.d_kykm IS '台帳：契約書明細（物件）';


--
-- Name: COLUMN d_kykm.kykm_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kykm_id IS 'N(15) 契約明細ID';


--
-- Name: COLUMN d_kykm.kykh_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kykh_id IS 'N(15) 契約ID';


--
-- Name: COLUMN d_kykm.kykh_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kykh_no IS 'N(15) 契約No';


--
-- Name: COLUMN d_kykm.kykm_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kykm_no IS 'N(15) 契約明細No';


--
-- Name: COLUMN d_kykm.kykm_no_mae; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kykm_no_mae IS 'N(15) 契約明細No・合算前';


--
-- Name: COLUMN d_kykm.saikaisu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.saikaisu IS 'N(2) 再ﾘｰｽ回数';


--
-- Name: COLUMN d_kykm.b_kedaban; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_kedaban IS 'V2(10) 契約枝番';


--
-- Name: COLUMN d_kykm.bukn_bango1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.bukn_bango1 IS 'V2(30) 物件番号1';


--
-- Name: COLUMN d_kykm.bukn_bango2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.bukn_bango2 IS 'V2(30) 物件番号2';


--
-- Name: COLUMN d_kykm.bukn_bango3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.bukn_bango3 IS 'V2(30) 物件番号3';


--
-- Name: COLUMN d_kykm.b_create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN d_kykm.b_create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_create_dt IS 'D 作成日時';


--
-- Name: COLUMN d_kykm.b_update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN d_kykm.b_update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_update_dt IS 'D 更新日時';


--
-- Name: COLUMN d_kykm.b_suuryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_suuryo IS 'N(9) 数量';


--
-- Name: COLUMN d_kykm.suuryo_sum_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.suuryo_sum_f IS 'N(1) 数量集計ﾌﾗｸﾞ（未使用）';


--
-- Name: COLUMN d_kykm.b_knyukn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_knyukn IS 'N(15) 購入価額';


--
-- Name: COLUMN d_kykm.b_glsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_glsryo IS 'N(15) 月額ﾘｰｽ料';


--
-- Name: COLUMN d_kykm.b_klsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_klsryo IS 'N(15) 1支払額';


--
-- Name: COLUMN d_kykm.b_mlsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_mlsryo IS 'N(15) 前払ﾘｰｽ料';


--
-- Name: COLUMN d_kykm.b_slsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_slsryo IS 'N(15) 総額ﾘｰｽ料';


--
-- Name: COLUMN d_kykm.b_gzei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_gzei IS 'N(15) 月額消費税';


--
-- Name: COLUMN d_kykm.b_kzei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_kzei IS 'N(15) 1支払額消費税';


--
-- Name: COLUMN d_kykm.b_mzei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_mzei IS 'N(15) 前払消費税';


--
-- Name: COLUMN d_kykm.b_glsryo_zkomi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_glsryo_zkomi IS 'N(15) 月額ﾘｰｽ料税込み';


--
-- Name: COLUMN d_kykm.b_klsryo_zkomi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_klsryo_zkomi IS 'N(15) 1支払額税込み';


--
-- Name: COLUMN d_kykm.b_mlsryo_zkomi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_mlsryo_zkomi IS 'N(15) 前払ﾘｰｽ料税込み';


--
-- Name: COLUMN d_kykm.b_ijiknr; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_ijiknr IS 'N(15) 維持管理費用';


--
-- Name: COLUMN d_kykm.b_zanryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_zanryo IS 'N(15) 残価保証額';


--
-- Name: COLUMN d_kykm.b_ghassei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_ghassei IS 'N(15) 月発生額';


--
-- Name: COLUMN d_kykm.b_gnzai_kt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_gnzai_kt IS 'N(15) 現在価値';


--
-- Name: COLUMN d_kykm.b_syutok; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_syutok IS 'N(15) 取得価格相当額';


--
-- Name: COLUMN d_kykm.kari_ritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kari_ritu IS 'N(11,8) 追加借入利子率';


--
-- Name: COLUMN d_kykm.kari_ritu_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kari_ritu_ms_f IS 'N(1) 追加借入利子率手動設定ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykm.ksan_ritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.ksan_ritu IS 'N(11,8) 計算利子率';


--
-- Name: COLUMN d_kykm.taiyo_nen; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.taiyo_nen IS 'N(3) 償却期間';


--
-- Name: COLUMN d_kykm.taiyo_nen_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.taiyo_nen_ms_f IS 'N(1) 償却期間手動設定ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykm.rslt90p; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.rslt90p IS 'N(5,2) 90%以上基準計算値';


--
-- Name: COLUMN d_kykm.rslt90p_str; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.rslt90p_str IS 'V2(10) 90%以上基準計算値(表示)';


--
-- Name: COLUMN d_kykm.rslt75p; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.rslt75p IS 'N(5,2) 75%以上基準計算値';


--
-- Name: COLUMN d_kykm.rslt75p_str; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.rslt75p_str IS 'V2(10) 75%以上基準計算値(表示)';


--
-- Name: COLUMN d_kykm.leakbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.leakbn_id IS 'N(2) ﾘｰｽ区分ID';


--
-- Name: COLUMN d_kykm.leakbn_id_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.leakbn_id_ms_f IS 'N(1) ﾘｰｽ区分CD手動設定ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykm.chuum_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.chuum_id IS 'N(1) 注記有無ID';


--
-- Name: COLUMN d_kykm.chuum_id_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.chuum_id_ms_f IS 'N(1) 注記有無手動設定ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykm.chu_hnti_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.chu_hnti_id IS 'N(2) 注記判定結果ID';


--
-- Name: COLUMN d_kykm.b_lb_soneki; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_lb_soneki IS 'N(15) ﾘｰｽﾊﾞｯｸ売却損益';


--
-- Name: COLUMN d_kykm.lb_chuki_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.lb_chuki_f IS 'N(1) ﾘｰｽﾊﾞｯｸ売却損益注記ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykm.hkho_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.hkho_id IS 'N(9) 廃棄方法ID';


--
-- Name: COLUMN d_kykm.hk_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.hk_dt IS 'D 廃棄日';


--
-- Name: COLUMN d_kykm.hk_gsha_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.hk_gsha_id IS 'N(9) 廃棄業者ID';


--
-- Name: COLUMN d_kykm.b_ckaiyk_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_ckaiyk_f IS 'N(1) 中途解約ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykm.ckaiyk_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.ckaiyk_dt IS 'D 中途解約日';


--
-- Name: COLUMN d_kykm.ckaiyk_esdt_t; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.ckaiyk_esdt_t IS 'D 中途解約時最終支払日・定額';


--
-- Name: COLUMN d_kykm.ckaiyk_esdt_h; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.ckaiyk_esdt_h IS 'D 中途解約時最終支払日・変額';


--
-- Name: COLUMN d_kykm.iyaku_kin; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.iyaku_kin IS 'N(15) 中途解約違約金（未使用）';


--
-- Name: COLUMN d_kykm.b_henl_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_henl_f IS 'N(1) 変額ﾘｰｽﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykm.b_henl_sum; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_henl_sum IS 'N(15) 変額ﾘｰｽ料合計額(税抜き)';


--
-- Name: COLUMN d_kykm.b_henl_sedt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_henl_sedt IS 'D 変額ﾘｰｽ料最終支払日';


--
-- Name: COLUMN d_kykm.b_henf_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_henf_f IS 'N(1) 付随費用ﾌﾗｸﾞ';


--
-- Name: COLUMN d_kykm.b_henf_sedt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_henf_sedt IS 'D 付随費用最終支払日';


--
-- Name: COLUMN d_kykm.b_henf_klsryo_new; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_henf_klsryo_new IS 'N(15) 付随費用1支払額(最新行)';


--
-- Name: COLUMN d_kykm.f_lcpt_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.f_lcpt_id IS 'N(9) 付随費用支払先ID';


--
-- Name: COLUMN d_kykm.f_hkmk_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.f_hkmk_id IS 'N(9) 付随費用費用科目ID';


--
-- Name: COLUMN d_kykm.f_gsha_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.f_gsha_id IS 'N(9) 付随費用契約先ID';


--
-- Name: COLUMN d_kykm.kykbnf; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kykbnf IS 'V2(30) 付随費用契約番号';


--
-- Name: COLUMN d_kykm.genson_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.genson_f IS 'N(1) 現存ﾌﾗｸﾞ（未使用）';


--
-- Name: COLUMN d_kykm.b_rend_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_rend_dt IS 'D 実際終了日';


--
-- Name: COLUMN d_kykm.b_seigou_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_seigou_f IS 'N(1) 整合ﾌﾗｸﾞ（未使用）';


--
-- Name: COLUMN d_kykm.skmk_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.skmk_id IS 'N(9) 資産科目ID';


--
-- Name: COLUMN d_kykm.b_bcat_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_bcat_id IS 'N(9) 管理部署ID';


--
-- Name: COLUMN d_kykm.ido_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.ido_dt IS 'D 移動日';


--
-- Name: COLUMN d_kykm.b_bcat_id_r1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_bcat_id_r1 IS 'N(9) 管理部署ID(移動前1)';


--
-- Name: COLUMN d_kykm.ido_dt_r1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.ido_dt_r1 IS 'D 移動日(移動前1)';


--
-- Name: COLUMN d_kykm.b_bcat_id_r2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_bcat_id_r2 IS 'N(9) 管理部署ID(移動前2)';


--
-- Name: COLUMN d_kykm.ido_dt_r2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.ido_dt_r2 IS 'D 移動日(移動前2)';


--
-- Name: COLUMN d_kykm.b_bcat_id_r3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_bcat_id_r3 IS 'N(9) 管理部署ID(移動前3)';


--
-- Name: COLUMN d_kykm.ido_dt_r3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.ido_dt_r3 IS 'D 移動日(移動前3)';


--
-- Name: COLUMN d_kykm.k_gsha_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.k_gsha_id IS 'N(9) 購入先ID';


--
-- Name: COLUMN d_kykm.bkind_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.bkind_id IS 'N(9) 物件種別ID';


--
-- Name: COLUMN d_kykm.mcpt_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.mcpt_id IS 'N(9) ﾒｰｶｰID';


--
-- Name: COLUMN d_kykm.rsrvb1_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.rsrvb1_id IS 'N(9) 予備ID';


--
-- Name: COLUMN d_kykm.b_smdt_fst_sum; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_smdt_fst_sum IS 'D 初回〆日・支払集計用';


--
-- Name: COLUMN d_kykm.b_smdt_lst_sum; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_smdt_lst_sum IS 'D 最終〆日・支払集計用';


--
-- Name: COLUMN d_kykm.b_shdt_fst_sum; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_shdt_fst_sum IS 'D 初回支払日・支払集計用';


--
-- Name: COLUMN d_kykm.b_shdt_lst_sum; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_shdt_lst_sum IS 'D 最終支払日・支払集計用';


--
-- Name: COLUMN d_kykm.setti_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.setti_dt IS 'D 設置日';


--
-- Name: COLUMN d_kykm.bukn_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.bukn_nm IS 'V2(100) 物件名称';


--
-- Name: COLUMN d_kykm.b_zokusei1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_zokusei1 IS 'V2(100) 備考1';


--
-- Name: COLUMN d_kykm.b_zokusei2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_zokusei2 IS 'V2(100) 備考2';


--
-- Name: COLUMN d_kykm.b_zokusei3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_zokusei3 IS 'V2(100) 備考3';


--
-- Name: COLUMN d_kykm.b_zokusei4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_zokusei4 IS 'V2(100) 備考4';


--
-- Name: COLUMN d_kykm.b_zokusei5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_zokusei5 IS 'V2(100) 備考5';


--
-- Name: COLUMN d_kykm.b_gson_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_gson_f IS 'N(1) 減損ﾌﾗｸﾞ ★2005/03/23';


--
-- Name: COLUMN d_kykm.rsok_tmg; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.rsok_tmg IS 'N(1) 先払/後払 1:後払(約定支払ﾓｰﾄﾞの場合、開始日以前の支払は全額元本とする)(M4) 2:先払 0:無指定 ★2005/02/08';


--
-- Name: COLUMN d_kykm.gk_calc_kind; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.gk_calc_kind IS 'N(1) 現在価値算定方法 1:約定支払 2:均等支払 0:無指定 ★2005/02/08';


--
-- Name: COLUMN d_kykm.hensai_kind; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.hensai_kind IS 'N(1) 返済方法 1:約定支払 2:均等支払 0:無指定 ★2005/03/23';


--
-- Name: COLUMN d_kykm.ij_kjyo_kind; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.ij_kjyo_kind IS 'N(1) 維持管理費用計上方法 1:約定支払 2:均等支払 0:無指定 ★2005/02/15';


--
-- Name: COLUMN d_kykm.gson_tk_kind; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.gson_tk_kind IS 'N(1) 減損勘定取崩額計上方法 1:約定支払 2:均等支払 0:無指定 ★2005/02/28';


--
-- Name: COLUMN d_kykm.lb_kjyo_kind; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.lb_kjyo_kind IS 'N(1) ﾘｰｽﾊﾞｯｸ繰延損益計上方法 1:約定支払 2:均等支払 0:無指定 ★2005/03/23';


--
-- Name: COLUMN d_kykm.rsok_tmg_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.rsok_tmg_ms_f IS 'N(1) 先払/後払上書不可ﾌﾗｸﾞ ★2005/02/08';


--
-- Name: COLUMN d_kykm.gk_calc_kind_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.gk_calc_kind_ms_f IS 'N(1) 現在価値算定方法上書不可ﾌﾗｸﾞ ★2005/02/08';


--
-- Name: COLUMN d_kykm.hensai_kind_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.hensai_kind_ms_f IS 'N(1) 返済方法上書不可ﾌﾗｸﾞ ★2005/03/23';


--
-- Name: COLUMN d_kykm.ij_kjyo_kind_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.ij_kjyo_kind_ms_f IS 'N(1) 維持管理費用計上方法上書不可ﾌﾗｸﾞ ★2005/02/15';


--
-- Name: COLUMN d_kykm.gson_tk_kind_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.gson_tk_kind_ms_f IS 'N(1) 減損勘定取崩額計上方法上書不可ﾌﾗｸﾞ ★2005/02/28';


--
-- Name: COLUMN d_kykm.lb_kjyo_kind_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.lb_kjyo_kind_ms_f IS 'N(1) ﾘｰｽﾊﾞｯｸ繰延損益計上方法上書不可ﾌﾗｸﾞ ★2005/03/23';


--
-- Name: COLUMN d_kykm.kjkbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kjkbn_id IS 'N(1) 計上区分ID 2007/11/7 オンバランス対応';


--
-- Name: COLUMN d_kykm.skyak_ho_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.skyak_ho_id IS 'N(1) 償却方法ID 2007/12/26';


--
-- Name: COLUMN d_kykm.kj_flg; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kj_flg IS 'N(1) 切替フラグ 2008-04-03切替対応';


--
-- Name: COLUMN d_kykm.syk_kikan; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.syk_kikan IS 'N(3) 償却期間（月数） 2008-04-03切替対応';


--
-- Name: COLUMN d_kykm.kj_kkakaku; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kj_kkakaku IS 'N(15) 計上開始価格 2008-04-03切替対応';


--
-- Name: COLUMN d_kykm.kj_ksan_ritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kj_ksan_ritu IS 'N(11,8) 切替後計算利子率 2008-04-03切替対応';


--
-- Name: COLUMN d_kykm.kj_ho; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kj_ho IS 'N(1) 旧令資産計上方針 2008-04-03切替対応';


--
-- Name: COLUMN d_kykm.kj_b_slsryo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kj_b_slsryo IS 'N(15) 切替後ﾘｰｽ料総額 2008-04-09切替対応';


--
-- Name: COLUMN d_kykm.kj_b_ijiknr; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kj_b_ijiknr IS 'N(15) 切替後維持管理費用 2008-04-25切替対応';


--
-- Name: COLUMN d_kykm.kjkbn_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.kjkbn_ms_f IS 'N(1) 計上区分自動設定フラグ 2008-05-26';


--
-- Name: COLUMN d_kykm.b_kjyo_en_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_kjyo_en_dt IS 'D 計上終了月 2008-05-26';


--
-- Name: COLUMN d_kykm.b_bcat_cd_k; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_bcat_cd_k IS 'V2(12) 契約時使用場所CD 2008-05-26';


--
-- Name: COLUMN d_kykm.b_bcat_nm_k; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_bcat_nm_k IS 'V2(40) 契約時使用場所名称 2008-05-26';


--
-- Name: COLUMN d_kykm.b_sairyo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.b_sairyo IS 'N(15) 参考再リース料 2008-05-26';


--
-- Name: COLUMN d_kykm.szei_kjkbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.szei_kjkbn_id IS 'N(1) 消費税計上区分ID 2009/01/21';


--
-- Name: COLUMN d_kykm.szei_kjkbn_id_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.szei_kjkbn_id_ms_f IS 'N(1) 消費税計上区分自動設定禁止ﾌﾗｸﾞ 2009/01/21';


--
-- Name: COLUMN d_kykm.hszei_kjkbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.hszei_kjkbn_id IS 'N(1) 保守消費税計上区分ID 2009/01/21';


--
-- Name: COLUMN d_kykm.hszei_kjkbn_id_ms_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.hszei_kjkbn_id_ms_f IS 'N(1) 保守消費税計上区分自動設定禁止ﾌﾗｸﾞ 2009/01/21';


--
-- Name: COLUMN d_kykm.act_unit_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.d_kykm.act_unit_id IS '拡張: 新リース会計単位IDへのリンク';


--
-- Name: l_bklog; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.l_bklog (
    op_dt timestamp without time zone NOT NULL,
    op_nm character varying(8),
    op_s character varying(20),
    op_user_cd character varying(12),
    op_user_nm character varying(40),
    pc_name character varying(40),
    ip_adr character varying(100),
    win_user character varying(40),
    file_name character varying(40),
    folder character varying(255),
    pwd character varying(255),
    db_version character varying(30) NOT NULL
);


--
-- Name: TABLE l_bklog; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.l_bklog IS '保存・復元ログ 2009/08/31';


--
-- Name: COLUMN l_bklog.op_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.op_dt IS 'D 操作日時';


--
-- Name: COLUMN l_bklog.op_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.op_nm IS 'V2(8) 操作名　保存、復元、移行';


--
-- Name: COLUMN l_bklog.op_s; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.op_s IS 'V2(20) 操作備考';


--
-- Name: COLUMN l_bklog.op_user_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.op_user_cd IS 'V2(12) 操作者コード　（利用者CD）';


--
-- Name: COLUMN l_bklog.op_user_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.op_user_nm IS 'V2(40) 操作者名　（利用者名称）';


--
-- Name: COLUMN l_bklog.pc_name; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.pc_name IS 'V2(40) コンピュータ名';


--
-- Name: COLUMN l_bklog.ip_adr; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.ip_adr IS 'V2(100) ＩＰアドレス';


--
-- Name: COLUMN l_bklog.win_user; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.win_user IS 'V2(40) ＷＩＮユーザー';


--
-- Name: COLUMN l_bklog.file_name; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.file_name IS 'V2(40) ファイル名';


--
-- Name: COLUMN l_bklog.folder; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.folder IS 'V2(255) フォルダ名';


--
-- Name: COLUMN l_bklog.pwd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.pwd IS 'V2(255) ﾊﾟｽﾜｰﾄﾞ';


--
-- Name: COLUMN l_bklog.db_version; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_bklog.db_version IS 'V2(30) DBﾊﾞｰｼﾞｮﾝ';


--
-- Name: l_slog; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.l_slog (
    slog_no integer NOT NULL,
    op_st_dt timestamp without time zone,
    op_en_dt timestamp without time zone,
    op_kbn character varying(3),
    op_nm character varying(50),
    op_s character varying(40),
    op_user_cd character varying(12),
    op_user_nm character varying(40),
    pc_name character varying(40),
    ip_adr character varying(100),
    win_user character varying(40),
    op_detail1 character varying(255),
    op_detail2 text,
    upd_sbt character varying(6),
    yobi character varying(40)
);


--
-- Name: TABLE l_slog; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.l_slog IS '操作ログ 2009/08/31';


--
-- Name: COLUMN l_slog.slog_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.slog_no IS 'N(9) 操作ログ番号';


--
-- Name: COLUMN l_slog.op_st_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.op_st_dt IS 'D 操作開始日時';


--
-- Name: COLUMN l_slog.op_en_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.op_en_dt IS 'D 操作終了日時';


--
-- Name: COLUMN l_slog.op_kbn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.op_kbn IS 'N(3) 操作区分';


--
-- Name: COLUMN l_slog.op_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.op_nm IS 'V2(50) 操作名';


--
-- Name: COLUMN l_slog.op_s; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.op_s IS 'V2(40) 操作備考 2009/11/03  20 -> 40';


--
-- Name: COLUMN l_slog.op_user_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.op_user_cd IS 'V2(12) 操作者コード　（利用者CD）';


--
-- Name: COLUMN l_slog.op_user_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.op_user_nm IS 'V2(40) 操作者名　（利用者名称）';


--
-- Name: COLUMN l_slog.pc_name; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.pc_name IS 'V2(40) コンピュータ名';


--
-- Name: COLUMN l_slog.ip_adr; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.ip_adr IS 'V2(100) ＩＰアドレス';


--
-- Name: COLUMN l_slog.win_user; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.win_user IS 'V2(40) ＷＩＮユーザー';


--
-- Name: COLUMN l_slog.op_detail1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.op_detail1 IS 'V2(255) 操作詳細１';


--
-- Name: COLUMN l_slog.op_detail2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.op_detail2 IS 'V2(4000) 操作詳細２';


--
-- Name: COLUMN l_slog.upd_sbt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.upd_sbt IS 'V2(6) 更新種別';


--
-- Name: COLUMN l_slog.yobi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_slog.yobi IS 'V2(40) 予備';


--
-- Name: l_ulog; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.l_ulog (
    slog_no integer NOT NULL,
    ulog_no integer NOT NULL,
    tbl_nm character varying(40),
    upd_nm character varying(4),
    key_nm1 character varying(50),
    key_val1 character varying(30),
    key_nm2 character varying(50),
    key_val2 character varying(30),
    rec1 text,
    rec2 text,
    db_version character varying(30) NOT NULL,
    recf character varying(1),
    yobi character varying(40)
);


--
-- Name: TABLE l_ulog; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.l_ulog IS 'データ更新ログ　2009/08/31';


--
-- Name: COLUMN l_ulog.slog_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.slog_no IS 'N(9) 操作ログ番号';


--
-- Name: COLUMN l_ulog.ulog_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.ulog_no IS 'N(9) 更新ログ番号';


--
-- Name: COLUMN l_ulog.tbl_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.tbl_nm IS 'V2(40) ﾃｰﾌﾞﾙ名';


--
-- Name: COLUMN l_ulog.upd_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.upd_nm IS 'V2(4) 更新名 追加　変更　削除';


--
-- Name: COLUMN l_ulog.key_nm1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.key_nm1 IS 'V2(50) KEY名称１';


--
-- Name: COLUMN l_ulog.key_val1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.key_val1 IS 'V2(30) KEY値１';


--
-- Name: COLUMN l_ulog.key_nm2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.key_nm2 IS 'V2(50) KEY名称２';


--
-- Name: COLUMN l_ulog.key_val2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.key_val2 IS 'V2(30) KEY値２';


--
-- Name: COLUMN l_ulog.rec1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.rec1 IS 'CLOB レコード内容１';


--
-- Name: COLUMN l_ulog.rec2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.rec2 IS 'CLOB レコード内容２';


--
-- Name: COLUMN l_ulog.db_version; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.db_version IS 'V2(30) DBﾊﾞｰｼﾞｮﾝ';


--
-- Name: COLUMN l_ulog.recf; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.recf IS 'V2(1) レコード出力フラグ';


--
-- Name: COLUMN l_ulog.yobi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.l_ulog.yobi IS 'V2(40) 予備';


--
-- Name: m_bcat; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_bcat (
    bcat_id integer NOT NULL,
    bcat1_cd character varying(12),
    bcat1_nm character varying(80),
    bcat2_cd character varying(12),
    bcat2_nm character varying(40),
    bcat3_cd character varying(12),
    bcat3_nm character varying(40),
    bcat4_cd character varying(12),
    bcat4_nm character varying(40),
    bcat5_cd character varying(12),
    bcat5_nm character varying(40),
    genk_id integer NOT NULL,
    skti_id integer NOT NULL,
    sum1_cd character varying(12),
    sum1_nm character varying(40),
    sum2_cd character varying(12),
    sum2_nm character varying(40),
    sum3_cd character varying(12),
    sum3_nm character varying(40),
    bknri_id integer NOT NULL,
    kbf_kb boolean NOT NULL,
    kbf_fb boolean NOT NULL,
    kbf_sb boolean NOT NULL,
    gensonf boolean NOT NULL,
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_bcat; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_bcat IS 'マスタ：部署';


--
-- Name: COLUMN m_bcat.bcat_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bcat_id IS 'N(9) 部署ID';


--
-- Name: COLUMN m_bcat.bcat1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bcat1_cd IS 'V2(12) 部署ｶﾃｺﾞﾘ1CD';


--
-- Name: COLUMN m_bcat.bcat1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bcat1_nm IS 'V2(80) 部署ｶﾃｺﾞﾘ1名称 ★2005/04/25 V(40)→V(80)';


--
-- Name: COLUMN m_bcat.bcat2_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bcat2_cd IS 'V2(12) 部署ｶﾃｺﾞﾘ2CD';


--
-- Name: COLUMN m_bcat.bcat2_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bcat2_nm IS 'V2(40) 部署ｶﾃｺﾞﾘ2名称';


--
-- Name: COLUMN m_bcat.bcat3_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bcat3_cd IS 'V2(12) 部署ｶﾃｺﾞﾘ3CD';


--
-- Name: COLUMN m_bcat.bcat3_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bcat3_nm IS 'V2(40) 部署ｶﾃｺﾞﾘ3名称';


--
-- Name: COLUMN m_bcat.bcat4_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bcat4_cd IS 'V2(12) 部署ｶﾃｺﾞﾘ4CD';


--
-- Name: COLUMN m_bcat.bcat4_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bcat4_nm IS 'V2(40) 部署ｶﾃｺﾞﾘ4名称';


--
-- Name: COLUMN m_bcat.bcat5_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bcat5_cd IS 'V2(12) 部署ｶﾃｺﾞﾘ5CD';


--
-- Name: COLUMN m_bcat.bcat5_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bcat5_nm IS 'V2(40) 部署ｶﾃｺﾞﾘ5名称';


--
-- Name: COLUMN m_bcat.genk_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.genk_id IS 'N(9) 原価区分ID';


--
-- Name: COLUMN m_bcat.skti_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.skti_id IS 'N(9) 申告地ID';


--
-- Name: COLUMN m_bcat.sum1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.sum1_cd IS 'V2(12) 集計区分1CD';


--
-- Name: COLUMN m_bcat.sum1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.sum1_nm IS 'V2(40) 集計区分1名称';


--
-- Name: COLUMN m_bcat.sum2_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.sum2_cd IS 'V2(12) 集計区分2CD';


--
-- Name: COLUMN m_bcat.sum2_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.sum2_nm IS 'V2(40) 集計区分2名称';


--
-- Name: COLUMN m_bcat.sum3_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.sum3_cd IS 'V2(12) 集計区分3CD';


--
-- Name: COLUMN m_bcat.sum3_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.sum3_nm IS 'V2(40) 集計区分3名称';


--
-- Name: COLUMN m_bcat.bknri_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.bknri_id IS 'N(9) 物件管理単位ID ☆2008-07-30';


--
-- Name: COLUMN m_bcat.kbf_kb; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.kbf_kb IS 'N(1) 管理部署使用ﾌﾗｸﾞ ☆2008-07-30';


--
-- Name: COLUMN m_bcat.kbf_fb; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.kbf_fb IS 'N(1) 負担部署使用ﾌﾗｸﾞ ☆2008-07-30';


--
-- Name: COLUMN m_bcat.kbf_sb; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.kbf_sb IS 'N(1) 設置部署使用ﾌﾗｸﾞ ☆2008-07-30';


--
-- Name: COLUMN m_bcat.gensonf; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.gensonf IS 'N(1) 現存ﾌﾗｸﾞ ☆2008-07-30';


--
-- Name: COLUMN m_bcat.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_bcat.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_bcat.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_bcat.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_bcat.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_bcat.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_bcat.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bcat.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_bkind; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_bkind (
    bkind_id integer NOT NULL,
    bkind_cd character varying(12),
    bkind_nm character varying(40),
    bkind2_cd character varying(12),
    bkind2_nm character varying(40),
    bkind3_cd character varying(12),
    bkind3_nm character varying(40),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_bkind; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_bkind IS 'マスタ：物件種別';


--
-- Name: COLUMN m_bkind.bkind_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.bkind_id IS 'N(9) 物件種別ID';


--
-- Name: COLUMN m_bkind.bkind_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.bkind_cd IS 'V2(12) 物件種別CD';


--
-- Name: COLUMN m_bkind.bkind_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.bkind_nm IS 'V2(40) 物件種別名称';


--
-- Name: COLUMN m_bkind.bkind2_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.bkind2_cd IS 'V2(12) 物件種別2CD ★2005/04/28';


--
-- Name: COLUMN m_bkind.bkind2_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.bkind2_nm IS 'V2(40) 物件種別2名称 ★2005/04/28';


--
-- Name: COLUMN m_bkind.bkind3_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.bkind3_cd IS 'V2(12) 物件種別3CD ★2005/04/28';


--
-- Name: COLUMN m_bkind.bkind3_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.bkind3_nm IS 'V2(40) 物件種別3名称 ★2005/04/28';


--
-- Name: COLUMN m_bkind.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.biko IS 'V(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_bkind.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_bkind.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_bkind.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_bkind.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_bkind.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_bkind.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bkind.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_bknri; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_bknri (
    bknri_id integer NOT NULL,
    bknri1_cd character varying(12),
    bknri1_nm character varying(80),
    bknri2_cd character varying(12),
    bknri2_nm character varying(40),
    bknri3_cd character varying(12),
    bknri3_nm character varying(40),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_bknri; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_bknri IS 'マスタ：物件管理単位 ☆2008-07-30';


--
-- Name: COLUMN m_bknri.bknri_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.bknri_id IS 'N(9) 物件管理単位ID';


--
-- Name: COLUMN m_bknri.bknri1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.bknri1_cd IS 'V2(12) 物件管理単位1CD';


--
-- Name: COLUMN m_bknri.bknri1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.bknri1_nm IS 'V2(80) 物件管理単位1名称';


--
-- Name: COLUMN m_bknri.bknri2_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.bknri2_cd IS 'V2(12) 物件管理単位2CD';


--
-- Name: COLUMN m_bknri.bknri2_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.bknri2_nm IS 'V2(40) 物件管理単位2名称';


--
-- Name: COLUMN m_bknri.bknri3_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.bknri3_cd IS 'V2(12) 物件管理単位3CD';


--
-- Name: COLUMN m_bknri.bknri3_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.bknri3_nm IS 'V2(40) 物件管理単位3名称';


--
-- Name: COLUMN m_bknri.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.biko IS 'V2(100) 備考';


--
-- Name: COLUMN m_bknri.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_bknri.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_bknri.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_bknri.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_bknri.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_bknri.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_bknri.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_corp; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_corp (
    corp_id integer NOT NULL,
    corp1_cd character varying(12),
    corp1_nm character varying(40),
    corp2_cd character varying(12),
    corp2_nm character varying(40),
    corp3_cd character varying(12),
    corp3_nm character varying(40),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_corp; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_corp IS 'マスタ：会社';


--
-- Name: COLUMN m_corp.corp_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.corp_id IS 'N(9) 会社ID';


--
-- Name: COLUMN m_corp.corp1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.corp1_cd IS 'V2(12) 会社ｶﾃｺﾞﾘ1CD';


--
-- Name: COLUMN m_corp.corp1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.corp1_nm IS 'V2(40) 会社ｶﾃｺﾞﾘ1名称';


--
-- Name: COLUMN m_corp.corp2_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.corp2_cd IS 'V2(12) 会社ｶﾃｺﾞﾘ2CD';


--
-- Name: COLUMN m_corp.corp2_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.corp2_nm IS 'V2(40) 会社ｶﾃｺﾞﾘ2名称';


--
-- Name: COLUMN m_corp.corp3_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.corp3_cd IS 'V2(12) 会社ｶﾃｺﾞﾘ3CD';


--
-- Name: COLUMN m_corp.corp3_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.corp3_nm IS 'V2(40) 会社ｶﾃｺﾞﾘ3名称';


--
-- Name: COLUMN m_corp.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.biko IS 'V(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_corp.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_corp.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_corp.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_corp.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_corp.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_corp.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_corp.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_genk; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_genk (
    genk_id integer NOT NULL,
    genk_cd character varying(12),
    genk_nm character varying(40),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_genk; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_genk IS 'マスタ：原価区分';


--
-- Name: COLUMN m_genk.genk_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_genk.genk_id IS 'N(9) 原価区分ID';


--
-- Name: COLUMN m_genk.genk_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_genk.genk_cd IS 'V2(12) 原価区分CD';


--
-- Name: COLUMN m_genk.genk_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_genk.genk_nm IS 'V2(40) 原価区分名称';


--
-- Name: COLUMN m_genk.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_genk.biko IS 'V(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_genk.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_genk.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_genk.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_genk.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_genk.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_genk.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_genk.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_genk.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_genk.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_genk.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_genk.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_genk.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_gsha; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_gsha (
    gsha_id integer NOT NULL,
    gsha_cd character varying(12),
    gsha_nm character varying(40),
    biko character varying(200),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_gsha; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_gsha IS 'マスタ：業者';


--
-- Name: COLUMN m_gsha.gsha_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_gsha.gsha_id IS 'N(9) 業者ID';


--
-- Name: COLUMN m_gsha.gsha_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_gsha.gsha_cd IS 'V2(12) 業者CD';


--
-- Name: COLUMN m_gsha.gsha_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_gsha.gsha_nm IS 'V2(40) 業者名称';


--
-- Name: COLUMN m_gsha.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_gsha.biko IS 'V2(200) 備考';


--
-- Name: COLUMN m_gsha.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_gsha.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_gsha.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_gsha.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_gsha.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_gsha.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_gsha.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_gsha.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_gsha.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_gsha.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_gsha.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_gsha.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_hkho; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_hkho (
    hkho_id integer NOT NULL,
    hkho_cd character varying(12),
    hkho_nm character varying(40),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_hkho; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_hkho IS 'マスタ：廃棄方法';


--
-- Name: COLUMN m_hkho.hkho_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkho.hkho_id IS 'N(9) 廃棄方法ID';


--
-- Name: COLUMN m_hkho.hkho_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkho.hkho_cd IS 'V2(12) 廃棄方法CD';


--
-- Name: COLUMN m_hkho.hkho_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkho.hkho_nm IS 'V2(40) 廃棄方法名称';


--
-- Name: COLUMN m_hkho.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkho.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_hkho.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkho.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_hkho.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkho.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_hkho.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkho.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_hkho.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkho.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_hkho.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkho.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_hkho.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkho.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_hkmk; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_hkmk (
    hkmk_id integer NOT NULL,
    hkmk_cd character varying(12),
    hkmk_nm character varying(40),
    knjkb_id integer NOT NULL,
    sum1_cd character varying(12),
    sum1_nm character varying(40),
    sum2_cd character varying(12),
    sum2_nm character varying(40),
    sum3_cd character varying(12),
    sum3_nm character varying(40),
    hrel_ptn_cd3 character varying(12),
    hrel_ptn_nm3 character varying(40),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_hkmk; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_hkmk IS 'マスタ：費用科目';


--
-- Name: COLUMN m_hkmk.hkmk_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.hkmk_id IS 'N(9) 費用区分ID';


--
-- Name: COLUMN m_hkmk.hkmk_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.hkmk_cd IS 'V2(12) 費用区分CD';


--
-- Name: COLUMN m_hkmk.hkmk_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.hkmk_nm IS 'V2(40) 費用区分名称';


--
-- Name: COLUMN m_hkmk.knjkb_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.knjkb_id IS 'N(9) 勘定区分ID(ﾀﾞﾐｰ)';


--
-- Name: COLUMN m_hkmk.sum1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.sum1_cd IS 'V2(12) 集計区分1CD';


--
-- Name: COLUMN m_hkmk.sum1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.sum1_nm IS 'V2(40) 集計区分1名称';


--
-- Name: COLUMN m_hkmk.sum2_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.sum2_cd IS 'V2(12) 集計区分2CD';


--
-- Name: COLUMN m_hkmk.sum2_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.sum2_nm IS 'V2(40) 集計区分2名称';


--
-- Name: COLUMN m_hkmk.sum3_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.sum3_cd IS 'V2(12) 集計区分3CD';


--
-- Name: COLUMN m_hkmk.sum3_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.sum3_nm IS 'V2(40) 集計区分3名称';


--
-- Name: COLUMN m_hkmk.hrel_ptn_cd3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.hrel_ptn_cd3 IS 'V2(12) 費目決定要素CD 2008/07/17';


--
-- Name: COLUMN m_hkmk.hrel_ptn_nm3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.hrel_ptn_nm3 IS 'V2(40) 費目決定要素     2008/07/17';


--
-- Name: COLUMN m_hkmk.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_hkmk.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_hkmk.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_hkmk.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_hkmk.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_hkmk.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_hkmk.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_hkmk.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_kknri; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_kknri (
    kknri_id integer NOT NULL,
    kknri1_cd character varying(12),
    kknri1_nm character varying(40),
    kknri2_cd character varying(12),
    kknri2_nm character varying(40),
    kknri3_cd character varying(12),
    kknri3_nm character varying(40),
    corp_id integer NOT NULL,
    hrel_ptn_cd4 character varying(12),
    hrel_ptn_nm4 character varying(40),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_kknri; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_kknri IS 'マスタ：契約管理単位';


--
-- Name: COLUMN m_kknri.kknri_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.kknri_id IS 'N(9) 契約管理単位ID';


--
-- Name: COLUMN m_kknri.kknri1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.kknri1_cd IS 'V2(12) 契約管理単位1CD';


--
-- Name: COLUMN m_kknri.kknri1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.kknri1_nm IS 'V2(40) 契約管理単位1名称';


--
-- Name: COLUMN m_kknri.kknri2_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.kknri2_cd IS 'V2(12) 契約管理単位2CD';


--
-- Name: COLUMN m_kknri.kknri2_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.kknri2_nm IS 'V2(40) 契約管理単位2名称';


--
-- Name: COLUMN m_kknri.kknri3_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.kknri3_cd IS 'V2(12) 契約管理単位3CD';


--
-- Name: COLUMN m_kknri.kknri3_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.kknri3_nm IS 'V2(40) 契約管理単位3名称';


--
-- Name: COLUMN m_kknri.corp_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.corp_id IS 'N(9) 会社ID';


--
-- Name: COLUMN m_kknri.hrel_ptn_cd4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.hrel_ptn_cd4 IS 'V2(12) 費目決定要素CD 2008/07/17';


--
-- Name: COLUMN m_kknri.hrel_ptn_nm4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.hrel_ptn_nm4 IS 'V2(40) 費目決定要素     2008/07/17';


--
-- Name: COLUMN m_kknri.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_kknri.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_kknri.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_kknri.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_kknri.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_kknri.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_kknri.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_kknri.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_koza; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_koza (
    koza_id integer NOT NULL,
    koza_cd character varying(12),
    koza_nm character varying(40),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_koza; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_koza IS 'マスタ：銀行口座（引落口座）';


--
-- Name: COLUMN m_koza.koza_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_koza.koza_id IS 'N(9) 銀行口座ID';


--
-- Name: COLUMN m_koza.koza_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_koza.koza_cd IS 'V2(12) 銀行口座CD';


--
-- Name: COLUMN m_koza.koza_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_koza.koza_nm IS 'V2(40) 銀行口座名称';


--
-- Name: COLUMN m_koza.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_koza.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_koza.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_koza.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_koza.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_koza.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_koza.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_koza.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_koza.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_koza.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_koza.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_koza.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_koza.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_koza.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_lcpt; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_lcpt (
    lcpt_id integer NOT NULL,
    lcpt1_cd character varying(12),
    lcpt1_nm character varying(40),
    lcpt2_cd character varying(12),
    lcpt2_nm character varying(40),
    shime_day_1 integer,
    sshri_kn1_1 integer,
    shri_day1_1 integer,
    sshri_kn2_1 integer,
    shri_day2_1 integer,
    shime_day_2 integer,
    sshri_kn1_2 integer,
    shri_day1_2 integer,
    sshri_kn2_2 integer,
    shri_day2_2 integer,
    shime_day_3 integer,
    sshri_kn1_3 integer,
    shri_day1_3 integer,
    sshri_kn2_3 integer,
    shri_day2_3 integer,
    sai_denomi integer,
    biko character varying(200),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL,
    sum1_cd character varying(12),
    sum1_nm character varying(40),
    sum2_cd character varying(12),
    sum2_nm character varying(40),
    sum3_cd character varying(12),
    sum3_nm character varying(40),
    shri_kn_ini integer,
    slkikan_s integer,
    shri_kn_s integer,
    sai_denomi_s integer,
    sai_numerator_s integer,
    slkikan_n integer,
    shri_kn_n integer,
    sai_denomi_n integer,
    sai_numerator_n integer,
    shri_cnt_s_1 integer,
    shho_id_s_1 integer NOT NULL,
    shho_id_n_1 integer NOT NULL,
    shri_cnt_s_2 integer,
    shho_id_s_2 integer NOT NULL,
    shho_id_n_2 integer NOT NULL,
    shri_cnt_s_3 integer,
    shho_id_s_3 integer NOT NULL,
    shho_id_n_3 integer NOT NULL
);


--
-- Name: TABLE m_lcpt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_lcpt IS 'マスタ：ﾘｰｽ会社';


--
-- Name: COLUMN m_lcpt.lcpt_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.lcpt_id IS 'N(9) 支払先ID';


--
-- Name: COLUMN m_lcpt.lcpt1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.lcpt1_cd IS 'V2(12) 支払先1CD';


--
-- Name: COLUMN m_lcpt.lcpt1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.lcpt1_nm IS 'V2(40) 支払先1名称';


--
-- Name: COLUMN m_lcpt.lcpt2_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.lcpt2_cd IS 'V2(12) 支払先2CD';


--
-- Name: COLUMN m_lcpt.lcpt2_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.lcpt2_nm IS 'V2(40) 支払先2名称';


--
-- Name: COLUMN m_lcpt.shime_day_1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shime_day_1 IS 'N(2) 〆日1';


--
-- Name: COLUMN m_lcpt.sshri_kn1_1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sshri_kn1_1 IS 'N(2) 初回支払〆支払間隔1';


--
-- Name: COLUMN m_lcpt.shri_day1_1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_day1_1 IS 'N(2) 初回支払日1';


--
-- Name: COLUMN m_lcpt.sshri_kn2_1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sshri_kn2_1 IS 'N(2) 2回目支払〆支払間隔1';


--
-- Name: COLUMN m_lcpt.shri_day2_1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_day2_1 IS 'N(2) 2回目支払日1';


--
-- Name: COLUMN m_lcpt.shime_day_2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shime_day_2 IS 'N(2) 〆日2';


--
-- Name: COLUMN m_lcpt.sshri_kn1_2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sshri_kn1_2 IS 'N(2) 初回支払〆支払間隔2';


--
-- Name: COLUMN m_lcpt.shri_day1_2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_day1_2 IS 'N(2) 初回支払日2';


--
-- Name: COLUMN m_lcpt.sshri_kn2_2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sshri_kn2_2 IS 'N(2) 2回目支払〆支払間隔2';


--
-- Name: COLUMN m_lcpt.shri_day2_2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_day2_2 IS 'N(2) 2回目支払日2';


--
-- Name: COLUMN m_lcpt.shime_day_3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shime_day_3 IS 'N(2) 〆日3';


--
-- Name: COLUMN m_lcpt.sshri_kn1_3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sshri_kn1_3 IS 'N(2) 初回支払〆支払間隔3';


--
-- Name: COLUMN m_lcpt.shri_day1_3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_day1_3 IS 'N(2) 初回支払日3';


--
-- Name: COLUMN m_lcpt.sshri_kn2_3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sshri_kn2_3 IS 'N(2) 2回目支払〆支払間隔3';


--
-- Name: COLUMN m_lcpt.shri_day2_3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_day2_3 IS 'N(2) 2回目支払日3';


--
-- Name: COLUMN m_lcpt.sai_denomi; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sai_denomi IS 'N(3) 再ﾘｰｽ料算定分母';


--
-- Name: COLUMN m_lcpt.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.biko IS 'V2(200) 備考';


--
-- Name: COLUMN m_lcpt.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_lcpt.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_lcpt.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_lcpt.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_lcpt.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_lcpt.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: COLUMN m_lcpt.sum1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sum1_cd IS 'V2(12) 集計区分1CD 2008-05-26';


--
-- Name: COLUMN m_lcpt.sum1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sum1_nm IS 'V2(40) 集計区分1名称 2008-05-26';


--
-- Name: COLUMN m_lcpt.sum2_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sum2_cd IS 'V2(12) 集計区分2CD 2008-05-26';


--
-- Name: COLUMN m_lcpt.sum2_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sum2_nm IS 'V2(40) 集計区分2名称 2008-05-26';


--
-- Name: COLUMN m_lcpt.sum3_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sum3_cd IS 'V2(12) 集計区分3CD 2008-05-26';


--
-- Name: COLUMN m_lcpt.sum3_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sum3_nm IS 'V2(40) 集計区分3名称 2008-05-26';


--
-- Name: COLUMN m_lcpt.shri_kn_ini; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_kn_ini IS 'N(2) 支払間隔初期値 2008-05-30';


--
-- Name: COLUMN m_lcpt.slkikan_s; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.slkikan_s IS 'N(3) 初回・再ﾘｰｽ期間 ★RISO 2007/03/22(ROLANDと同じ)';


--
-- Name: COLUMN m_lcpt.shri_kn_s; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_kn_s IS 'N(2) 初回・支払間隔 ★RISO 2007/03/22(ROLANDと同じ)';


--
-- Name: COLUMN m_lcpt.sai_denomi_s; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sai_denomi_s IS 'N(3) 初回・再ﾘｰｽ料算定分母 ★RISO 2007/03/22(ROLANDと同じ)';


--
-- Name: COLUMN m_lcpt.sai_numerator_s; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sai_numerator_s IS 'N(3) 初回・再ﾘｰｽ料算定分子 ★RISO 2007/03/22(ROLANDと同じ)';


--
-- Name: COLUMN m_lcpt.slkikan_n; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.slkikan_n IS 'N(3) 2回目以降・再ﾘｰｽ期間 ★RISO 2007/03/22(ROLANDと同じ)';


--
-- Name: COLUMN m_lcpt.shri_kn_n; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_kn_n IS 'N(2) 2回目以降・支払間隔 ★RISO 2007/03/22(ROLANDと同じ)';


--
-- Name: COLUMN m_lcpt.sai_denomi_n; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sai_denomi_n IS 'N(3) 2回目以降・再ﾘｰｽ料算定分母 ★RISO 2007/03/22(ROLANDと同じ)';


--
-- Name: COLUMN m_lcpt.sai_numerator_n; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.sai_numerator_n IS 'N(3) 2回目以降・再ﾘｰｽ料算定分子 ★RISO 2007/03/22(ROLANDと同じ)';


--
-- Name: COLUMN m_lcpt.shri_cnt_s_1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_cnt_s_1 IS 'N(3) 〆日1・1初回・支払回数★MYCOM 2011/02/18★';


--
-- Name: COLUMN m_lcpt.shho_id_s_1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shho_id_s_1 IS 'N(9) 〆日1・初回・支払方法ID★MYCOM 2011/02/18★';


--
-- Name: COLUMN m_lcpt.shho_id_n_1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shho_id_n_1 IS 'N(9) 〆日1・初回以降・支払方法ID★MYCOM 2011/02/18★';


--
-- Name: COLUMN m_lcpt.shri_cnt_s_2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_cnt_s_2 IS 'N(3) 〆日2・1初回・支払回数★MYCOM 2011/02/18★';


--
-- Name: COLUMN m_lcpt.shho_id_s_2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shho_id_s_2 IS 'N(9) 〆日2・初回・支払方法ID★MYCOM 2011/02/18★';


--
-- Name: COLUMN m_lcpt.shho_id_n_2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shho_id_n_2 IS 'N(9) 〆日2・初回以降・支払方法ID★MYCOM 2011/02/18★';


--
-- Name: COLUMN m_lcpt.shri_cnt_s_3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shri_cnt_s_3 IS 'N(3) 〆日3・1初回・支払回数★MYCOM 2011/02/18★';


--
-- Name: COLUMN m_lcpt.shho_id_s_3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shho_id_s_3 IS 'N(9) 〆日3・初回・支払方法ID★MYCOM 2011/02/18★';


--
-- Name: COLUMN m_lcpt.shho_id_n_3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_lcpt.shho_id_n_3 IS 'N(9) 〆日3・初回以降・支払方法ID★MYCOM 2011/02/18★';


--
-- Name: m_mcpt; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_mcpt (
    mcpt_id integer NOT NULL,
    mcpt_cd character varying(12),
    mcpt_nm character varying(40),
    biko character varying(200),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_mcpt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_mcpt IS 'マスタ：ﾒｰｶｰ';


--
-- Name: COLUMN m_mcpt.mcpt_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_mcpt.mcpt_id IS 'N(9) ﾒｰｶｰID';


--
-- Name: COLUMN m_mcpt.mcpt_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_mcpt.mcpt_cd IS 'V2(12) ﾒｰｶｰCD';


--
-- Name: COLUMN m_mcpt.mcpt_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_mcpt.mcpt_nm IS 'V2(40) ﾒｰｶｰ名称';


--
-- Name: COLUMN m_mcpt.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_mcpt.biko IS 'V2(200) 備考';


--
-- Name: COLUMN m_mcpt.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_mcpt.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_mcpt.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_mcpt.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_mcpt.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_mcpt.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_mcpt.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_mcpt.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_mcpt.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_mcpt.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_mcpt.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_mcpt.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_rsrvb1; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_rsrvb1 (
    rsrvb1_id integer NOT NULL,
    rsrvb1_cd character varying(12),
    rsrvb1_nm character varying(40),
    num double precision,
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_rsrvb1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_rsrvb1 IS 'マスタ：予備（物件）';


--
-- Name: COLUMN m_rsrvb1.rsrvb1_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvb1.rsrvb1_id IS 'N(9) 予備ID';


--
-- Name: COLUMN m_rsrvb1.rsrvb1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvb1.rsrvb1_cd IS 'V2(12) 予備CD';


--
-- Name: COLUMN m_rsrvb1.rsrvb1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvb1.rsrvb1_nm IS 'V2(40) 予備名称';


--
-- Name: COLUMN m_rsrvb1.num; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvb1.num IS 'N(15) 予備数値';


--
-- Name: COLUMN m_rsrvb1.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvb1.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_rsrvb1.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvb1.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_rsrvb1.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvb1.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_rsrvb1.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvb1.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_rsrvb1.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvb1.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_rsrvb1.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvb1.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_rsrvb1.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvb1.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_rsrvh1; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_rsrvh1 (
    rsrvh1_id integer NOT NULL,
    rsrvh1_cd character varying(12),
    rsrvh1_nm character varying(40),
    num double precision,
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_rsrvh1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_rsrvh1 IS 'マスタ：予備（配賦）';


--
-- Name: COLUMN m_rsrvh1.rsrvh1_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvh1.rsrvh1_id IS 'N(9) 予備ID';


--
-- Name: COLUMN m_rsrvh1.rsrvh1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvh1.rsrvh1_cd IS 'V2(12) 予備CD';


--
-- Name: COLUMN m_rsrvh1.rsrvh1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvh1.rsrvh1_nm IS 'V2(40) 予備名称';


--
-- Name: COLUMN m_rsrvh1.num; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvh1.num IS 'N(15) 予備数値';


--
-- Name: COLUMN m_rsrvh1.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvh1.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_rsrvh1.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvh1.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_rsrvh1.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvh1.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_rsrvh1.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvh1.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_rsrvh1.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvh1.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_rsrvh1.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvh1.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_rsrvh1.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvh1.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_rsrvk1; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_rsrvk1 (
    rsrvk1_id integer NOT NULL,
    rsrvk1_cd character varying(12),
    rsrvk1_nm character varying(40),
    num double precision,
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_rsrvk1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_rsrvk1 IS 'マスタ：予備（契約書）';


--
-- Name: COLUMN m_rsrvk1.rsrvk1_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvk1.rsrvk1_id IS 'N(9) 予備ID';


--
-- Name: COLUMN m_rsrvk1.rsrvk1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvk1.rsrvk1_cd IS 'V2(12) 予備CD';


--
-- Name: COLUMN m_rsrvk1.rsrvk1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvk1.rsrvk1_nm IS 'V2(40) 予備名称';


--
-- Name: COLUMN m_rsrvk1.num; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvk1.num IS 'N(15) 予備数値';


--
-- Name: COLUMN m_rsrvk1.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvk1.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_rsrvk1.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvk1.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_rsrvk1.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvk1.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_rsrvk1.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvk1.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_rsrvk1.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvk1.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_rsrvk1.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvk1.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_rsrvk1.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_rsrvk1.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_shho; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_shho (
    shho_id integer NOT NULL,
    shho_cd character varying(12),
    shho_nm character varying(40),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_shho; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_shho IS 'マスタ：支払方法';


--
-- Name: COLUMN m_shho.shho_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_shho.shho_id IS 'N(9) 支払方法ID';


--
-- Name: COLUMN m_shho.shho_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_shho.shho_cd IS 'V2(12) 支払方法CD';


--
-- Name: COLUMN m_shho.shho_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_shho.shho_nm IS 'V2(40) 支払方法名称';


--
-- Name: COLUMN m_shho.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_shho.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_shho.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_shho.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_shho.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_shho.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_shho.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_shho.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_shho.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_shho.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_shho.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_shho.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_shho.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_shho.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_skmk; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_skmk (
    skmk_id integer NOT NULL,
    skmk_cd character varying(12),
    skmk_nm character varying(40),
    knjkb_id integer NOT NULL,
    sum1_cd character varying(20),
    sum1_nm character varying(80),
    sum2_cd character varying(20),
    sum2_nm character varying(80),
    sum3_cd character varying(20),
    sum3_nm character varying(80),
    sum4_cd character varying(20),
    sum4_nm character varying(80),
    sum5_cd character varying(20),
    sum5_nm character varying(80),
    sum6_cd character varying(20),
    sum6_nm character varying(80),
    sum7_cd character varying(20),
    sum7_nm character varying(80),
    sum8_cd character varying(20),
    sum8_nm character varying(80),
    sum9_cd character varying(20),
    sum9_nm character varying(80),
    sum10_cd character varying(20),
    sum10_nm character varying(80),
    sum11_cd character varying(20),
    sum11_nm character varying(80),
    sum12_cd character varying(20),
    sum12_nm character varying(80),
    sum13_cd character varying(20),
    sum13_nm character varying(80),
    sum14_cd character varying(20),
    sum14_nm character varying(80),
    sum15_cd character varying(20),
    sum15_nm character varying(80),
    hrel_ptn_cd1 character varying(12),
    hrel_ptn_nm1 character varying(40),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_skmk; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_skmk IS 'マスタ：資産科目';


--
-- Name: COLUMN m_skmk.skmk_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.skmk_id IS 'N(9) 資産区分ID';


--
-- Name: COLUMN m_skmk.skmk_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.skmk_cd IS 'V2(12) 資産区分CD';


--
-- Name: COLUMN m_skmk.skmk_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.skmk_nm IS 'V2(40) 資産区分名称';


--
-- Name: COLUMN m_skmk.knjkb_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.knjkb_id IS 'N(9) 勘定区分ID(ﾀﾞﾐｰ)';


--
-- Name: COLUMN m_skmk.sum1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum1_cd IS 'V2(20) 集計区分1CD';


--
-- Name: COLUMN m_skmk.sum1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum1_nm IS 'V2(80) 集計区分1名称';


--
-- Name: COLUMN m_skmk.sum2_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum2_cd IS 'V2(20) 集計区分2CD';


--
-- Name: COLUMN m_skmk.sum2_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum2_nm IS 'V2(80) 集計区分2名称';


--
-- Name: COLUMN m_skmk.sum3_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum3_cd IS 'V2(20) 集計区分3CD';


--
-- Name: COLUMN m_skmk.sum3_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum3_nm IS 'V2(80) 集計区分3名称';


--
-- Name: COLUMN m_skmk.sum4_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum4_cd IS 'V2(20) 集計区分4CD';


--
-- Name: COLUMN m_skmk.sum4_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum4_nm IS 'V2(80) 集計区分4名称';


--
-- Name: COLUMN m_skmk.sum5_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum5_cd IS 'V2(20) 集計区分5CD';


--
-- Name: COLUMN m_skmk.sum5_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum5_nm IS 'V2(80) 集計区分5名称';


--
-- Name: COLUMN m_skmk.sum6_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum6_cd IS 'V2(20) 集計区分6CD';


--
-- Name: COLUMN m_skmk.sum6_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum6_nm IS 'V2(80) 集計区分6名称';


--
-- Name: COLUMN m_skmk.sum7_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum7_cd IS 'V2(20) 集計区分7CD';


--
-- Name: COLUMN m_skmk.sum7_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum7_nm IS 'V2(80) 集計区分7名称';


--
-- Name: COLUMN m_skmk.sum8_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum8_cd IS 'V2(20) 集計区分8CD';


--
-- Name: COLUMN m_skmk.sum8_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum8_nm IS 'V2(80) 集計区分8名称';


--
-- Name: COLUMN m_skmk.sum9_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum9_cd IS 'V2(20) 集計区分9CD';


--
-- Name: COLUMN m_skmk.sum9_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum9_nm IS 'V2(80) 集計区分9名称';


--
-- Name: COLUMN m_skmk.sum10_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum10_cd IS 'V2(20) 集計区分10CD';


--
-- Name: COLUMN m_skmk.sum10_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum10_nm IS 'V2(80) 集計区分10名称';


--
-- Name: COLUMN m_skmk.sum11_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum11_cd IS 'V2(20) 集計区分11CD';


--
-- Name: COLUMN m_skmk.sum11_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum11_nm IS 'V2(80) 集計区分11名称';


--
-- Name: COLUMN m_skmk.sum12_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum12_cd IS 'V2(20) 集計区分12CD';


--
-- Name: COLUMN m_skmk.sum12_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum12_nm IS 'V2(80) 集計区分12名称';


--
-- Name: COLUMN m_skmk.sum13_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum13_cd IS 'V2(20) 集計区分13CD';


--
-- Name: COLUMN m_skmk.sum13_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum13_nm IS 'V2(80) 集計区分13名称';


--
-- Name: COLUMN m_skmk.sum14_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum14_cd IS 'V2(20) 集計区分14CD';


--
-- Name: COLUMN m_skmk.sum14_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum14_nm IS 'V2(80) 集計区分14名称';


--
-- Name: COLUMN m_skmk.sum15_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum15_cd IS 'V2(20) 集計区分15CD';


--
-- Name: COLUMN m_skmk.sum15_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.sum15_nm IS 'V2(80) 集計区分15名称';


--
-- Name: COLUMN m_skmk.hrel_ptn_cd1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.hrel_ptn_cd1 IS 'V2(12) 費目決定要素CD';


--
-- Name: COLUMN m_skmk.hrel_ptn_nm1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.hrel_ptn_nm1 IS 'V2(80) 費目決定要素';


--
-- Name: COLUMN m_skmk.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.biko IS 'V2(100) 備考';


--
-- Name: COLUMN m_skmk.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_skmk.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_skmk.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_skmk.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_skmk.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_skmk.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skmk.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_skti; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_skti (
    skti_id integer NOT NULL,
    skti_cd character varying(12),
    skti_nm character varying(40),
    sktsyt character varying(40),
    jgsyonm character varying(40),
    jgsyopst character varying(10),
    jgsyoadr character varying(100),
    jgsyotel character varying(20),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_skti; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_skti IS 'マスタ：地方税申告地';


--
-- Name: COLUMN m_skti.skti_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.skti_id IS 'N(9) 申告地ID';


--
-- Name: COLUMN m_skti.skti_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.skti_cd IS 'V2(12) 申告地CD';


--
-- Name: COLUMN m_skti.skti_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.skti_nm IS 'V2(40) 申告地名称';


--
-- Name: COLUMN m_skti.sktsyt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.sktsyt IS 'V2(40) 提出先';


--
-- Name: COLUMN m_skti.jgsyonm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.jgsyonm IS 'V2(40) 事業所名称';


--
-- Name: COLUMN m_skti.jgsyopst; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.jgsyopst IS 'V2(10) 事業所郵便番号';


--
-- Name: COLUMN m_skti.jgsyoadr; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.jgsyoadr IS 'V2(100) 事業所名称';


--
-- Name: COLUMN m_skti.jgsyotel; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.jgsyotel IS 'V2(20) 事業所電話番号';


--
-- Name: COLUMN m_skti.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN m_skti.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_skti.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_skti.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_skti.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_skti.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_skti.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_skti.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: m_swptn; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.m_swptn (
    swptn_id integer NOT NULL,
    swptn_cd character varying(12),
    swptn_nm character varying(40),
    kmk1_cd character varying(12),
    kmk1_nm character varying(40),
    kmk2_cd character varying(12),
    kmk2_nm character varying(40),
    kmk3_cd character varying(12),
    kmk3_nm character varying(40),
    kmk4_cd character varying(12),
    kmk4_nm character varying(40),
    kmk5_cd character varying(12),
    kmk5_nm character varying(40),
    kmk6_cd character varying(12),
    kmk6_nm character varying(40),
    kmk7_cd character varying(12),
    kmk7_nm character varying(40),
    kmk8_cd character varying(12),
    kmk8_nm character varying(40),
    kmk9_cd character varying(12),
    kmk9_nm character varying(40),
    kmk10_cd character varying(12),
    kmk10_nm character varying(40),
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE m_swptn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.m_swptn IS 'マスタ：仕訳ﾊﾟﾀｰﾝ';


--
-- Name: COLUMN m_swptn.swptn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.swptn_id IS 'N(9) 仕訳ﾊﾟﾀｰﾝID';


--
-- Name: COLUMN m_swptn.swptn_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.swptn_cd IS 'V2(12) 仕訳ﾊﾟﾀｰﾝCD';


--
-- Name: COLUMN m_swptn.swptn_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.swptn_nm IS 'V2(40) 仕訳ﾊﾟﾀｰﾝ名称';


--
-- Name: COLUMN m_swptn.kmk1_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk1_cd IS 'V2(12) 科目1CD';


--
-- Name: COLUMN m_swptn.kmk1_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk1_nm IS 'V2(40) 科目1名称';


--
-- Name: COLUMN m_swptn.kmk2_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk2_cd IS 'V2(12) 科目2CD';


--
-- Name: COLUMN m_swptn.kmk2_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk2_nm IS 'V2(40) 科目2名称';


--
-- Name: COLUMN m_swptn.kmk3_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk3_cd IS 'V2(12) 科目3CD';


--
-- Name: COLUMN m_swptn.kmk3_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk3_nm IS 'V2(40) 科目3名称';


--
-- Name: COLUMN m_swptn.kmk4_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk4_cd IS 'V2(12) 科目4CD';


--
-- Name: COLUMN m_swptn.kmk4_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk4_nm IS 'V2(40) 科目4名称';


--
-- Name: COLUMN m_swptn.kmk5_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk5_cd IS 'V2(12) 科目5CD';


--
-- Name: COLUMN m_swptn.kmk5_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk5_nm IS 'V2(40) 科目5名称';


--
-- Name: COLUMN m_swptn.kmk6_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk6_cd IS 'V2(12) 科目6CD';


--
-- Name: COLUMN m_swptn.kmk6_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk6_nm IS 'V2(40) 科目6名称';


--
-- Name: COLUMN m_swptn.kmk7_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk7_cd IS 'V2(12) 科目7CD';


--
-- Name: COLUMN m_swptn.kmk7_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk7_nm IS 'V2(40) 科目7名称';


--
-- Name: COLUMN m_swptn.kmk8_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk8_cd IS 'V2(12) 科目8CD';


--
-- Name: COLUMN m_swptn.kmk8_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk8_nm IS 'V2(40) 科目8名称';


--
-- Name: COLUMN m_swptn.kmk9_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk9_cd IS 'V2(12) 科目9CD';


--
-- Name: COLUMN m_swptn.kmk9_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk9_nm IS 'V2(40) 科目9名称';


--
-- Name: COLUMN m_swptn.kmk10_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk10_cd IS 'V2(12) 科目10CD';


--
-- Name: COLUMN m_swptn.kmk10_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.kmk10_nm IS 'V2(40) 科目10名称';


--
-- Name: COLUMN m_swptn.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.biko IS 'V2(100) 備考';


--
-- Name: COLUMN m_swptn.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN m_swptn.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.create_dt IS 'D 作成日時';


--
-- Name: COLUMN m_swptn.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN m_swptn.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.update_dt IS 'D 更新日時';


--
-- Name: COLUMN m_swptn.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN m_swptn.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.m_swptn.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: sec_kngn; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.sec_kngn (
    kngn_id integer NOT NULL,
    kngn_cd character varying(12),
    kngn_nm character varying(40),
    access_kind integer NOT NULL,
    access_kind_b integer NOT NULL,
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL,
    admin boolean NOT NULL,
    master_update boolean NOT NULL,
    file_output boolean NOT NULL,
    print boolean NOT NULL,
    log_ref boolean NOT NULL,
    approval boolean NOT NULL
);


--
-- Name: TABLE sec_kngn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.sec_kngn IS 'セキュリティ：ｼｽﾃﾑ利用権限';


--
-- Name: COLUMN sec_kngn.kngn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.kngn_id IS 'N(9) 権限ID';


--
-- Name: COLUMN sec_kngn.kngn_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.kngn_cd IS 'V2(12) 権限CD';


--
-- Name: COLUMN sec_kngn.kngn_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.kngn_nm IS 'V2(40) 権限名称';


--
-- Name: COLUMN sec_kngn.access_kind; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.access_kind IS 'N(1) ﾃﾞｰﾀｱｸｾｽ種別(契約) 1：全ﾃﾞｰﾀ変更 2：全ﾃﾞｰﾀ参照 3：契約管理単位依存';


--
-- Name: COLUMN sec_kngn.access_kind_b; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.access_kind_b IS 'N(1) ﾃﾞｰﾀｱｸｾｽ種別(物件) ☆2008-07-30';


--
-- Name: COLUMN sec_kngn.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN sec_kngn.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN sec_kngn.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.create_dt IS 'D 作成日時';


--
-- Name: COLUMN sec_kngn.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN sec_kngn.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.update_dt IS 'D 更新日時';


--
-- Name: COLUMN sec_kngn.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN sec_kngn.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: COLUMN sec_kngn.admin; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.admin IS 'N(1) ｼｽﾃﾑ管理者権限 2009/07/23';


--
-- Name: COLUMN sec_kngn.master_update; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.master_update IS 'N(1) ﾏｽﾀ更新権限 2009/07/23';


--
-- Name: COLUMN sec_kngn.file_output; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.file_output IS 'N(1) ﾌｧｲﾙ出力権限 2009/07/23';


--
-- Name: COLUMN sec_kngn.print; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.print IS 'N(1) 印刷権限 2009/07/23';


--
-- Name: COLUMN sec_kngn.log_ref; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.log_ref IS 'N(1) ﾛｸﾞ参照権限 2009/07/23';


--
-- Name: COLUMN sec_kngn.approval; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn.approval IS 'N(1) 承認権限 2009/07/23';


--
-- Name: sec_kngn_bknri; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.sec_kngn_bknri (
    kngn_id integer NOT NULL,
    bknri_id integer NOT NULL,
    access_kind integer NOT NULL
);


--
-- Name: TABLE sec_kngn_bknri; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.sec_kngn_bknri IS 'セキュリティ：ｼｽﾃﾑ利用権限 物件管理単位ﾘｽﾄ ☆2008-07-30';


--
-- Name: COLUMN sec_kngn_bknri.kngn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn_bknri.kngn_id IS 'N(9) 権限ID';


--
-- Name: COLUMN sec_kngn_bknri.bknri_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn_bknri.bknri_id IS 'N(9) 物件管理単位ID';


--
-- Name: COLUMN sec_kngn_bknri.access_kind; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn_bknri.access_kind IS 'N(1) ﾃﾞｰﾀｱｸｾｽ種別 1：変更 2：参照';


--
-- Name: sec_kngn_kknri; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.sec_kngn_kknri (
    kngn_id integer NOT NULL,
    kknri_id integer NOT NULL,
    access_kind integer NOT NULL
);


--
-- Name: TABLE sec_kngn_kknri; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.sec_kngn_kknri IS 'セキュリティ：ｼｽﾃﾑ利用権限 契約管理単位ﾘｽﾄ';


--
-- Name: COLUMN sec_kngn_kknri.kngn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn_kknri.kngn_id IS 'N(9) 権限ID';


--
-- Name: COLUMN sec_kngn_kknri.kknri_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn_kknri.kknri_id IS 'N(9) 契約管理単位ID';


--
-- Name: COLUMN sec_kngn_kknri.access_kind; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_kngn_kknri.access_kind IS 'N(1) ﾃﾞｰﾀｱｸｾｽ種別 1：変更 2：参照';


--
-- Name: sec_user; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.sec_user (
    user_id integer NOT NULL,
    user_cd character varying(12),
    user_nm character varying(40),
    pwd character varying(255),
    kngn_id integer NOT NULL,
    biko character varying(100),
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL,
    login_attempts integer,
    pwd_life_time integer,
    pwd_grace_time integer,
    pwd_min integer,
    pwd_moji_chk boolean NOT NULL,
    pwd_alph_chk boolean NOT NULL,
    pwd_num_chk boolean NOT NULL,
    pwd_symbol_chk boolean NOT NULL,
    pwd_upd_dt timestamp without time zone,
    d_first_login timestamp without time zone,
    err_ct integer,
    last_err_dt timestamp without time zone
);


--
-- Name: TABLE sec_user; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.sec_user IS 'セキュリティ：ｼｽﾃﾑ利用者';


--
-- Name: COLUMN sec_user.user_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.user_id IS 'N(9) 利用者ID';


--
-- Name: COLUMN sec_user.user_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.user_cd IS 'V2(12) 利用者CD';


--
-- Name: COLUMN sec_user.user_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.user_nm IS 'V2(40) 利用者名称';


--
-- Name: COLUMN sec_user.pwd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.pwd IS 'V2(255) ﾊﾟｽﾜｰﾄﾞ';


--
-- Name: COLUMN sec_user.kngn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.kngn_id IS 'N(9) 権限ID';


--
-- Name: COLUMN sec_user.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.biko IS 'V2(100) 備考 ★2005/04/25 V(30)→V(100)';


--
-- Name: COLUMN sec_user.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN sec_user.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.create_dt IS 'D 作成日時';


--
-- Name: COLUMN sec_user.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN sec_user.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.update_dt IS 'D 更新日時';


--
-- Name: COLUMN sec_user.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN sec_user.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: COLUMN sec_user.login_attempts; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.login_attempts IS 'N(2) 有効ﾛｸﾞｲﾝ回数 2009/07/31';


--
-- Name: COLUMN sec_user.pwd_life_time; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.pwd_life_time IS 'N(3) ﾊﾟｽﾜｰﾄﾞの有効期限 2009/07/31';


--
-- Name: COLUMN sec_user.pwd_grace_time; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.pwd_grace_time IS 'N(3) 変更までの猶予期間 2009/07/31';


--
-- Name: COLUMN sec_user.pwd_min; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.pwd_min IS 'N(2) 最小桁(文字)数 2009/07/31';


--
-- Name: COLUMN sec_user.pwd_moji_chk; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.pwd_moji_chk IS 'N(1) 文字種制限 2009/07/31';


--
-- Name: COLUMN sec_user.pwd_alph_chk; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.pwd_alph_chk IS 'N(1) 英字 2009/07/31';


--
-- Name: COLUMN sec_user.pwd_num_chk; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.pwd_num_chk IS 'N(1) 数字 2009/07/31';


--
-- Name: COLUMN sec_user.pwd_symbol_chk; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.pwd_symbol_chk IS 'N(1) 記号 2009/07/31';


--
-- Name: COLUMN sec_user.pwd_upd_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.pwd_upd_dt IS 'D パスワード更新日時 2009/08/06';


--
-- Name: COLUMN sec_user.d_first_login; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.d_first_login IS 'D 期限切れ後最初のログイン日 2009/08/06';


--
-- Name: COLUMN sec_user.err_ct; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.err_ct IS 'N(3) エラー回数 2009/08/28';


--
-- Name: COLUMN sec_user.last_err_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.sec_user.last_err_dt IS 'D 最終エラー日時 2009/08/28';


--
-- Name: t_accounting_unit; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_accounting_unit (
    act_unit_id integer NOT NULL,
    kykh_id double precision NOT NULL,
    lease_type character varying(20) DEFAULT 'FINANCE'::character varying NOT NULL,
    on_balance_flag boolean DEFAULT true,
    impairment_flag boolean DEFAULT false,
    currency_code character varying(3) DEFAULT 'JPY'::character varying,
    discount_rate numeric(5,4) NOT NULL,
    rou_asset_value numeric(18,2) NOT NULL,
    lease_liability_value numeric(18,2) NOT NULL,
    residual_value numeric(18,2) DEFAULT 0,
    start_date date,
    end_date date,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    updated_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    created_by character varying(50),
    termination_date date,
    termination_penalty numeric(18,0) DEFAULT 0,
    status character varying(20) DEFAULT 'ACTIVE'::character varying,
    is_determination_fixed boolean DEFAULT false
);


--
-- Name: TABLE t_accounting_unit; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_accounting_unit IS '拡張: 会計単位ヘッダ（新リース会計用）';


--
-- Name: COLUMN t_accounting_unit.termination_date; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_accounting_unit.termination_date IS '中途解約日';


--
-- Name: COLUMN t_accounting_unit.termination_penalty; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_accounting_unit.termination_penalty IS '中途解約違約金 (リース解約損)';


--
-- Name: COLUMN t_accounting_unit.status; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_accounting_unit.status IS '契約ステータス (ACTIVE/TERMINATED)';


--
-- Name: COLUMN t_accounting_unit.is_determination_fixed; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_accounting_unit.is_determination_fixed IS '判定結果固定フラグ: TRUEの場合、自動再判定による上書きを防止(照井様指摘対応)';


--
-- Name: t_accounting_unit_act_unit_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.t_accounting_unit_act_unit_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- Name: t_accounting_unit_act_unit_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.t_accounting_unit_act_unit_id_seq OWNED BY public.t_accounting_unit.act_unit_id;


--
-- Name: t_amortization_schedule; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_amortization_schedule (
    schedule_id integer NOT NULL,
    act_unit_id integer NOT NULL,
    payment_count integer NOT NULL,
    payment_date date NOT NULL,
    payment_amount numeric(18,2) NOT NULL,
    interest_expense numeric(18,2) NOT NULL,
    principal_repayment numeric(18,2) NOT NULL,
    liability_balance numeric(18,2) NOT NULL,
    rou_depreciation numeric(18,2) DEFAULT 0,
    rou_book_value numeric(18,2) DEFAULT 0
);


--
-- Name: TABLE t_amortization_schedule; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_amortization_schedule IS '拡張: 利息法償却予定表';


--
-- Name: t_amortization_schedule_schedule_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.t_amortization_schedule_schedule_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- Name: t_amortization_schedule_schedule_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.t_amortization_schedule_schedule_id_seq OWNED BY public.t_amortization_schedule.schedule_id;


--
-- Name: t_audit_log; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_audit_log (
    log_id bigint NOT NULL,
    table_name character varying(50),
    record_id character varying(50),
    operation_type character varying(10),
    operated_by character varying(50),
    operated_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    old_value jsonb,
    new_value jsonb
);


--
-- Name: TABLE t_audit_log; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_audit_log IS '拡張: 操作監査ログ';


--
-- Name: t_audit_log_log_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.t_audit_log_log_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- Name: t_audit_log_log_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.t_audit_log_log_id_seq OWNED BY public.t_audit_log.log_id;


--
-- Name: t_db_version; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_db_version (
    db_version character varying(30) NOT NULL
);


--
-- Name: TABLE t_db_version; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_db_version IS 'その他のデータ：DBﾊﾞｰｼﾞｮﾝ管理ﾃｰﾌﾞﾙ';


--
-- Name: COLUMN t_db_version.db_version; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_db_version.db_version IS 'V2(30) DBﾊﾞｰｼﾞｮﾝ';


--
-- Name: t_holiday; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_holiday (
    id integer NOT NULL,
    h_date timestamp without time zone NOT NULL,
    biko character varying(255)
);


--
-- Name: TABLE t_holiday; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_holiday IS 'その他のデータ：祝日ﾃｰﾌﾞﾙ ◆2008-11-03';


--
-- Name: COLUMN t_holiday.id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_holiday.id IS 'N(3) ID';


--
-- Name: COLUMN t_holiday.h_date; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_holiday.h_date IS 'D 日付';


--
-- Name: COLUMN t_holiday.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_holiday.biko IS 'V2(255) 備考';


--
-- Name: t_journal_setting; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_journal_setting (
    setting_key character varying(50) NOT NULL,
    setting_value character varying(100) NOT NULL,
    description character varying(200)
);


--
-- Name: TABLE t_journal_setting; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_journal_setting IS '拡張: 仕訳生成用設定マスタ';


--
-- Name: t_kari_ritu; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_kari_ritu (
    kari_ritu_id integer NOT NULL,
    start_dt timestamp without time zone NOT NULL,
    kari_ritu double precision NOT NULL,
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE t_kari_ritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_kari_ritu IS 'その他のデータ：追加借入利子率設定ﾃｰﾌﾞﾙ';


--
-- Name: COLUMN t_kari_ritu.kari_ritu_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kari_ritu.kari_ritu_id IS 'N(9) 行ID';


--
-- Name: COLUMN t_kari_ritu.start_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kari_ritu.start_dt IS 'D 適用開始日';


--
-- Name: COLUMN t_kari_ritu.kari_ritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kari_ritu.kari_ritu IS 'N(11,8) 追加借入利子率';


--
-- Name: COLUMN t_kari_ritu.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kari_ritu.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN t_kari_ritu.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kari_ritu.create_dt IS 'D 作成日時';


--
-- Name: COLUMN t_kari_ritu.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kari_ritu.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN t_kari_ritu.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kari_ritu.update_dt IS 'D 更新日時';


--
-- Name: COLUMN t_kari_ritu.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kari_ritu.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN t_kari_ritu.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kari_ritu.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: t_kykbnj_seq; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_kykbnj_seq (
    key character varying(30) NOT NULL,
    nextval double precision NOT NULL,
    biko character varying(50)
);


--
-- Name: TABLE t_kykbnj_seq; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_kykbnj_seq IS 'その他のデータ：自社契約番号採番ﾃｰﾌﾞﾙ 2008/10/21';


--
-- Name: COLUMN t_kykbnj_seq.key; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kykbnj_seq.key IS 'V2(30) キー項目（固定部分）';


--
-- Name: COLUMN t_kykbnj_seq.nextval; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kykbnj_seq.nextval IS 'N(15) 次回採番値';


--
-- Name: COLUMN t_kykbnj_seq.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_kykbnj_seq.biko IS 'V2(50) 備考';


--
-- Name: t_mstk; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_mstk (
    mstk_id integer NOT NULL,
    mst_name character varying(50),
    update_dt timestamp without time zone,
    kind integer,
    local_name character varying(50),
    pkeys character varying(255),
    compfld character varying(30),
    biko character varying(30)
);


--
-- Name: TABLE t_mstk; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_mstk IS 'その他のデータ：ﾏｽﾀ管理ﾃｰﾌﾞﾙ';


--
-- Name: COLUMN t_mstk.mstk_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_mstk.mstk_id IS 'N(9) 行ID';


--
-- Name: COLUMN t_mstk.mst_name; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_mstk.mst_name IS 'V2(50) ﾏｽﾀ名称';


--
-- Name: COLUMN t_mstk.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_mstk.update_dt IS 'D 最終更新日';


--
-- Name: COLUMN t_mstk.kind; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_mstk.kind IS 'N(3) 処理種別 0:変更時ﾀﾞｳﾝﾛｰﾄﾞ 1:強制ﾀﾞｳﾝﾛｰﾄﾞ';


--
-- Name: COLUMN t_mstk.local_name; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_mstk.local_name IS 'V2(50) ﾛｰｶﾙ名称';


--
-- Name: COLUMN t_mstk.pkeys; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_mstk.pkeys IS 'V2(255) 主ｷｰﾘｽﾄ';


--
-- Name: COLUMN t_mstk.compfld; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_mstk.compfld IS 'V2(30) 更新有無比較用項目名';


--
-- Name: COLUMN t_mstk.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_mstk.biko IS 'V2(30) 備考';


--
-- Name: t_opt; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_opt (
    slog boolean NOT NULL,
    ulog boolean NOT NULL,
    recopt boolean NOT NULL,
    cnvlog boolean NOT NULL,
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL
);


--
-- Name: TABLE t_opt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_opt IS '内部統制ユーザオプション 2009/07/24';


--
-- Name: COLUMN t_opt.slog; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_opt.slog IS '操作ログ出力';


--
-- Name: COLUMN t_opt.ulog; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_opt.ulog IS '更新ログ出力';


--
-- Name: COLUMN t_opt.recopt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_opt.recopt IS 'レコード内容を更新ログに出力';


--
-- Name: COLUMN t_opt.cnvlog; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_opt.cnvlog IS 'データコンバート時、元ログも読み込む';


--
-- Name: COLUMN t_opt.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_opt.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN t_opt.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_opt.create_dt IS 'D 作成日時';


--
-- Name: COLUMN t_opt.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_opt.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN t_opt.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_opt.update_dt IS 'D 更新日時';


--
-- Name: COLUMN t_opt.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_opt.update_cnt IS 'N(9) 更新回数';


--
-- Name: t_req; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_req (
    req_id integer NOT NULL,
    req_nm character varying(40),
    req_dt timestamp without time zone,
    biko character varying(30)
);


--
-- Name: TABLE t_req; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_req IS 'その他のデータ：処理要求ﾃｰﾌﾞﾙ';


--
-- Name: COLUMN t_req.req_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_req.req_id IS 'N(9) 処理ID';


--
-- Name: COLUMN t_req.req_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_req.req_nm IS 'V2(40) 処理名称';


--
-- Name: COLUMN t_req.req_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_req.req_dt IS 'D 要求日時';


--
-- Name: COLUMN t_req.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_req.biko IS 'V2(30) 備考';


--
-- Name: t_seq; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_seq (
    field_nm character varying(30) NOT NULL,
    table_nm character varying(30) NOT NULL,
    nextval double precision NOT NULL
);


--
-- Name: TABLE t_seq; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_seq IS 'その他のデータ：採番ﾃｰﾌﾞﾙ';


--
-- Name: COLUMN t_seq.field_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_seq.field_nm IS 'V2(30) 項目名';


--
-- Name: COLUMN t_seq.table_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_seq.table_nm IS 'V2(30) 表名';


--
-- Name: COLUMN t_seq.nextval; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_seq.nextval IS 'N(15) 次回採番値';


--
-- Name: t_settei; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_settei (
    settei_id integer NOT NULL,
    settei_nm character varying(30) NOT NULL,
    settei_nm_jpn character varying(50) NOT NULL,
    settei_type integer NOT NULL,
    val_text character varying(100),
    val_number double precision,
    val_datetime timestamp without time zone,
    biko character varying(100)
);


--
-- Name: TABLE t_settei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_settei IS 'その他のデータ：共有初期設定ﾃｰﾌﾞﾙ★2005/02/14';


--
-- Name: COLUMN t_settei.settei_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_settei.settei_id IS 'N(9) 設定項目ID';


--
-- Name: COLUMN t_settei.settei_nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_settei.settei_nm IS 'V2(30) 設定項目名';


--
-- Name: COLUMN t_settei.settei_nm_jpn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_settei.settei_nm_jpn IS 'V2(50) 設定項目名(日本語)';


--
-- Name: COLUMN t_settei.settei_type; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_settei.settei_type IS 'N(2) ﾀｲﾌﾟ';


--
-- Name: COLUMN t_settei.val_text; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_settei.val_text IS 'V2(100) 設定値(文字列)';


--
-- Name: COLUMN t_settei.val_number; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_settei.val_number IS 'N(15,8) 設定値(数値)';


--
-- Name: COLUMN t_settei.val_datetime; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_settei.val_datetime IS 'D 設定値(日付時刻)';


--
-- Name: COLUMN t_settei.biko; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_settei.biko IS 'V2(100) 備考';


--
-- Name: t_shwak_d; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_shwak_d (
    shwak_id integer NOT NULL,
    process_date date NOT NULL,
    kykh_id double precision NOT NULL,
    act_unit_id integer,
    debit_acct_cd character varying(20),
    debit_acct_nm character varying(100),
    debit_tax_cd character varying(10),
    debit_amount numeric(18,2) DEFAULT 0,
    credit_acct_cd character varying(20),
    credit_acct_nm character varying(100),
    credit_tax_cd character varying(10),
    credit_amount numeric(18,2) DEFAULT 0,
    description character varying(255),
    entry_type character varying(20) DEFAULT 'NORMAL'::character varying,
    is_exported boolean DEFAULT false,
    created_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    updated_at timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);


--
-- Name: TABLE t_shwak_d; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_shwak_d IS '仕訳生成ワーク: 月次処理および遡及修正(Catch-up)仕訳の一時保管場所';


--
-- Name: COLUMN t_shwak_d.entry_type; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_shwak_d.entry_type IS '仕訳区分: NORMAL=通常仕訳, CATCHUP=遡及修正仕訳(過年度修正損益など)';


--
-- Name: t_shwak_d_shwak_id_seq; Type: SEQUENCE; Schema: public; Owner: -
--

CREATE SEQUENCE public.t_shwak_d_shwak_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


--
-- Name: t_shwak_d_shwak_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: -
--

ALTER SEQUENCE public.t_shwak_d_shwak_id_seq OWNED BY public.t_shwak_d.shwak_id;


--
-- Name: t_szei_kmk; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_szei_kmk (
    zritu double precision,
    kind integer,
    hreikbn integer,
    leakbn_id integer,
    kjkbn_id integer,
    szei_kjkbn_id integer,
    ptn_cd1 character varying(12),
    ptn_nm1 character varying(40),
    ptn_cd2 character varying(12),
    ptn_nm2 character varying(40),
    ptn_cd3 character varying(12),
    ptn_nm3 character varying(40),
    ptn_cd4 character varying(12),
    ptn_nm4 character varying(40),
    zkmk_cd1 character varying(20),
    zhkmk_nm1 character varying(40),
    zkmk_cd2 character varying(20),
    zhkmk_nm2 character varying(40),
    zkmk_cd3 character varying(20),
    zhkmk_nm3 character varying(40)
);


--
-- Name: TABLE t_szei_kmk; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_szei_kmk IS '消費税計上科目決定テーブル 2009/01/21';


--
-- Name: COLUMN t_szei_kmk.zritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.zritu IS 'N(7,6) 消費税率';


--
-- Name: COLUMN t_szei_kmk.kind; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.kind IS 'N(1) 種別';


--
-- Name: COLUMN t_szei_kmk.hreikbn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.hreikbn IS 'N(1) 法令区分';


--
-- Name: COLUMN t_szei_kmk.leakbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.leakbn_id IS 'N(2) ﾘｰｽ区分ID';


--
-- Name: COLUMN t_szei_kmk.kjkbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.kjkbn_id IS 'N(1) 計上区分ID';


--
-- Name: COLUMN t_szei_kmk.szei_kjkbn_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.szei_kjkbn_id IS 'N(1) 消費税計上区分ID';


--
-- Name: COLUMN t_szei_kmk.ptn_cd1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.ptn_cd1 IS 'V2(12) パターンコード１　資産科目CD等';


--
-- Name: COLUMN t_szei_kmk.ptn_nm1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.ptn_nm1 IS 'V2(40) パターン１';


--
-- Name: COLUMN t_szei_kmk.ptn_cd2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.ptn_cd2 IS 'V2(12) パターンコード２　原価区分CD等';


--
-- Name: COLUMN t_szei_kmk.ptn_nm2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.ptn_nm2 IS 'V2(40) パターン２';


--
-- Name: COLUMN t_szei_kmk.ptn_cd3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.ptn_cd3 IS 'V2(12) パターンコード３　契約管理単位CD等';


--
-- Name: COLUMN t_szei_kmk.ptn_nm3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.ptn_nm3 IS 'V2(40) パターン３';


--
-- Name: COLUMN t_szei_kmk.ptn_cd4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.ptn_cd4 IS 'V2(12) パターンコード４　契約管理単位ﾏｽﾀ.費目決定要素CD';


--
-- Name: COLUMN t_szei_kmk.ptn_nm4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.ptn_nm4 IS 'V2(40) パターン４';


--
-- Name: COLUMN t_szei_kmk.zkmk_cd1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.zkmk_cd1 IS 'V2(20) 消費税計上科目CD1';


--
-- Name: COLUMN t_szei_kmk.zhkmk_nm1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.zhkmk_nm1 IS 'V2(40) 消費税計上科目1';


--
-- Name: COLUMN t_szei_kmk.zkmk_cd2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.zkmk_cd2 IS 'V2(20) 消費税計上科目CD2';


--
-- Name: COLUMN t_szei_kmk.zhkmk_nm2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.zhkmk_nm2 IS 'V2(40) 消費税計上科目2';


--
-- Name: COLUMN t_szei_kmk.zkmk_cd3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.zkmk_cd3 IS 'V2(20) 消費税計上科目CD3';


--
-- Name: COLUMN t_szei_kmk.zhkmk_nm3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_szei_kmk.zhkmk_nm3 IS 'V2(40) 消費税計上科目3';


--
-- Name: t_zei_kaisei; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.t_zei_kaisei (
    zei_kaisei_id integer NOT NULL,
    teki_dt_from timestamp without time zone,
    teki_dt_to timestamp without time zone,
    zritu double precision,
    kkyak_dt_from timestamp without time zone,
    kkyak_dt_to timestamp without time zone,
    create_id integer NOT NULL,
    create_dt timestamp without time zone,
    update_id integer NOT NULL,
    update_dt timestamp without time zone,
    update_cnt integer NOT NULL,
    history_f boolean NOT NULL
);


--
-- Name: TABLE t_zei_kaisei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.t_zei_kaisei IS 'その他のデータ：消費税率設定ﾃｰﾌﾞﾙ';


--
-- Name: COLUMN t_zei_kaisei.zei_kaisei_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.zei_kaisei_id IS 'N(9) 行ID';


--
-- Name: COLUMN t_zei_kaisei.teki_dt_from; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.teki_dt_from IS 'D 適用日・自';


--
-- Name: COLUMN t_zei_kaisei.teki_dt_to; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.teki_dt_to IS 'D 適用日・至';


--
-- Name: COLUMN t_zei_kaisei.zritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.zritu IS 'N(7,6) 消費税率';


--
-- Name: COLUMN t_zei_kaisei.kkyak_dt_from; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.kkyak_dt_from IS 'D 経過措置適用契約日・自';


--
-- Name: COLUMN t_zei_kaisei.kkyak_dt_to; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.kkyak_dt_to IS 'D 経過措置適用契約日・至';


--
-- Name: COLUMN t_zei_kaisei.create_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.create_id IS 'N(9) 作成者ID';


--
-- Name: COLUMN t_zei_kaisei.create_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.create_dt IS 'D 作成日時';


--
-- Name: COLUMN t_zei_kaisei.update_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.update_id IS 'N(9) 更新者ID';


--
-- Name: COLUMN t_zei_kaisei.update_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.update_dt IS 'D 更新日時';


--
-- Name: COLUMN t_zei_kaisei.update_cnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.update_cnt IS 'N(9) 更新回数';


--
-- Name: COLUMN t_zei_kaisei.history_f; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.t_zei_kaisei.history_f IS 'N(1) 履歴ﾌﾗｸﾞ';


--
-- Name: tc_hrel; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.tc_hrel (
    ptn_cd1 character varying(12),
    ptn_nm1 character varying(40),
    ptn_cd2 character varying(12),
    ptn_nm2 character varying(40),
    ptn_cd3 character varying(12),
    ptn_nm3 character varying(40),
    ptn_cd4 character varying(12),
    ptn_nm4 character varying(40),
    kmk_cd1 character varying(20),
    kmk_nm1 character varying(80),
    kmk_cd2 character varying(20),
    kmk_nm2 character varying(80),
    kmk_cd3 character varying(20),
    kmk_nm3 character varying(80),
    kmk_cd4 character varying(20),
    kmk_nm4 character varying(80),
    kmk_cd5 character varying(20),
    kmk_nm5 character varying(80),
    kmk_cd6 character varying(20),
    kmk_nm6 character varying(80),
    kmk_cd7 character varying(20),
    kmk_nm7 character varying(80),
    kmk_cd8 character varying(20),
    kmk_nm8 character varying(80),
    kmk_cd9 character varying(20),
    kmk_nm9 character varying(80),
    kmk_cd10 character varying(20),
    kmk_nm10 character varying(80),
    kmk_cd11 character varying(20),
    kmk_nm11 character varying(80),
    kmk_cd12 character varying(20),
    kmk_nm12 character varying(80),
    kmk_cd13 character varying(20),
    kmk_nm13 character varying(80),
    kmk_cd14 character varying(20),
    kmk_nm14 character varying(80),
    kmk_cd15 character varying(20),
    kmk_nm15 character varying(80)
);


--
-- Name: TABLE tc_hrel; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.tc_hrel IS 'その他のデータ：費目関連ﾃｰﾌﾞﾙ';


--
-- Name: COLUMN tc_hrel.ptn_cd1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.ptn_cd1 IS 'V2(12) パターンコード１　資産科目ﾏｽﾀ.費目決定要素CD';


--
-- Name: COLUMN tc_hrel.ptn_nm1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.ptn_nm1 IS 'V2(40) パターン１';


--
-- Name: COLUMN tc_hrel.ptn_cd2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.ptn_cd2 IS 'V2(12) パターンコード２　原価区分ﾏｽﾀ.原価区分CD';


--
-- Name: COLUMN tc_hrel.ptn_nm2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.ptn_nm2 IS 'V2(40) パターン２';


--
-- Name: COLUMN tc_hrel.ptn_cd3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.ptn_cd3 IS 'V2(12) パターンコード３　費用科目ﾏｽﾀ.費目決定要素CD';


--
-- Name: COLUMN tc_hrel.ptn_nm3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.ptn_nm3 IS 'V2(40) パターン３';


--
-- Name: COLUMN tc_hrel.ptn_cd4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.ptn_cd4 IS 'V2(12) パターンコード４　契約管理単位ﾏｽﾀ.費目決定要素CD';


--
-- Name: COLUMN tc_hrel.ptn_nm4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.ptn_nm4 IS 'V2(40) パターン４';


--
-- Name: COLUMN tc_hrel.kmk_cd1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd1 IS 'V2(20) 科目CD１';


--
-- Name: COLUMN tc_hrel.kmk_nm1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm1 IS 'V2(80) 科目名１';


--
-- Name: COLUMN tc_hrel.kmk_cd2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd2 IS 'V2(20) 科目CD２';


--
-- Name: COLUMN tc_hrel.kmk_nm2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm2 IS 'V2(80) 科目名２';


--
-- Name: COLUMN tc_hrel.kmk_cd3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd3 IS 'V2(20) 科目CD３';


--
-- Name: COLUMN tc_hrel.kmk_nm3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm3 IS 'V2(80) 科目名３';


--
-- Name: COLUMN tc_hrel.kmk_cd4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd4 IS 'V2(20) 科目CD４';


--
-- Name: COLUMN tc_hrel.kmk_nm4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm4 IS 'V2(80) 科目名４';


--
-- Name: COLUMN tc_hrel.kmk_cd5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd5 IS 'V2(20) 科目CD５';


--
-- Name: COLUMN tc_hrel.kmk_nm5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm5 IS 'V2(80) 科目名５';


--
-- Name: COLUMN tc_hrel.kmk_cd6; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd6 IS 'V2(20) 科目CD６';


--
-- Name: COLUMN tc_hrel.kmk_nm6; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm6 IS 'V2(80) 科目名６';


--
-- Name: COLUMN tc_hrel.kmk_cd7; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd7 IS 'V2(20) 科目CD７';


--
-- Name: COLUMN tc_hrel.kmk_nm7; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm7 IS 'V2(80) 科目名７';


--
-- Name: COLUMN tc_hrel.kmk_cd8; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd8 IS 'V2(20) 科目CD８';


--
-- Name: COLUMN tc_hrel.kmk_nm8; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm8 IS 'V2(80) 科目名８';


--
-- Name: COLUMN tc_hrel.kmk_cd9; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd9 IS 'V2(20) 科目CD９';


--
-- Name: COLUMN tc_hrel.kmk_nm9; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm9 IS 'V2(80) 科目名９';


--
-- Name: COLUMN tc_hrel.kmk_cd10; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd10 IS 'V2(20) 科目CD１０';


--
-- Name: COLUMN tc_hrel.kmk_nm10; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm10 IS 'V2(80) 科目名１０';


--
-- Name: COLUMN tc_hrel.kmk_cd11; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd11 IS 'V2(20) 科目CD１１';


--
-- Name: COLUMN tc_hrel.kmk_nm11; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm11 IS 'V2(80) 科目名１１';


--
-- Name: COLUMN tc_hrel.kmk_cd12; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd12 IS 'V2(20) 科目CD１２';


--
-- Name: COLUMN tc_hrel.kmk_nm12; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm12 IS 'V2(80) 科目名１２';


--
-- Name: COLUMN tc_hrel.kmk_cd13; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd13 IS 'V2(20) 科目CD１３';


--
-- Name: COLUMN tc_hrel.kmk_nm13; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm13 IS 'V2(80) 科目名１３';


--
-- Name: COLUMN tc_hrel.kmk_cd14; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd14 IS 'V2(20) 科目CD１４';


--
-- Name: COLUMN tc_hrel.kmk_nm14; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm14 IS 'V2(80) 科目名１４';


--
-- Name: COLUMN tc_hrel.kmk_cd15; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_cd15 IS 'V2(20) 科目CD１５';


--
-- Name: COLUMN tc_hrel.kmk_nm15; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_hrel.kmk_nm15 IS 'V2(80) 科目名１５';


--
-- Name: tc_rec_shri; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.tc_rec_shri (
    ktmg integer,
    shri_tuki timestamp without time zone NOT NULL,
    shri_dt timestamp without time zone NOT NULL,
    shri_r_dt timestamp without time zone,
    xxxx1id integer,
    xxxx1cd character varying(12),
    xxxx1nm character varying(80),
    xxxx2id integer,
    xxxx2cd character varying(12),
    xxxx2nm character varying(80),
    xxxx3id integer,
    xxxx3cd character varying(12),
    xxxx3nm character varying(80),
    xxxx4id integer,
    xxxx4cd character varying(12),
    xxxx4nm character varying(80),
    xxxx5id integer,
    xxxx5cd character varying(12),
    xxxx5nm character varying(80),
    siwakekbn integer,
    sum_zkomi_toki double precision,
    sum_znuki_toki double precision,
    sum_zei_toki double precision,
    cnt_reccnt integer,
    kihyo_dt timestamp without time zone,
    output_dt timestamp without time zone,
    sum_zkomi_toki_hiyo double precision,
    sum_zkomi_toki_sisan double precision,
    "計上日" timestamp without time zone
);


--
-- Name: TABLE tc_rec_shri; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.tc_rec_shri IS 'その他のデータ：仕訳出力指示記録';


--
-- Name: COLUMN tc_rec_shri.ktmg; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.ktmg IS 'N(2) 計上ﾀｲﾐﾝｸﾞ  1:請求ﾍﾞｰｽ 2:約定支払日ﾍﾞｰｽ 3:実際支払日ﾍﾞｰｽ★v143';


--
-- Name: COLUMN tc_rec_shri.shri_tuki; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.shri_tuki IS 'D 支払月　※当月支払リース料出力の集計条件';


--
-- Name: COLUMN tc_rec_shri.shri_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.shri_dt IS 'D 支払予定日';


--
-- Name: COLUMN tc_rec_shri.shri_r_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.shri_r_dt IS 'D 実支払日';


--
-- Name: COLUMN tc_rec_shri.xxxx1id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx1id IS 'N(9) ＩＤ１';


--
-- Name: COLUMN tc_rec_shri.xxxx1cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx1cd IS 'V2(12) コード１';


--
-- Name: COLUMN tc_rec_shri.xxxx1nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx1nm IS 'V2(80) 名称１';


--
-- Name: COLUMN tc_rec_shri.xxxx2id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx2id IS 'N(9) ＩＤ２';


--
-- Name: COLUMN tc_rec_shri.xxxx2cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx2cd IS 'V2(12) コード２';


--
-- Name: COLUMN tc_rec_shri.xxxx2nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx2nm IS 'V2(80) 名称２';


--
-- Name: COLUMN tc_rec_shri.xxxx3id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx3id IS 'N(9) ＩＤ３';


--
-- Name: COLUMN tc_rec_shri.xxxx3cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx3cd IS 'V2(12) コード３';


--
-- Name: COLUMN tc_rec_shri.xxxx3nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx3nm IS 'V2(80) 名称３';


--
-- Name: COLUMN tc_rec_shri.xxxx4id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx4id IS 'N(9) ＩＤ４';


--
-- Name: COLUMN tc_rec_shri.xxxx4cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx4cd IS 'V2(12) コード４';


--
-- Name: COLUMN tc_rec_shri.xxxx4nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx4nm IS 'V2(80) 名称４';


--
-- Name: COLUMN tc_rec_shri.xxxx5id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx5id IS 'N(9) ＩＤ５';


--
-- Name: COLUMN tc_rec_shri.xxxx5cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx5cd IS 'V2(12) コード５';


--
-- Name: COLUMN tc_rec_shri.xxxx5nm; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.xxxx5nm IS 'V2(80) 名称５';


--
-- Name: COLUMN tc_rec_shri.siwakekbn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.siwakekbn IS 'N(2) 仕訳区分　1:費用／現預金　2:費用／未払金　3:未払金／現預金';


--
-- Name: COLUMN tc_rec_shri.sum_zkomi_toki; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.sum_zkomi_toki IS 'N(15) 税込額';


--
-- Name: COLUMN tc_rec_shri.sum_znuki_toki; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.sum_znuki_toki IS 'N(15) 税抜き額';


--
-- Name: COLUMN tc_rec_shri.sum_zei_toki; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.sum_zei_toki IS 'N(15) 消費税額';


--
-- Name: COLUMN tc_rec_shri.cnt_reccnt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.cnt_reccnt IS 'N(9) 処理件数';


--
-- Name: COLUMN tc_rec_shri.kihyo_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.kihyo_dt IS 'D 起票日';


--
-- Name: COLUMN tc_rec_shri.output_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.output_dt IS 'D 出力日';


--
-- Name: COLUMN tc_rec_shri.sum_zkomi_toki_hiyo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.sum_zkomi_toki_hiyo IS 'N(15) 税込額';


--
-- Name: COLUMN tc_rec_shri.sum_zkomi_toki_sisan; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri.sum_zkomi_toki_sisan IS 'N(15) 税込額';


--
-- Name: COLUMN tc_rec_shri."計上日"; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_rec_shri."計上日" IS 'D 計上日';


--
-- Name: tc_reg_report; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.tc_reg_report (
    line_id integer NOT NULL,
    address1 character varying(40),
    address2 character varying(40),
    address3 character varying(40),
    address4 character varying(40),
    address5 character varying(40),
    attachment1 character varying(40),
    attachment2 character varying(40),
    attachment3 character varying(40),
    attachment4 character varying(40),
    attachment5 character varying(40),
    attachment6 character varying(40),
    attachment7 character varying(40),
    attachment8 character varying(40),
    attachment9 character varying(40),
    attachment10 character varying(40),
    attachment11 character varying(40),
    attachment12 character varying(40),
    attachment13 character varying(40),
    attachment14 character varying(40),
    attachment15 character varying(40),
    attachment16 character varying(40),
    attachment17 character varying(40),
    attachment18 character varying(40),
    attachment19 character varying(40),
    attachment20 character varying(40)
);


--
-- Name: TABLE tc_reg_report; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.tc_reg_report IS 'その他のデータ：登録届指示ﾃｰﾌﾞﾙ◆2008-10-17';


--
-- Name: COLUMN tc_reg_report.line_id; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.line_id IS 'N(1) 行ID';


--
-- Name: COLUMN tc_reg_report.address1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.address1 IS 'V2(40) 届先１';


--
-- Name: COLUMN tc_reg_report.address2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.address2 IS 'V2(40) 届先２';


--
-- Name: COLUMN tc_reg_report.address3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.address3 IS 'V2(40) 届先３ ◆予備';


--
-- Name: COLUMN tc_reg_report.address4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.address4 IS 'V2(40) 届先４ ◆予備';


--
-- Name: COLUMN tc_reg_report.address5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.address5 IS 'V2(40) 届先５ ◆予備';


--
-- Name: COLUMN tc_reg_report.attachment1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment1 IS 'V2(40) 添付書類１';


--
-- Name: COLUMN tc_reg_report.attachment2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment2 IS 'V2(40) 添付書類２';


--
-- Name: COLUMN tc_reg_report.attachment3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment3 IS 'V2(40) 添付書類３';


--
-- Name: COLUMN tc_reg_report.attachment4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment4 IS 'V2(40) 添付書類４';


--
-- Name: COLUMN tc_reg_report.attachment5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment5 IS 'V2(40) 添付書類５';


--
-- Name: COLUMN tc_reg_report.attachment6; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment6 IS 'V2(40) 添付書類６';


--
-- Name: COLUMN tc_reg_report.attachment7; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment7 IS 'V2(40) 添付書類７';


--
-- Name: COLUMN tc_reg_report.attachment8; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment8 IS 'V2(40) 添付書類８';


--
-- Name: COLUMN tc_reg_report.attachment9; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment9 IS 'V2(40) 添付書類９';


--
-- Name: COLUMN tc_reg_report.attachment10; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment10 IS 'V2(40) 添付書類１０';


--
-- Name: COLUMN tc_reg_report.attachment11; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment11 IS 'V2(40) 添付書類１１';


--
-- Name: COLUMN tc_reg_report.attachment12; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment12 IS 'V2(40) 添付書類１２';


--
-- Name: COLUMN tc_reg_report.attachment13; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment13 IS 'V2(40) 添付書類１３';


--
-- Name: COLUMN tc_reg_report.attachment14; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment14 IS 'V2(40) 添付書類１４';


--
-- Name: COLUMN tc_reg_report.attachment15; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment15 IS 'V2(40) 添付書類１５ ◆予備';


--
-- Name: COLUMN tc_reg_report.attachment16; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment16 IS 'V2(40) 添付書類１６ ◆予備';


--
-- Name: COLUMN tc_reg_report.attachment17; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment17 IS 'V2(40) 添付書類１７ ◆予備';


--
-- Name: COLUMN tc_reg_report.attachment18; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment18 IS 'V2(40) 添付書類１８ ◆予備';


--
-- Name: COLUMN tc_reg_report.attachment19; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment19 IS 'V2(40) 添付書類１９ ◆予備';


--
-- Name: COLUMN tc_reg_report.attachment20; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_reg_report.attachment20 IS 'V2(40) 添付書類２０ ◆予備';


--
-- Name: tc_swk_def_com; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.tc_swk_def_com (
    swk_kbn integer NOT NULL,
    xxxxcd character varying(12),
    getsudo timestamp without time zone,
    seikyu_no integer,
    data_kbn character varying(2),
    corp_cd character varying(3),
    hassei_basho character varying(2),
    kanjo_basho character varying(2),
    kessai_kbn character varying(1),
    keijo_dt timestamp without time zone,
    d_kamoku character varying(4),
    d_kessai_basho character varying(2),
    d_xx1cd character varying(12),
    d_xx2cd character varying(12),
    d_xx3cd character varying(12),
    d_xx4cd character varying(12),
    d_xx5cd character varying(12),
    d_kbn1 character varying(2),
    d_kbn2 character varying(2),
    d_kbn3 character varying(2),
    d_kbn4 character varying(2),
    d_kbn5 character varying(2),
    d_kingaku double precision,
    c_kamoku character varying(4),
    c_kessai_basho character varying(2),
    c_xx1cd character varying(12),
    c_xx2cd character varying(12),
    c_xx3cd character varying(12),
    c_xx4cd character varying(12),
    c_xx5cd character varying(12),
    c_kbn1 character varying(2),
    c_kbn2 character varying(2),
    c_kbn3 character varying(2),
    c_kbn4 character varying(2),
    c_kbn5 character varying(2),
    c_kingaku double precision,
    tekiyo_cd1 character varying(3),
    tekiyo_cd2 character varying(3),
    tekiyo_cd3 character varying(3),
    zei double precision,
    zritu double precision,
    input_kbn character varying(12)
);


--
-- Name: TABLE tc_swk_def_com; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.tc_swk_def_com IS 'その他のデータ：仕訳固定値設定ﾃｰﾌﾞﾙ';


--
-- Name: COLUMN tc_swk_def_com.swk_kbn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.swk_kbn IS 'N(2) 仕訳区分 1:支払(費用/預金) 2:未払 3:支払(未払金/預金) 4:振替 5:減損損失 6:減損勘定取崩';


--
-- Name: COLUMN tc_swk_def_com.xxxxcd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.xxxxcd IS 'V2(12) 予備コード';


--
-- Name: COLUMN tc_swk_def_com.getsudo; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.getsudo IS 'D 処理年月';


--
-- Name: COLUMN tc_swk_def_com.seikyu_no; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.seikyu_no IS 'N(7) 請求NO';


--
-- Name: COLUMN tc_swk_def_com.data_kbn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.data_kbn IS 'V2(2) ﾃﾞｰﾀ区分';


--
-- Name: COLUMN tc_swk_def_com.corp_cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.corp_cd IS 'V2(3) 会社ｺｰﾄﾞ';


--
-- Name: COLUMN tc_swk_def_com.hassei_basho; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.hassei_basho IS 'V2(2) 発生場所';


--
-- Name: COLUMN tc_swk_def_com.kanjo_basho; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.kanjo_basho IS 'V2(2) 勘定場所';


--
-- Name: COLUMN tc_swk_def_com.kessai_kbn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.kessai_kbn IS 'V2(1) 決済区分';


--
-- Name: COLUMN tc_swk_def_com.keijo_dt; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.keijo_dt IS 'D 処理年月日';


--
-- Name: COLUMN tc_swk_def_com.d_kamoku; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_kamoku IS 'V2(4) 借)勘定科目';


--
-- Name: COLUMN tc_swk_def_com.d_kessai_basho; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_kessai_basho IS 'V2(2) 借)決済場所';


--
-- Name: COLUMN tc_swk_def_com.d_xx1cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_xx1cd IS 'V2(12) 借)コード１';


--
-- Name: COLUMN tc_swk_def_com.d_xx2cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_xx2cd IS 'V2(12) 借)コード２';


--
-- Name: COLUMN tc_swk_def_com.d_xx3cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_xx3cd IS 'V2(12) 借)コード３';


--
-- Name: COLUMN tc_swk_def_com.d_xx4cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_xx4cd IS 'V2(12) 借)コード４';


--
-- Name: COLUMN tc_swk_def_com.d_xx5cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_xx5cd IS 'V2(12) 借)コード５';


--
-- Name: COLUMN tc_swk_def_com.d_kbn1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_kbn1 IS '借)区分１';


--
-- Name: COLUMN tc_swk_def_com.d_kbn2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_kbn2 IS '借)区分２';


--
-- Name: COLUMN tc_swk_def_com.d_kbn3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_kbn3 IS '借)区分３';


--
-- Name: COLUMN tc_swk_def_com.d_kbn4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_kbn4 IS '借)区分４';


--
-- Name: COLUMN tc_swk_def_com.d_kbn5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_kbn5 IS '借)区分５';


--
-- Name: COLUMN tc_swk_def_com.d_kingaku; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.d_kingaku IS 'N(15) 借)金額';


--
-- Name: COLUMN tc_swk_def_com.c_kamoku; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_kamoku IS 'V2(4) 貸)勘定科目';


--
-- Name: COLUMN tc_swk_def_com.c_kessai_basho; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_kessai_basho IS 'V2(2) 貸)決済場所';


--
-- Name: COLUMN tc_swk_def_com.c_xx1cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_xx1cd IS 'V2(12) 貸)コード１';


--
-- Name: COLUMN tc_swk_def_com.c_xx2cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_xx2cd IS 'V2(12) 貸)コード２';


--
-- Name: COLUMN tc_swk_def_com.c_xx3cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_xx3cd IS 'V2(12) 貸)コード３';


--
-- Name: COLUMN tc_swk_def_com.c_xx4cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_xx4cd IS 'V2(12) 貸)コード４';


--
-- Name: COLUMN tc_swk_def_com.c_xx5cd; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_xx5cd IS 'V2(12) 貸)コード５';


--
-- Name: COLUMN tc_swk_def_com.c_kbn1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_kbn1 IS '貸)区分１';


--
-- Name: COLUMN tc_swk_def_com.c_kbn2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_kbn2 IS '貸)区分２';


--
-- Name: COLUMN tc_swk_def_com.c_kbn3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_kbn3 IS '貸)区分３';


--
-- Name: COLUMN tc_swk_def_com.c_kbn4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_kbn4 IS '貸)区分４';


--
-- Name: COLUMN tc_swk_def_com.c_kbn5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_kbn5 IS '貸)区分５';


--
-- Name: COLUMN tc_swk_def_com.c_kingaku; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.c_kingaku IS 'N(15) 貸)金額';


--
-- Name: COLUMN tc_swk_def_com.tekiyo_cd1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.tekiyo_cd1 IS 'V2(3) 摘要ｺｰﾄﾞ１';


--
-- Name: COLUMN tc_swk_def_com.tekiyo_cd2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.tekiyo_cd2 IS 'V2(3) 摘要ｺｰﾄﾞ２';


--
-- Name: COLUMN tc_swk_def_com.tekiyo_cd3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.tekiyo_cd3 IS 'V2(3) 摘要ｺｰﾄﾞ３';


--
-- Name: COLUMN tc_swk_def_com.zei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.zei IS 'N(15) 税額';


--
-- Name: COLUMN tc_swk_def_com.zritu; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.zritu IS 'N(7,6) 税率';


--
-- Name: COLUMN tc_swk_def_com.input_kbn; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_def_com.input_kbn IS 'V2(12) 入力区分';


--
-- Name: tc_swk_settei; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.tc_swk_settei (
    xxxxcd1 character varying(20),
    xxxxnm1 character varying(80),
    xxxxcd2 character varying(20),
    xxxxnm2 character varying(80),
    xxxxcd3 character varying(20),
    xxxxnm3 character varying(80),
    xxxxcd4 character varying(20),
    xxxxnm4 character varying(80),
    xxxxcd5 character varying(20),
    xxxxnm5 character varying(80),
    xxxxcd6 character varying(20),
    xxxxnm6 character varying(80),
    xxxxcd7 character varying(20),
    xxxxnm7 character varying(80),
    xxxxcd8 character varying(20),
    xxxxnm8 character varying(80),
    xxxxcd9 character varying(20),
    xxxxnm9 character varying(80),
    xxxxcd10 character varying(20),
    xxxxnm10 character varying(80),
    xxxxcd11 character varying(20),
    xxxxnm11 character varying(80),
    xxxxcd12 character varying(20),
    xxxxnm12 character varying(80),
    xxxxcd13 character varying(20),
    xxxxnm13 character varying(80),
    xxxxcd14 character varying(20),
    xxxxnm14 character varying(80),
    xxxxcd15 character varying(20),
    xxxxnm15 character varying(80),
    text1 character varying(100),
    text2 character varying(100),
    text3 character varying(100),
    text4 character varying(100),
    text5 character varying(100),
    datetime1 timestamp without time zone,
    datetime2 timestamp without time zone,
    datetime3 timestamp without time zone,
    datetime4 timestamp without time zone,
    datetime5 timestamp without time zone,
    flag1 boolean NOT NULL,
    flag2 boolean NOT NULL,
    flag3 boolean NOT NULL,
    flag4 boolean NOT NULL,
    flag5 boolean NOT NULL,
    kingaku1 double precision,
    kingaku2 double precision,
    kingaku3 double precision,
    kingaku4 double precision,
    kingaku5 double precision
);


--
-- Name: TABLE tc_swk_settei; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON TABLE public.tc_swk_settei IS 'その他のデータ：仕訳設定ﾃｰﾌﾞﾙ（2011/2/18時点ではMYCOMのみ）';


--
-- Name: COLUMN tc_swk_settei.xxxxcd1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd1 IS 'V2(20) コード1  MYCOM:会社CD';


--
-- Name: COLUMN tc_swk_settei.xxxxnm1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm1 IS 'V2(80) 名称1';


--
-- Name: COLUMN tc_swk_settei.xxxxcd2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd2 IS 'V2(20) コード2  MYCOM:会社区分CD';


--
-- Name: COLUMN tc_swk_settei.xxxxnm2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm2 IS 'V2(80) 名称2';


--
-- Name: COLUMN tc_swk_settei.xxxxcd3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd3 IS 'V2(20) コード3  MYCOM:起票部門CD';


--
-- Name: COLUMN tc_swk_settei.xxxxnm3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm3 IS 'V2(80) 名称3';


--
-- Name: COLUMN tc_swk_settei.xxxxcd4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd4 IS 'V2(20) コード4  MYCOM:計上部門CD';


--
-- Name: COLUMN tc_swk_settei.xxxxnm4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm4 IS 'V2(80) 名称4';


--
-- Name: COLUMN tc_swk_settei.xxxxcd5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd5 IS 'V2(20) コード5  MYCOM:仮払勘定CD';


--
-- Name: COLUMN tc_swk_settei.xxxxnm5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm5 IS 'V2(80) 名称5';


--
-- Name: COLUMN tc_swk_settei.xxxxcd6; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd6 IS 'V2(20) コード6  MYCOM:仮払内訳CD';


--
-- Name: COLUMN tc_swk_settei.xxxxnm6; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm6 IS 'V2(80) 名称6';


--
-- Name: COLUMN tc_swk_settei.xxxxcd7; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd7 IS 'V2(20) コード7  MYCOM:関係会社未払勘定CD';


--
-- Name: COLUMN tc_swk_settei.xxxxnm7; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm7 IS 'V2(80) 名称7';


--
-- Name: COLUMN tc_swk_settei.xxxxcd8; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd8 IS 'V2(20) コード8  MYCOM:関係会社未払内訳CD';


--
-- Name: COLUMN tc_swk_settei.xxxxnm8; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm8 IS 'V2(80) 名称8';


--
-- Name: COLUMN tc_swk_settei.xxxxcd9; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd9 IS 'V2(20) コード9  MYCOM:関係会社立替勘定CD';


--
-- Name: COLUMN tc_swk_settei.xxxxnm9; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm9 IS 'V2(80) 名称9';


--
-- Name: COLUMN tc_swk_settei.xxxxcd10; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd10 IS 'V2(20) コード10  MYCOM:関係会社立替内訳CD';


--
-- Name: COLUMN tc_swk_settei.xxxxnm10; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm10 IS 'V2(80) 名称10';


--
-- Name: COLUMN tc_swk_settei.xxxxcd11; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd11 IS 'V2(20) コード11  MYCOM:経過勘定CD';


--
-- Name: COLUMN tc_swk_settei.xxxxnm11; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm11 IS 'V2(80) 名称11';


--
-- Name: COLUMN tc_swk_settei.xxxxcd12; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd12 IS 'V2(20) コード12';


--
-- Name: COLUMN tc_swk_settei.xxxxnm12; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm12 IS 'V2(80) 名称12';


--
-- Name: COLUMN tc_swk_settei.xxxxcd13; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd13 IS 'V2(20) コード13';


--
-- Name: COLUMN tc_swk_settei.xxxxnm13; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm13 IS 'V2(80) 名称13';


--
-- Name: COLUMN tc_swk_settei.xxxxcd14; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd14 IS 'V2(20) コード14';


--
-- Name: COLUMN tc_swk_settei.xxxxnm14; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm14 IS 'V2(80) 名称14';


--
-- Name: COLUMN tc_swk_settei.xxxxcd15; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxcd15 IS 'V2(20) コード15';


--
-- Name: COLUMN tc_swk_settei.xxxxnm15; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.xxxxnm15 IS 'V2(80) 名称15';


--
-- Name: COLUMN tc_swk_settei.text1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.text1 IS 'V2(100) テキスト1  MYCOM:伝票摘要';


--
-- Name: COLUMN tc_swk_settei.text2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.text2 IS 'V2(100) テキスト2  MYCOM:明細摘要';


--
-- Name: COLUMN tc_swk_settei.text3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.text3 IS 'V2(100) テキスト3';


--
-- Name: COLUMN tc_swk_settei.text4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.text4 IS 'V2(100) テキスト4';


--
-- Name: COLUMN tc_swk_settei.text5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.text5 IS 'V2(100) テキスト6';


--
-- Name: COLUMN tc_swk_settei.datetime1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.datetime1 IS 'D 日付時刻1  MYCOM:前回計上月';


--
-- Name: COLUMN tc_swk_settei.datetime2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.datetime2 IS 'D 日付時刻2  MYCOM:前回日時';


--
-- Name: COLUMN tc_swk_settei.datetime3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.datetime3 IS 'D 日付時刻3';


--
-- Name: COLUMN tc_swk_settei.datetime4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.datetime4 IS 'D 日付時刻4';


--
-- Name: COLUMN tc_swk_settei.datetime5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.datetime5 IS 'D 日付時刻5';


--
-- Name: COLUMN tc_swk_settei.flag1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.flag1 IS 'N(1) フラグ1  MYCOM:有効F';


--
-- Name: COLUMN tc_swk_settei.flag2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.flag2 IS 'N(1) フラグ2';


--
-- Name: COLUMN tc_swk_settei.flag3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.flag3 IS 'N(1) フラグ3';


--
-- Name: COLUMN tc_swk_settei.flag4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.flag4 IS 'N(1) フラグ4';


--
-- Name: COLUMN tc_swk_settei.flag5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.flag5 IS 'N(1) フラグ5';


--
-- Name: COLUMN tc_swk_settei.kingaku1; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.kingaku1 IS 'N(15) 金額1';


--
-- Name: COLUMN tc_swk_settei.kingaku2; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.kingaku2 IS 'N(15) 金額2';


--
-- Name: COLUMN tc_swk_settei.kingaku3; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.kingaku3 IS 'N(15) 金額3';


--
-- Name: COLUMN tc_swk_settei.kingaku4; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.kingaku4 IS 'N(15) 金額4';


--
-- Name: COLUMN tc_swk_settei.kingaku5; Type: COMMENT; Schema: public; Owner: -
--

COMMENT ON COLUMN public.tc_swk_settei.kingaku5 IS 'N(15) 金額5';


--
-- Name: tw_m_user; Type: TABLE; Schema: public; Owner: -
--

CREATE TABLE public.tw_m_user (
    user_id integer NOT NULL,
    user_name character varying(100),
    user_kana character varying(100),
    create_date timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    update_date timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);


--
-- Name: v_account_list; Type: VIEW; Schema: public; Owner: -
--

CREATE VIEW public.v_account_list AS
 SELECT m_hkmk.hkmk_cd AS code,
    m_hkmk.hkmk_nm AS name,
    '費用'::text AS kbn
   FROM public.m_hkmk
UNION ALL
 SELECT m_skmk.skmk_cd AS code,
    m_skmk.skmk_nm AS name,
    '資産'::text AS kbn
   FROM public.m_skmk
UNION ALL
 SELECT m_koza.koza_cd AS code,
    m_koza.koza_nm AS name,
    '預金'::text AS kbn
   FROM public.m_koza
  ORDER BY 1;


--
-- Name: t_accounting_unit act_unit_id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_accounting_unit ALTER COLUMN act_unit_id SET DEFAULT nextval('public.t_accounting_unit_act_unit_id_seq'::regclass);


--
-- Name: t_amortization_schedule schedule_id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_amortization_schedule ALTER COLUMN schedule_id SET DEFAULT nextval('public.t_amortization_schedule_schedule_id_seq'::regclass);


--
-- Name: t_audit_log log_id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_audit_log ALTER COLUMN log_id SET DEFAULT nextval('public.t_audit_log_log_id_seq'::regclass);


--
-- Name: t_shwak_d shwak_id; Type: DEFAULT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_shwak_d ALTER COLUMN shwak_id SET DEFAULT nextval('public.t_shwak_d_shwak_id_seq'::regclass);


--
-- Name: c_chu_hnti c_chu_hnti_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.c_chu_hnti
    ADD CONSTRAINT c_chu_hnti_pkey PRIMARY KEY (chu_hnti_id);


--
-- Name: c_chuum c_chuum_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.c_chuum
    ADD CONSTRAINT c_chuum_pkey PRIMARY KEY (chuum_id);


--
-- Name: c_kjkbn c_kjkbn_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.c_kjkbn
    ADD CONSTRAINT c_kjkbn_pkey PRIMARY KEY (kjkbn_id);


--
-- Name: c_kjtaisyo c_kjtaisyo_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.c_kjtaisyo
    ADD CONSTRAINT c_kjtaisyo_pkey PRIMARY KEY (kjkbn_id);


--
-- Name: c_kkbn c_kkbn_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.c_kkbn
    ADD CONSTRAINT c_kkbn_pkey PRIMARY KEY (kkbn_id);


--
-- Name: c_leakbn c_leakbn_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.c_leakbn
    ADD CONSTRAINT c_leakbn_pkey PRIMARY KEY (leakbn_id);


--
-- Name: c_rcalc c_rcalc_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.c_rcalc
    ADD CONSTRAINT c_rcalc_pkey PRIMARY KEY (rcalc_id);


--
-- Name: c_settei_idfld c_settei_idfld_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.c_settei_idfld
    ADD CONSTRAINT c_settei_idfld_pkey PRIMARY KEY (settei_id, val_id);


--
-- Name: c_skyak_ho c_skyak_ho_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.c_skyak_ho
    ADD CONSTRAINT c_skyak_ho_pkey PRIMARY KEY (skyak_ho_id);


--
-- Name: c_szei_kjkbn c_szei_kjkbn_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.c_szei_kjkbn
    ADD CONSTRAINT c_szei_kjkbn_pkey PRIMARY KEY (szei_kjkbn_id);


--
-- Name: d_gson d_gson_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_gson
    ADD CONSTRAINT d_gson_pkey PRIMARY KEY (kykm_id, line_id);


--
-- Name: d_haif d_haif_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_haif
    ADD CONSTRAINT d_haif_pkey PRIMARY KEY (kykm_id, line_id);


--
-- Name: d_henf d_henf_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_henf
    ADD CONSTRAINT d_henf_pkey PRIMARY KEY (kykm_id, line_id);


--
-- Name: d_henl d_henl_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_henl
    ADD CONSTRAINT d_henl_pkey PRIMARY KEY (kykm_id, line_id);


--
-- Name: d_kykh d_kykh_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykh
    ADD CONSTRAINT d_kykh_pkey PRIMARY KEY (kykh_id);


--
-- Name: d_kykm d_kykm_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykm
    ADD CONSTRAINT d_kykm_pkey PRIMARY KEY (kykm_id);


--
-- Name: l_bklog l_bklog_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.l_bklog
    ADD CONSTRAINT l_bklog_pkey PRIMARY KEY (op_dt);


--
-- Name: l_slog l_slog_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.l_slog
    ADD CONSTRAINT l_slog_pkey PRIMARY KEY (slog_no);


--
-- Name: l_ulog l_ulog_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.l_ulog
    ADD CONSTRAINT l_ulog_pkey PRIMARY KEY (slog_no, ulog_no);


--
-- Name: m_bcat m_bcat_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_bcat
    ADD CONSTRAINT m_bcat_pkey PRIMARY KEY (bcat_id);


--
-- Name: m_bkind m_bkind_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_bkind
    ADD CONSTRAINT m_bkind_pkey PRIMARY KEY (bkind_id);


--
-- Name: m_bknri m_bknri_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_bknri
    ADD CONSTRAINT m_bknri_pkey PRIMARY KEY (bknri_id);


--
-- Name: m_corp m_corp_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_corp
    ADD CONSTRAINT m_corp_pkey PRIMARY KEY (corp_id);


--
-- Name: m_genk m_genk_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_genk
    ADD CONSTRAINT m_genk_pkey PRIMARY KEY (genk_id);


--
-- Name: m_gsha m_gsha_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_gsha
    ADD CONSTRAINT m_gsha_pkey PRIMARY KEY (gsha_id);


--
-- Name: m_hkho m_hkho_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_hkho
    ADD CONSTRAINT m_hkho_pkey PRIMARY KEY (hkho_id);


--
-- Name: m_hkmk m_hkmk_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_hkmk
    ADD CONSTRAINT m_hkmk_pkey PRIMARY KEY (hkmk_id);


--
-- Name: m_kknri m_kknri_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_kknri
    ADD CONSTRAINT m_kknri_pkey PRIMARY KEY (kknri_id);


--
-- Name: m_koza m_koza_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_koza
    ADD CONSTRAINT m_koza_pkey PRIMARY KEY (koza_id);


--
-- Name: m_lcpt m_lcpt_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_lcpt
    ADD CONSTRAINT m_lcpt_pkey PRIMARY KEY (lcpt_id);


--
-- Name: m_mcpt m_mcpt_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_mcpt
    ADD CONSTRAINT m_mcpt_pkey PRIMARY KEY (mcpt_id);


--
-- Name: m_rsrvb1 m_rsrvb1_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_rsrvb1
    ADD CONSTRAINT m_rsrvb1_pkey PRIMARY KEY (rsrvb1_id);


--
-- Name: m_rsrvh1 m_rsrvh1_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_rsrvh1
    ADD CONSTRAINT m_rsrvh1_pkey PRIMARY KEY (rsrvh1_id);


--
-- Name: m_rsrvk1 m_rsrvk1_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_rsrvk1
    ADD CONSTRAINT m_rsrvk1_pkey PRIMARY KEY (rsrvk1_id);


--
-- Name: m_shho m_shho_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_shho
    ADD CONSTRAINT m_shho_pkey PRIMARY KEY (shho_id);


--
-- Name: m_skmk m_skmk_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_skmk
    ADD CONSTRAINT m_skmk_pkey PRIMARY KEY (skmk_id);


--
-- Name: m_skti m_skti_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_skti
    ADD CONSTRAINT m_skti_pkey PRIMARY KEY (skti_id);


--
-- Name: m_swptn m_swptn_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_swptn
    ADD CONSTRAINT m_swptn_pkey PRIMARY KEY (swptn_id);


--
-- Name: sec_kngn_bknri sec_kngn_bknri_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.sec_kngn_bknri
    ADD CONSTRAINT sec_kngn_bknri_pkey PRIMARY KEY (kngn_id, bknri_id);


--
-- Name: sec_kngn_kknri sec_kngn_kknri_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.sec_kngn_kknri
    ADD CONSTRAINT sec_kngn_kknri_pkey PRIMARY KEY (kngn_id, kknri_id);


--
-- Name: sec_kngn sec_kngn_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.sec_kngn
    ADD CONSTRAINT sec_kngn_pkey PRIMARY KEY (kngn_id);


--
-- Name: sec_user sec_user_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.sec_user
    ADD CONSTRAINT sec_user_pkey PRIMARY KEY (user_id);


--
-- Name: t_accounting_unit t_accounting_unit_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_accounting_unit
    ADD CONSTRAINT t_accounting_unit_pkey PRIMARY KEY (act_unit_id);


--
-- Name: t_amortization_schedule t_amortization_schedule_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_amortization_schedule
    ADD CONSTRAINT t_amortization_schedule_pkey PRIMARY KEY (schedule_id);


--
-- Name: t_audit_log t_audit_log_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_audit_log
    ADD CONSTRAINT t_audit_log_pkey PRIMARY KEY (log_id);


--
-- Name: t_db_version t_db_version_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_db_version
    ADD CONSTRAINT t_db_version_pkey PRIMARY KEY (db_version);


--
-- Name: t_holiday t_holiday_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_holiday
    ADD CONSTRAINT t_holiday_pkey PRIMARY KEY (id);


--
-- Name: t_journal_setting t_journal_setting_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_journal_setting
    ADD CONSTRAINT t_journal_setting_pkey PRIMARY KEY (setting_key);


--
-- Name: t_kari_ritu t_kari_ritu_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_kari_ritu
    ADD CONSTRAINT t_kari_ritu_pkey PRIMARY KEY (kari_ritu_id);


--
-- Name: t_kykbnj_seq t_kykbnj_seq_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_kykbnj_seq
    ADD CONSTRAINT t_kykbnj_seq_pkey PRIMARY KEY (key);


--
-- Name: t_mstk t_mstk_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_mstk
    ADD CONSTRAINT t_mstk_pkey PRIMARY KEY (mstk_id);


--
-- Name: t_req t_req_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_req
    ADD CONSTRAINT t_req_pkey PRIMARY KEY (req_id);


--
-- Name: t_seq t_seq_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_seq
    ADD CONSTRAINT t_seq_pkey PRIMARY KEY (field_nm);


--
-- Name: t_settei t_settei_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_settei
    ADD CONSTRAINT t_settei_pkey PRIMARY KEY (settei_id);


--
-- Name: t_shwak_d t_shwak_d_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_shwak_d
    ADD CONSTRAINT t_shwak_d_pkey PRIMARY KEY (shwak_id);


--
-- Name: t_zei_kaisei t_zei_kaisei_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_zei_kaisei
    ADD CONSTRAINT t_zei_kaisei_pkey PRIMARY KEY (zei_kaisei_id);


--
-- Name: tc_reg_report tc_reg_report_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.tc_reg_report
    ADD CONSTRAINT tc_reg_report_pkey PRIMARY KEY (line_id);


--
-- Name: tc_swk_def_com tc_swk_def_com_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.tc_swk_def_com
    ADD CONSTRAINT tc_swk_def_com_pkey PRIMARY KEY (swk_kbn);


--
-- Name: tw_m_user tw_m_user_pkey; Type: CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.tw_m_user
    ADD CONSTRAINT tw_m_user_pkey PRIMARY KEY (user_id);


--
-- Name: c_chu_hnti_idx_1_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE UNIQUE INDEX c_chu_hnti_idx_1_idx ON public.c_chu_hnti USING btree (chu_hnti_nm);


--
-- Name: c_chuum_idx_1_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE UNIQUE INDEX c_chuum_idx_1_idx ON public.c_chuum USING btree (chuum_nm);


--
-- Name: c_kjkbn_kjkbn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE UNIQUE INDEX c_kjkbn_kjkbn_id_idx ON public.c_kjkbn USING btree (kjkbn_id);


--
-- Name: c_kjtaisyo_kjkbn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE UNIQUE INDEX c_kjtaisyo_kjkbn_id_idx ON public.c_kjtaisyo USING btree (kjkbn_id);


--
-- Name: c_kkbn_idx_1_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE UNIQUE INDEX c_kkbn_idx_1_idx ON public.c_kkbn USING btree (kkbn_nm);


--
-- Name: c_leakbn_idx_1_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE UNIQUE INDEX c_leakbn_idx_1_idx ON public.c_leakbn USING btree (leakbn_nm);


--
-- Name: c_rcalc_idx_1_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE UNIQUE INDEX c_rcalc_idx_1_idx ON public.c_rcalc USING btree (rcalc_nm);


--
-- Name: c_skyak_ho_idx_1_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE UNIQUE INDEX c_skyak_ho_idx_1_idx ON public.c_skyak_ho USING btree (skyak_ho_nm);


--
-- Name: c_szei_kjkbn_sz_order_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX c_szei_kjkbn_sz_order_idx ON public.c_szei_kjkbn USING btree (d_order);


--
-- Name: d_gson_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_gson_create_id_idx ON public.d_gson USING btree (create_id);


--
-- Name: d_gson_kykh_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_gson_kykh_id_idx ON public.d_gson USING btree (kykh_id);


--
-- Name: d_gson_kykh_no_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_gson_kykh_no_idx ON public.d_gson USING btree (kykh_no);


--
-- Name: d_gson_kykm_no_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_gson_kykm_no_idx ON public.d_gson USING btree (kykm_no);


--
-- Name: d_gson_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_gson_update_id_idx ON public.d_gson USING btree (update_id);


--
-- Name: d_haif_h_bcat_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_haif_h_bcat_id_idx ON public.d_haif USING btree (h_bcat_id);


--
-- Name: d_haif_h_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_haif_h_create_id_idx ON public.d_haif USING btree (h_create_id);


--
-- Name: d_haif_h_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_haif_h_update_id_idx ON public.d_haif USING btree (h_update_id);


--
-- Name: d_haif_hkmk_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_haif_hkmk_id_idx ON public.d_haif USING btree (hkmk_id);


--
-- Name: d_haif_idx_kykh_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_haif_idx_kykh_id_idx ON public.d_haif USING btree (kykh_id);


--
-- Name: d_haif_idx_kykh_no_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_haif_idx_kykh_no_idx ON public.d_haif USING btree (kykh_no);


--
-- Name: d_haif_idx_kykm_no_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_haif_idx_kykm_no_idx ON public.d_haif USING btree (kykm_no);


--
-- Name: d_haif_idx_saikaisu_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_haif_idx_saikaisu_idx ON public.d_haif USING btree (saikaisu);


--
-- Name: d_haif_rsrvh1_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_haif_rsrvh1_id_idx ON public.d_haif USING btree (rsrvh1_id);


--
-- Name: d_henf_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henf_create_id_idx ON public.d_henf USING btree (create_id);


--
-- Name: d_henf_idx_kykh_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henf_idx_kykh_id_idx ON public.d_henf USING btree (kykh_id);


--
-- Name: d_henf_idx_kykh_no_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henf_idx_kykh_no_idx ON public.d_henf USING btree (kykh_no);


--
-- Name: d_henf_idx_kykm_no_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henf_idx_kykm_no_idx ON public.d_henf USING btree (kykm_no);


--
-- Name: d_henf_shho_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henf_shho_id_idx ON public.d_henf USING btree (shho_id);


--
-- Name: d_henf_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henf_update_id_idx ON public.d_henf USING btree (update_id);


--
-- Name: d_henl_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henl_create_id_idx ON public.d_henl USING btree (create_id);


--
-- Name: d_henl_idx_kykh_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henl_idx_kykh_id_idx ON public.d_henl USING btree (kykh_id);


--
-- Name: d_henl_idx_kykh_no_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henl_idx_kykh_no_idx ON public.d_henl USING btree (kykh_no);


--
-- Name: d_henl_idx_kykm_no_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henl_idx_kykm_no_idx ON public.d_henl USING btree (kykm_no);


--
-- Name: d_henl_shho_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henl_shho_id_idx ON public.d_henl USING btree (shho_id);


--
-- Name: d_henl_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_henl_update_id_idx ON public.d_henl USING btree (update_id);


--
-- Name: d_kykh_idx_1_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE UNIQUE INDEX d_kykh_idx_1_idx ON public.d_kykh USING btree (kykh_no, saikaisu);


--
-- Name: d_kykh_idx_k_history_f_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_idx_k_history_f_idx ON public.d_kykh USING btree (k_history_f);


--
-- Name: d_kykh_idx_kyak_end_f_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_idx_kyak_end_f_idx ON public.d_kykh USING btree (kyak_end_f);


--
-- Name: d_kykh_k_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_k_create_id_idx ON public.d_kykh USING btree (k_create_id);


--
-- Name: d_kykh_k_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_k_update_id_idx ON public.d_kykh USING btree (k_update_id);


--
-- Name: d_kykh_kjkbn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_kjkbn_id_idx ON public.d_kykh USING btree (kjkbn_id);


--
-- Name: d_kykh_kkbn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_kkbn_id_idx ON public.d_kykh USING btree (kkbn_id);


--
-- Name: d_kykh_kknri_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_kknri_id_idx ON public.d_kykh USING btree (kknri_id);


--
-- Name: d_kykh_koza_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_koza_id_idx ON public.d_kykh USING btree (koza_id);


--
-- Name: d_kykh_lcpt_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_lcpt_id_idx ON public.d_kykh USING btree (lcpt_id);


--
-- Name: d_kykh_rsrvk1_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_rsrvk1_id_idx ON public.d_kykh USING btree (rsrvk1_id);


--
-- Name: d_kykh_shho_1_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_shho_1_id_idx ON public.d_kykh USING btree (shho_1_id);


--
-- Name: d_kykh_shho_2_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_shho_2_id_idx ON public.d_kykh USING btree (shho_2_id);


--
-- Name: d_kykh_shho_3_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_shho_3_id_idx ON public.d_kykh USING btree (shho_3_id);


--
-- Name: d_kykh_shho_m_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykh_shho_m_id_idx ON public.d_kykh USING btree (shho_m_id);


--
-- Name: d_kykm_b_bcat_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_b_bcat_id_idx ON public.d_kykm USING btree (b_bcat_id);


--
-- Name: d_kykm_b_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_b_create_id_idx ON public.d_kykm USING btree (b_create_id);


--
-- Name: d_kykm_b_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_b_update_id_idx ON public.d_kykm USING btree (b_update_id);


--
-- Name: d_kykm_bkind_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_bkind_id_idx ON public.d_kykm USING btree (bkind_id);


--
-- Name: d_kykm_chu_hnti_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_chu_hnti_id_idx ON public.d_kykm USING btree (chu_hnti_id);


--
-- Name: d_kykm_chuum_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_chuum_id_idx ON public.d_kykm USING btree (chuum_id);


--
-- Name: d_kykm_f_gsha_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_f_gsha_id_idx ON public.d_kykm USING btree (f_gsha_id);


--
-- Name: d_kykm_f_hkmk_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_f_hkmk_id_idx ON public.d_kykm USING btree (f_hkmk_id);


--
-- Name: d_kykm_f_lcpt_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_f_lcpt_id_idx ON public.d_kykm USING btree (f_lcpt_id);


--
-- Name: d_kykm_hk_gsha_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_hk_gsha_id_idx ON public.d_kykm USING btree (hk_gsha_id);


--
-- Name: d_kykm_hkho_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_hkho_id_idx ON public.d_kykm USING btree (hkho_id);


--
-- Name: d_kykm_hszei_kjkbn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_hszei_kjkbn_id_idx ON public.d_kykm USING btree (hszei_kjkbn_id);


--
-- Name: d_kykm_ido_dt_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_ido_dt_idx ON public.d_kykm USING btree (ido_dt);


--
-- Name: d_kykm_ido_dt_r1_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_ido_dt_r1_idx ON public.d_kykm USING btree (ido_dt_r1);


--
-- Name: d_kykm_ido_dt_r2_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_ido_dt_r2_idx ON public.d_kykm USING btree (ido_dt_r2);


--
-- Name: d_kykm_ido_dt_r3_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_ido_dt_r3_idx ON public.d_kykm USING btree (ido_dt_r3);


--
-- Name: d_kykm_idx_1_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE UNIQUE INDEX d_kykm_idx_1_idx ON public.d_kykm USING btree (kykm_no, saikaisu);


--
-- Name: d_kykm_idx_b_ckaiyk_f_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_idx_b_ckaiyk_f_idx ON public.d_kykm USING btree (b_ckaiyk_f);


--
-- Name: d_kykm_idx_kykh_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_idx_kykh_id_idx ON public.d_kykm USING btree (kykh_id);


--
-- Name: d_kykm_idx_kykh_no_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_idx_kykh_no_idx ON public.d_kykm USING btree (kykh_no);


--
-- Name: d_kykm_idx_saikaisu_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_idx_saikaisu_idx ON public.d_kykm USING btree (saikaisu);


--
-- Name: d_kykm_k_gsha_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_k_gsha_id_idx ON public.d_kykm USING btree (k_gsha_id);


--
-- Name: d_kykm_kjkbn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_kjkbn_id_idx ON public.d_kykm USING btree (kjkbn_id);


--
-- Name: d_kykm_leakbn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_leakbn_id_idx ON public.d_kykm USING btree (leakbn_id);


--
-- Name: d_kykm_mcpt_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_mcpt_id_idx ON public.d_kykm USING btree (mcpt_id);


--
-- Name: d_kykm_rsrvb1_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_rsrvb1_id_idx ON public.d_kykm USING btree (rsrvb1_id);


--
-- Name: d_kykm_skmk_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_skmk_id_idx ON public.d_kykm USING btree (skmk_id);


--
-- Name: d_kykm_skyak_ho_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_skyak_ho_id_idx ON public.d_kykm USING btree (skyak_ho_id);


--
-- Name: d_kykm_szei_kjkbn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX d_kykm_szei_kjkbn_id_idx ON public.d_kykm USING btree (szei_kjkbn_id);


--
-- Name: idx_kykm_act_unit; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX idx_kykm_act_unit ON public.d_kykm USING btree (act_unit_id);


--
-- Name: idx_shwak_d_entry_type; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX idx_shwak_d_entry_type ON public.t_shwak_d USING btree (entry_type);


--
-- Name: idx_shwak_d_kykh_id; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX idx_shwak_d_kykh_id ON public.t_shwak_d USING btree (kykh_id);


--
-- Name: idx_shwak_d_process_date; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX idx_shwak_d_process_date ON public.t_shwak_d USING btree (process_date);


--
-- Name: m_bcat_bknri_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_bcat_bknri_id_idx ON public.m_bcat USING btree (bknri_id);


--
-- Name: m_bcat_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_bcat_create_id_idx ON public.m_bcat USING btree (create_id);


--
-- Name: m_bcat_genk_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_bcat_genk_id_idx ON public.m_bcat USING btree (genk_id);


--
-- Name: m_bcat_skti_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_bcat_skti_id_idx ON public.m_bcat USING btree (skti_id);


--
-- Name: m_bcat_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_bcat_update_id_idx ON public.m_bcat USING btree (update_id);


--
-- Name: m_bkind_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_bkind_create_id_idx ON public.m_bkind USING btree (create_id);


--
-- Name: m_bkind_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_bkind_update_id_idx ON public.m_bkind USING btree (update_id);


--
-- Name: m_bknri_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_bknri_create_id_idx ON public.m_bknri USING btree (create_id);


--
-- Name: m_bknri_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_bknri_update_id_idx ON public.m_bknri USING btree (update_id);


--
-- Name: m_corp_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_corp_create_id_idx ON public.m_corp USING btree (create_id);


--
-- Name: m_corp_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_corp_update_id_idx ON public.m_corp USING btree (update_id);


--
-- Name: m_genk_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_genk_create_id_idx ON public.m_genk USING btree (create_id);


--
-- Name: m_genk_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_genk_update_id_idx ON public.m_genk USING btree (update_id);


--
-- Name: m_gsha_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_gsha_create_id_idx ON public.m_gsha USING btree (create_id);


--
-- Name: m_gsha_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_gsha_update_id_idx ON public.m_gsha USING btree (update_id);


--
-- Name: m_hkho_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_hkho_create_id_idx ON public.m_hkho USING btree (create_id);


--
-- Name: m_hkho_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_hkho_update_id_idx ON public.m_hkho USING btree (update_id);


--
-- Name: m_hkmk_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_hkmk_create_id_idx ON public.m_hkmk USING btree (create_id);


--
-- Name: m_hkmk_knjkb_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_hkmk_knjkb_id_idx ON public.m_hkmk USING btree (knjkb_id);


--
-- Name: m_hkmk_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_hkmk_update_id_idx ON public.m_hkmk USING btree (update_id);


--
-- Name: m_kknri_corp_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_kknri_corp_id_idx ON public.m_kknri USING btree (corp_id);


--
-- Name: m_kknri_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_kknri_create_id_idx ON public.m_kknri USING btree (create_id);


--
-- Name: m_kknri_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_kknri_update_id_idx ON public.m_kknri USING btree (update_id);


--
-- Name: m_koza_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_koza_create_id_idx ON public.m_koza USING btree (create_id);


--
-- Name: m_koza_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_koza_update_id_idx ON public.m_koza USING btree (update_id);


--
-- Name: m_lcpt_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_lcpt_create_id_idx ON public.m_lcpt USING btree (create_id);


--
-- Name: m_lcpt_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_lcpt_update_id_idx ON public.m_lcpt USING btree (update_id);


--
-- Name: m_mcpt_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_mcpt_create_id_idx ON public.m_mcpt USING btree (create_id);


--
-- Name: m_mcpt_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_mcpt_update_id_idx ON public.m_mcpt USING btree (update_id);


--
-- Name: m_rsrvb1_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_rsrvb1_create_id_idx ON public.m_rsrvb1 USING btree (create_id);


--
-- Name: m_rsrvb1_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_rsrvb1_update_id_idx ON public.m_rsrvb1 USING btree (update_id);


--
-- Name: m_rsrvh1_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_rsrvh1_create_id_idx ON public.m_rsrvh1 USING btree (create_id);


--
-- Name: m_rsrvh1_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_rsrvh1_update_id_idx ON public.m_rsrvh1 USING btree (update_id);


--
-- Name: m_rsrvk1_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_rsrvk1_create_id_idx ON public.m_rsrvk1 USING btree (create_id);


--
-- Name: m_rsrvk1_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_rsrvk1_update_id_idx ON public.m_rsrvk1 USING btree (update_id);


--
-- Name: m_shho_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_shho_create_id_idx ON public.m_shho USING btree (create_id);


--
-- Name: m_shho_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_shho_update_id_idx ON public.m_shho USING btree (update_id);


--
-- Name: m_skmk_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_skmk_create_id_idx ON public.m_skmk USING btree (create_id);


--
-- Name: m_skmk_knjkb_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_skmk_knjkb_id_idx ON public.m_skmk USING btree (knjkb_id);


--
-- Name: m_skmk_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_skmk_update_id_idx ON public.m_skmk USING btree (update_id);


--
-- Name: m_skti_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_skti_create_id_idx ON public.m_skti USING btree (create_id);


--
-- Name: m_skti_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_skti_update_id_idx ON public.m_skti USING btree (update_id);


--
-- Name: m_swptn_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_swptn_create_id_idx ON public.m_swptn USING btree (create_id);


--
-- Name: m_swptn_swptn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_swptn_swptn_id_idx ON public.m_swptn USING btree (swptn_id);


--
-- Name: m_swptn_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX m_swptn_update_id_idx ON public.m_swptn USING btree (update_id);


--
-- Name: sec_kngn_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX sec_kngn_create_id_idx ON public.sec_kngn USING btree (create_id);


--
-- Name: sec_kngn_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX sec_kngn_update_id_idx ON public.sec_kngn USING btree (update_id);


--
-- Name: sec_user_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX sec_user_create_id_idx ON public.sec_user USING btree (create_id);


--
-- Name: sec_user_kngn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX sec_user_kngn_id_idx ON public.sec_user USING btree (kngn_id);


--
-- Name: sec_user_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX sec_user_update_id_idx ON public.sec_user USING btree (update_id);


--
-- Name: t_kari_ritu_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX t_kari_ritu_create_id_idx ON public.t_kari_ritu USING btree (create_id);


--
-- Name: t_kari_ritu_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX t_kari_ritu_update_id_idx ON public.t_kari_ritu USING btree (update_id);


--
-- Name: t_opt_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX t_opt_create_id_idx ON public.t_opt USING btree (create_id);


--
-- Name: t_opt_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX t_opt_update_id_idx ON public.t_opt USING btree (update_id);


--
-- Name: t_szei_kmk_kjkbn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX t_szei_kmk_kjkbn_id_idx ON public.t_szei_kmk USING btree (kjkbn_id);


--
-- Name: t_szei_kmk_leakbn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX t_szei_kmk_leakbn_id_idx ON public.t_szei_kmk USING btree (leakbn_id);


--
-- Name: t_szei_kmk_szei_kjkbn_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX t_szei_kmk_szei_kjkbn_id_idx ON public.t_szei_kmk USING btree (szei_kjkbn_id);


--
-- Name: t_zei_kaisei_create_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX t_zei_kaisei_create_id_idx ON public.t_zei_kaisei USING btree (create_id);


--
-- Name: t_zei_kaisei_update_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX t_zei_kaisei_update_id_idx ON public.t_zei_kaisei USING btree (update_id);


--
-- Name: tc_hrel_index01_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX tc_hrel_index01_idx ON public.tc_hrel USING btree (ptn_cd1, ptn_cd2, ptn_cd3, ptn_cd4);


--
-- Name: tc_rec_shri_xxxx1id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX tc_rec_shri_xxxx1id_idx ON public.tc_rec_shri USING btree (xxxx1id);


--
-- Name: tc_rec_shri_xxxx2id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX tc_rec_shri_xxxx2id_idx ON public.tc_rec_shri USING btree (xxxx2id);


--
-- Name: tc_rec_shri_xxxx3id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX tc_rec_shri_xxxx3id_idx ON public.tc_rec_shri USING btree (xxxx3id);


--
-- Name: tc_rec_shri_xxxx4id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX tc_rec_shri_xxxx4id_idx ON public.tc_rec_shri USING btree (xxxx4id);


--
-- Name: tc_rec_shri_xxxx5id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX tc_rec_shri_xxxx5id_idx ON public.tc_rec_shri USING btree (xxxx5id);


--
-- Name: tc_reg_report_line_id_idx; Type: INDEX; Schema: public; Owner: -
--

CREATE INDEX tc_reg_report_line_id_idx ON public.tc_reg_report USING btree (line_id);


--
-- Name: d_haif d_haif_h_bcat_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_haif
    ADD CONSTRAINT d_haif_h_bcat_id_fk FOREIGN KEY (h_bcat_id) REFERENCES public.m_bcat(bcat_id) DEFERRABLE;


--
-- Name: d_haif d_haif_hkmk_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_haif
    ADD CONSTRAINT d_haif_hkmk_id_fk FOREIGN KEY (hkmk_id) REFERENCES public.m_hkmk(hkmk_id) DEFERRABLE;


--
-- Name: d_haif d_haif_rsrvh1_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_haif
    ADD CONSTRAINT d_haif_rsrvh1_id_fk FOREIGN KEY (rsrvh1_id) REFERENCES public.m_rsrvh1(rsrvh1_id) DEFERRABLE;


--
-- Name: d_henf d_henf_shho_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_henf
    ADD CONSTRAINT d_henf_shho_id_fk FOREIGN KEY (shho_id) REFERENCES public.m_shho(shho_id) DEFERRABLE;


--
-- Name: d_henl d_henl_shho_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_henl
    ADD CONSTRAINT d_henl_shho_id_fk FOREIGN KEY (shho_id) REFERENCES public.m_shho(shho_id) DEFERRABLE;


--
-- Name: d_kykh d_kykh_kkbn_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykh
    ADD CONSTRAINT d_kykh_kkbn_id_fk FOREIGN KEY (kkbn_id) REFERENCES public.c_kkbn(kkbn_id) DEFERRABLE;


--
-- Name: d_kykh d_kykh_kknri_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykh
    ADD CONSTRAINT d_kykh_kknri_id_fk FOREIGN KEY (kknri_id) REFERENCES public.m_kknri(kknri_id) DEFERRABLE;


--
-- Name: d_kykh d_kykh_koza_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykh
    ADD CONSTRAINT d_kykh_koza_id_fk FOREIGN KEY (koza_id) REFERENCES public.m_koza(koza_id) DEFERRABLE;


--
-- Name: d_kykh d_kykh_lcpt_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykh
    ADD CONSTRAINT d_kykh_lcpt_id_fk FOREIGN KEY (lcpt_id) REFERENCES public.m_lcpt(lcpt_id) DEFERRABLE;


--
-- Name: d_kykh d_kykh_rsrvk1_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykh
    ADD CONSTRAINT d_kykh_rsrvk1_id_fk FOREIGN KEY (rsrvk1_id) REFERENCES public.m_rsrvk1(rsrvk1_id) DEFERRABLE;


--
-- Name: d_kykh d_kykh_shho_1_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykh
    ADD CONSTRAINT d_kykh_shho_1_id_fk FOREIGN KEY (shho_1_id) REFERENCES public.m_shho(shho_id) DEFERRABLE;


--
-- Name: d_kykh d_kykh_shho_2_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykh
    ADD CONSTRAINT d_kykh_shho_2_id_fk FOREIGN KEY (shho_2_id) REFERENCES public.m_shho(shho_id) DEFERRABLE;


--
-- Name: d_kykh d_kykh_shho_3_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykh
    ADD CONSTRAINT d_kykh_shho_3_id_fk FOREIGN KEY (shho_3_id) REFERENCES public.m_shho(shho_id) DEFERRABLE;


--
-- Name: d_kykm d_kykm_b_bcat_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykm
    ADD CONSTRAINT d_kykm_b_bcat_id_fk FOREIGN KEY (b_bcat_id) REFERENCES public.m_bcat(bcat_id) DEFERRABLE;


--
-- Name: d_kykm d_kykm_b_bcat_id_r2_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykm
    ADD CONSTRAINT d_kykm_b_bcat_id_r2_fk FOREIGN KEY (b_bcat_id_r2) REFERENCES public.m_bcat(bcat_id) DEFERRABLE;


--
-- Name: t_accounting_unit fk_act_unit_kykh; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_accounting_unit
    ADD CONSTRAINT fk_act_unit_kykh FOREIGN KEY (kykh_id) REFERENCES public.d_kykh(kykh_id) ON DELETE CASCADE;


--
-- Name: d_kykm fk_kykm_act_unit; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.d_kykm
    ADD CONSTRAINT fk_kykm_act_unit FOREIGN KEY (act_unit_id) REFERENCES public.t_accounting_unit(act_unit_id) ON DELETE SET NULL;


--
-- Name: t_amortization_schedule fk_schedule_act_unit; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.t_amortization_schedule
    ADD CONSTRAINT fk_schedule_act_unit FOREIGN KEY (act_unit_id) REFERENCES public.t_accounting_unit(act_unit_id) ON DELETE CASCADE;


--
-- Name: m_bcat m_bcat_bknri_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_bcat
    ADD CONSTRAINT m_bcat_bknri_id_fk FOREIGN KEY (bknri_id) REFERENCES public.m_bknri(bknri_id) DEFERRABLE;


--
-- Name: m_bcat m_bcat_genk_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_bcat
    ADD CONSTRAINT m_bcat_genk_id_fk FOREIGN KEY (genk_id) REFERENCES public.m_genk(genk_id) DEFERRABLE;


--
-- Name: m_bcat m_bcat_skti_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_bcat
    ADD CONSTRAINT m_bcat_skti_id_fk FOREIGN KEY (skti_id) REFERENCES public.m_skti(skti_id) DEFERRABLE;


--
-- Name: m_kknri m_kknri_corp_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_kknri
    ADD CONSTRAINT m_kknri_corp_id_fk FOREIGN KEY (corp_id) REFERENCES public.m_corp(corp_id) DEFERRABLE;


--
-- Name: m_lcpt m_lcpt_shho_id_n_1_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_lcpt
    ADD CONSTRAINT m_lcpt_shho_id_n_1_fk FOREIGN KEY (shho_id_n_1) REFERENCES public.m_shho(shho_id) DEFERRABLE;


--
-- Name: m_lcpt m_lcpt_shho_id_n_2_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_lcpt
    ADD CONSTRAINT m_lcpt_shho_id_n_2_fk FOREIGN KEY (shho_id_n_2) REFERENCES public.m_shho(shho_id) DEFERRABLE;


--
-- Name: m_lcpt m_lcpt_shho_id_n_3_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_lcpt
    ADD CONSTRAINT m_lcpt_shho_id_n_3_fk FOREIGN KEY (shho_id_n_3) REFERENCES public.m_shho(shho_id) DEFERRABLE;


--
-- Name: m_lcpt m_lcpt_shho_id_s_1_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_lcpt
    ADD CONSTRAINT m_lcpt_shho_id_s_1_fk FOREIGN KEY (shho_id_s_1) REFERENCES public.m_shho(shho_id) DEFERRABLE;


--
-- Name: m_lcpt m_lcpt_shho_id_s_2_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_lcpt
    ADD CONSTRAINT m_lcpt_shho_id_s_2_fk FOREIGN KEY (shho_id_s_2) REFERENCES public.m_shho(shho_id) DEFERRABLE;


--
-- Name: m_lcpt m_lcpt_shho_id_s_3_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.m_lcpt
    ADD CONSTRAINT m_lcpt_shho_id_s_3_fk FOREIGN KEY (shho_id_s_3) REFERENCES public.m_shho(shho_id) DEFERRABLE;


--
-- Name: sec_kngn_kknri sec_kngn_kknri_kknri_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.sec_kngn_kknri
    ADD CONSTRAINT sec_kngn_kknri_kknri_id_fk FOREIGN KEY (kknri_id) REFERENCES public.m_kknri(kknri_id) DEFERRABLE;


--
-- Name: sec_kngn_kknri sec_kngn_kknri_kngn_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.sec_kngn_kknri
    ADD CONSTRAINT sec_kngn_kknri_kngn_id_fk FOREIGN KEY (kngn_id) REFERENCES public.sec_kngn(kngn_id) ON DELETE CASCADE DEFERRABLE;


--
-- Name: sec_user sec_user_kngn_id_fk; Type: FK CONSTRAINT; Schema: public; Owner: -
--

ALTER TABLE ONLY public.sec_user
    ADD CONSTRAINT sec_user_kngn_id_fk FOREIGN KEY (kngn_id) REFERENCES public.sec_kngn(kngn_id) DEFERRABLE;


--
-- PostgreSQL database dump complete
--

\unrestrict JR6r9HH0A35G7cyeDUtuiGkqoHXjS0s3wKRGMLfjYtHZVylPi5EB7wmB13npD2Q

