using BusinessObjectLayer;
using ServiceLayer.Interfaces;
using ServiceLayer;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace PresentationLayerWPF
{
    /// <summary>
    /// Interaction logic for MemberPage.xaml
    /// </summary>
    public partial class MemberPage : Page
    {
        private IMemberService memberService;
        private IRoleUserService roleService; // Assuming you have a service for roles


        public MemberPage()
        {
            InitializeComponent();
            memberService = new MemberService();
            roleService = new RoleUserService(); // Ensure you have this service
            LoadMembers();
        }

        private void LoadMembers()
        {
            var members = memberService.GetMembers();
            var Members = new List<Member>();
            foreach (var member in members) 
            {
                if(member.RoleId != 1) Members.Add(member); 
               
            }

            MemberDataGrid.ItemsSource = Members;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //CreateMemberForm createMemberForm = new CreateMemberForm();
            //if (createMemberForm.ShowDialog() == true)
            //{
            //    LoadMembers();
            //}
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            //if (MemberDataGrid.SelectedItem is Member selectedMember)
            //{
            //    var editForm = new UpdateMemberForm(selectedMember);
            //    if (editForm.ShowDialog() == true)
            //    {
            //        LoadMembers();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a member to update.");
            //}
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //if (MemberDataGrid.SelectedItem is Member selectedMember)
            //{
            //    memberService.DeleteMember(selectedMember.MemberId);
            //    LoadMembers();
            //    MessageBox.Show("Successfully deleted selected member.");
            //}
            //else
            //{
            //    MessageBox.Show("Please select a member to delete.");
            //}
        }

        private void MemberDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "RoleId" || e.PropertyName == "TransactionBuyers" || e.PropertyName == "TransactionSellers")
            {
                e.Cancel = true;
            }
        }

        private void AddMemberButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry ! You cannot using this feature for now. We will update in time.");
        }

        private void EditMemberButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry ! You cannot using this feature for now. We will update in time.");

        }

        private void DeleteMemberButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry ! You cannot using this feature for now. We will update in time.");

        }
    }
}
