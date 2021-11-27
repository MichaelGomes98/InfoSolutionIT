-- ====================================================================
-- Script : 01_EasyStore.sql
-- Objet  : Cr�ation BDD EasyStore sur SGBD Oracle en Local (HEGLOCAL) 
--
-- Mise � jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ---------------------------------------------
-- 1.0	     GA   2.05.08    Cr�ation
-- ====================================================================

SET ECHO ON
SET LINESIZE 200
SET PAGESIZE 60

-- Cr�ation des utilisateurs en tant que System
SPOOL .\Logs\02_utilisateurs_EasyStore.log
@.\02_utilisateurs_EasyStore.sql
SPOOL OFF

-- Connexion � HEGLOCAL en tant que EasyStore_data (propir�taires des objets de sch�ma)
CONNECT EasyStore_data/EasyStore_data@xe

-- Cr�ation des tables
SPOOL .\Logs\03_tables_EasyStore.log
@.\03_tables_EasyStore.sql
SPOOL OFF

-- Chargement des donn�es
SPOOL .\Logs\04_insertions_EasyStore.log
@.\04_insertions_EasyStore.sql;
SPOOL OFF

-- Cr�ation des vues
SPOOL .\Logs\05_vues_EasyStore.log
@.\05_vues_EasyStore.sql
SPOOL OFF

-- Cr�ation des triggers pour les clefs primaires
SPOOL .\Logs\06_triggers_EasyStore.log
@.\06_triggers_EasyStore.sql;
SPOOL OFF

-- Cr�ation des packages
SPOOL .\Logs\07_package_EasyStore.log
@.\07_package_EasyStore.sql;
SPOOL OFF

-- Connexion � HEGLOCAL en tant que system
CONNECT SYSTEM/admin@xe

-- Cr�ation des synonymes
SPOOL .\Logs\08_synonymes_EasyStore.log
@.\08_synonymes_EasyStore.sql;
SPOOL OFF

SET ECHO OFF

EXIT;
