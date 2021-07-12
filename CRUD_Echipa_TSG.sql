CREATE PROCEDURE SelectEchipe_TSG
AS

SELECT * FROM Echipe_TSG;
GO

CREATE PROCEDURE CreateEchipe_TSG  @ID_TeamLeader int
AS

Insert into Echipe_TSG values
	(@ID_TeamLeader);
GO


CREATE PROCEDURE DeleteEchipe_TSG @ID_Echipa varchar(255)
AS
Delete from dbo.Echipe_TSG where ID_Echipa=@ID_Echipa;
GO

CREATE PROCEDURE UpdateEchipe_TSG @ID_Echipa int, @ID_TeamLeader int
AS
Update dbo.Echipe_TSG set ID_TeamLeader=@ID_TeamLeader where ID_Echipa=@ID_Echipa;
GO




