using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IPropertyRepository
    {
        void AddProperty(Property property);
        Property GetPropertyById(int propertyId);
        List<Property> GetAllProperties();
        void UpdateProperty(Property property);
        void DeleteProperty(int propertyId);
    }
}
