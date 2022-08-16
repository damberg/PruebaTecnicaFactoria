using MecaluxPruebaTecnica.Interfaces.TextAnalisis;
using MecaluxPruebaTecnica.Models;

namespace MecaluxPruebaTecnica.Services.TextAnalisis
{
	public class WordAnalysis : ITextAnalysis
	{
		public TextAnalysisModel Analyze(string text, int position, TextAnalysisModel textAnalysis)
		{
			
			if (text[position] != ' ' && (position == text.Length - 1 || text[position+1] == ' '))
			{
				textAnalysis.Word++;
			}

			return textAnalysis;
		}
	}
}
