namespace ap1poo
{
    public class ProdutoRepository {
    private List<Produto> listaProduto = new List<Produto>();
    public List<Produto> GetAll() {
      return listaProduto;
    }

    public void Add(Produto produto) {
      listaProduto.Add(produto);
    }

    public void Update(Produto produto) {
      // A expressão lambda p => p.Id == person.Id verifica se o Id do objeto Person p é igual ao Id do objeto Person fornecido como parâmetro, se não houver ID, o método FindIndex retorna -1.
      int index = listaProduto.FindIndex(p => p.Id == produto.Id);
      if (index != -1) {
        listaProduto[index] = produto;
      }
    }

    public void Delete(Produto produto) {
      listaProduto.RemoveAll(p => p.Id == produto.Id);
    }
  }
}