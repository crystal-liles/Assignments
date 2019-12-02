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

namespace SimpleForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Full Name:  {FullName.Text}");
            sb.AppendLine($"Gender? {((bool) Male.IsChecked ? "Male" : "Female")}");
            sb.AppendLine($"Computer: {((bool)Desktop.IsChecked ? "Desktop " : "")} {((bool)Laptop.IsChecked ? "Laptop " : "")} {((bool)Tablet.IsChecked ? "Tablet " : "")}");
            sb.AppendLine($"Your job {Job.SelectedItem.ToString()}");
            sb.AppendLine($"Delivery Date {(DeliveryDate.SelectedDate.ToString())}");

            MessageBox.Show(sb.ToString());

        }

        private void Job_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newlySelectedItems = e.AddedItems[0];
            MessageBox.Show(newlySelectedItems.ToString());
        }
    }

}
