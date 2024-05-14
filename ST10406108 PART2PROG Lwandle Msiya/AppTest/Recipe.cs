namespace RecipeApp.RecipeApp
{
    internal class Recipe
    {
            public string Title { get; }
            public List<Ingredient> Ingredients { get; } = new List<Ingredient>();
        public List<string> Steps { get; } = new List<string>();

        public Recipe(string title)
            {
                Title = title;
            }

        public void AddStep(string step)
        {
            Steps.Add(step);
        }

        public override string ToString()
        {
            string ingredientList = string.Join("\n", Ingredients.Select(ingredient => $"- {ingredient}"));
            string stepList = string.Join("\n", Steps.Select((step, index) => $"{index + 1}. {step}"));
            return $"Recipe: {Title}\nIngredients:\n{ingredientList}\nSteps:\n{stepList}";
        }

        public Recipe(string title, List<Ingredient> ingredients) : this(title)
        {
        }

        public void AddIngredient(Ingredient ingredient)
            {
                Ingredients.Add(ingredient);
            }

            
        

    }
}