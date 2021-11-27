-- ======================================================================
--  Script: 05_vues_EasyStore.sql 
--  Objet : Création des vues schéma de la base EasyStore
--  Objectif : créer des vues et tester l'interrogation et la mise-à-jour à travers ces vues. 
-- ======================================================================

-- ====================================================
-- Création des VUES
-- ====================================================
-- ====================================================
-- Vue d'affichage des utilisateurs
-- ====================================================
CREATE OR REPLACE VIEW vw_utilisateur(Id, Nom, Prenom, Adresse, CodePostal, Email, Password, Connected, Role) AS
       SELECT uti_id, uti_nom, uti_prenom, uti_adresse, uti_codepostal, uti_email, uti_password, uti_connected, uti_role
       FROM Utilisateur;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_utilisateur TO EasyStore_user;

-- ====================================================
-- Vue d'affichage des clients
-- ====================================================
CREATE OR REPLACE VIEW vw_client(Id, Nom, Prenom, Adresse, CodePostal, Email, Password, Connected, Role) AS
       SELECT uti_id, uti_nom, uti_prenom, uti_adresse, uti_codepostal, uti_email, uti_password, uti_connected, uti_role
       FROM Utilisateur WHERE uti_role like 0;
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_client TO EasyStore_user;
-- ====================================================
-- Vue d'affichage des commandes
-- ====================================================
CREATE OR REPLACE VIEW vw_commande(Id, NumeroCommande, DateCommande, StatutCommande, TotalCommande, UserId) AS
       SELECT com_id, com_numero, com_date, com_statut, com_total, uti_id
       FROM Commande;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_commande TO EasyStore_user;
-- ====================================================
-- Vue d'affichage des commmandes detaillé 
--               + les clients
--               + La quantité
--               + Le produit
-- ====================================================
CREATE OR REPLACE VIEW vw_commandeDetail(Id, Nom, Prenom, IdCommande, CommandeNumero, CommandeStatut, Quantite,IdProduit, TypeProduit, ModeleProduit, ProduitMarque) AS
       SELECT Utilisateur.uti_id, Utilisateur.uti_nom, Utilisateur.uti_prenom, Commande.Com_Id, Commande.Com_Numero,Commande.Com_Statut, Ligne_Commande.Lig_Quantite, Produit.Pro_Id, Produit.Pro_Type, Produit.Pro_Modele, produit.pro_marque
       FROM Utilisateur
       INNER JOIN Commande ON Commande.Uti_Id = Utilisateur.Uti_Id
       INNER JOIN Ligne_Commande ON ligne_commande.com_id = Commande.Com_Id
       INNER JOIN Produit ON ligne_commande.pro_id = Produit.Pro_Id;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_commandeDetail TO EasyStore_user;
-- ====================================================
-- Vue d'affichage de la liste des produits
-- ====================================================
CREATE OR REPLACE VIEW vw_produit(Id, Type,  Modele, Description, Marque, Prix, IsEnable, Image) AS
       SELECT pro_id, pro_type, pro_modele, pro_description, pro_marque, pro_prix, pro_isenable, pro_image
       FROM Produit;
;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_produit TO EasyStore_user;

-- ====================================================
-- Vue d'affichage de la liste des evaluations des produits
--               + l'utilisateur
--               + Le produit 
-- ====================================================
CREATE OR REPLACE VIEW vw_evaluations(Id, Nom, Prenom, Notes,  Commentaire, ProduitType, ProduitModele) AS
       SELECT Utilisateur.uti_id, uti_nom, uti_prenom, eva_notes, eva_commentaire, produit.pro_type, produit.pro_modele
       FROM Evaluation
         INNER JOIN Utilisateur ON Utilisateur.Uti_Id = Evaluation.Uti_Id
         INNER JOIN Produit ON Produit.Pro_Id = Evaluation.Pro_Id;
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_evaluations TO EasyStore_user;

-- ====================================================
-- Vue des paniers
--               + Commande
--               + Ligne Commande
--               + Produit
-- ====================================================
CREATE OR REPLACE VIEW vw_panier(Id, NumCommande, DateCommande, StatutCommande, TotalCommande, UserId, ligCommandeId, ligProduitId, ligQuantite, ligPrix) AS
       SELECT commande.com_id, commande.com_numero, commande.com_date, commande.com_statut, commande.com_total, commande.uti_id, ligne_commande.com_id, ligne_commande.pro_id, ligne_commande.lig_quantite, ligne_commande.pro_prix
       FROM COMMANDE
         INNER JOIN LIGNE_COMMANDE ON COMMANDE.COM_ID = LIGNE_COMMANDE.COM_ID
         INNER JOIN Produit ON Produit.Pro_Id = LIGNE_COMMANDE.PRO_ID
         WHERE commande.com_statut = 'Panier';
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_panier TO EasyStore_user;



--SELECT * FROM vw_utilisateur;
--SELECT * From vw_client;
--SELECT * FROM vw_commande;
--SELECT * FROM vw_produit;
--SELECT * FROM vw_evaluations;
--SELECT * FROM vw_panier;
