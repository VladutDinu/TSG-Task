
CREATE PROCEDURE JoinOne_To_One
AS
SELECT Personal_TSG.ID, Personal_TSG.Nume, Venit_Personal_TSG.Venit
FROM Personal_TSG
INNER JOIN Venit_Personal_TSG ON Personal_TSG.ID=Venit_Personal_TSG.ID_Personal;
GO


exec JoinOne_To_One




