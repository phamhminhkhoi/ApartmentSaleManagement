using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IPropertyCategoryRepository
    {
        void AddPropertyCategory(PropertyCategory category);
        PropertyCategory GetPropertyCategoryById(int categoryId);
        List<PropertyCategory> GetAllPropertyCategories();
        void UpdatePropertyCategory(PropertyCategory category);
        void DeletePropertyCategory(int categoryId);
    }
}
