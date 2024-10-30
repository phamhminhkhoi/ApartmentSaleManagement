using System.Collections.Generic;
using BusinessObjectLayer;

namespace ServiceLayer.Interfaces
{
    public interface IPropertyCategoryService
    {
        void AddPropertyCategory(PropertyCategory category);
        PropertyCategory GetPropertyCategoryById(int categoryId);
        List<PropertyCategory> GetAllPropertyCategories();
        void UpdatePropertyCategory(PropertyCategory category);
        void DeletePropertyCategory(int categoryId);
    }
}
