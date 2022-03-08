CREATE DATABASE CatalogoBD
GO

USE CatalogoBD
GO

CREATE TABLE Filmes(
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nomeFilme VARCHAR (200) NOT NULL,
	generoFilme VARCHAR (50) NOT NULL,
	classificacaoFilme VARCHAR (5) NOT NULL
)
GO

CREATE TABLE Series(
	id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	nomeSerie VARCHAR (200) NOT NULL,
	generoSerie VARCHAR (50) NOT NULL,
	classificacaoSerie VARCHAR (5) NOT NULL
)
GO

INSERT INTO Filmes(nomeFilme, generoFilme, classificacaoFilme)
VALUES
	('Guardi�es da Gal�xia', 'A��o, Fic��o Cient�fica', '12'),
	('At� o �ltimo Homem', 'Drama, Guerra', '16'),
	('Toy Story', 'Anima��o', 'Livre'),
	('Batman', 'A��o, Suspense', '14'),
	('O Menino do Pijama Listrado', 'Drama, Guerra', '12')
GO

INSERT INTO Series(nomeSerie, generoSerie, classificacaoSerie)
VALUES
	('The Office', 'Com�dia', '12'),
	('Mr. Robot', 'Drama, Suspense', '16'),
	('Todo Mundo Odeia o Chris', 'Com�dia', '10'),
	('La Casa de Papel', 'Drama, Suspense', '16'),
	('Breaking Bad', 'Drama, Suspense', '16')
GO