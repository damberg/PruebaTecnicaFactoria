using MecaluxPruebaTecnica.Enums;
using MecaluxPruebaTecnica.Services.Order;

namespace TestProject
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void AlphabeticAsc()
		{
			var orderedList = FactoryDic.GetOrderObject(OrderOptionsEnum.AlphabeticAsc).orderList("aaa eee bb ccc");
			var asertList = new List<string> { "aaa","bb","ccc","eee" };
			Assert.AreEqual(orderedList,asertList);
		}

		[Test]
		public void AlphabeticDesc()
		{
			var orderedList = FactoryDic.GetOrderObject(OrderOptionsEnum.AlphabeticDesc).orderList("aaa eee bb ccc");
			var asertList = new List<string> {  "eee","ccc","bb","aaa" };
			Assert.AreEqual(orderedList, asertList);
		}

		[Test]
		public void LenghtAsc()
		{
			var orderedList = FactoryDic.GetOrderObject(OrderOptionsEnum.LenghtAsc).orderList("aa e bbbbbc ccc");
			var asertList = new List<string> { "e","aa","ccc","bbbbbc" };
			Assert.AreEqual(orderedList, asertList);
		}

	}
}