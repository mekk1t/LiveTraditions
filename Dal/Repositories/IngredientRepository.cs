﻿using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Interfaces;
using KitBook.Helpers.Extensions;
using KitBook.Models.Database;
using KitBook.Models.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace KitBook.Models.Repositories
{
    public class IngredientRepository : IRepositoryAdvanced<Ingredient>
    {
        private readonly CookbookDbContext dbContext;

        public IngredientRepository(CookbookDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(Ingredient entity)
        {
            dbContext.Ingredients.Add(entity);
            dbContext.SaveChanges();
        }

        public void DeleteById(Guid id)
        {
            var ingredient = dbContext.Ingredients.FirstOrDefault(i => i.Id == id);
            dbContext.Ingredients.Remove(ingredient);
            dbContext.SaveChanges();
        }

        public Ingredient GetById(Guid id)
        {
            return dbContext.Ingredients.AsNoTracking().FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Ingredient> GetList(int pageSize = 10, int pageNumber = 1)
        {
            return dbContext.Ingredients.AsNoTracking().AsEnumerable();
        }

        public Ingredient GetByIdWithRelationships(Guid id)
        {
            return dbContext.Ingredients
                .AsNoTracking()
                .Include(i => i.Type)
                .Include(i => i.Recipes)
                .ThenInclude(r => r.Recipe)
                .FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Ingredient> GetListWithRelationships(int pageSize = 10, int pageNumber = 1)
        {
            return dbContext.Ingredients
                .AsNoTracking()
                .Include(i => i.Type)
                .AsEnumerable();
        }

        public void Update(Ingredient entity)
        {
            var ingredient = dbContext.Ingredients.FirstOrDefault(i => i.Id == entity.Id);
            ingredient.Update(entity);
            dbContext.SaveChanges();
        }
    }
}