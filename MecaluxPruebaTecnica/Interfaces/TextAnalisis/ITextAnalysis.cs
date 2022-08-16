using MecaluxPruebaTecnica.Models;

namespace MecaluxPruebaTecnica.Interfaces.TextAnalisis
{
	public interface ITextAnalysis
	{
		public TextAnalysisModel Analyze(string text, int position, TextAnalysisModel textAnalysisModel);
	}
}
