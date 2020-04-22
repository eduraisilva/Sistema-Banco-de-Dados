//Chaves estrangeiras

//Estoque => Produtos
//Criar
alter table 'estoques'
add constraint 'FK_produtos foreign key' ('ProdutosProduto_Id') references ('Produto_Id');

alter table estoques
add foreign key (ProdutosProduto_Id) references produtos (Produto_Id);

//Deletar

alter table estoques drop constraint FK_Estoques_Produtos_ProdutosProduto_Id
///////////////////////////////////////////////////////////////////////////////