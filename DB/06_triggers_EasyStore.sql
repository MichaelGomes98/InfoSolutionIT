-- ====================================================================
-- Script : 06_triggers_EasyStore.sql
-- Objet  : Cr�ation des triggers EasyStore sur SGBD Oracle en Local (HEGLOCAL) 
--
-- Mise � jour des versions
-- Version  Visa   Date      Commentaires
-- -----  ------ --------    ------------------------------------------
-- 1.0	     GA   2.05.08    Cr�ation trigers
-- ====================================================================

DROP SEQUENCE sq_utilisateur;
DROP SEQUENCE sq_commande;
DROP SEQUENCE sq_produit;
DROP SEQUENCE sq_updatePanier;
DROP SEQUENCE sq_deletePanier;
DROP SEQUENCE sq_insertPanier;
DROP SEQUENCE sq_updateStatutCommande;


-- ====================================================
-- Trigger Utilisateur incr�ment
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
-- Trigger Commande incr�ment
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
-- Trigger Produit incr�ment
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
-- update du panier (Quantit�) � voir
-- dans le cas ou la quantit� de produits du panier venait a �tre modifi�
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
-- delete du panier � voir
-- dans le cas ou un produit est supprim�
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
-- insert du panier (Quantit�)
-- dans le cas ou un produit est ajout� au panier
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
--Pas de suppression dans la base de donn�e pr�vu pour les commandes ainsi que pour les produits (suppression logique plus adapt�es)
--Pas de trigger pr�vu pour la vue Evaluation car pas utilis� pour le projet
--Ce script ce trouve apr�s celui des ins�rtions car les trigger (auto-incr�ment) ont �t� configurer afin de commencer apr�s les donn�es d�j� stock�es dans la base
--G�n�ral:
--Trigger cr�er pour l'insert de produit dans le panier
--Trigger cr�er pour l'update du contenu du panier
--Trigger cr�er pour le delete du panier
--Administrateur:
--Gestion Client -> pas de trigger pr�vu car vue simple
--Gestion Produit -> pas de trigger pr�vu car vue simple
--Gestion Commande -> trigger mis en place afin de modifier le statut de la commande -> seule modification possible pour le detail de la commande de l'application
--Client:
--Mes Commandes -> pas de trigger car l'utilisateur ne peut pas manipuler les donn�es (fen�tre ne sert qu'� consulter ses commandes)
--Mon Compte -> pas de donn�es 
--Mes Informations -> pas de trigger pr�vu car vue simple 



























