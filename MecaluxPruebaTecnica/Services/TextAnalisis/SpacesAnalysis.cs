using MecaluxPruebaTecnica.Interfaces.TextAnalisis;
using MecaluxPruebaTecnica.Models;

namespace MecaluxPruebaTecnica.Services.TextAnalisis
{
	public class SpacesAnalysis : ITextAnalysis
	{
		public TextAnalysisModel Analyze(string text, int position, TextAnalysisModel textAnalysis)
		{
			if (text[position] == ' ')
			{
				textAnalysis.Spaces++;
			}

			return textAnalysis;
		}
	}
}
