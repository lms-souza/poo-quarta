namespace ap1poo
{
public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public Produto(int id, string nome, string descricao, decimal preco = 0)
        {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.Descricao = descricao;
        }
    }
}