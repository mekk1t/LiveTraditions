﻿using KK.Cookbook.Models.Database.Entities;
using KK.Cookbook.Models.ViewData;
using System.Collections.Generic;

namespace KK.Cookbook.Models.Mappers.Interfaces
{
    public interface IRecipeIngredientMapper : BaseMapper<IEnumerable<RecipeIngredient>, IEnumerable<IngredientViewData>>
    {
    }
}