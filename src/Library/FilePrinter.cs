using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IPrint printContent)
        {
            File.WriteAllText("Recipe.txt", printContent.GetTextToPrint());
        }
    }
}