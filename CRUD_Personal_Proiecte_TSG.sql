CREATE PROCEDURE SelectPersonal_Proiecte_TSG
AS

SELECT * FROM Personal_Proiecte_TSG;
GO

CREATE PROCEDURE CreatePersonal_Proiecte_TSG @ID_Personal int, @ID_Proiect int
AS

Insert into Personal_Proiecte_TSG values
	(@ID_Personal, @ID_Proiect);
GO


CREATE PROCEDURE DeletePersonal_Proiecte_TSG @ID_Proiect int
AS
Delete from dbo.Personal_Proiecte_TSG where ID_Proiect=@ID_Proiect;
GO

CREATE PROCEDURE UpdatePersonal_Proiecte_TSG @ID_Personal int, @ID_Proiect int
AS
Update dbo.Personal_Proiecte_TSG set ID_Personal=@ID_Personal where ID_Proiect=@ID_Proiect;
GO




