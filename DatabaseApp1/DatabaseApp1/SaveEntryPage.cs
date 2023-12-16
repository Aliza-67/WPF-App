using System;
using System.Windows;
using System.Windows.Controls;

namespace DatabaseApp1
{
    public partial class SaveEntryPage : UserControl
    {
        public SaveEntryPage()
        {
            InitializeComponent();
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        private void SaveEntryBackButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void Close()
        {
            throw new NotImplementedException();
        }
    }
}
