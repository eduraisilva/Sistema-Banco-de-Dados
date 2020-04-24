use sistemadb

select * from clientes;
select * from pedidos;


//Faturamento_Bruto
select sum(REPLACE(Valor_Total_Compra, ',', '.')) from pedidos

//Quantidades_Vendas
select count(Pedido_Id) from pedidos

//Quantidade_clientes
select count(Cliente_Id) from clientes

//Qtde_Clientes_Compras
select count(DISTINCT clientes.Cliente_Id) as total from clientes inner join pedidos on clientes.Cliente_Id = pedidos.Cliente_Id

//Qtde_Usuarios
select count(Codigo) as Qtde from usuarios

//Qtde_Produtos
select count(Produto_Id) as Qtde from produtos


//chart produtos em estoque
select  Produto_Nome, Produto_Qtde from produtos

// chart Produtos Vendidos
select a.Produto_Nome, count(b.Produto_Id) as Qtde
from produtos a
left join pedidos b
on a.Produto_Id = b.Produto_Id
group by a.Produto_Id
order by Qtde desc

select * from pedidos;
select * from produtos;




---------------------------------------------------------
delimiter $$
create procedure Dashboard_Painel(out dash_faturamento_bruto_A decimal(10,2), out dash_qtde_vendas_B int, out dash_qtde_cliente_C int, out dash_qtde_clientes_compras_D int, out dash_qtde_usuarios_E int, out dash_qtde_produtos_F int)
begin
		set dash_faturamento_bruto_A = (select sum(Valor_Total_Compra) as A from pedidos);
        set dash_qtde_vendas_B = (select count(Pedido_Id)as B from pedidos);
        set dash_qtde_cliente_C = (select count(Cliente_Id)as C from clientes);
        set dash_qtde_clientes_compras_D = (select count(*) as D from clientes inner join pedidos on clientes.Cliente_Id = pedidos.Cliente_Id);
        set dash_qtde_usuarios_E = (select count(Codigo) as E from usuarios);
        set dash_qtde_produtos_F = (select count(Produto_Id) as F from produtos);
end
$$

call Dashboard_Painel()
drop procedure Dashboard_Painel

declare @dash_faturamento_bruto decimal out,
declare @dash_qtde_vendas int out,
declare @dash_qtde_cliente int out,
declare @dash_qtde_clientes_compras int out,
declare @dash_qtde_usuarios int out,
declare @dash_qtde_produtos int out