using System.Windows;

namespace DatabaseApp1
{
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void AddEntryButton_Click(object sender, RoutedEventArgs e)
        {
            AddEntryPage addEntryPage = new AddEntryPage();
            addEntryPage.Show();
            this.Close();
        }

        private void SaveEntryButton_Click(object sender, RoutedEventArgs e)
        {
            SaveEntryPage saveEntryPage = new SaveEntryPage();
            saveEntryPage.Show();
            this.Close();
        }

        private void AboutDevelopersButton_Click(object sender, RoutedEventArgs e)
        {
            AboutDevelopersPage aboutDevelopersPage = new AboutDevelopersPage();
            aboutDevelopersPage.Show();
            this.Close();
        }
    }
}
