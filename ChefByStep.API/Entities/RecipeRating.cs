﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefByStep.API.Entities
{
    public class RecipeRating
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }
    }
}