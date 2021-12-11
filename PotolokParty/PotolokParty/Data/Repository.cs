using PotolokParty.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PotolokParty.Data
{
    public class Repository
    {
		IRestService restService;

		public Repository(IRestService service)
		{
			restService = service;
		}

		public Task<List<Order>> GetTasksAsync()
		{
			return restService.RefreshDataAsync();
		}

		public Task<List<string>> GetNewsTasksAsync()
		{
			return restService.GetNewsAsync();
		}

		public Task SaveTaskAsync(Order order, bool isNewOrder = false)
		{
			return restService.SaveTodoItemAsync(order, isNewOrder);
		}

		public Task DeleteTaskAsync(Order order)
		{
			return restService.DeleteTodoItemAsync(order.Id.ToString());
		}
	}
}
