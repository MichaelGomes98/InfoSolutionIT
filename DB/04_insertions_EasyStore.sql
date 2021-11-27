-- ====================================================================
-- Script : 04_insertions_EasyStore.sql
-- Objet  : Insertions de donn�es sur les tables EasyStore 
-- ====================================================================
-- ====================================================
-- Insertion Table : UTILISATEUR
-- ====================================================

INSERT INTO UTILISATEUR VALUES (1, 'Dupont', 'Jean', 'Chemin de la patrie 3', 1254, 'jdp@outlook.com', 'test', 0, 0);
INSERT INTO UTILISATEUR VALUES (2, 'Sinclair', 'Fran�ois', 'Chemin du cerle 2', 1212, 'francois@outlook.com','test', 0, 0);
INSERT INTO UTILISATEUR VALUES (3, 'Blaise', 'Pascal', 'Parc des princes 23', 1225, 'blaise@windowslive.com','test', 0, 0);
INSERT INTO UTILISATEUR VALUES (4, 'Coste', 'Jeanne', 'Parc de la route 12', 1234, 'jeanne@windowslive.com','test', 0, 0);
INSERT INTO UTILISATEUR VALUES (5, 'Schmidt', 'Pascal', 'Parc de la patrie 1', 1222, 'pascpasc@hotmail.com','test', 0, 0);
INSERT INTO UTILISATEUR VALUES (6, 'Martin', 'Elodie', 'Route des jeunes 31', 1215, 'elodie98@hotmail.com','test', 0, 0);
INSERT INTO UTILISATEUR VALUES (7, 'Nicolet', 'Anne', 'Chemin du lac 3', 1223, 'annenico@Icloud.com','test', 0, 0);
INSERT INTO UTILISATEUR VALUES (8, 'Bergeret', 'Laurent', 'Parc du crou 2', 1211, 'lolo@windowslive.com','test', 0, 0);
INSERT INTO UTILISATEUR VALUES (9, 'Ingold', 'Samuel',  'route de la place 2', 1231, 'samsam@hotmail.com', 'test',0, 0);
INSERT INTO UTILISATEUR VALUES (10, 'Michael', 'Gomes', 'route de batelle 23', 1254, 'admin@admin.com' ,'test',0, 1);

