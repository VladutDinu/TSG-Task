CREATE PROCEDURE SelectVenit_Personal_TSG
AS

SELECT * FROM Venit_Personal_TSG;
GO

CREATE PROCEDURE CreateVenit_Personal_TSG @ID_Personal int, @Venit float
AS

Insert into Venit_Personal_TSG values
	(@ID_Personal, @Venit);
GO


CREATE PROCEDURE DeleteVenit_Personal_TSG @ID_Personal int
AS
Delete from dbo.Venit_Personal_TSG where ID_Personal=@ID_Personal;
GO

CREATE PROCEDURE UpdateVenit_Personal_TSG @ID_Personal int, @Venit float
AS
Update dbo.Venit_Personal_TSG set Venit=@Venit where ID_Personal=@ID_Personal;
GO




