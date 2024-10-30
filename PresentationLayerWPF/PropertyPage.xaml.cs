using BusinessObjectLayer.Model;
using BusinessObjectLayer;
using ServiceLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Xps;

namespace PresentationLayerWPF
{
    /// <summary>
    /// Interaction logic for PropertyPage.xaml
    /// </summary>
    public partial class PropertyPage : Page
    {
        private IPropertyService propertyService;
        private ITransactionDetailService transactionDetailService;
        private ITransactionService transactionService;
        private IMemberService memberService;
        public PropertyPage()
        {
            InitializeComponent();
            propertyService = new PropertyService();
            transactionDetailService = new TransactionDetailService();
            transactionService = new TransactionService();
            memberService = new MemberService();
            LoadProperties();
        }

        private void LoadProperties()
        {
            var properties = propertyService.GetAllProperties();
            PropertiesDataGrid.ItemsSource = properties;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            CreatePropertyForm cRPropertyForm = new CreatePropertyForm();
            cRPropertyForm.ShowDialog();
            LoadProperties();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedProperty = (Property)PropertiesDataGrid.SelectedItem;
            if (selectedProperty != null)
            {  
                propertyService.DeleteProperty(selectedProperty.PropertyId);
                LoadProperties();
                MessageBox.Show("Successfully deleted selected Property.");
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedProperty = (Property)PropertiesDataGrid.SelectedItem;
            if (selectedProperty != null)
            {
                var editForm = new UpdatePropertyForm(selectedProperty);
                editForm.ShowDialog();
                LoadProperties();
            }
            else
            {
                MessageBox.Show("Please select a property to update.");
            }
        }


        private void ViewDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            if (PropertiesDataGrid.SelectedItem is Property selectedProperty)
            {
                ViewDetailWindow detailsWindow = new ViewDetailWindow();

                detailsWindow.PropertyNameTextBlock.Text = selectedProperty.PropertyName;
                detailsWindow.LocationTextBlock.Text = selectedProperty.Location;
                detailsWindow.PriceTextBlock.Text = selectedProperty.Price.ToString("C");
                detailsWindow.SizeTextBlock.Text = selectedProperty.SizeSqFt.ToString();
                detailsWindow.BedroomsTextBlock.Text = selectedProperty.Bedrooms?.ToString() ?? "N/A";
                detailsWindow.BathroomsTextBlock.Text = selectedProperty.Bathrooms?.ToString() ?? "N/A";
                detailsWindow.DescriptionTextBlock.Text = selectedProperty.Description?.ToString();

                var transactionDetails = transactionDetailService.GetTransactionDetailsByPropertyId(selectedProperty.PropertyId);
                var ListToShow = new List<TransactionDetailViewModel>();

                try
                {
                    foreach (var item in transactionDetails)
                    {
                        var transaction = transactionService.GetTransactionById(item.TransactionId);
                        var buyer = memberService.GetBuyerById(transaction.BuyerId);
                        if(buyer == null)
                        {
                            MessageBox.Show("Donnot have buyer");
                            return;
                        }

                        var seller = memberService.GetSellerById(item.Transaction.SellerId);
                        if(seller == null)
                        {
                            MessageBox.Show("Donnot have seller");
                            return;

                        }

                        ListToShow.Add(new TransactionDetailViewModel
                        {
                            PropertyName = selectedProperty.PropertyName,
                            TransactionDate = transaction.TransactionDate.ToString("g"),
                            Price = item.Price,
                            BuyerName = buyer.FullName,
                            SellerName = seller.FullName
                        });
                    }
                }
                catch (Exception ex)
                {

                    
                }

                detailsWindow.TransactionDataGrid.ItemsSource = ListToShow;

                detailsWindow.Show();
            }
            else
            {
                MessageBox.Show("Please select a property to view details.");
            }
        }








        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var  searchItem = SearchTextBox.Text;
            if (searchItem == null) { return; }
            var linkObject = propertyService.GetAllProperties();
            List<Property> searchList = new List<Property>();
            foreach (var property in linkObject) 
            {
                if (property.PropertyName.ToLower().Contains(searchItem.ToLower()))
                {
                    searchList.Add(property);
                }
            }
            PropertiesDataGrid.ItemsSource = searchList;
        }

        private void PropertiesDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if(e.PropertyName == "CategoryId" || e.PropertyName == "TransactionDetails")
            {
                e.Cancel = true;
            }
        }
    }
}
