delimiter $
create trigger TG_Atualiza_Qtde_Produto after insert
on pedidos

for each row
begin

    
  update produtos set Produto_Qtde = Produto_Qtde - new.Pedido_Qtde
   where Produto_Id = new.Produto_id;
   		
end
$


use sistemadb
select * from pedidos;
select * from produtos;
desc pedidos
go


/*
	declare @Produto_Qtde int
    declare @Pedido_Qtde int
    declare @Produto_Id int
    
    
    select @Pedido_Qtde = Pedido_Qtde from inserted
    select @Produto_Qtde = Produto_Qtde from inserted
    select @Produto_Id = Produto_Id from inserted
   */
