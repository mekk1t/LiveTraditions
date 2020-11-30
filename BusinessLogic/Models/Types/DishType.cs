﻿using System;
using System.ComponentModel.DataAnnotations;
using BusinessLogic.Attributes;
using BusinessLogic.Models.Files;
using BusinessLogic.Models.Types.Interface;

namespace KitBook.Models.Database.Entities.Types
{
    [Translation("Тип блюда")]
    public class DishType : IType
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public File Icon { get; set; }
    }
}
