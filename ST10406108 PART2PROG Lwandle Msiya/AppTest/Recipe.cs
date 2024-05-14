namespace RecipeApp.RecipeApp
{
    //class for recipe
    internal class Recipe
    {
        //constructor
            public string Title { get; }
            public List<Ingredient> Ingredients { get; } = new List<Ingredient>();
        public List<string> Steps { get; } = new List<string>();

        public Recipe(string title)
            {
                Title = title;
            }

        //adding steps
        public void AddStep(string step)
        {
            Steps.Add(step);
        }

        //adding to list
        public override string ToString()
        {
            string ingredientList = string.Join("\n", Ingredients.Select(ingredient => $"- {ingredient}"));
            string stepList = string.Join("\n", Steps.Select((step, index) => $"{index + 1}. {step}"));
            return $"Recipe: {Title}\nIngredients:\n{ingredientList}\nSteps:\n{stepList}";
        }

        public Recipe(string title, List<Ingredient> ingredients) : this(title)
        {
        }

        //add ingredient method
        public void AddIngredient(Ingredient ingredient)
            {
                Ingredients.Add(ingredient);
            }

            
        

    }
}