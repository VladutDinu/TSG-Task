
CREATE PROCEDURE JoinOne_To_Many
AS
SELECT Personal_TSG.ID, Personal_TSG.Nume, Echipe_TSG.ID_Echipa, Echipe_TSG.ID_TeamLeader
FROM Echipe_TSG
INNER JOIN Personal_TSG ON Personal_TSG.ID=Echipe_TSG.ID_TeamLeader;
GO


exec JoinOne_To_Many




