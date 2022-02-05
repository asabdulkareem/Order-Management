using OrderManagement.Domain.Models;

namespace OrderManagement.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
