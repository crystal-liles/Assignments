﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topical_Assignment_10___Connect_Four
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private int _gameCells;
        private void InitializeAndSetupNewGame()
        {
            _gameCells.Clear(); // resets the collection of game cells
            pnlGameGrid.Controls.Clear();
            pnlGameGrid.Size = new Size(90 * _numCols, 80 * _numRows);
            this.Size = new Size(pnlGameGrid.Left + pnlGameGrid.Width + 50, pnlGameGrid.Top + pnlGameGrid.Height + 75);
            for (var row = 0; row < _numRows; row++)
            {
                for (var col = 0; col < _numCols; col++)
                {
                    var newGameCell = new GameCell
                    {
                        GameCellRow = row,
                        GameCellCol = col,
                        GameCellState = GameCellStates.clear,
                        Location = new Point(col * 90, row * 80)
                    };
                    _gameCells.Add(newGameCell);
                    pnlGameGrid.Controls.Add(newGameCell);
                }
            }
        }

    }
}
