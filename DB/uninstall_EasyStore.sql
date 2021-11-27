--------------------------------------------------------------------------------------------
--Script : uninstall_EasyCooking.sql
--Objet  : Cr�ation des synonymes de la BDD d�monstration sur SGBD Oracle en Local (HEGLOCAL)
--
--Mise � jour des versions
--Version  Visa   Date      Commentaires
-------  ------ --------    ----------------------------------------------------------------
--1.0	     SC   26.03.07    Cr�ation
--------------------------------------------------------------------------------------------

-- Suppression des utilisateurs (CASCADE), r�les et profil
SPOOL .\Logs\uninstall_EasyStore.log

--=============================================
--Suppression des r�les, utilisateurs et profil
--=============================================
--Suppression des utilisateurs
DROP USER EasyStore_data CASCADE;
DROP USER EasyStore_user CASCADE;

--Suppression des r�les
DROP ROLE role_EasyStore_data CASCADE;
DROP ROLE role_EasyStore_user CASCADE;

--Suppression du profil
DROP PROFILE EasyStore_profil;

SPOOL OFF

EXIT;
