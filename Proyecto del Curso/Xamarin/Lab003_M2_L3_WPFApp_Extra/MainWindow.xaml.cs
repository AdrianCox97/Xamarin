using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab003_M2_L3_WPFApp_Extra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Lab003_M2_L3_SharedProject.MySharedCode sharedCode =
                new Lab003_M2_L3_SharedProject.MySharedCode();

            MessageBox.Show(
                sharedCode.GetFilePath("demo.dat"),
                "Información",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }
}