-- Vistas sobre os Ensaios Clinicos realizados no último ano, e os Participantes destes estudos
CREATE VIEW EC_Anual
AS
	SELECT Estudo.Codigo, Renum, Estado, Num_Part, Num_Vagas, CC_Inv, Phase_StartDate FROM (Estudo JOIN Ensaio_Clinico ON Estudo.Codigo = Ensaio_Clinico.Codigo) WHERE Phase_StartDate BETWEEN DATEFROMPARTS(YEAR(GETDATE()), 1, 1) AND GETDATE()
	

CREATE VIEW Participante_ECAnual
AS
	SELECT * FROM (Participante LEFT OUTER JOIN Participa_EC ON ID = ID_Participante) JOIN EC_Anual ON Cod_Estudo = Codigo

-- Vista que junta a lista de participantes de Ensaios Clinicos com a lista de participantes de Estudos de Investigação
-- de maneira a permitir operações comuns a ambos os tipos de estudo

CREATE VIEW Lista_Participantes
AS
	(SELECT * FROM Participa_EC) UNION (SELECT * FROM Participa_EI)

