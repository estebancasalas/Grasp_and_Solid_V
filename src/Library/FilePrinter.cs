using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(ISaleContent content)
        {
            File.WriteAllText("Recipe.txt", content.GetTextToPrint());
        }
    }
}