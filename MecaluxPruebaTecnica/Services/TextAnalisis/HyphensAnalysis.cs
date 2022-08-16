using MecaluxPruebaTecnica.Interfaces.TextAnalisis;
using MecaluxPruebaTecnica.Models;

namespace MecaluxPruebaTecnica.Services.TextAnalisis
{
	public class HyphensAnalysis : ITextAnalysis
	{
		public TextAnalysisModel Analyze(string text, int position, TextAnalysisModel textAnalysis)
		{
			if (text[position] == '-')
			{
				textAnalysis.Hyphens++;
			}

			return textAnalysis;
		}
	}
}
