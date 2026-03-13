-- ============================================================
-- LeaseM4BS 開発環境用 初期データ投入
--
-- 実行方法:
--   psql -U lease_m4bs_user -d lease_m4bs_dev -f 002_seed_dev.sql
--
-- 注意: 開発・テスト環境専用です。本番環境には使用しないでください。
-- ============================================================

BEGIN;

-- ==========================================================
-- 権限グループ (sec_kngn)
-- ==========================================================
INSERT INTO sec_kngn (kngn_id, kngn_cd, kngn_nm, access_kind, access_kind_b,
    biko, create_id, create_dt, update_id, update_dt, update_cnt, history_f,
    admin, master_update, file_output, print, log_ref, approval)
VALUES
    -- 管理者権限（全権限付与）
    (1, 'ADMIN', '管理者', 1, 1,
     '全機能へのアクセス権限', 0, NOW(), 0, NOW(), 0, FALSE,
     TRUE, TRUE, TRUE, TRUE, TRUE, TRUE),
    -- 一般ユーザー権限
    (2, 'USER', '一般ユーザー', 1, 1,
     '基本機能のみ', 0, NOW(), 0, NOW(), 0, FALSE,
     FALSE, FALSE, TRUE, TRUE, FALSE, FALSE),
    -- 閲覧専用権限
    (3, 'VIEWER', '閲覧専用', 0, 0,
     '参照のみ', 0, NOW(), 0, NOW(), 0, FALSE,
     FALSE, FALSE, FALSE, FALSE, FALSE, FALSE)
ON CONFLICT (kngn_id) DO NOTHING;

-- ==========================================================
-- ユーザー (sec_user)
-- ==========================================================
INSERT INTO sec_user (user_id, user_cd, user_nm, pwd, kngn_id,
    biko, create_id, create_dt, update_id, update_dt, update_cnt, history_f,
    login_attempts, pwd_life_time, pwd_grace_time, pwd_min,
    pwd_moji_chk, pwd_alph_chk, pwd_num_chk, pwd_symbol_chk,
    pwd_upd_dt, d_first_login, err_ct, last_err_dt)
VALUES
    -- 管理者ユーザー (admin / admin123)
    (1, 'admin', '管理者', 'admin123', 1,
     '開発用管理者アカウント', 0, NOW(), 0, NOW(), 0, FALSE,
     10, NULL, NULL, NULL,
     FALSE, FALSE, FALSE, FALSE,
     NOW(), NULL, 0, NULL),
    -- 一般ユーザー (user01 / pass01)
    (2, 'user01', 'テストユーザー01', 'pass01', 2,
     '開発用一般アカウント', 0, NOW(), 0, NOW(), 0, FALSE,
     5, NULL, NULL, NULL,
     FALSE, FALSE, FALSE, FALSE,
     NOW(), NULL, 0, NULL),
    -- 閲覧専用ユーザー (viewer / view01)
    (3, 'viewer', '閲覧ユーザー', 'view01', 3,
     '開発用閲覧専用アカウント', 0, NOW(), 0, NOW(), 0, FALSE,
     5, NULL, NULL, NULL,
     FALSE, FALSE, FALSE, FALSE,
     NOW(), NULL, 0, NULL)
ON CONFLICT (user_id) DO NOTHING;

COMMIT;

-- ============================================================
-- 投入データ確認
-- ============================================================
\echo '--- 権限グループ ---'
SELECT kngn_id, kngn_cd, kngn_nm, admin, master_update, file_output, print FROM sec_kngn ORDER BY kngn_id;

\echo ''
\echo '--- ユーザー一覧 ---'
SELECT user_id, user_cd, user_nm, kngn_id, biko FROM sec_user ORDER BY user_id;

\echo ''
\echo '--- ログイン情報 ---'
\echo '  admin   / admin123  (管理者権限)'
\echo '  user01  / pass01    (一般ユーザー権限)'
\echo '  viewer  / view01    (閲覧専用権限)'
