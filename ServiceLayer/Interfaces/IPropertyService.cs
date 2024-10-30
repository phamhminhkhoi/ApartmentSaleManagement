using System.Collections.Generic;
using BusinessObjectLayer;

namespace ServiceLayer.Interfaces
{
    public interface IPropertyService
    {
        void AddProperty(Property property);
        Property GetPropertyById(int propertyId);
        List<Property> GetAllProperties();
        void UpdateProperty(Property property);
        void DeleteProperty(int propertyId);
    }
}
