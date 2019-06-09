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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculateWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Calculate();
        }
        public void Calculate()
        {

            textCalculate.Text= File.ReadAllText("fileNumber.txt");
            if(string.IsNullOrEmpty(textCalculate.Text))
            {
                Console.WriteLine("Ошибка чтения файла");
            }
            else
            {
                int points = int.Parse(textCalculate.Text);
                long cycle = 1;
                for (int i = 1; i <= points; i++)
                {
                    cycle *= i;
                }
                textCalculate.Text = $"Факториал = {cycle}";
            }
        }
    }
}
