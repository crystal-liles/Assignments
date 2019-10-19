using System.Windows;

namespace BattleshipUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        private void BtwResetGame_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BtnResetGame_Click Event");
        }

        private void BtwShowOneCell_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BtnShowOneCell_Click Event");
        }

        private void BtwShowSolution_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BtwnShowSolution_Click Event");
        }

        private void BtwAboutBattleship_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("BtnAboutBattleship_Click Event");
        }

        private void BtwExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
