using Bulky.Models;

namespace Bulky.DataAccess.Repository.IRepository
{
	public interface IOrderHeaderRepository : IRepository<OrderHeader>
	{
		void Update(OrderHeader obj);
		void UpdateStatus(int id, string orderStatus, String? paymentStatus);
		void UpdateStripePaymentID(int id, string sessionId, string paymentItentId);
	}
}

