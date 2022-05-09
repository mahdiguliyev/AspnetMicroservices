using Shopping.Aggregator.Models;
using Shopping.Aggregator.Services.Abstract;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shopping.Aggregator.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _client;

        public OrderService(HttpClient client)
        {
            _client = client;
        }

        public Task<IEnumerable<OrderResponseModel>> GetOrderByUsername(string userName)
        {
            throw new System.NotImplementedException();
        }
    }
} 
