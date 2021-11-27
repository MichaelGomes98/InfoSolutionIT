-- ====================================================================
-- Script : 01_EasyStore.sql
-- Objet  : Création BDD EasyStore sur SGBD Oracle en Local (HEGLOCAL) 
--
-- Mise à jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ---------------------------------------------
-- 1.0	     GA   2.05.08    Création
-- ====================================================================

SET ECHO ON
SET LINESIZE 200
SET PAGESIZE 60

-- Création des utilisateurs en tant que System
SPOOL .\Logs\02_utilisateurs_EasyStore.log
@.\02_utilisateurs_EasyStore.sql
SPOOL OFF

-- Connexion à HEGLOCAL en tant que EasyStore_data (propirétaires des objets de schéma)
CONNECT EasyStore_data/EasyStore_data@xe

-- Création des tables
SPOOL .\Logs\03_tables_EasyStore.log
@.\03_tables_EasyStore.sql
SPOOL OFF

-- Chargement des données
SPOOL .\Logs\04_insertions_EasyStore.log
@.\04_insertions_EasyStore.sql;
SPOOL OFF

-- Création des vues
SPOOL .\Logs\05_vues_EasyStore.log
@.\05_vues_EasyStore.sql
SPOOL OFF

-- Création des triggers pour les clefs primaires
SPOOL .\Logs\06_triggers_EasyStore.log
@.\06_triggers_EasyStore.sql;
SPOOL OFF

-- Création des packages
SPOOL .\Logs\07_package_EasyStore.log
@.\07_package_EasyStore.sql;
SPOOL OFF

-- Connexion à HEGLOCAL en tant que system
CONNECT SYSTEM/admin@xe

-- Création des synonymes
SPOOL .\Logs\08_synonymes_EasyStore.log
@.\08_synonymes_EasyStore.sql;
SPOOL OFF

SET ECHO OFF

EXIT;
