create database HROADS

use HROADS

create table Cliente (
idCliente tinyint primary key IDENTITY(1,1),
nomeDoCliente varchar (25)
);

create table Classe(
idClasse tinyint primary key IDENTITY (1,1),
NomeDaClasse varchar(80)
);

CREATE TABLE Personagens(
	idPersonagens TINYINT PRIMARY KEY IDENTITY(1,1),
	idClasse tinyint foreign key references Classe(idClasse),
	idCliente TINYINT FOREIGN KEY REFERENCES Cliente(idCliente) ,
	nomePer varCHAR(20),
	maxVida SMALLINT,
	maxMana SMALLINT,
	Atualiza��o DATE,
	Cria��o date
);

create table Habilidades(
idHabilidades tinyint primary key IDENTITY (1,1),
nomeDaHabilidade varchar (50),
);

create table Intermediaria(
idIntermediaria tinyint primary key IDENTITY (1,1),
idHabilidades tinyint foreign key references Habilidades (idHabilidades),
idClasse tinyint foreign key references Classe (idClasse)
);