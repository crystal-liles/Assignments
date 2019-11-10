using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private struct ShipSegmentDefinition
        {
            public int row;
            public int col;
            public ShipCellSegment shipCellSegment;
        }
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
            // MessageBox.Show("BtnShowSolution_Click Event");
            foreach (var userControl in ButtonCanvas.Children
            ) // check each element because we cannot shorten this process
            {
                if (userControl is GameCell gameCell) // is it a GameCell?, then lets call it gameCell
                {
                    gameCell.ShipSegmentShown = true;
                }
            }
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
            ButtonCanvas.Children.Clear();
            for (var row = 0; row < 10; row++)
            {
                for (var col = 0; col < 10; col++)
                {
                    var newGameCell = new GameCell
                    {
                        Name = $"GameCell{row}{col}",
                        Height = 50,
                        Width = 50,
                        Margin = new Thickness
                        {
                            Left = col * 50,
                            Top = row * 50
                        }
                    };
                    ButtonCanvas.Children.Add(newGameCell);
                }
            }

            foreach (var uc in ButtonCanvas.Children)
            {
                if (uc is GameCell gc)
                {
                    gc.ShipSegment = ShipCellSegment.Water;
                    gc.ShipSegmentShown = false;
                }
            }

            {
                //SetUserControlSegment(0,0,ShipCellSegment.Left);
                //SetUserControlSegment(0,1,ShipCellSegment.Horizontal);
                //SetUserControlSegment(0,2,ShipCellSegment.Horizontal);
                //SetUserControlSegment(0,3,ShipCellSegment.Right);
                //SetUserControlSegment(1,4,ShipCellSegment.Top);
                //SetUserControlSegment(2,4,ShipCellSegment.Vertical);
                //SetUserControlSegment(3,4,ShipCellSegment.Bottom);
                //SetUserControlSegment(4,1,ShipCellSegment.Single);
                var collectionOfShipSegments = new Collection<ShipSegmentDefinition>
                {
                    new ShipSegmentDefinition {row = 0, col = 0, shipCellSegment = ShipCellSegment.Left},
                    new ShipSegmentDefinition {row = 0, col = 1, shipCellSegment = ShipCellSegment.Horizontal},
                    new ShipSegmentDefinition {row = 0, col = 2, shipCellSegment = ShipCellSegment.Horizontal},
                    new ShipSegmentDefinition {row = 0, col = 3, shipCellSegment = ShipCellSegment.Right},
                    new ShipSegmentDefinition {row = 1, col = 4, shipCellSegment = ShipCellSegment.Top},
                    new ShipSegmentDefinition {row = 2, col = 4, shipCellSegment = ShipCellSegment.Vertical},
                    new ShipSegmentDefinition {row = 3, col = 4, shipCellSegment = ShipCellSegment.Bottom},
                    new ShipSegmentDefinition {row = 4, col = 1, shipCellSegment = ShipCellSegment.Single}
                };
                foreach (var shipSegmentDefinition in collectionOfShipSegments)
                {
                    SetUserControlSegment(
                        shipSegmentDefinition.row,
                        shipSegmentDefinition.col,
                        shipSegmentDefinition.shipCellSegment);
                }
            }
        }
        private void SetUserControlSegment(int row, int col, ShipCellSegment shipCellSegment)
        {
            foreach (var userControl in ButtonCanvas.Children) // check each element because we cannot shorten this process
            {
                if (userControl is GameCell gameCell) // is it a GameCell?, then lets call it gameCell
                {
                    if (gameCell.Name == $"GameCell{row}{col}") // is gameCell the one we seek?
                    {
                        gameCell.ShipSegment = shipCellSegment; // finally, assign the segment!
                    }
                }
            }
        }

    }
}