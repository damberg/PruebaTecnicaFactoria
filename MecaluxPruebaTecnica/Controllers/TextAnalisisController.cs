using MecaluxPruebaTecnica.Enums;
using MecaluxPruebaTecnica.Interfaces;
using MecaluxPruebaTecnica.Services.Order;
using MecaluxPruebaTecnica.Services.TextAnalisis;
using Microsoft.AspNetCore.Mvc;

namespace MecaluxPruebaTecnica.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class TextAnalisisController : Controller
	{

		[HttpGet]
		[Route("GetOrderOptions")]
		public ActionResult<List<string>> GetOrderOptions()
		{
			return Ok(Enum.GetNames(typeof(OrderOptionsEnum)).ToList());
		}

		[HttpPost]
		[Route("GetOrderedText")]
		public ActionResult<List<string>> GetOrderedText(string textToOrder, OrderOptionsEnum option)
		{
			return Ok(FactoryDic.GetOrderObject(option).orderList(textToOrder));
		}


		[HttpPost]
		[Route("GetStatistics")]
		public ActionResult<List<string>> GetStatistics(string textToOrder)
		{
			return Ok(TextAnalysis.TextAnalisis(textToOrder));

		}

	}
}
