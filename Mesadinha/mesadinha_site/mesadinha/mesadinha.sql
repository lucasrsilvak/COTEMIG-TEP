-- Lucas Ribeiro
-- Rodrigo de Oliveira
-- Thiago Henrique
-- Vinicius

create database mesadinha;
use mesadinha;

create table usuario(
	id 		 int unsigned not null auto_increment primary key,
    nome 	 varchar(80) not null,
    email 	 varchar(80) not null,
    endereco varchar(140) not null,
    telefone char(15) not null,
    senha 	 varchar(150) not null,
    receita  double(12,2),
    despesas double(12,2)
)engine=innodb;

create table categoria(
	id 		int unsigned not null auto_increment primary key,
    nome 	varchar(30) not null,
    
	usuario_id int unsigned not null,
    foreign key(usuario_id) references usuario(id)
)engine=innodb;

create table conta(
	id 		int unsigned not null auto_increment primary key,
    nome 	varchar(30) not null,
	tipo 	char(1) not null,
    
	categoria_id int unsigned not null,
	foreign key(categoria_id) references categoria(id)
)engine=innodb;

create table movimentacao(
	id 		int unsigned not null auto_increment primary key,
    valor 	double(12,2) not null,
    data 	date not null,
    
	conta_id int unsigned not null,
    usuario_id int unsigned not null,
	foreign key(conta_id) references conta(id),
    foreign key(usuario_id) references usuario(id)
)engine=innodb;
