using System;
using System.Windows;

namespace DatabaseApp1
{
    public partial class AddEntryPage : Window
    {
        public AddEntryPage()
        {
            InitializeComponent();
        }

        private void AddEntrySaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Add code to save the entry
        }

        private void AddEntryBackButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
