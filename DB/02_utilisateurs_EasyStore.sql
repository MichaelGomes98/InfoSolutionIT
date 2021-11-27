-- ====================================================================
-- Script : 02_utilisateurs_EasyStore.sql
-- Objet  : Création des utilisateurs BDD EasyStore sur SGBD Oracle en Local (HEGLOCAL)
--
-- Mise à jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ------------------------------------------
-- 1.0	     GA   26.03.07    Création utilisateurs
-- ====================================================================
-- =============================================================================================
-- Suppression des rôles, utilisateurs et profil
-- =============================================================================================
-- Suppression des utilisateurs
DROP USER EasyStore_data CASCADE;
DROP USER EasyStore_user CASCADE;

-- Suppression des rôles
DROP ROLE role_EasyStore_data CASCADE;
DROP ROLE role_EasyStore_user CASCADE;

-- Suppression du profil
DROP PROFILE EasyStore_profil;

-- =============================================================================================
-- Création du profil
-- =============================================================================================
-- Creation du profil EasyStore_profil
CREATE PROFILE EasyStore_profil LIMIT
	SESSIONS_PER_USER 3
	FAILED_LOGIN_ATTEMPTS 3 
	PASSWORD_LOCK_TIME 1/24
	PASSWORD_LIFE_TIME 180 
	PASSWORD_REUSE_TIME 180 
	PASSWORD_REUSE_MAX UNLIMITED
	PASSWORD_GRACE_TIME 7;

-- =============================================================================================
-- Création du rôle role_EasyStore_data (rôle de l'utilisateur propriétaire des objets de la base)
-- =============================================================================================
-- Creation du rôle role_EasyStore_data
CREATE ROLE role_EasyStore_data;

-- droit de se connecter à la BDD
GRANT CONNECT TO role_EasyStore_data;

-- droit de créer des triggers, séquence, tables, packages, ...
GRANT RESOURCE TO role_EasyStore_data;

-- droit de créer des vues
GRANT CREATE VIEW TO role_EasyStore_data;

-- droit de créer des synonymes
-- GRANT CREATE ANY SYNONYM TO role_EasyStore_data;
-- ! fonctionne mais donne trop de privilèges, à éviter

-- ===============================
-- Création du rôle role_EasyStore_user (rôle de l'utilisateur de l'application)
-- ===============================
-- Creation du rôle role_EasyStore_user
CREATE ROLE role_EasyStore_user;

-- droit de se connecter à la BDD
GRANT CREATE SESSION TO role_EasyStore_user;

-- ===================================
-- Création de l'utilisateur EasyStore_data (propriétaire des objets de schéma de la base)
-- ===================================
-- Creation de l'utilisateur EasyStore_data 
CREATE USER EasyStore_data
	PROFILE EasyStore_profil
	IDENTIFIED BY EasyStore_data
	DEFAULT TABLESPACE USERS
	TEMPORARY TABLESPACE TEMP
;
GRANT role_EasyStore_data TO EasyStore_data;
ALTER USER EasyStore_data quota unlimited ON USERS;

--===================================
--Création de l'utilisateur EasyStore_user (utilisateur de l'application)
--===================================
CREATE USER EasyStore_user
	PROFILE EasyStore_profil
	IDENTIFIED BY EasyStore_user
;
GRANT role_EasyStore_user TO EasyStore_user;
