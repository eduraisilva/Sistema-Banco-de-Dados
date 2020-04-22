//Deletar um registro 
delete from pedidos 
where Cliente_Id = 3;
 
 //Inserir Registros
 insert into produtos values(1, 'Mesa', '599,99');
 insert into produtos values(2, 'Cadeira', '900,00');
 insert into produtos values(3, 'Ventilador', '169,90');
 insert into produtos values(4, 'Climatizador', '428,00');
 insert into produtos values(5, 'Monitor', '799,99');
 insert into produtos values(6, 'Notebook', '3.499,99');
 insert into produtos values(7, 'Teclado', '149,90');
 insert into produtos values(8, 'Mouse', '99,00');
 
 insert into usuarios values(1, 'Eduardo Silva', 'Masculino', 'edu@gmail.com', 'edu','123456', now());
 insert into usuarios values(2, 'Leonardo da Costa', 'Masculino', 'leo@gmail.com', 'leo','789123', now());
 insert into usuarios values(3, 'Cristina Martins', 'Feminino', 'cris@gmail.com', 'crismel','456789', now());
 
 select * from produtos
 use sistemadb
 
 desc produtos;

 
 //Atualizar registro table
update produtos
set Produto_Nome ='', Produto_Valor =''
where Produto_Id = '';
 
 /*adicionar coluna*/
 alter table clientes add Email varchar(100);
 select* from produtos
 
//condição if
  select IF (Qtde_Produto > 1, 'sim', 'não') as 'resultado'
	from produtos
    where Produto_Id = 1

// obter descrição da tabela
desc produtos

//Alterar chave primaria entre colunas
ALTER TABLE pedidos MODIFY COLUMN Cliente_Id INTEGER
ALTER TABLE pedidos DROP PRIMARY KEY
alter table pedidos add primary key (Pedido_Id)

alter table clientes drop column Login
alter table clientes drop column Senha

 
 desc itens_pedido
 select * from pedidos
 
ALTER TABLE pedidos 
DROP PRIMARY KEY;


alter table pedidos add primary key (Pedido_Id)

DROP PRIMARY KEY

Cliente_Id

truncate table pedidos

//add coluna
alter table usuarios add Sexo varchar(20)

use sistemadb
select * from usuarios
desc produtos


//Criar Tabela
create table usuarios(
	Codigo int primary key not null,
    Nome_Completo varchar(100),
    Login varchar(100),
    Senha varchar(100),
    Email varchar(100)
);
    
	
