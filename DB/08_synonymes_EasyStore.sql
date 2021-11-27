-- ======================================================================
--  Script: 07_synonymes_EasyStore.sql 
--  Objet : Création des synonymes de la base EasyStore
-- ======================================================================

CREATE OR REPLACE SYNONYM EasyStore_user.vw_utilisateur FOR EasyStore_data.vw_utilisateur;
CREATE OR REPLACE SYNONYM EasyStore_user.vw_commande FOR EasyStore_data.vw_commande;
CREATE OR REPLACE SYNONYM EasyStore_user.vw_commandeDetail FOR EasyStore_data.vw_commandeDetail;
CREATE OR REPLACE SYNONYM EasyStore_user.vw_produit FOR EasyStore_data.vw_produit;
CREATE OR REPLACE SYNONYM EasyStore_user.vw_evaluations FOR EasyStore_data.vw_evaluations;
CREATE OR REPLACE SYNONYM EasyStore_user.vw_panier FOR EasyStore_data.vw_panier;
CREATE OR REPLACE SYNONYM EasyStore_user.pkg_STATISTIQUEVENTE FOR EasyStore_data.pkg_STATISTIQUEVENTE;

CREATE OR REPLACE SYNONYM EasyStore_user.sq_utilisateur FOR EasyStore_data.sq_utilisateur;
CREATE OR REPLACE SYNONYM EasyStore_user.sq_commande FOR EasyStore_data.sq_commande;
CREATE OR REPLACE SYNONYM EasyStore_user.sq_produit FOR EasyStore_data.sq_produit;
CREATE OR REPLACE SYNONYM EasyStore_user.sq_ajoutProduit FOR EasyStore_data.sq_ajoutProduit;
CREATE OR REPLACE SYNONYM EasyStore_user.sq_updatePanier FOR EasyStore_data.sq_updatePanier;
CREATE OR REPLACE SYNONYM EasyStore_user.sq_deletePanier FOR EasyStore_data.sq_deletePanier;
CREATE OR REPLACE SYNONYM EasyStore_user.sq_insertPanier FOR EasyStore_data.sq_insertPanier;
CREATE OR REPLACE SYNONYM EasyStore_user.sq_updateStatutCommande FOR EasyStore_data.sq_updateStatutCommande;




