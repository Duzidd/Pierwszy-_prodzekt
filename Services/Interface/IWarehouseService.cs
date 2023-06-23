using Pierwszy__prodzekt.Models;

namespace Pierwszy__prodzekt.Services.Interface
{
    public interface IWarehouseService
    {
        int Save(Product product);
        
        List<Product> GetAll();
        Product Get(int id);
        int Delete(int id);
    }
}
