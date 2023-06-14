namespace ap1poo
{
    public class Fornecedor
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; set; }

        public Fornecedor(int id, string nome, string endereco)
        {
            this.Id = id;
            this.Nome = nome;
            this.Endereco = endereco;
        }
    }
}