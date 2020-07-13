using Microsoft.Win32;
using SessionManager.Database;
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

namespace SessionManager
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SystemsData systems = new SystemsData();
        DatabaseControler databaseObject = new DatabaseControler();

        public MainWindow()
        {
            InitializeComponent();

            SystemPick.ItemsSource = systems;
        }

        private void ButtonPower_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void MinimButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ImageChose_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == true)
            {
                string selectedFileName = dlg.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();
                NpcImage.Source = bitmap;
            }
        }

        private void AddNpcButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SystemPick_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            String selectedSystem = e.AddedItems[0].ToString();
            //selectedSystem = selectedSystem.Split(':')[1].TrimStart(' ');
            TestSystem.Text = selectedSystem;
            switch (selectedSystem)
            {
                case "Fate Core":
                    SystemFate.Visibility = Visibility.Visible;
                    SystemDnD5e.Visibility = Visibility.Collapsed;
                    break;
                case "DnD 5e":
                    SystemFate.Visibility = Visibility.Collapsed;
                    SystemDnD5e.Visibility = Visibility.Visible;
                    break;
                default:
                    SystemFate.Visibility = Visibility.Collapsed;
                    SystemDnD5e.Visibility = Visibility.Collapsed;
                    break;
            }
        }
    }
}