COMMIT;
-- ====================================================
-- Insertion Table : COMMANDE  
-- ====================================================
INSERT INTO COMMANDE VALUES (1, 1, 100,  TO_DATE('2020-7-02','YYYY-MM-DD'),'En preparation', 300.00);
INSERT INTO COMMANDE VALUES (2, 2, 101, TO_DATE('2020-7-02','YYYY-MM-DD'),'En preparation', 180.00);
INSERT INTO COMMANDE VALUES (3, 3, 102, TO_DATE('2020-7-03','YYYY-MM-DD'),'En preparation', 226.00);
INSERT INTO COMMANDE VALUES (4, 4, 103, TO_DATE('2020-7-03','YYYY-MM-DD'), 'Annul�', 190.00);
INSERT INTO COMMANDE VALUES (5, 5, 104, TO_DATE('2020-7-04','YYYY-MM-DD'), 'Pr�te � �tre retir�e', 150.25);
INSERT INTO COMMANDE VALUES (6, 9, 105, TO_DATE('2020-7-04','YYYY-MM-DD'),'Panier', 108.30);
INSERT INTO COMMANDE VALUES (7, 7, 106, TO_DATE('2020-7-06','YYYY-MM-DD'), 'Panier', 200.00);
INSERT INTO COMMANDE VALUES (8, 1, 107, TO_DATE('2020-7-06','YYYY-MM-DD'), 'Pr�te � �tre retir�e', 119.00);
INSERT INTO COMMANDE VALUES (9, 2,  108, TO_DATE('2020-7-06','YYYY-MM-DD'),'Pr�te � �tre retir�e', 190.00);
INSERT INTO COMMANDE VALUES (10, 4, 109, TO_DATE('2020-7-06','YYYY-MM-DD'), 'Annul�', 110.00);
INSERT INTO COMMANDE VALUES (11, 5, 110, TO_DATE('2020-7-06','YYYY-MM-DD'), 'Pr�te � �tre retir�e', 110.00);
INSERT INTO COMMANDE VALUES (12, 4, 111, TO_DATE('2020-7-07','YYYY-MM-DD'), 'Pr�te � �tre retir�e', 110.00);
INSERT INTO COMMANDE VALUES (13, 9, 112, TO_DATE('2020-7-07','YYYY-MM-DD'), 'En preparation', 189.90);
INSERT INTO COMMANDE VALUES (14, 3, 113, TO_DATE('2020-7-07','YYYY-MM-DD'), 'En preparation', 299.90);
INSERT INTO COMMANDE VALUES (15, 1, 114, TO_DATE('2020-7-07','YYYY-MM-DD'), 'En preparation', 380.90);
INSERT INTO COMMANDE VALUES (16, 6, 115,TO_DATE('2020-7-07','YYYY-MM-DD'), 'En preparation', 110.0);
INSERT INTO COMMANDE VALUES (17, 5, 116, TO_DATE('2020-7-08','YYYY-MM-DD'), 'Annul�', 99.0);
INSERT INTO COMMANDE VALUES (18, 4, 117, TO_DATE('2020-7-08','YYYY-MM-DD'), 'En preparation', 610.00);
INSERT INTO COMMANDE VALUES (19, 3, 118, TO_DATE('2020-7-08','YYYY-MM-DD'), 'Pr�te � �tre retir�e', 320.00);
INSERT INTO COMMANDE VALUES (20, 5, 119, TO_DATE('2020-7-08','YYYY-MM-DD'), 'Pr�te � �tre retir�e', 220.00);
INSERT INTO COMMANDE VALUES (21, 2, 120, TO_DATE('2020-7-08','YYYY-MM-DD'), 'Pr�te � �tre retir�e', 240.00);
INSERT INTO COMMANDE VALUES (22, 1, 121, TO_DATE('2020-7-08','YYYY-MM-DD'), 'Pr�te � �tre retir�e', 260.90);
INSERT INTO COMMANDE VALUES (23, 1, 121, TO_DATE('2020-7-09','YYYY-MM-DD'), 'Pr�te � �tre retir�e', 270.00);
INSERT INTO COMMANDE VALUES (24, 9, 122, TO_DATE('2020-7-09','YYYY-MM-DD'), 'En attente', 290.00);
INSERT INTO COMMANDE VALUES (25, 9, 122, TO_DATE('2020-7-09','YYYY-MM-DD'), 'Panier', 110.00);
INSERT INTO COMMANDE VALUES (26, 9, 122, TO_DATE('2020-7-09','YYYY-MM-DD'), 'Panier', 110.00);
INSERT INTO COMMANDE VALUES (27, 8, 123, TO_DATE('2020-7-10','YYYY-MM-DD'), 'En attente', 110.00);
INSERT INTO COMMANDE VALUES (28, 7, 124, TO_DATE('2020-7-10','YYYY-MM-DD'), 'Annul�', 99.90);
INSERT INTO COMMANDE VALUES (29, 1, 125, TO_DATE('2020-7-10','YYYY-MM-DD'), 'Pr�te � �tre retir�e', 200.90);
INSERT INTO COMMANDE VALUES (30, 6, 126, TO_DATE('2020-7-10','YYYY-MM-DD'), 'Pr�te � �tre retir�e', 249.90);
INSERT INTO COMMANDE VALUES (31, 5, 127, TO_DATE('2020-7-10','YYYY-MM-DD'),'lard', 90.90);
INSERT INTO COMMANDE VALUES (32, 4, 128, TO_DATE('2020-7-11','YYYY-MM-DD'), 'En attente', 90.00);
INSERT INTO COMMANDE VALUES (33, 2, 129, TO_DATE('2020-7-12','YYYY-MM-DD'), 'En attente', 110.00);
INSERT INTO COMMANDE VALUES (34, 2, 129, TO_DATE('2020-7-13','YYYY-MM-DD'), 'En attente', 110.00);
INSERT INTO COMMANDE VALUES (35, 3, 130, TO_DATE('2020-7-14','YYYY-MM-DD'), 'En attente', 300.00);


