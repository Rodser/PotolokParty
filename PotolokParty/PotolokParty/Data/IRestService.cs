using PotolokParty.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PotolokParty.Data
{
    public interface IRestService
	{
		Task<List<Order>> RefreshDataAsync();

		Task<List<string>> GetNewsAsync();

		Task SaveTodoItemAsync(Order item, bool isNewItem);

		Task DeleteTodoItemAsync(string id);
	}
}
