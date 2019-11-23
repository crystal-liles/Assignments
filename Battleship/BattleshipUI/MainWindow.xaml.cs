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
        private const int GameCellSize = 60; // this is the size of the game cell - previously it was always 50
        private const int GamePanelSize = 8; // this is the number of rows and columns, previously, this was always 10
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
            //MessageBox.Show("BtnShowOneCell_Click Event");

            foreach (var userControl in ButtonCanvas.Children)
            {
                if (userControl is GameCell gamecell)
                {
                    if (gamecell.ShipSegmentShown)
                    {
                        gamecell.ShipSegmentShown = true;
                    }
                }
            }
        }

        private void BtnShowSolution_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("BtnShowSolution_Click Event");
            foreach (var userControl in ButtonCanvas.Children) // check each element because we cannot shorten this process
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
            for (var row = 0; row < GamePanelSize; row++)
            { 
                for (var row = 0; row < GamePanelSize; row++)
                { 
                    var newGameCell = new GameCell 
                    {
                        Name = $"GameCell{row}{col}",
                        Height = GameCellSize,,
                        Width = GameCellSize,
                        Margin = new Thickness
                        {
                            Left = col * GameCellSize,
                            Top = row * GameCellSize
                        }
                    };
                    ButtonCanvas.Children.Add(newGameCell);
                }
            }

            GameBorder.Width = GamePanelSize * GameCellSize + GameBorder.BorderThickness.Left * 2;
            GameBorder.Height = GamePanelSize * GameCellSize + GameBorder.BorderThickness.Top * 2;

            foreach (var uc in ButtonCanvas.Children)
            {
                if (uc is GameCell gc)
                {
                    gc.ShipSegment = ShipCellSegment.Water;
                    gc.ShipSegmentShown = false;
                }
            }

            {

                int[] gamePieces = { 5, 4, 3, 3, 2, 2, 2, 2 };

                var r = new Random();

                foreach (var gamePiece in gamePieces)
                {
                    var placementCompleted = false; // used to exit the do...while loop
                    do
                    {
                        if (r.Next(0, 2) == 0) // attempt to make the one horizontal
                        {
                            // Horizontal ships will be defined and placed here
                            var row = r.Next(0, GamePanelSize); // select random row
                            var col = r.Next(0, GamePanelSize - gamePiece); // select random col
                            var cellsAppearEmpty = true; // this may change to false and a new row/col will be selected
                            // check that each cell is empty (remember, this is a horizontal ship)
                            for (var cellcol = col; cellcol <= col + gamePiece; cellcol++)
                            {
                                var testCell = LocateByRowCol(row, cellcol);
                                var thisTestCellAppearsEmpty = (testCell.ShipSegment == ShipCellSegment.Water);
                                cellsAppearEmpty = cellsAppearEmpty &&
                                                   thisTestCellAppearsEmpty;
                            }

                            if (cellsAppearEmpty) // so far so good - now set the cells as appropriate
                            {
                                // change the _left_ game cell to ShipCellSegment.left
                                var leftGameCell = LocateByRowCol(row, col); // first segment
                                leftGameCell.ShipSegment = ShipCellSegment.Left;
                                // change the _right_ game cell to ShipCellSegment.right
                                var rightGameCell = LocateByRowCol(row, col + gamePiece - 1); // last segment
                                rightGameCell.ShipSegment = ShipCellSegment.Right;
                                if (gamePiece > 2) // has middle pieces
                                {
                                    for (var cellcol = col + 1;
                                        cellcol <= col + gamePiece - 2;
                                        cellcol++) // the pieces in the middle
                                    {
                                        var thisGameCell = LocateByRowCol(row, cellcol);
                                        thisGameCell.ShipSegment = ShipCellSegment.Horizontal;
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Vertical ships will be defined and placed here
                            var col = r.Next(0, GamePanelSize); // select random col
                            var row = r.Next(0, GamePanelSize - gamePiece); // select random row
                            var cellsAppearEmpty = true; // this may change to false and a new row/col will be selected
                            // check that each cell is empty (remember, this is a vertical ship)
                            for (var cellrow = row; cellrow <= row + gamePiece; cellrow++)
                            {
                                var testCell = LocateByRowCol(cellrow, col);
                                var thisTestCellAppearsEmpty = testCell.ShipSegment == ShipCellSegment.Water;
                                cellsAppearEmpty = cellsAppearEmpty &&
                                                   thisTestCellAppearsEmpty;
                            }

                            if (cellsAppearEmpty) // so far so good - now set the cells as appropriate
                            {
                                // change the _right_ game cell to ShipCellSegment.right
                                var rightGameCell = LocateByRowCol(row, col); // first segment
                                rightGameCell.ShipSegment = ShipCellSegment.Right;
                                // change the _right_ game cell to ShipCellSegment.Right
                                var leftGameCell = LocateByRowCol(row + gamePiece - 1, col); // last segment
                                leftGameCell.ShipSegment = ShipCellSegment.Left;
                                if (gamePiece > 2) // has middle pieces
                                    for (var cellrow = row + 1;
                                        cellrow <= row + gamePiece - 2;
                                        cellrow++) // the pieces in the middle
                                    {
                                        var thisGameCell = LocateByRowCol(cellrow, col);
                                        thisGameCell.ShipSegment = ShipCellSegment.Vertical;
                                    }
                            }
                        }
                    } while (!placementCompleted);
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
        private GameCell LocateByRowCol(int gameCellRow, int gameCellColumn)
        {
            foreach (var uc in ButtonCanvas.Children)
            {
                if (uc is GameCell gc)
                {
                    if (gc.Name == $"GameCell{gameCellRow}{gameCellColumn}")
                    {
                        return gc;
                    }
                }
            }
            return null;
        }
    }
}