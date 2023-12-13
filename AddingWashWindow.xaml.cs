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
using System.Windows.Shapes;

namespace WashingHouseChetvernyaDemo
{
    /// <summary>
    /// Логика взаимодействия для AddingWashWindow.xaml
    /// </summary>
    public partial class AddingWashWindow : Window
    {
        public AddingWashWindow()
        {
            InitializeComponent();
            CmbMachine.ItemsSource = Helper.context.Machine.ToList();
            CmbPowder.ItemsSource = Helper.context.Powder.ToList();
            DataContext = new Staff();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbMachineSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CmbPowderSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
