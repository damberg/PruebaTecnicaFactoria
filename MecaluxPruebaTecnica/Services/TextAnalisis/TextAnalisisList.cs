using MecaluxPruebaTecnica.Interfaces.TextAnalisis;

namespace MecaluxPruebaTecnica.Services.TextAnalisis
{
	public static class TextAnalisisList 
	{
		public static List<ITextAnalysis> ListTextAnalysis = new List<ITextAnalysis>();
		static TextAnalisisList()
		{
			ListTextAnalysis.Add(new HyphensAnalysis());
			ListTextAnalysis.Add(new WordAnalysis());
			ListTextAnalysis.Add(new SpacesAnalysis());
		}
		public static List<ITextAnalysis> GetListTextAnalysis()
		{
			return ListTextAnalysis;
		}
	}
}
