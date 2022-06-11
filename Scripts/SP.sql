GO
CREATE PROC Add_Participant_EC @ID_Part INT, @Cod_Est INT
AS
	DECLARE @Consent AS CHAR(8);
	SET @Consent = SUBSTRING(CONVERT(VARCHAR(255), NEWID()), 0, 9);
	INSERT INTO Participa_EC VALUES (@ID_Part, @Cod_Est, @Consent);
GO


GO
CREATE PROC Add_Participant_EI @ID_Part INT, @Cod_Est INT
AS
	DECLARE @Consent AS CHAR(8);
	SET @Consent = SUBSTRING(CONVERT(VARCHAR(255), NEWID()), 0, 7);
	INSERT INTO Participa_EI VALUES (@ID_Part, @Cod_Est, @Consent);
GO