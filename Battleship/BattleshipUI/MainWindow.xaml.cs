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

namespace BattleshipUI
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

        private void BtnResetGame_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BtnResetGame_Click Event");
        }

        private void BtnShowOneCell_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BtnShowOneCell_Click Event");
        }

        private void BtnShowSolution_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BtnShowSolution_Click Event");
        }

        private void BtnAboutBattleship_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new AboutWindow();
            newForm.Show();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        
    }
}