-- Pagamento do Estudo aos Participantes inscritos

GO
CREATE TRIGGER acceptEC ON Participa_EC
AFTER INSERT
AS
	BEGIN
		DECLARE @ID AS INT;
		DECLARE @Cod AS INT;
		DECLARE @pay AS MONEY;

		SELECT @ID = ID_Participante FROM inserted;
		SELECT @Cod = Cod_Estudo FROM inserted;

		SELECT @pay = renum FROM Estudo WHERE Codigo = @Cod;
		UPDATE Participante SET Renum_Total = Renum_Total + @pay WHERE ID = @ID;
		UPDATE Estudo SET Num_Part = Num_Part + 1 WHERE Codigo = @Cod;
	END
GO

GO
CREATE TRIGGER acceptEI ON Participa_EI
AFTER INSERT
AS
	BEGIN
		DECLARE @ID AS INT;
		DECLARE @Cod AS INT;
		DECLARE @pay AS MONEY;

		SELECT @ID = ID_Participante FROM inserted;
		SELECT @Cod = Cod_Estudo FROM inserted;

		SELECT @pay = renum FROM Estudo WHERE Codigo = @Cod;
		UPDATE Participante SET Renum_Total = Renum_Total + @pay WHERE ID = @ID;
		UPDATE Estudo SET Num_Part = Num_Part + 1 WHERE Codigo = @Cod;
	END
GO

