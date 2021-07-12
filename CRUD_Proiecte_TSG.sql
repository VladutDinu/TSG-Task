CREATE PROCEDURE SelectProiecte_TSG
AS

SELECT * FROM Proiecte_TSG;
GO

CREATE PROCEDURE CreateProiecte_TSG @Proiect varchar(255)
AS

Insert into Proiecte_TSG values
	(@Proiect);
GO


CREATE PROCEDURE DeleteProiecte_TSG @Proiect varchar(255)
AS
Delete from dbo.Proiecte_TSG where Proiect=@Proiect;
GO

CREATE PROCEDURE UpdateProiecte_TSG @Proiect varchar(255)
AS
Update dbo.Proiecte_TSG set Proiect=@Proiect where Proiect=@Proiect;
GO




