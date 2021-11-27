REM Fichier		: Installation.cmd
REM Objet		: Création de la BDD EasyStore

mkdir .\Logs

REM Lancement du script 01_BDD_EasyStore.sql dans SQL*PLUS
REM le %1 permet de demander le mot de passe lors du lancement du script
sqlplus SYSTEM/admin@xe @%~dp0\01_BDD_EasyStore.sql %~dp0
