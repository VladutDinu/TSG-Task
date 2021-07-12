
CREATE PROCEDURE JoinMany_To_Many
AS
SELECT Personal_TSG.ID, Personal_TSG.Nume, Personal_TSG.ID_Proiect, Personal_Proiecte_TSG.ID_Personal
FROM Personal_TSG
INNER JOIN Personal_Proiecte_TSG ON Personal_TSG.ID=Personal_Proiecte_TSG.ID_Personal;
GO


exec JoinMany_To_Many




