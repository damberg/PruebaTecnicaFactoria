using MecaluxPruebaTecnica.Enums;
using MecaluxPruebaTecnica.Interfaces.Order;

namespace MecaluxPruebaTecnica.Services.Order
{
	public static class FactoryDic
	{
		static Dictionary<string, Type> OrderFactoryDic = new Dictionary<string, Type>();
		static FactoryDic()
		{
			var Orders = SettingsConfigHelper.GetSection("Factories").GetChildren().ToList();
			foreach (var order in Orders)
			{
				if (order.Key != null)
				{
					Type factoryTipe = Type.GetType(order.Value);
					OrderFactoryDic.Add(order.Key, factoryTipe);
				}
			}
		}

		public static Dictionary<string, Type> GetOrderFactoryDic()
		{
			return OrderFactoryDic;
		}

		public static ItextOrder GetOrderObject(OrderOptionsEnum option)
		{
			Type optionName;
			var a = Enum.GetName(option);
			GetOrderFactoryDic().TryGetValue(Enum.GetName(option), out optionName);
			return (ItextOrder)Activator.CreateInstance(optionName);
		}
	}
}

