using MecaluxPruebaTecnica.Interfaces.TextAnalisis;
using MecaluxPruebaTecnica.Models;

namespace MecaluxPruebaTecnica.Services.TextAnalisis
{
	public static class TextAnalysis
	{
		public static TextAnalysisModel TextAnalisis(string text)
		{
			TextAnalysisModel textAnalysisModel = new TextAnalysisModel() { Hyphens = 0, Spaces = 0, Word = 0 };
			int position = 0;

			for (int i = 0; i < text.Length; i++)
			{
				foreach (ITextAnalysis itextAnalysis in TextAnalisisList.ListTextAnalysis)
				{
					 itextAnalysis.Analyze(text, i, textAnalysisModel);
				}
			}

			return textAnalysisModel;
		}
	}
}
