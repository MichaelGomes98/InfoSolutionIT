-- ====================================================================
-- Script : 06_triggers_EasyStore.sql
-- Objet  : Création des triggers EasyStore sur SGBD Oracle en Local (HEGLOCAL) 
--
-- Mise à jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ------------------------------------------
-- 1.0	     GA   2.05.08    Création trigers
-- ====================================================================

DROP SEQUENCE sq_utilisateur;
DROP SEQUENCE sq_commande;
DROP SEQUENCE sq_produit;
DROP SEQUENCE sq_updatePanier;
DROP SEQUENCE sq_deletePanier;
DROP SEQUENCE sq_insertPanier;
DROP SEQUENCE sq_updateStatutCommande;


-- ====================================================
-- Trigger Utilisateur incrément
-- ====================================================

 CREATE SEQUENCE   sq_utilisateur  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 11 CACHE 20 NOORDER NOCYCLE
/

CREATE OR REPLACE TRIGGER  tr_utilisateur 
  before insert on UTILISATEUR               
  for each row  
begin   
    select sq_utilisateur.nextval into :NEW.uti_id from dual; 
end; 

/
ALTER TRIGGER  tr_utilisateur ENABLE
/

-- ====================================================
-- Trigger Commande incrément
-- ====================================================


 CREATE SEQUENCE sq_commande MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 36 CACHE 20 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER  tr_commande
  before insert on commande              
  for each row  
begin   
    select sq_commande.nextval into :NEW.com_id from dual; 
end; 

/
ALTER TRIGGER  tr_commande ENABLE
/
-- ====================================================
-- Trigger Produit incrément
-- ====================================================

 CREATE SEQUENCE   sq_produit  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 11 CACHE 20 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER  tr_produit 
  before insert on produit              
  for each row  
begin   
    select sq_produit.nextval into :NEW.pro_id from dual; 
end; 

/
ALTER TRIGGER  tr_produit ENABLE
/

-- ====================================================
-- update du panier (Quantité) à voir
-- dans le cas ou la quantité de produits du panier venait a être modifié
-- ====================================================

 CREATE SEQUENCE sq_updatePanier  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 11 CACHE 20 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER tr_updatePanier
  instead of update on vw_panier
  for each row
begin
    update LIGNE_COMMANDE SET LIGNE_COMMANDE.LIG_QUANTITE = :NEW.ligquantite
    WHERE ligne_commande.pro_id = :NEW.idproduit
    and ligne_commande.com_id = :NEW.id;
end;


/
ALTER TRIGGER  tr_updatePanier ENABLE;

-- ====================================================
-- delete du panier à voir
-- dans le cas ou un produit est supprimé
-- ====================================================

 CREATE SEQUENCE sq_deletePanier  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 11 CACHE 20 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER tr_deletePanier
  instead of delete on vw_panier
  for each row
begin
    delete FROM LIGNE_COMMANDE WHERE
    ligne_commande.pro_id = :OLD.idproduit
    and ligne_commande.com_id = :OLD.id;
end;
 
/
ALTER TRIGGER  tr_deletePanier ENABLE;

-- ====================================================
-- insert du panier (Quantité)
-- dans le cas ou un produit est ajouté au panier
-- ====================================================

 CREATE SEQUENCE sq_insertPanier  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 11 CACHE 20 NOORDER  NOCYCLE
/

CREATE OR REPLACE TRIGGER tr_insertPanier
  instead of insert on vw_panier
  for each row
begin
    insert into COMMANDE VALUES (:NEW.id, :NEW.userid, :NEW.numcommande, :NEW.datecommande, :NEW.statutcommande, :NEW.totalcommande);
    insert into LIGNE_COMMANDE  VALUES (EASYSTORE_DATA.sq_commande.currval, :NEW.ligproduitid, :NEW.ligquantite, :NEW.ligprix);

end;



/
ALTER TRIGGER  tr_insertPanier ENABLE;

-- ====================================================
-- Modification du statut de la commande "Administrateur"
-- ====================================================
 CREATE SEQUENCE sq_updateStatutCommande  MINVALUE 1 NOMAXVALUE INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE
/
CREATE OR REPLACE TRIGGER tr_updateStatutCommande
  instead of update on vw_commandeDetail
  for each row
begin
    update COMMANDE SET COMMANDE.COM_STATUT = :NEW.CommandeStatut
    WHERE COMMANDE.COM_ID = :NEW.idcommande;
end; 
/
ALTER TRIGGER  tr_updateStatutCommande ENABLE;


-----
--Remarques :
--Pas de suppression dans la base de donnée prévu pour les commandes ainsi que pour les produits (suppression logique plus adaptées)
--Pas de trigger prévu pour la vue Evaluation car pas utilisé pour le projet
--Ce script ce trouve après celui des insértions car les trigger (auto-incrément) ont été configurer afin de commencer après les données déjà stockées dans la base
--Général:
--Trigger créer pour l'insert de produit dans le panier
--Trigger créer pour l'update du contenu du panier
--Trigger créer pour le delete du panier
--Administrateur:
--Gestion Client -> pas de trigger prévu car vue simple
--Gestion Produit -> pas de trigger prévu car vue simple
--Gestion Commande -> trigger mis en place afin de modifier le statut de la commande -> seule modification possible pour le detail de la commande de l'application
--Client:
--Mes Commandes -> pas de trigger car l'utilisateur ne peut pas manipuler les données (fenêtre ne sert qu'à consulter ses commandes)
--Mon Compte -> pas de données 
--Mes Informations -> pas de trigger prévu car vue simple 



























