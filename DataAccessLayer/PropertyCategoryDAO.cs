using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BusinessObjectLayer;

namespace DataAccessLayer
{
    public class PropertyCategoryDAO
    {
        private readonly SaleManagementContext _context;
        public static PropertyCategoryDAO instance = null;
        public static PropertyCategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PropertyCategoryDAO();
                }
                return instance;
            }
        }

        public PropertyCategoryDAO()
        {
            _context = new SaleManagementContext();
        }

        // Create
        public void AddPropertyCategory(PropertyCategory category)
        {
            _context.PropertyCategories.Add(category);
            _context.SaveChanges();
        }

        // Read
        public PropertyCategory GetPropertyCategoryById(int categoryId)
        {
            return _context.PropertyCategories
                           .Include(pc => pc.Properties)
                           .FirstOrDefault(pc => pc.CategoryId == categoryId);
        }

        // Read All
        public List<PropertyCategory> GetAllPropertyCategories()
        {
            return _context.PropertyCategories
                           .Include(pc => pc.Properties)
                           .ToList();
        }

        // Update
        public void UpdatePropertyCategory(PropertyCategory category)
        {
            var existingCategory = _context.PropertyCategories.Find(category.CategoryId);
            if (existingCategory != null)
            {
                _context.Entry(existingCategory).CurrentValues.SetValues(category);
                _context.SaveChanges();
            }
        }

        // Delete
        public void DeletePropertyCategory(int categoryId)
        {
            var category = _context.PropertyCategories.Find(categoryId);
            if (category != null)
            {
                _context.PropertyCategories.Remove(category);
                _context.SaveChanges();
            }
        }
    }
}
