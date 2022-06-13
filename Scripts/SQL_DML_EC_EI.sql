-- Inserção dos Ensaios Clinicos
insert into Ensaio_Clinico (Codigo, Cod_Inf, Cod_CEIC, Cod_Proc, Follow_Up, Num_Tomas, Cod_Tipo) values (19, 'Q7vN8soc', 'cMpWAhb7', 'gcLi9dVM', 1, 1, 1);
insert into Ensaio_Clinico (Codigo, Cod_Inf, Cod_CEIC, Cod_Proc, Follow_Up, Num_Tomas, Cod_Tipo) values (2, 'UbfqnPmC', 'S3N6KDdh', 'sLCgOI9B', 0, 2, 2);
insert into Ensaio_Clinico (Codigo, Cod_Inf, Cod_CEIC, Cod_Proc, Follow_Up, Num_Tomas, Cod_Tipo) values (3, 'eCdiqn6E', 'UVViuQxG', 'WyyEorH1', 1, 2, 2);
insert into Ensaio_Clinico (Codigo, Cod_Inf, Cod_CEIC, Cod_Proc, Follow_Up, Num_Tomas, Cod_Tipo) values (13, 'wFmuovnL', 'KmbA3bQz', 'x7ZLmgC9', 0, 2, 2);
insert into Ensaio_Clinico (Codigo, Cod_Inf, Cod_CEIC, Cod_Proc, Follow_Up, Num_Tomas, Cod_Tipo) values (14, 'Lt8dNNJs', 'Uk41CXWf', 'LiWlN9bH', 1, 2, 2);
insert into Ensaio_Clinico (Codigo, Cod_Inf, Cod_CEIC, Cod_Proc, Follow_Up, Num_Tomas, Cod_Tipo) values (15, 'NhBnF4DX', 'fkeJ0FeU', 'BngM525C', 0, 2, 2);
insert into Ensaio_Clinico (Codigo, Cod_Inf, Cod_CEIC, Cod_Proc, Follow_Up, Num_Tomas, Cod_Tipo) values (7, 'VoeY0A7d', 'GwDp9YH4', 'UkS5WBFQ', 0, 1, 2);
insert into Ensaio_Clinico (Codigo, Cod_Inf, Cod_CEIC, Cod_Proc, Follow_Up, Num_Tomas, Cod_Tipo) values (8, '4hnOGhba', 'lCAlxMqy', '1xKUH4Sw', 1, 1, 1);
insert into Ensaio_Clinico (Codigo, Cod_Inf, Cod_CEIC, Cod_Proc, Follow_Up, Num_Tomas, Cod_Tipo) values (12, 'sZDsbecn', 'ijcuzTu1', 'vlzZfmHu', 1, 3, 2);

--	Inserção dos Fármacos associados a cada EC								  
insert into EC_Farmaco values ('02642583469279', 19)
insert into EC_Farmaco values ('06874475480910', 2)
insert into EC_Farmaco values ('14003295093623', 3)
insert into EC_Farmaco values ('16974468102693', 13)
insert into EC_Farmaco values ('22898272833807', 14)
insert into EC_Farmaco values ('23622893640843', 15)
insert into EC_Farmaco values ('27040238946071', 7)
insert into EC_Farmaco values ('29761133993398', 8)
insert into EC_Farmaco values ('34826975451911', 12)
insert into EC_Farmaco values ('43309238265490', 7)
insert into EC_Farmaco values ('52739968719349', 8)

-- Inserção dos Estudos de Investigação
insert into Estudo_Investigacao values (1, 4, 3);
insert into Estudo_Investigacao values (16, 2, 3);
insert into Estudo_Investigacao values (17, 3, 1);
insert into Estudo_Investigacao values (4, 3, 1);
insert into Estudo_Investigacao values (5, 1, 2);
insert into Estudo_Investigacao values (6, 4, 2);
insert into Estudo_Investigacao values (18, 3, 1);
insert into Estudo_Investigacao values (20, 4, 2);
insert into Estudo_Investigacao values (9, 1, 3);
insert into Estudo_Investigacao values (10, 3, 1);
insert into Estudo_Investigacao values (11, 3, 3);

-- Inserção dos Participantes nos Estudos
GO
DECLARE @i AS int = 1;
DECLARE @id AS int;

WHILE @i <= 80
	BEGIN
		SET @id = CAST(FLOOR(Rand()*(1000)) AS INT)
		EXEC Add_Participant_EI @id, 9
		SET @i += 1;
	END
GO
