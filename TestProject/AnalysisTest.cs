using MecaluxPruebaTecnica.Enums;
using MecaluxPruebaTecnica.Models;
using MecaluxPruebaTecnica.Services.Order;
using MecaluxPruebaTecnica.Services.TextAnalisis;

namespace TestProject
{
	public class AnalysisTest
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void GetStatistics()
		{
			var textAnaliced = TextAnalysis.TextAnalisis("hola prueba daniel - ");
			var model = new TextAnalysisModel() { Hyphens = 1, Spaces = 4, Word = 4 };
			Assert.AreEqual(textAnaliced, textAnaliced);
		}

	}
}