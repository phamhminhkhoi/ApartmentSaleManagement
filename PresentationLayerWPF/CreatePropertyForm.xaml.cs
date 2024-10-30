using System;
using System.Windows;
using BusinessObjectLayer;
using ServiceLayer;
using ServiceLayer.Interfaces;

namespace PresentationLayerWPF
{
    public partial class CreatePropertyForm : Window
    {
        private readonly IPropertyService propertyService;
        private readonly IPropertyCategoryService categoryService;


        public CreatePropertyForm()
        {
            InitializeComponent();
            this.propertyService = new PropertyService();
            this.categoryService = new PropertyCategoryService();
            LoadCategories();
        }

        private void AddPropertyButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newProperty = new Property
                {
                    PropertyName = PropertyNameTextBox.Text,
                    Location = LocationTextBox.Text,
                    Price = decimal.Parse(PriceTextBox.Text),
                    SizeSqFt = int.Parse(SizeTextBox.Text),
                    Bedrooms = string.IsNullOrEmpty(BedroomsTextBox.Text) ? (int?)null : int.Parse(BedroomsTextBox.Text),
                    Bathrooms = string.IsNullOrEmpty(BathroomsTextBox.Text) ? (int?)null : int.Parse(BathroomsTextBox.Text),
                    CategoryId = (int)CategoryIdComboBox.SelectedValue,
                    Description = DescriptionTextBox.Text
                };

                propertyService.AddProperty(newProperty);
                MessageBox.Show("Property added successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding property: {ex.Message}");
            }
        }

        private void LoadCategories()
        {
            var categories = categoryService.GetAllPropertyCategories();
            CategoryIdComboBox.ItemsSource = categories;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
