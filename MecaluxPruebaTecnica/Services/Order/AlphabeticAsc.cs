using MecaluxPruebaTecnica.Enums;
using MecaluxPruebaTecnica.Interfaces.Order;

namespace MecaluxPruebaTecnica.Services.Order
{
	public class AlphabeticAsc : ItextOrder
	{
		public List<string> orderList(string text)
		{
			var words = text.Split().ToList();
			return words.OrderBy(x => x).ToList();
		}
	}
}
