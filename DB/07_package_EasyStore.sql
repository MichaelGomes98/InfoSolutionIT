create or replace package pkg_statistiqueVente
AS
       FUNCTION StatVente RETURN INTEGER;
END;

/

create or replace package body pkg_statistiqueVente
AS

FUNCTION StatVente RETURN INTEGER
AS
         TOTAL INTEGER;
BEGIN
         SELECT COUNT(*) into TOTAL FROM COMMANDE WHERE COM_STATUT <> 'Panier' AND COM_STATUT <> 'Annulé';
         RETURN TOTAL;
END StatVente;
END pkg_statistiqueVente;
/
GRANT EXECUTE ON pkg_statistiqueVente TO role_EasyStore_user;

BEGIN
  dbms_output.put_line('Le nombre total de commande est : ' || pkg_statistiqueVente.StatVente());
END;