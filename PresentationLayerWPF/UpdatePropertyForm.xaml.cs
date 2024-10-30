using BusinessObjectLayer;
using ServiceLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace PresentationLayerWPF
{
    public partial class UpdatePropertyForm : Window
    {
        private readonly IPropertyService propertyService;
        private readonly IPropertyCategoryService categoryService; 
        private Property selectedProp;

        public UpdatePropertyForm(Property property)
        {
            InitializeComponent();
            this.propertyService = new PropertyService();
            this.categoryService = new PropertyCategoryService();
            this.selectedProp = property;

            LoadCategories();
            FillPropertyDetails();
        }

        private void LoadCategories()
        {
            var categories = categoryService.GetAllPropertyCategories();
            CategoryIdComboBox.ItemsSource = categories;
        }

        private void FillPropertyDetails()
        {
            PropertyNameTextBox.Text = selectedProp.PropertyName;
            LocationTextBox.Text = selectedProp.Location;
            PriceTextBox.Text = selectedProp.Price.ToString();
            SizeTextBox.Text = selectedProp.SizeSqFt.ToString();
            BedroomsTextBox.Text = selectedProp.Bedrooms?.ToString();
            BathroomsTextBox.Text = selectedProp.Bathrooms?.ToString();
            CategoryIdComboBox.SelectedValue = selectedProp.CategoryId;
            DescriptionTextBox.Text = selectedProp.Description;
        }

        private void UpdatePropertyButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PropertyNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LocationTextBox.Text) ||
                string.IsNullOrWhiteSpace(PriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(SizeTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            var updatedProperty = new Property
            {
                PropertyId = selectedProp.PropertyId,
                PropertyName = PropertyNameTextBox.Text,
                Location = LocationTextBox.Text,
                Price = decimal.Parse(PriceTextBox.Text),
                SizeSqFt = int.Parse(SizeTextBox.Text),
                Bedrooms = string.IsNullOrWhiteSpace(BedroomsTextBox.Text) ? (int?)null : int.Parse(BedroomsTextBox.Text),
                Bathrooms = string.IsNullOrWhiteSpace(BathroomsTextBox.Text) ? (int?)null : int.Parse(BathroomsTextBox.Text),
                CategoryId = (int)CategoryIdComboBox.SelectedValue,
                Description = DescriptionTextBox.Text,
                
            };

            try
            {
                propertyService.UpdateProperty(updatedProperty);
                MessageBox.Show("Property updated successfully.");
                this.DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update the property. Error: {ex.Message}");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
