--
CREATE VIEW EC_Anual
AS
	SELECT * FROM Estudo WHERE Phase_StartDate BETWEEN DATEFROMPARTS(YEAR(GETDATE()), 1, 1) AND GETDATE()


CREATE VIEW Participante_EC
AS
	SELECT * FROM (Participante LEFT OUTER JOIN Participa_EC ON ID = ID_Participante) JOIN EC_Anual ON Cod_Estudo = Codigo
