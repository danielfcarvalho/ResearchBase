-- Vistas sobre os Ensaios Clinicos realizados no último ano, e os Participantes destes estudos
CREATE VIEW EC_Anual
AS
	SELECT Estudo.Codigo, Renum, Estado, Num_Part, Num_Vagas, CC_Inv, Phase_StartDate FROM (Estudo JOIN Ensaio_Clinico ON Estudo.Codigo = Ensaio_Clinico.Codigo) WHERE Phase_StartDate BETWEEN DATEFROMPARTS(YEAR(GETDATE()), 1, 1) AND GETDATE()
	

CREATE VIEW Participante_ECAnual
AS
    SELECT ID, COUNT(ID) AS AnnualStudies, SUM(Renum) AS AnnualPay
		FROM (Participante LEFT OUTER JOIN Participa_EC ON ID = ID_Participante) JOIN EC_Anual ON Cod_Estudo = Codigo
		GROUP BY ID

-- Vista que junta a lista de participantes de Ensaios Clinicos com a lista de participantes de Estudos de Investigação
-- de maneira a permitir operações comuns a ambos os tipos de estudo

CREATE VIEW Lista_Participantes
AS
	(SELECT * FROM Participa_EC) UNION (SELECT * FROM Participa_EI)

-- Vistas que apresentam a informação completa de Ensaios Clínicos e Estudos de Investigação (Junta os atributos da classes
-- Estudo e das suas subclasses)

CREATE VIEW EC_Total
AS
	SELECT Estudo.Codigo, Titulo, Estado, Num_Part, Num_Vagas, Renum, CC_Inv, Phase_StartDate, Follow_Up, Num_Tomas, Cod_Tipo, Cod_Inf, Cod_CEIC, Cod_Proc FROM (Estudo JOIN Ensaio_Clinico ON Estudo.Codigo = Ensaio_Clinico.Codigo)

CREATE VIEW EI_Total
AS
	SELECT Estudo.Codigo, Titulo, Estado, Num_Part, Num_Vagas, Renum, CC_Inv, Phase_StartDate, Cod_Tipo, Num_Sessoes FROM (Estudo JOIN Estudo_Investigacao ON Estudo.Codigo = Cod_Est)


