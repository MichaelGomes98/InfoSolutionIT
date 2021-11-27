--------------------------------------------------------------------------------------------
--Script : uninstall_EasyCooking.sql
--Objet  : Création des synonymes de la BDD démonstration sur SGBD Oracle en Local (HEGLOCAL)
--
--Mise à jour des versions
--Version  Visa   Date      Commentaires
-------  ------ --------    ----------------------------------------------------------------
--1.0	     SC   26.03.07    Création
--------------------------------------------------------------------------------------------

-- Suppression des utilisateurs (CASCADE), rôles et profil
SPOOL .\Logs\uninstall_EasyStore.log

--=============================================
--Suppression des rôles, utilisateurs et profil
--=============================================
--Suppression des utilisateurs
DROP USER EasyStore_data CASCADE;
DROP USER EasyStore_user CASCADE;

--Suppression des rôles
DROP ROLE role_EasyStore_data CASCADE;
DROP ROLE role_EasyStore_user CASCADE;

--Suppression du profil
DROP PROFILE EasyStore_profil;

SPOOL OFF

EXIT;
