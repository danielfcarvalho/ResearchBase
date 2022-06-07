-- CRIAÇÃO DAS TABELAS

CREATE TABLE Estudo(
    Codigo					  int,
    Titulo					  varchar(50),
    Estado					  int,
    Data					  date,
    Num_Part				  int,
    Num_Vagas				  int,
    Renum					  money,
    CC_Inv					  char(8),

    PRIMARY KEY (Codigo),
);

CREATE TABLE Tipo_Estado(
	Codigo					INT,
	Tipo					VARCHAR(50),

	PRIMARY KEY(Codigo)
)

CREATE TABLE Ensaio_Clinico(
    Codigo					 int,
    Cod_Inf					 char(8),
    Cod_CEIC				 char(8),
    Cod_Proc				 char(8),
    Follow_Up			     Bit,
    Num_Tomas			     int,
    Cod_Tipo				 int,

    PRIMARY KEY (Codigo),
);

CREATE TABLE Estudo_Investigacao(
    Cod_Est					 int,
    Cod_Tipo				 int,
    Num_Sessoes			     int,

    PRIMARY KEY (Cod_Est),
);

CREATE TABLE Participante(
    ID						 int,
    CC						 char(8),
    Email					 varchar(100),
    IBAN					 char(25),
    NIF						 char(9),
    Data_nasc			     date,
    Genero					 char(1),
    Localidade				 varchar(100),
    Renum_Total				 money,
    Idade					 int,
    Cod_Analises			 char(8),

	PRIMARY KEY(ID)
)

CREATE TABLE Participa_EC(
	ID_Participante			INT,
	Cod_Estudo				INT,
	Cod_Consentimento		CHAR(8),

	PRIMARY KEY(ID_Participante, Cod_Estudo)
)

CREATE TABLE Participa_EI(
	ID_Participante			INT,
	Cod_Estudo				INT,
	Cod_Consentimento		CHAR(8),

	PRIMARY KEY(ID_Participante, Cod_Estudo)
)

CREATE TABLE Tipo_EC(
	Codigo					INT,
	Tipo					VARCHAR(50),

	PRIMARY KEY(Codigo)
)

CREATE TABLE Tipo_EI(
	Codigo					INT,
	Tipo					VARCHAR(50),

	PRIMARY KEY(Codigo)
)

CREATE TABLE Farmaceutica(
	Cod_Ref					CHAR(8),
	Nome					VARCHAR(50),
	Endereco				VARCHAR(100),
	Num_telefone			CHAR(9),
	
	PRIMARY KEY(Cod_Ref)
)

CREATE TABLE Farmaco(
	Cod_GTIN				CHAR(14),
	Ref_Farmaceutica		CHAR(8),
	Nome					VARCHAR(50),
	Cod_Formula				CHAR(8),
	Subst_Ativa				VARCHAR(50),

	PRIMARY KEY(Cod_GTIN)
)

CREATE TABLE EC_Farmaco(
	Cod_GTIN_Farmaco		CHAR(14),
	Cod_Estudo				int,

	PRIMARY KEY(Cod_GTIN_Farmaco, Cod_Estudo)
)

CREATE TABLE Investigador(
	CC						CHAR(8),
	Nome					VARCHAR(50),
	Email					VARCHAR(100),
	Num_Estudos				INT			DEFAULT 0,
	EntPatronal				INT,

	PRIMARY KEY(CC),
	CHECK(Num_Estudos > 0)
)

CREATE TABLE EntPatronal(
	Num_Registo				INT,
	Nome					VARCHAR(50),
	Endereco				VARCHAR(100),
	Num_telefone			CHAR(9),
	IBAN					CHAR(25),
	NIF						CHAR(9),
	Tipo_EntPatronal		INT,

	PRIMARY KEY(Num_Registo)
)

CREATE TABLE Tipo_EntPatronal(
	Codigo					INT,
	Tipo					VARCHAR(50),

	PRIMARY KEY(Codigo)
)


-- RESTRIÇÕES FOREIGN KEY
-- Estudo
ALTER TABLE Estudo ADD CONSTRAINT FK_Estudo_Investigador FOREIGN KEY (CC_Inv) REFERENCES Investigador (CC) ON UPDATE CASCADE ON DELETE set null;
ALTER TABLE Estudo ADD CONSTRAINT FK_Estudo_Tipo FOREIGN KEY (Estado) REFERENCES Tipo_Estado(Codigo) ON UPDATE CASCADE ON DELETE set null;

--Ensaio_Clinico
ALTER TABLE Ensaio_Clinico ADD CONSTRAINT FK_Estudo_EC FOREIGN KEY (Codigo) REFERENCES Estudo (Codigo) ON UPDATE CASCADE ON DELETE CASCADE;
ALTER TABLE Ensaio_Clinico ADD CONSTRAINT FK_Ensaio_Tipo FOREIGN KEY (Cod_Tipo) REFERENCES Tipo_EC (Codigo) ON UPDATE CASCADE ON DELETE set null;

--Estudo_Investigacao
ALTER TABLE Estudo_Investigacao ADD CONSTRAINT FK_Estudo_EI FOREIGN KEY (Cod_Est) REFERENCES Estudo (Codigo) ON UPDATE CASCADE ON DELETE CASCADE;
ALTER TABLE Estudo_Investigacao ADD CONSTRAINT FK_EC_Tipo FOREIGN KEY (Cod_Tipo) REFERENCES Tipo_EI (Codigo) ON UPDATE CASCADE ON DELETE set null;

alter table Participa_EC
		add constraint FK_ParticipaEC_Participante foreign key (ID_Participante) references Participante(ID) on update cascade on delete cascade;

alter table Participa_EC
		add constraint FK_ParticipaEC_ParticipanteII foreign key (Cod_Estudo) references Estudo(Codigo) on update cascade on delete cascade;

alter table Participa_EI
		add constraint FK_ParticipaEI_Participante foreign key (ID_Participante) references Participante(ID) on update cascade on delete cascade;

alter table Participa_EI
		add constraint FK_ParticipaEI_Estudante foreign key (Cod_Estudo) references Estudo(Codigo) on update cascade on delete cascade;

alter table Farmaco
		add constraint FK_Farmaco_Farmaceutica foreign key (Ref_Farmaceutica) references Farmaceutica(Cod_Ref) on update cascade on delete set null;

alter table EC_Farmaco
		add constraint FK_ECFarmaco_Farmaco foreign key (Cod_GTIN_Farmaco) references Farmaco(Cod_GTIN) on update cascade on delete cascade;

alter table EC_Farmaco
		add constraint FK_ECFarmaco_FarmacoII foreign key (Cod_Estudo) references Estudo(Codigo) on update cascade on delete cascade;

alter table Investigador
		add constraint FK_Investigador_EntPatronal foreign key (EntPatronal) references EntPatronal(Num_Registo) on update cascade on delete set null;

alter table EntPatronal
		add constraint FK_EntPatronal_Tipo foreign key (Tipo_EntPatronal) references Tipo_EntPatronal(Codigo) on update cascade on delete set null;