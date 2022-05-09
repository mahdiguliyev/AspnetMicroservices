using Shopping.Aggregator.Models;
using System.Collections;
using System.Threading.Tasks;

namespace Shopping.Aggregator.Services.Abstract
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}
