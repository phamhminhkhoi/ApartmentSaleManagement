using System.Collections.Generic;
using BusinessObjectLayer;
using RepositoryLayer.Interfaces;

namespace DataAccessLayer.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        public void AddProperty(Property property)
        {
            PropertyDAO.Instance.AddProperty(property);
        }

        public Property GetPropertyById(int propertyId)
        {
            return PropertyDAO.Instance.GetPropertyById(propertyId);
        }

        public List<Property> GetAllProperties()
        {
            return PropertyDAO.Instance.GetAllProperties();
        }

        public void UpdateProperty(Property property)
        {
            PropertyDAO.Instance.UpdateProperty(property);
        }

        public void DeleteProperty(int propertyId)
        {
            PropertyDAO.Instance.DeleteProperty(propertyId);
        }


    }
}
