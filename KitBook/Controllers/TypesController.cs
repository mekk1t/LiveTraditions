﻿using System;
using BusinessLogic.Interfaces;
using KitBook.Models.Database.Entities.Types;
using Microsoft.AspNetCore.Mvc;

namespace KitBook.Controllers
{
    public class TypesController : Controller
    {
        private readonly IRepository<RecipeType> recipeTypeRepository;
        private readonly IRepository<DishType> dishTypeRepository;
        private readonly IRepository<CookingType> cookingTypeRepository;
        private readonly IRepository<IngredientType> ingredientTypeRepository;

        // ЗДЕСЬ НУЖНО ИСПОЛЬЗОВАТЬ AJAX, ТК ОПЕРАЦИИ НЕЗНАЧИТЕЛЬНЫЕ и могут пригодиться при редактировании / создании
        public TypesController(
            IRepository<RecipeType> recipeTypeRepository,
            IRepository<CookingType> cookingTypeRepository,
            IRepository<IngredientType> ingredientTypeRepository,
            IRepository<DishType> dishTypeRepository)
        {
            this.recipeTypeRepository = recipeTypeRepository;
            this.cookingTypeRepository = cookingTypeRepository;
            this.dishTypeRepository = dishTypeRepository;
            this.ingredientTypeRepository = ingredientTypeRepository;
        }

        public IActionResult Index()
        {
            return View(nameof(Index));
        }

        #region RecipeType
        [HttpGet]
        public IActionResult GetRecipeTypes()
        {
            return View(nameof(GetRecipeTypes), recipeTypeRepository.GetList());
        }

        [HttpGet]
        public IActionResult GetRecipeType(Guid id)
        {
            return View(nameof(GetRecipeType), recipeTypeRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult PostRecipeType(RecipeType type)
        {
            recipeTypeRepository.Create(type);
            return RedirectToAction(nameof(GetRecipeTypes));
        }

        [HttpGet]
        public IActionResult PostRecipeType()
        {
            return View(nameof(PostRecipeType));
        }

        [HttpPost]
        public IActionResult PutRecipeType(RecipeType type)
        {
            recipeTypeRepository.Update(type);
            return RedirectToAction(nameof(GetRecipeType), new { id = type.Id });
        }

        [HttpGet]
        public IActionResult PutRecipeType(Guid id)
        {
            var formData = recipeTypeRepository.GetById(id);
            return View(nameof(PutRecipeType), formData);
        }

        public IActionResult DeleteRecipeType(Guid id)
        {
            recipeTypeRepository.DeleteById(id);
            return RedirectToAction(nameof(GetRecipeTypes));
        }
        #endregion

        #region CookingType
        [HttpGet]
        public IActionResult GetCookingTypes()
        {
            return View(nameof(GetCookingTypes), cookingTypeRepository.GetList());
        }

        [HttpGet]
        public IActionResult GetCookingType(Guid id)
        {
            return View(nameof(GetCookingType), cookingTypeRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult PostCookingType(CookingType type)
        {
            cookingTypeRepository.Create(type);
            return RedirectToAction(nameof(GetCookingTypes));
        }

        [HttpGet]
        public IActionResult PostCookingType()
        {
            return View(nameof(PostCookingType));
        }

        [HttpPost]
        public IActionResult PutCookingType(CookingType type)
        {
            cookingTypeRepository.Update(type);
            return RedirectToAction(nameof(GetCookingType), new { id = type.Id });
        }

        [HttpGet]
        public IActionResult PutCookingType(Guid id)
        {
            var formData = cookingTypeRepository.GetById(id);
            return View(nameof(PutCookingType), formData);
        }

        public IActionResult DeleteCookingType(Guid id)
        {
            cookingTypeRepository.DeleteById(id);
            return RedirectToAction(nameof(GetCookingTypes));
        }
        #endregion

        #region DishType
        [HttpGet]
        public IActionResult GetDishTypes()
        {
            return View(nameof(GetDishTypes), dishTypeRepository.GetList());
        }

        [HttpGet]
        public IActionResult GetDishType(Guid id)
        {
            return View(nameof(GetDishType), dishTypeRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult PostDishType(DishType type)
        {
            dishTypeRepository.Create(type);
            return RedirectToAction(nameof(GetDishTypes));
        }

        [HttpGet]
        public IActionResult PostDishType()
        {
            return View(nameof(PostDishType));
        }

        [HttpPost]
        public IActionResult PutDishType(DishType type)
        {
            dishTypeRepository.Update(type);
            return RedirectToAction(nameof(GetDishType), new { id = type.Id });
        }

        [HttpGet]
        public IActionResult PutDishType(Guid id)
        {
            var formData = dishTypeRepository.GetById(id);
            return View(nameof(PutDishType), formData);
        }

        public IActionResult DeleteDishType(Guid id)
        {
            dishTypeRepository.DeleteById(id);
            return RedirectToAction(nameof(GetDishTypes));
        }
        #endregion

        #region IngredientType
        [HttpGet]
        public IActionResult GetIngredientTypes()
        {
            return View(nameof(GetIngredientTypes), ingredientTypeRepository.GetList());
        }

        [HttpGet]
        public IActionResult GetIngredientType(Guid id)
        {
            return View(nameof(GetIngredientType), ingredientTypeRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult PostIngredientType(IngredientType type)
        {
            ingredientTypeRepository.Create(type);
            return RedirectToAction(nameof(GetIngredientTypes));
        }

        [HttpGet]
        public IActionResult PostIngredientType()
        {
            return View(nameof(PostIngredientType));
        }

        [HttpPost]
        public IActionResult PutIngredientType(IngredientType type)
        {
            ingredientTypeRepository.Update(type);
            return RedirectToAction(nameof(GetIngredientType), new { id = type.Id });
        }

        [HttpGet]
        public IActionResult PutIngredientType(Guid id)
        {
            var formData = ingredientTypeRepository.GetById(id);
            return View(nameof(PutIngredientType), formData);
        }

        public IActionResult DeleteIngredientType(Guid id)
        {
            ingredientTypeRepository.DeleteById(id);
            return RedirectToAction(nameof(GetIngredientTypes));
        }
        #endregion
    }
}
