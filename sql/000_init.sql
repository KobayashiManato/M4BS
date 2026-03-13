-- ============================================================
-- LeaseM4BS PostgreSQL 初期セットアップ
-- データベース・ユーザー作成スクリプト
--
-- 実行方法:
--   psql -U postgres -f 000_init.sql
--
-- 注意: このスクリプトは PostgreSQL スーパーユーザー（postgres）で実行してください
-- ============================================================

-- ==========================================================
-- ユーザー作成
-- ==========================================================
DO $$
BEGIN
    IF NOT EXISTS (SELECT FROM pg_catalog.pg_roles WHERE rolname = 'lease_m4bs_user') THEN
        CREATE ROLE lease_m4bs_user WITH
            LOGIN
            PASSWORD 'iltex_mega_pass_m4'
            NOSUPERUSER
            NOCREATEDB
            NOCREATEROLE
            INHERIT;
        RAISE NOTICE 'ユーザー lease_m4bs_user を作成しました。';
    ELSE
        -- パスワードを更新
        ALTER ROLE lease_m4bs_user WITH PASSWORD 'iltex_mega_pass_m4';
        RAISE NOTICE 'ユーザー lease_m4bs_user は既に存在します。パスワードを更新しました。';
    END IF;
END
$$;

-- ==========================================================
-- データベース作成（開発環境）
-- ==========================================================
SELECT 'CREATE DATABASE lease_m4bs_dev OWNER lease_m4bs_user ENCODING ''UTF8'' LC_COLLATE ''ja_JP.UTF-8'' LC_CTYPE ''ja_JP.UTF-8'' TEMPLATE template0'
WHERE NOT EXISTS (SELECT FROM pg_database WHERE datname = 'lease_m4bs_dev')
\gexec

-- ==========================================================
-- データベース作成（テスト環境）
-- ==========================================================
SELECT 'CREATE DATABASE lease_m4bs_test OWNER lease_m4bs_user ENCODING ''UTF8'' LC_COLLATE ''ja_JP.UTF-8'' LC_CTYPE ''ja_JP.UTF-8'' TEMPLATE template0'
WHERE NOT EXISTS (SELECT FROM pg_database WHERE datname = 'lease_m4bs_test')
\gexec

-- ==========================================================
-- 各データベースに対する権限設定
-- ==========================================================
GRANT ALL PRIVILEGES ON DATABASE lease_m4bs_dev TO lease_m4bs_user;
GRANT ALL PRIVILEGES ON DATABASE lease_m4bs_test TO lease_m4bs_user;

-- ==========================================================
-- 開発データベースに接続してスキーマ権限を設定
-- ==========================================================
\connect lease_m4bs_dev

GRANT ALL ON SCHEMA public TO lease_m4bs_user;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT ALL ON TABLES TO lease_m4bs_user;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT ALL ON SEQUENCES TO lease_m4bs_user;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT ALL ON FUNCTIONS TO lease_m4bs_user;

-- ==========================================================
-- テストデータベースに接続してスキーマ権限を設定
-- ==========================================================
\connect lease_m4bs_test

GRANT ALL ON SCHEMA public TO lease_m4bs_user;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT ALL ON TABLES TO lease_m4bs_user;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT ALL ON SEQUENCES TO lease_m4bs_user;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT ALL ON FUNCTIONS TO lease_m4bs_user;

-- ============================================================
-- セットアップ完了
--
-- 次のステップ:
--   1. 各データベースに接続してテーブルを作成:
--      psql -U lease_m4bs_user -d lease_m4bs_dev -f 001_ddl.sql
--   2. 初期データを投入:
--      psql -U lease_m4bs_user -d lease_m4bs_dev -f 002_seed_dev.sql
-- ============================================================
