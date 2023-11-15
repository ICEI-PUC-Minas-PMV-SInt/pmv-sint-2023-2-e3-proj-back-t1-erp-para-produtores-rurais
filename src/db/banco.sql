CREATE TABLE USUARIO
(
	id_usuario int PRIMARY KEY NOT NULL,
	nome text,
	email text,
);


CREATE TABLE INSUMO
(
	id_insumo int PRIMARY KEY NOT NULL,
	unidade_medida text,
	valor float,
);


CREATE TABLE COMPRA
(
	id_compra int PRIMARY KEY NOT NULL,
	datas date,
	id_insumo int NOT NULL,
	valor float,
	id_usuario int NOT NULL,
);

CREATE TABLE PRODUTO
(
	id_produto int PRIMARY KEY NOT NULL,
	unidade_medida text,
	valor float,
);

CREATE TABLE VENDA
(
	id_venda int PRIMARY KEY NOT NULL,
	datas date,
	id_produto int NOT NULL,
	valor float,
	id_usuario int NOT NULL,
);