namespace Full_GRASP_And_SOLID
{
    public class RecipeContent : IPrint
    {
        private Recipe recipe;

        public RecipeContent(Recipe recipe)
        {
            this.recipe = recipe;
        }

        public string GetTextToPrint()
        {
            string result = $"Receta de {this.recipe.FinalProduct.Description}:\n";
            foreach (BaseStep step in this.recipe.steps)
            {
                result = result + step.GetTextToPrint() + "\n";
            }

            result = result + $"Costo de producción: {this.recipe.GetProductionCost()}";
            return result;
        }
    }
}