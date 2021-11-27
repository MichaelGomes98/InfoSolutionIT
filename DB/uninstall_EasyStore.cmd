REM Fichier		: BDD_EasyStore.cmd
REM Objet		: Désinstallation de la BDD EasyStore 

mkdir .\Logs

REM Lancement du script uninstall_EasyStore.sql dans SQL*PLUS
REM le %1 permet de demander le mot de passe lors du lancement du script
sqlplus SYSTEM/admin@xe @%~dp0\uninstall_EasyStore.sql @%~dp0