using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace DomainSPDownloadFile
{
    /// <summary>
    /// Логика взаимодействия для CalculateForm.xaml
    /// </summary>
    public partial class CalculateForm : Window
    {
        public CalculateForm()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("fileNumber.txt", textBoxCalculate.Text);
            var secondDomain = AppDomain.CreateDomain("CalculationWPF");
            //AnalizeDomain(secondDomain);

            secondDomain.ExecuteAssembly(secondDomain.BaseDirectory + "CalculateWPF.exe");
            //AnalizeDomain(secondDomain);
        }

        //private static void AnalizeDomain(AppDomain currentDomain)
        //{
        //    Console.WriteLine($"{currentDomain.FriendlyName}, {currentDomain.BaseDirectory}, {currentDomain.Id}");

        //    var assembles = currentDomain.GetAssemblies();
        //    foreach (var assembly in assembles)
        //    {
        //        Console.WriteLine($"{assembly.FullName}, {assembly.Location}");
        //    }
        //}
    }
}
