using System.Collections.Generic;
using BusinessObjectLayer;
using RepositoryLayer.Interfaces;

namespace DataAccessLayer.Repository
{
    public class PropertyCategoryRepository : IPropertyCategoryRepository
    {
        public void AddPropertyCategory(PropertyCategory category)
        {
            PropertyCategoryDAO.Instance.AddPropertyCategory(category);
        }

        public PropertyCategory GetPropertyCategoryById(int categoryId)
        {
            return PropertyCategoryDAO.Instance.GetPropertyCategoryById(categoryId);
        }

        public List<PropertyCategory> GetAllPropertyCategories()
        {
            return PropertyCategoryDAO.Instance.GetAllPropertyCategories();
        }

        public void UpdatePropertyCategory(PropertyCategory category)
        {
            PropertyCategoryDAO.Instance.UpdatePropertyCategory(category);
        }

        public void DeletePropertyCategory(int categoryId)
        {
            PropertyCategoryDAO.Instance.DeletePropertyCategory(categoryId);
        }
    }
}
