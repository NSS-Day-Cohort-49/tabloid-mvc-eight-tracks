﻿using System.Collections.Generic;
using TabloidMVC.Models;

namespace TabloidMVC.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        void AddCategory(Category category);
        void DeleteCategory(int id);
        Category GetCategoryById(int id);
    }
}