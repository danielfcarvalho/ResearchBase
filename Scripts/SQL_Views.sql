--
CREATE VIEW EC_Anual
AS
	SELECT Estudo.Codigo, Renum, Estado, Num_Part, Num_Vagas, CC_Inv, Phase_StartDate FROM (Estudo JOIN Ensaio_Clinico ON Estudo.Codigo = Ensaio_Clinico.Codigo) WHERE Phase_StartDate BETWEEN DATEFROMPARTS(YEAR(GETDATE()), 1, 1) AND GETDATE()
	

CREATE VIEW Participante_EC
AS
	SELECT * FROM (Participante LEFT OUTER JOIN Participa_EC ON ID = ID_Participante) JOIN EC_Anual ON Cod_Estudo = Codigo

