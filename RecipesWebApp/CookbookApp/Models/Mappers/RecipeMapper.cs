﻿using KK.Cookbook.Models.Mappers.Interfaces;
using KK.Cookbook.Models.Database.Entities;
using KK.Cookbook.Models.ViewData;

namespace KK.Cookbook.Models.Mappers
{
    public class RecipeMapper : IRecipeMapper
    {
        private readonly IRecipeIngredientMapper riMapper;
        private readonly ICommentMapper commentMapper;
        private readonly IStageMapper stageMapper;

        public RecipeMapper(
            ICommentMapper commentMapper,
            IStageMapper stageMapper,
            IRecipeIngredientMapper riMapper)
        {
            this.commentMapper = commentMapper;
            this.stageMapper = stageMapper;
            this.riMapper = riMapper;
        }

        public RecipeViewData Map(Recipe model)
        {
            return new RecipeViewData
            {
                Title = model.Title,
                Description = model.Description,
                Comments = commentMapper.Map(model.Comments),
                Stages = stageMapper.Map(model.Stages),
                SourceURL = model.SourceURL,
                Ingredients = riMapper.Map(model.Ingredients)
            };
        }
    }
}
