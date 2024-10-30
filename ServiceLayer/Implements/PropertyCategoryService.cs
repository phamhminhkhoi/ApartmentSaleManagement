using System.Collections.Generic;
using BusinessObjectLayer;
using DataAccessLayer.Repository;
using RepositoryLayer.Interfaces;
using ServiceLayer.Interfaces;

namespace ServiceLayer
{
    public class PropertyCategoryService : IPropertyCategoryService
    {
        private readonly IPropertyCategoryRepository _propertyCategoryRepository = new PropertyCategoryRepository();

        public void AddPropertyCategory(PropertyCategory category)
        {
            _propertyCategoryRepository.AddPropertyCategory(category);
        }

        public PropertyCategory GetPropertyCategoryById(int categoryId)
        {
            return _propertyCategoryRepository.GetPropertyCategoryById(categoryId);
        }

        public List<PropertyCategory> GetAllPropertyCategories()
        {
            return _propertyCategoryRepository.GetAllPropertyCategories();
        }

        public void UpdatePropertyCategory(PropertyCategory category)
        {
            _propertyCategoryRepository.UpdatePropertyCategory(category);
        }

        public void DeletePropertyCategory(int categoryId)
        {
            _propertyCategoryRepository.DeletePropertyCategory(categoryId);
        }
    }
}
