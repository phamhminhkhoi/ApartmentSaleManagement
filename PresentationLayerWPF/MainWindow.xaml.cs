using System.Windows;
using Microsoft.Data.SqlClient;
using ServiceLayer;
using ServiceLayer.Interfaces;

namespace PresentationLayerWPF
{
    public partial class MainWindow : Window
    {
        private readonly IMemberService _memberService;

        public MainWindow()
        {
            InitializeComponent();
            _memberService = new MemberService();
        }

        // Constructor for dependency injection
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string email = EmailTextBox.Text;
                string password = PasswordBox.Password;

                // Check for empty fields
                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both email and password.");
                    return;
                }

                // Attempt to retrieve member data
                var member = _memberService.GetMemberByEmail(email);

                if (member == null)
                {
                    MessageBox.Show("No account found with this email.");

                    return;
                }

                // Check if the password matches
                if (member.Password != password)
                {
                    MessageBox.Show("Invalid email or password.");
                    return;
                }

                // Check for role-specific access
                if (member.Role.RoleName == "Admin")
                {
                    ErrorMessage.Visibility = Visibility.Collapsed;
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You do not have access to the system.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The email format is invalid.");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("An unexpected error occurred. Please try again.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("An error occurred during login. Please contact support if the issue persists.");
            }

            catch (Exception ex)
            {
                // Log exception details for debugging
                MessageBox.Show("An error occurred during login. Please contact support if the issue persists.");
            }
            
        }


        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry ! You cannot using this feature for now. We will update in time.");

        }
    }
}
