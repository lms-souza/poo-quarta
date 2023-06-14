namespace ap1poo
{
    public class CompraRepository {
    private List<Compra> listaCompra = new List<Compra>();
    public List<Compra> GetAll() {
      return listaCompra;
    }

    public void Add(Compra compra) {
      listaCompra.Add(compra);
    }

    public void Update(Compra compra) {
      
      int index = listaCompra.FindIndex(p => p.Id == compra.Id);
      if (index != -1) {
        listaCompra[index] = compra;
      }
    }
    public void Delete(Compra compra) {
      listaCompra.RemoveAll(p => p.Id == compra.Id);
    }
  }
}