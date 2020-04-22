drop procedure New_Cliente
 
delimiter $$
create procedure New_Cliente(in nome varchar(400), in sobrenome varchar(400), in datanascimento longtext, in sexo varchar(100), in email varchar(100))
begin
	declare maximo int;
    declare num int;
    declare codigo int;
    
    set maximo = (select max(Cliente_Id) from clientes);
    set num = (select ltrim(maximo));
    if num > 1 then    
	      set num= num+1;
          set codigo = num;
	else 
		set num = num;
	end if;
    
    insert into clientes values (codigo, nome, sobrenome, datanascimento, sexo, email, now());
 end $$
 
 call New_Cliente('Dayse', 'Silva', '24/11/1963', 'Masculino', 'juca@gmail.com');
/////////////////////////////////////////////////////////////////////////////////////
 
 use Sistemadb;
 select * from clientes;
 select * from produtos;
 
 select * from clientes where Cliente_Id = 14
 

delimiter $ 
create procedure Reposicao_Estoque(in codigo_produto int, in reposicao_qtde int)
begin	    
   
   update produtos set Produto_Qtde = Produto_Qtde + reposicao_qtde
   where Produto_Id = codigo_produto;
end
$
   
   use Sistemadb
   desc produtos
   
   call Reposicao_Estoque(2, 5)
   
   inner join clientes, itens pedido, pedido, produto

delimiter //   
create procedure Cliente_Compra(in Cliente_Id int, in Qtde_produto int, in produto_valor varchar(1000), in Produto_Id int, in Valor_Total_Compra varchar(1000))
 begin  
   declare maximo int;
   declare num int;
   declare codigo int;
       
    set maximo = (select max(Pedido_Id) from pedidos);
    set num = (select ltrim(maximo));
    if num > 1 then    
	      set num= num+1;
          set codigo = num;
	else 
		set num = num;
	end if;
    
   insert into pedidos values (Cliente_Id, codigo, now(), Produto_Id,produto_valor, Qtde_produto, Valor_Total_Compra); 
   end
   //
   
   select * from pedidos
   
   delimiter $$
   create procedure New_Produto(in Produto_nome varchar(100), in Produto_Valor varchar(100))
   begin
	  declare maximo int;
      declare num int;
       declare codigo int;
       
    set maximo = (select max(Produto_Id) from produtos);
    set num = (select ltrim(maximo));
    if num > 1 then    
	      set num= num+1;
          set codigo = num;
	else 
		set num = num;
	end if;
    
    insert into produtos values(codigo, Produto_Nome, Produto_Valor, '0', now());
    end
    $$
    drop procedure New_Produto
    
    delimiter //
    create procedure New_Usuario(in Nome_Completo varchar(100),in Sexo varchar(100),in Email varchar(100),in Login varchar(100),in Senha varchar(100))
    begin
	  declare maximo int;
      declare num int;
      declare codigo1 int;
       
    set maximo = (select max(Codigo) from usuarios);
    set num = (select ltrim(maximo));
    if num > 1 then    
	      set num= num+1;
          set codigo1 = num;
	else 
		set num = num;
	end if;
    
    insert into usuarios values(codigo1, Nome_Completo, Sexo, Email, Login, Senha, now());
    end
    //
    select * from produtos
    
    delimiter $$
    create procedure Chart_ProdutoEstoque()
    begin
		select  Produto_Nome, Produto_Qtde from produtos
        order by Produto_Nome desc;
        
    end
    $$
    
delimiter /
create procedure Chart_Produtos_Vendidos()
begin
select a.Produto_Nome, count(b.Produto_Id) as Qtde
from produtos a
left join pedidos b
on a.Produto_Id = b.Produto_Id
group by a.Produto_Id
order by Qtde desc;
end
/
drop procedure Chart_ProdutoEstoque
    
    
    
    
    call New_Usuario('Teste', 'Masculino', 'test@globo.com', 'testando', 'dudu')
   
 
desc produtos
desc clientes
select *from usuarios;
select *  from clientes;
call New_Produto('Avon','10'); 

alter table pedidos where Clie
        
insert into pedidos values (1, 2, now(),1, 1); 

delete



desc produtos

select * from pedidos
use sistemadb











 

 
 
 
 