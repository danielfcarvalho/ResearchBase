-- Cálculo da Idade de um novo Participante

GO
CREATE TRIGGER insertParticipant ON Participante
AFTER INSERT
AS
	BEGIN
		DECLARE @NewId AS int;
		DECLARE @Age AS int;
		SELECT @NewId = ID, @Age = DATEDIFF(year, Data_nasc, GetDate()) FROM inserted;
		UPDATE Participante SET Idade = @Age WHERE ID = @NewId;
	END
GO

-- Incremento do número total de estudos de um Investigador associado a um novo Estudo

GO
CREATE TRIGGER insertStudy ON Estudo
AFTER INSERT
AS
	BEGIN
		DECLARE @CC_Inv AS char(8);
		SELECT @CC_Inv = CC_Inv FROM inserted;
		UPDATE Investigador SET Num_Estudos = Num_Estudos + 1 WHERE CC = @CC_Inv;
	END
GO

-- Participante recrutado para um novo estudo

GO
CREATE TRIGGER acceptEC ON Participa_EC
AFTER INSERT
AS
	BEGIN
		DECLARE @Cod AS INT;

		SELECT @Cod = Cod_Estudo FROM inserted;

		UPDATE Estudo SET Num_Part = Num_Part + 1 WHERE Codigo = @Cod;
	END
GO

GO
CREATE TRIGGER acceptEI ON Participa_EI
AFTER INSERT
AS
	BEGIN
		DECLARE @Cod AS INT;

		SELECT @Cod = Cod_Estudo FROM inserted;

		UPDATE Estudo SET Num_Part = Num_Part + 1 WHERE Codigo = @Cod;
	END
GO

