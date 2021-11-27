-- -----------------------------------------------------------------------------
--             Génération d'une base de données pour
--                      Oracle Version 10g
--                        (7/5/2020 16:52:05)
-- -----------------------------------------------------------------------------
--      Nom de la base : MLR7
--      Projet : 
--      Auteur : Gomes
--      Date de dernière modification : 7/5/2020 16:51:57
-- -----------------------------------------------------------------------------

DROP TABLE UTILISATEUR CASCADE CONSTRAINTS;

DROP TABLE COMMANDE CASCADE CONSTRAINTS;

DROP TABLE PRODUIT CASCADE CONSTRAINTS;

DROP TABLE LIGNE_COMMANDE CASCADE CONSTRAINTS;

DROP TABLE EVALUATION CASCADE CONSTRAINTS;

-- -----------------------------------------------------------------------------
--       TABLE : UTILISATEUR
-- -----------------------------------------------------------------------------

CREATE TABLE UTILISATEUR
   (
    UTI_ID NUMBER(6)  NOT NULL,
    UTI_NOM VARCHAR2(128)  NOT NULL,
    UTI_PRENOM VARCHAR2(128)  NOT NULL,
    UTI_ADRESSE VARCHAR2(128)  NOT NULL,
    UTI_CODEPOSTAL NUMBER(5)  NOT NULL,
    UTI_EMAIL VARCHAR2(128)  NOT NULL,
    UTI_PASSWORD VARCHAR2(128)  NOT NULL,
    UTI_CONNECTED NUMBER(1)  NOT NULL,
    UTI_ROLE NUMBER(1)  NOT NULL
,   CONSTRAINT PK_UTILISATEUR PRIMARY KEY (UTI_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : COMMANDE
-- -----------------------------------------------------------------------------

CREATE TABLE COMMANDE
   (
    COM_ID NUMBER(6)  NOT NULL,
    UTI_ID NUMBER(6)  NOT NULL,
    COM_NUMERO NUMBER(6)  NOT NULL,
    COM_DATE DATE  NOT NULL,
    COM_STATUT CHAR(32)  NOT NULL,
    COM_TOTAL NUMBER(5,2)  NULL
,   CONSTRAINT PK_COMMANDE PRIMARY KEY (COM_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE COMMANDE
-- -----------------------------------------------------------------------------

CREATE  INDEX I_FK_COMMANDE_UTILISATEUR
     ON COMMANDE (UTI_ID ASC)
    ;

-- -----------------------------------------------------------------------------
--       TABLE : PRODUIT
-- -----------------------------------------------------------------------------

CREATE TABLE PRODUIT
   (
    PRO_ID NUMBER(6)  NOT NULL,
    PRO_TYPE VARCHAR2(128)  NOT NULL,
    PRO_MODELE VARCHAR2(128)  NOT NULL,
    PRO_DESCRIPTION VARCHAR2(3000)  NOT NULL,
    PRO_MARQUE VARCHAR2(128)  NOT NULL,
    PRO_PRIX NUMBER(5,2)  NOT NULL,
    PRO_ISENABLE NUMBER(1)  NOT NULL,
    PRO_IMAGE CLOB  NOT NULL
,   CONSTRAINT PK_PRODUIT PRIMARY KEY (PRO_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       TABLE : LIGNE_COMMANDE
-- -----------------------------------------------------------------------------

CREATE TABLE LIGNE_COMMANDE
   (
    COM_ID NUMBER(6)  NOT NULL,
    PRO_ID NUMBER(6)  NOT NULL,
    LIG_QUANTITE NUMBER(2)  NOT NULL,
    PRO_PRIX NUMBER(5,2)  NOT NULL
,   CONSTRAINT PK_LIGNE_COMMANDE PRIMARY KEY (COM_ID, PRO_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE LIGNE_COMMANDE
-- -----------------------------------------------------------------------------

CREATE  INDEX I_FK_LIGNE_COMMANDE_COMMANDE
     ON LIGNE_COMMANDE (COM_ID ASC)
    ;

CREATE  INDEX I_FK_LIGNE_COMMANDE_PRODUIT
     ON LIGNE_COMMANDE (PRO_ID ASC)
    ;

-- -----------------------------------------------------------------------------
--       TABLE : EVALUATION
-- -----------------------------------------------------------------------------

CREATE TABLE EVALUATION
   (
    UTI_ID NUMBER(6)  NOT NULL,
    PRO_ID NUMBER(6)  NOT NULL,
    EVA_NOTES CHAR(32)  NULL,
    EVA_COMMENTAIRE CHAR(32)  NULL
,   CONSTRAINT PK_EVALUATION PRIMARY KEY (UTI_ID, PRO_ID)  
   ) ;

-- -----------------------------------------------------------------------------
--       INDEX DE LA TABLE EVALUATION
-- -----------------------------------------------------------------------------

CREATE  INDEX I_FK_EVALUATION_UTILISATEUR
     ON EVALUATION (UTI_ID ASC)
    ;

CREATE  INDEX I_FK_EVALUATION_PRODUIT
     ON EVALUATION (PRO_ID ASC)
    ;


-- -----------------------------------------------------------------------------
--       CREATION DES REFERENCES DE TABLE
-- -----------------------------------------------------------------------------


ALTER TABLE COMMANDE ADD (
     CONSTRAINT FK_COMMANDE_UTILISATEUR
          FOREIGN KEY (UTI_ID)
               REFERENCES UTILISATEUR (UTI_ID))   ;

ALTER TABLE LIGNE_COMMANDE ADD (
     CONSTRAINT FK_LIGNE_COMMANDE_COMMANDE
          FOREIGN KEY (COM_ID)
               REFERENCES COMMANDE (COM_ID))   ;

ALTER TABLE LIGNE_COMMANDE ADD (
     CONSTRAINT FK_LIGNE_COMMANDE_PRODUIT
          FOREIGN KEY (PRO_ID)
               REFERENCES PRODUIT (PRO_ID))   ;

ALTER TABLE EVALUATION ADD (
     CONSTRAINT FK_EVALUATION_UTILISATEUR
          FOREIGN KEY (UTI_ID)
               REFERENCES UTILISATEUR (UTI_ID))   ;

ALTER TABLE EVALUATION ADD (
     CONSTRAINT FK_EVALUATION_PRODUIT
          FOREIGN KEY (PRO_ID)
               REFERENCES PRODUIT (PRO_ID))   ;


-- -----------------------------------------------------------------------------
--                FIN DE GENERATION
-- -----------------------------------------------------------------------------
