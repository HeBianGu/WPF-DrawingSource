using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace HeBianGu.DrawingSource.Demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UniformGrid_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;

            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "code.txt");

            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path).Dispose();
            }

            System.IO.File.WriteAllText(path, button?.Tag?.ToString());

            Process.Start(path);
        }
    }
}
