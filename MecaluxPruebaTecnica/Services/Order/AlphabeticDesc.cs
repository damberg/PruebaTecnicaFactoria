using MecaluxPruebaTecnica.Interfaces.Order;

namespace MecaluxPruebaTecnica.Services.Order
{
	public class AlphabeticDesc : ItextOrder
	{
		public List<string> orderList(string text)
		{
			var words = text.Split().ToList();
			return words.OrderByDescending(x => x).ToList();
		}
	}
}
