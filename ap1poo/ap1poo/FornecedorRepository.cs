namespace ap1poo
{
    public class FornecedorRepository {
    private List<Fornecedor> listaFornecedor = new List<Fornecedor>();
    public List<Fornecedor> GetAll() {
      return listaFornecedor;
    }

    public void Add(Fornecedor fornecedor) {
      listaFornecedor.Add(fornecedor);
    }

    public void Update(Fornecedor fornecedor) {
      
      int index = listaFornecedor.FindIndex(p => p.Id == fornecedor.Id);
      if (index != -1) {
        listaFornecedor[index] = fornecedor;
      }
    }

    public void Delete(Fornecedor fornecedor) {
      listaFornecedor.RemoveAll(p => p.Id == fornecedor.Id);
    }
  }
}