COMMIT;

-- ====================================================
-- Insertion Table : PRODUIT
-- ====================================================

INSERT INTO PRODUIT VALUES (1, 'Moniteur Gaming', 'LC1FMSUNG', 'Parfaitement adapt� pour les joueurs, m�me les plus exigeants, ce mod�le affiche un taux de rafra�chissement de 100 Hz pour des ralentissements r�duits au minimum et un temps de r�ponse de 4 ms pour des sc�nes d action sans aucun flou. 
', 'SAMSUNG', 300.00, 0, 'https://asset.conrad.com/media10/isa/160267/c1/-/fr/1591987_BB_02_LO/moniteur-led-samsung-c24f396fhu-lc24f396fhuxen-59-7-cm-23-5-pouces-eec-a-a-d-1920-x-1080-pixels-full-hd-4-ms-vg.jpg?x=300&'||'y=300&'||'format=jpg&'||'ex=300&'||'ey=300&'||'align=center');
COMMIT;


 INSERT INTO PRODUIT VALUES (2, 'Moniteur Gaming', 'LC2FASUS', 'ASUS BE27AQLB Business Monitor - 68,58 cm (27?) WQHD(2560x1440), IPS, HDMI, DisplayPort, design sans cadre, kit de montage pour mini-PC, technologie sans scintillement et � faible luminosit� bleue, support ergonomique.
68,58 cm (27?) Moniteur IPS WQHD avec un design sans cadre et un grand angle de vue pour une reproduction brillante de l image depuis n importe quelle position.'
 , 'ASUS', 290.90, 0,'https://media.ldlc.com/r1600/ld/products/00/05/18/54/LD0005185407_2.jpg');
 
 INSERT INTO PRODUIT VALUES (3, 'Moniteur business', 'LC3FACER', 'La nouvelle s�rie Acer EB1 offre aux utilisateurs multim�dia exigeants le nec plus ultra des �crans haut de gamme avec une r�solution de 2K de 2 560 x 1 440 pixels.
La s�rie EB1 d Acer �tablit �galement de nouvelles normes en mati�re de saturation et de qualit� des couleurs gr�ce � la technologie IPS.
La conception extraordinaire de l �cran fait �galement de ce dernier un v�ritable accroche-regard optique.'
, 'ACER', 190.00,  0, 'https://media.ldlc.com/r1600/ld/products/00/04/86/84/LD0004868443_2.jpg');

 INSERT INTO PRODUIT VALUES (4, 'Moniteur business', 'LC4FDELL', 'Reproduction graphique de premi�re classe : la courbure optimis�e de l �cran am�liore le champ de vision, r�duit les reflets et cr�e un point de vue presque uniforme. Vous n avez pas besoin de bouger vos yeux autant et vous pouvez travailler confortablement plus longtemps.
 Approfondissez votre travail : la vue p�riph�rique am�lior�e sur cet �cran cr�e des vues panoramiques d une profondeur, d une largeur et d une largeur incroyables qui vous aident � vous concentrer sur votre travail. Divertissant � l infini : Vivez une vue panoramique � l image d un cin�ma avec cet �cran incurv�.
 Un seul c�ble. Nombreuses applications : La connectivit� Usb-C vous permet de connecter votre ordinateur portable au moniteur et de charger jusqu � 90 Wi � partir d une source unique, prot�g�e par le parafoudre int�gr� de Dell. 
 R�pondez � tous vos besoins - vid�o, donn�es, alimentation - avec un seul c�ble tout en r�duisant l encombrement des c�bles.'
, 'DELL', 380.90,  0, 'https://media.ldlc.com/r1600/ld/products/00/05/16/81/LD0005168106_2.jpg');

 INSERT INTO PRODUIT VALUES (5, 'Moniteur business', 'LC5FDELL', 'Reproduction graphique de premi�re classe : la courbure optimis�e de l �cran am�liore le champ de vision, r�duit les reflets et cr�e un point de vue presque uniforme. Vous n avez pas besoin de bouger vos yeux autant et vous pouvez travailler confortablement plus longtemps.
 Approfondissez votre travail : la vue p�riph�rique am�lior�e sur cet �cran cr�e des vues panoramiques d une profondeur, d une largeur et d une largeur incroyables qui vous aident � vous concentrer sur votre travail. Divertissant � l infini : Vivez une vue panoramique � l image d un cin�ma avec cet �cran incurv�.
 Un seul c�ble. Nombreuses applications : La connectivit� Usb-C vous permet de connecter votre ordinateur portable au moniteur et de charger jusqu � 90 Wi � partir d une source unique, prot�g�e par le parafoudre int�gr� de Dell. 
 R�pondez � tous vos besoins - vid�o, donn�es, alimentation - avec un seul c�ble tout en r�duisant l encombrement des c�bles.'
, 'DELL', 480.90,  0, 'https://media.ldlc.com/r1600/ld/products/00/05/09/74/LD0005097455_2.jpg');

INSERT INTO PRODUIT VALUES (6, 'Moniteur Gaming', 'LC6FSUNG', 'La s�rie SH650 sa dapte � tout environnement de travail, avec sa dalle PLS haut de gamme qui affiche les textes de mani�re ultra-pr�cise et les images de fa�on cristalline, peu importe d o� vous regardiez l �cran.
Le mode eye saver r�duit les �missions de lumi�re bleue qui sont connues pour agresser la r�tine, diminuant ainsi votre fatigue oculaire lorsque vous travaillez pendant de longues heures.
La s�rie SH650 dispose d une technologie d �conomie d �nergie � la pointe de l innovation, incluant le Smart Eco Saving qui ajuste la luminosit� automatiquement en fonction des couleurs affich�es, ainsi qu une fonction 0 watts, r�duisant la consommation de l �cran au maximum lorsque l �cran est �teint.', 'SAMSUNG', 226.00, 0, 'https://media.ldlc.com/r1600/ld/products/00/04/99/77/LD0004997772_2.jpg');

 INSERT INTO PRODUIT VALUES (7, 'Moniteur business', 'LC7FLG', 'La latence, les stries et les secousses appartiennent au pass� avec une fr�quence d image de 165 Hz (overclock). Les caract�ristiques du stabilisateur noir, du mode DAS, des modes de jeu et du r�ticule en font un v�ritable gagnant.'
, 'LG', 449.00, 0, 'https://media.ldlc.com/r1600/ld/products/00/05/66/81/LD0005668103_2.jpg');

 INSERT INTO PRODUIT VALUES (8, 'Moniteur Gaming', 'LC8FAOC', 'Plongez au c�ur de vos univers de jeu gr�ce au design Curved et d�couvrez-les dans des couleurs �clatantes gr�ce au panneau VA. Profitez d une exp�rience de jeu incroyablement fluide et � faible retard avec un temps de r�ponse de 1 ms et un taux de rafra�chissement de 144 Hz. 
 Gr�ce � son support ergonomique flexible et � ses diff�rentes technologies pour prot�ger vos yeux, ce moniteur est plus que pr�t pour de longues sessions de jeu. Ce moniteur a une surface d affichage incurv�e, la conception dite incurv�e. Compar� aux �crans plats, il remplit une zone plus large de votre champ de vision avec la m�me diagonale d affichage. 
 Cela cr�e un effet panoramique impressionnant et garantit une lisibilit� optimale jusqu au bord.',
 'AOC', 328.00,  0, 'https://media.ldlc.com/r1600/ld/products/00/04/95/66/LD0004956659_2_0004956856.jpg');
 
 INSERT INTO PRODUIT VALUES (9, 'Moniteur busines', 'LC9ASUS', 'Con�u pour les jeux exigeants et rapides, l ASUS VG278Q est un moniteur Full HD de 68,58 cm (27 pouces) avec un temps de r�ponse ultra-rapide de 1ms et une fr�quence d image rapide de 144Hz pour un gameplay fluide. 
 Le VG278Q est dot� de la technologie Adaptive Sync(FreeSync) pour �liminer les d�chirures et les fr�quences d images instables. Des fonctions de jeu sp�ciales, telles que ASUS GamePlus, am�liorent votre exp�rience de jeu. En outre, GameVisual propose diff�rents modes d affichage pr�d�finis
 afin d optimiser les graphismes pour diff�rents types de jeux.',
 'ASUS', 180.00,  0, 'https://media.ldlc.com/r1600/ld/products/00/03/30/72/LD0003307295_2.jpg');
 
  INSERT INTO PRODUIT VALUES (10, 'Moniteur busines', 'LC10DELL', 'Excellente optique D�tails impeccables : Chaque image prend vie sur cet �cran de 27 (68,6 cm). Gr�ce � QHD avec une r�solution de 2 560 x 1 440, vous obtenez 1,77 fois plus de d�tails qu avec la Full HD.
Consistance des couleurs en standard : Le moniteur UltraSharp est calibr� en usine � 99% sRGB. Avec une valeur Delta E inf�rieure � 2, des couleurs pr�cises sont obtenues d�s le d�part. De plus, avec une couverture d encre � 99% Rec709 et 85% DCI-P3, vous verrez des couleurs r�alistes en format vid�o.
Toujours la meilleure vue : la technologie IPS (In-Plane Switching) permet d obtenir des couleurs �clatantes et constantes sur un large angle de vue.',
 'DELL', 280.00,  0, 'https://media.ldlc.com/r1600/ld/products/00/05/14/72/LD0005147258_2_0005243992.jpg');


COMMIT;

-- ====================================================
-- Insertion Table : LIGNE_COMMANDE
-- ====================================================
INSERT INTO LIGNE_COMMANDE VALUES (1, 2, 1, 300.00);
INSERT INTO LIGNE_COMMANDE VALUES (2, 10, 1, 180.00);
INSERT INTO LIGNE_COMMANDE VALUES (3, 6, 1, 226.00);
INSERT INTO LIGNE_COMMANDE VALUES (4, 3, 1, 190.00);
INSERT INTO LIGNE_COMMANDE VALUES (6, 4, 1, 300);
INSERT INTO LIGNE_COMMANDE VALUES (5, 2, 1, 300);
INSERT INTO LIGNE_COMMANDE VALUES (7, 5, 1, 300);
INSERT INTO LIGNE_COMMANDE VALUES (8, 2, 1, 300);
INSERT INTO LIGNE_COMMANDE VALUES (9, 2, 1, 300);
INSERT INTO LIGNE_COMMANDE VALUES (10, 2, 1, 300);
INSERT INTO LIGNE_COMMANDE VALUES (11, 2, 1, 300);
INSERT INTO LIGNE_COMMANDE VALUES (12, 2, 1, 300);
INSERT INTO LIGNE_COMMANDE VALUES (13, 2, 1, 300);
INSERT INTO LIGNE_COMMANDE VALUES (14, 2, 1, 300);
INSERT INTO LIGNE_COMMANDE VALUES (15, 2, 1, 300);

COMMIT;
-- ====================================================
-- Insertion Table : EVALUATION
-- ====================================================

INSERT INTO EVALUATION VALUES (1, 2, 'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (10, 5,'Nul', 'Produit nul');
INSERT INTO EVALUATION VALUES (3, 3, 'Tr�s bien', 'Tr�s bon produit');
INSERT INTO EVALUATION VALUES (9, 6, 'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (2, 7, 'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (2, 8, 'Moyen', 'Produit moyen');
INSERT INTO EVALUATION VALUES (10, 4, 'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (2, 3,'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (4, 7, 'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (7, 9, 'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (5, 9, 'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (7, 4, 'Nul', 'Produit nul');
INSERT INTO EVALUATION VALUES (6, 5, 'Moyen', 'Produit moyen');
INSERT INTO EVALUATION VALUES (6, 8, 'Moyen', 'Prduit moyen');
INSERT INTO EVALUATION VALUES (1, 3, 'Nul', 'Produit nul');
INSERT INTO EVALUATION VALUES (1, 5, 'Moyen', 'Produit moyen');
INSERT INTO EVALUATION VALUES (7, 7, 'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (8, 1, 'Moyen', 'Produit moyen');
INSERT INTO EVALUATION VALUES (10, 10, 'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (10, 3, 'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (3, 10, 'Bien', 'Bon produit');
INSERT INTO EVALUATION VALUES (4, 2, 'Nul', 'Produit nul');


COMMIT;

--SELECT * FROM UTILISATEUR;
--SELECT * FROM COMMANDE;
--SELECT * FROM PRODUIT;
--SELECT * FROM LIGNE_COMMANDE;
--SELECT * FROM EVALUATION;


--JEU DE DONNEE
--CONTRAINTE NULLITE(NOT NULL)
--INSERT INTO UTILISATEUR VALUES (50, 'Dupont', NULL, 'Chemin de la patrie 3', 1254, 'jdp@outlook.com', 'test', 0, 0);
--INSERT INTO COMMANDE VALUES (50, 1, 100,  NULL,'En preparation', 300.00);
--INSERT INTO PRODUIT VALUES (50, 'Moniteur Gaming', 'LC1FMSUNG', 'Parfaitement adapt� pour les joueurs, m�me les plus exigeants, ce mod�le affiche un taux de rafra�chissement de 100 Hz pour des ralentissements r�duits au minimum et un temps de r�ponse de 4 ms pour des sc�nes d action sans aucun flou.', 'SAMSUNG', 300.00, NULL);
--INSERT INTO LIGNE_COMMANDE VALUES (1, 2, 1, NULL);
--INSERT INTO EVALUATION VALUES (NULL, 2, 'Nul', 'Produit nul');
--CONTRAINTE UNICITE (ID UNIQUE)
--INSERT INTO UTILISATEUR VALUES (1, 'Dupont', 'Jean', 'Chemin de la patrie 3', 1254, 'jdp@outlook.com', 'test', 0, 0);
--INSERT INTO COMMANDE VALUES (1, 1, 100,  TO_DATE('2020-7-02','YYYY-MM-DD'),'En preparation', 300.00);
--INSERT INTO PRODUIT VALUES (1, 'Moniteur Gaming', 'LC1FMSUNG', 'Parfaitement adapt� pour les joueurs, m�me les plus exigeants, ce mod�le affiche un taux de rafra�chissement de 100 Hz pour des ralentissements r�duits au minimum et un temps de r�ponse de 4 ms pour des sc�nes d action sans aucun flou.', 'SAMSUNG', 300.00, 'https://asset.conrad.com/media10/isa/160267/c1/-/fr/1591987_BB_02_LO/moniteur-led-samsung-c24f396fhu-lc24f396fhuxen-59-7-cm-23-5-pouces-eec-a-a-d-1920-x-1080-pixels-full-hd-4-ms-vg.jpg?x=300&'||'y=300&'||'format=jpg&'||'ex=300&'||'ey=300&'||'align=center');
--INSERT INTO LIGNE_COMMANDE VALUES (1, 2, 1, 300.00);
--INSERT INTO EVALUATION VALUES (1, 2, 'Bien', 'Bon produit');
--CONTRAINTE TYPE DE DONNEES
--INSERT INTO UTILISATEUR VALUES (100, 'Dupont', 'Jean', 'Chemin de la patrie 3', 'douze', 'jdp@outlook.com', 'test', 0, 0);
--INSERT INTO COMMANDE VALUES (1, 1, 'CENT',  TO_DATE('2020-7-02','YYYY-MM-DD'),'En preparation', 300.00);
--INSERT INTO PRODUIT VALUES (1, 1, 'LC1FMSUNG', 'Parfaitement adapt� pour les joueurs, m�me les plus exigeants, ce mod�le affiche un taux de rafra�chissement de 100 Hz pour des ralentissements r�duits au minimum et un temps de r�ponse de 4 ms pour des sc�nes d action sans aucun flou.', 'SAMSUNG', 300.00, 'https://asset.conrad.com/media10/isa/160267/c1/-/fr/1591987_BB_02_LO/moniteur-led-samsung-c24f396fhu-lc24f396fhuxen-59-7-cm-23-5-pouces-eec-a-a-d-1920-x-1080-pixels-full-hd-4-ms-vg.jpg?x=300&'||'y=300&'||'format=jpg&'||'ex=300&'||'ey=300&'||'align=center');
--INSERT INTO LIGNE_COMMANDE VALUES (1, 'DEUX', 1, 300.00);
--INSERT INTO EVALUATION VALUES (1, 'DEUX', 'Bien', 'Bon produit');
--CONTRAINTE LONGEUR D'UN CHAMPS
--INSERT INTO UTILISATEUR VALUES (10000, 'Dupont', 'Jean', 'Chemin de la patrie 3', 'douze', 'jdp@outlook.com', 'test', 0, 0);
--INSERT INTO COMMANDE VALUES (50, 2, 1000,  TO_DATE('2020-7-02','YYYY-MM-DD'),'En preparation', 300.00);
--INSERT INTO PRODUIT VALUES (50, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut lacus mi, blandit a semper rhoncus, luctus at sapien. In in nulla nec odio porta fringilla. Morbi sagittis odio nisl, blandit laoreet dolor accumsan vel. Curabitur accumsan velit vel pretium sodales. Proin nec nisl mauris. Vestibulum cursus, magna sit amet auctor vehicula, enim ligula venenatis sapien, id bibendum sem arcu a est. Nullam non sodales metus. Curabitur quam neque, commodo et efficitur a, euismod eu est. Cras mi libero, consequat quis rutrum in, pulvinar a erat. Nam luctus sodales nisi, ac aliquam orci ullamcorper ut. Praesent sollicitudin diam sed justo interdum ornare. Suspendisse blandit enim est, ut euismod neque pellentesque ut.', 'LC1FMSUNG', 'Parfaitement adapt� pour les joueurs, m�me les plus exigeants, ce mod�le affiche un taux de rafra�chissement de 100 Hz pour des ralentissements r�duits au minimum et un temps de r�ponse de 4 ms pour des sc�nes d action sans aucun flou.', 'SAMSUNG', 300.00, 'https://asset.conrad.com/media10/isa/160267/c1/-/fr/1591987_BB_02_LO/moniteur-led-samsung-c24f396fhu-lc24f396fhuxen-59-7-cm-23-5-pouces-eec-a-a-d-1920-x-1080-pixels-full-hd-4-ms-vg.jpg?x=300&'||'y=300&'||'format=jpg&'||'ex=300&'||'ey=300&'||'align=center');
--INSERT INTO LIGNE_COMMANDE VALUES (51, 2, 1, 300000000000000000000000000000000000000.00);
--INSERT INTO EVALUATION VALUES (1, 2, 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut lacus mi, blandit a semper rhoncus, luctus at sapien. In in nulla nec odio porta fringilla. Morbi sagittis odio nisl, blandit laoreet dolor accumsan vel. Curabitur accumsan velit vel pretium sodales. Proin nec nisl mauris. Vestibulum cursus, magna sit amet auctor vehicula, enim ligula venenatis sapien, id bibendum sem arcu a est. Nullam non sodales metus. Curabitur quam neque, commodo et efficitur a, euismod eu est. Cras mi libero, consequat quis rutrum in, pulvinar a erat. Nam luctus sodales nisi, ac aliquam orci ullamcorper ut. Praesent sollicitudin diam sed justo interdum ornare. Suspendisse blandit enim est, ut euismod neque pellentesque ut.', 'Bon produit');
--CONTRAINTE CLE ETRANGERE
--INSERT INTO EVALUATION VALUES (50, 2, NULL, 'Bon produit');
--INSERT INTO LIGNE_COMMANDE VALUES (1, 202, 1, 300.00);











