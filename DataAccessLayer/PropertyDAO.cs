using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BusinessObjectLayer;

namespace DataAccessLayer
{
    public class PropertyDAO
    {
        private readonly SaleManagementContext _context;
        public static PropertyDAO instance = null;
        public static PropertyDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PropertyDAO();
                }
                return instance;
            }
        }

        public PropertyDAO()
        {
            _context = new SaleManagementContext();
        }

        public void AddProperty(Property property)
        {
            _context.Properties.Add(property);
            _context.SaveChanges();
        }

        public Property GetPropertyById(int propertyId)
        {
            return _context.Properties
                           .Include(p => p.Category)
                           .FirstOrDefault(p => p.PropertyId == propertyId);
        }

        public List<Property> GetAllProperties()
        {
            return _context.Properties
                           .Include(p => p.Category)
                           .ToList();
        }

        public void UpdateProperty(Property property)
        {
            var existingProperty = _context.Properties.Find(property.PropertyId);
            if (existingProperty != null)
            {
                _context.Entry(existingProperty).CurrentValues.SetValues(property);
                _context.SaveChanges();
            }
        }

        public void DeleteProperty(int propertyId)
        {
            var property = _context.Properties.Find(propertyId);
            if (property != null)
            {
                _context.Properties.Remove(property);
                _context.SaveChanges();
            }
        }
    }
}
