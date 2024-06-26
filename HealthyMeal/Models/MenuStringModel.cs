﻿using HealthyMeal.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyMeal.Models
{
    public class MenuStringModel : BaseNutritionalValueModel, IMealNutritionalValue
    {
        public string Id { get; set; } = null!;

        public string MealTypeId { get; set; }

        public string RecipeId { get; set; }

        public string MenuId { get; set; }

        public string RecipeName { get; set; }

        #nullable enable
        public byte[]? RecipePhoto { get; set; }

        public TimeSpan CookingTime { get; set; }
    }
}
