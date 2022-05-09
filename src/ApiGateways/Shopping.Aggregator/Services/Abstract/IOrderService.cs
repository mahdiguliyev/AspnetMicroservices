using Shopping.Aggregator.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shopping.Aggregator.Services.Abstract
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrderByUsername(string userName);
    }
}
