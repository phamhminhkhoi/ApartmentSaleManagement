using System.Collections.Generic;
using BusinessObjectLayer;
using DataAccessLayer.Repository;
using RepositoryLayer.Interfaces;
using ServiceLayer.Interfaces;

namespace ServiceLayer
{
    public class PropertyService : IPropertyService
    {
        private readonly IPropertyRepository _propertyRepository = new PropertyRepository();

        public void AddProperty(Property property)
        {
            _propertyRepository.AddProperty(property);
        }

        public Property GetPropertyById(int propertyId)
        {
            return _propertyRepository.GetPropertyById(propertyId);
        }

        public List<Property> GetAllProperties()
        {
            return _propertyRepository.GetAllProperties();
        }

        public void UpdateProperty(Property property)
        {
            _propertyRepository.UpdateProperty(property);
        }

        public void DeleteProperty(int propertyId)
        {
            _propertyRepository.DeleteProperty(propertyId);
        }
    }
}
