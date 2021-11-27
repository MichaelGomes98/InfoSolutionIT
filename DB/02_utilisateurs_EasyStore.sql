-- ====================================================================
-- Script : 02_utilisateurs_EasyStore.sql
-- Objet  : Cr�ation des utilisateurs BDD EasyStore sur SGBD Oracle en Local (HEGLOCAL)
--
-- Mise � jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ------------------------------------------
-- 1.0	     GA   26.03.07    Cr�ation utilisateurs
-- ====================================================================
-- =============================================================================================
-- Suppression des r�les, utilisateurs et profil
-- =============================================================================================
-- Suppression des utilisateurs
DROP USER EasyStore_data CASCADE;
DROP USER EasyStore_user CASCADE;

-- Suppression des r�les
DROP ROLE role_EasyStore_data CASCADE;
DROP ROLE role_EasyStore_user CASCADE;

-- Suppression du profil
DROP PROFILE EasyStore_profil;

-- =============================================================================================
-- Cr�ation du profil
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
-- Cr�ation du r�le role_EasyStore_data (r�le de l'utilisateur propri�taire des objets de la base)
-- =============================================================================================
-- Creation du r�le role_EasyStore_data
CREATE ROLE role_EasyStore_data;

-- droit de se connecter � la BDD
GRANT CONNECT TO role_EasyStore_data;

-- droit de cr�er des triggers, s�quence, tables, packages, ...
GRANT RESOURCE TO role_EasyStore_data;

-- droit de cr�er des vues
GRANT CREATE VIEW TO role_EasyStore_data;

-- droit de cr�er des synonymes
-- GRANT CREATE ANY SYNONYM TO role_EasyStore_data;
-- ! fonctionne mais donne trop de privil�ges, � �viter

-- ===============================
-- Cr�ation du r�le role_EasyStore_user (r�le de l'utilisateur de l'application)
-- ===============================
-- Creation du r�le role_EasyStore_user
CREATE ROLE role_EasyStore_user;

-- droit de se connecter � la BDD
GRANT CREATE SESSION TO role_EasyStore_user;

-- ===================================
-- Cr�ation de l'utilisateur EasyStore_data (propri�taire des objets de sch�ma de la base)
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
--Cr�ation de l'utilisateur EasyStore_user (utilisateur de l'application)
--===================================
CREATE USER EasyStore_user
	PROFILE EasyStore_profil
	IDENTIFIED BY EasyStore_user
;
GRANT role_EasyStore_user TO EasyStore_user;
