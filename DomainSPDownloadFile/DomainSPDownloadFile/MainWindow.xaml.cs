using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace DomainSPDownloadFile
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var currentDomain = AppDomain.CurrentDomain;
            AnalizeDomain(currentDomain);
        }

        private void DownLoadFile(object sender, RoutedEventArgs e)
        {
            var secondDomain = AppDomain.CreateDomain("File Download");
            AnalizeDomain(secondDomain);

            secondDomain.ExecuteAssembly(secondDomain.BaseDirectory + "DownLoadingFile.exe");
            AnalizeDomain(secondDomain);
        }
        

        private void СalculationClick(object sender, RoutedEventArgs e)
        {
            CalculateForm calculateForm = new CalculateForm();
            calculateForm.Show();
        }

        private static void AnalizeDomain(AppDomain currentDomain)
        {
            Console.WriteLine($"{currentDomain.FriendlyName}, {currentDomain.BaseDirectory}, {currentDomain.Id}");

            var assembles = currentDomain.GetAssemblies();
            foreach (var assembly in assembles)
            {
                Console.WriteLine($"{assembly.FullName}, {assembly.Location}");
            }
        }
    }
}
