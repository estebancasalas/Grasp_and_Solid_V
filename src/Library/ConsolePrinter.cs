using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(ISaleContent content)
        {
            Console.WriteLine(content.GetTextToPrint());
        }
    }
}