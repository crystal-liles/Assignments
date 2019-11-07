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

        /*
         * ProfReynolds
         * I added this for you
         */
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeAndSetupNewGame();
        }

        private void BtnResetGame_Click(object sender, RoutedEventArgs e)
        {
            InitializeAndSetupNewGame();
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
        private void InitializeAndSetupNewGame()
        {
            foreach (var uc in ButtonCanvas.Children)
            {
                if (uc is GameCell gc)
                {
                    gc.ShipSegment = ShipCellSegment.Water;
                    gc.ShipSegmentShown = false;
                }
            }

            {
                GameCell00.ShipSegment = ShipCellSegment.Left;
                GameCell01.ShipSegment = ShipCellSegment.Horizontal;
                GameCell02.ShipSegment = ShipCellSegment.Horizontal;
                GameCell03.ShipSegment = ShipCellSegment.Right;
                GameCell14.ShipSegment = ShipCellSegment.Top;
                GameCell24.ShipSegment = ShipCellSegment.Vertical;
                GameCell34.ShipSegment = ShipCellSegment.Bottom;
                GameCell41.ShipSegment = ShipCellSegment.Single;
            }
        }


    }
}