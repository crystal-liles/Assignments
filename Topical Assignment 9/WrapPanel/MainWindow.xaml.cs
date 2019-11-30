using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WrapPanel
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

        private void MainWindow_OnLocationChanged(object sender, EventArgs e)
        {
            var rnd = new Random();

            Rec0.Width = rnd.Next(25, 201);
            Rec1.Width = rnd.Next(25, 201); 
            Rec2.Width = rnd.Next(25, 201);
            Rec3.Width = rnd.Next(25, 201);
            Rec4.Width = rnd.Next(25, 201);
            Rec5.Width = rnd.Next(25, 201);
            Rec6.Width = rnd.Next(25, 201);
            Rec7.Width = rnd.Next(25, 201);
            Rec8.Width = rnd.Next(25, 201);
            Rec9.Width = rnd.Next(25, 201);
            Rec10.Width = rnd.Next(25, 201);
            Rec11.Width = rnd.Next(25, 201); 
            Rec12.Width = rnd.Next(25, 201);
            Rec13.Width = rnd.Next(25, 201);

        }
    }
}
