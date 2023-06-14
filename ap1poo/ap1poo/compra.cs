namespace ap1poo
{
    public class Compra
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int Quantidade { get; set; }

        public Compra(int id, Produto produto, Fornecedor fornecedor, int quantidade)
        {
            this.Id = id;
            this.Produto = produto;
            this.Fornecedor = fornecedor;
            this.Quantidade = quantidade;
        }
    }
}