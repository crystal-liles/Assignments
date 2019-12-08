using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonFramework.Core;
using Topical_Assignment_10___Connect_Four.Properties;

namespace Topical_Assignment_10___Connect_Four
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void columnTxt_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox tbox)
            {
                var suggestedColumns = tbox.Text.ToInt();
                e.Cancel = suggestedColumns < 5 || suggestedColumns > 10;
                
            }
        }

        private void rowTxt_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox tbox)
            {
                var suggestedRows = tbox.Text.ToInt();
                e.Cancel = suggestedRows < 4 || suggestedRows > 8;
            }
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            InitializeAndSetupNewGame();
        }

        private Collection<GameCell> _gameCells { get; set; }
        

        private void InitializeAndSetupNewGame()
        {
            int _numCols = columnTxt.Text.ToInt();
            int _numRows = rowTxt.Text.ToInt();
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
                        GameCellState = GameCellStates.Clear,
                        Location = new Point(col * 90, row * 80)
                    };
                    _gameCells.Add(newGameCell);
                    pnlGameGrid.Controls.Add(newGameCell);
                }
            }
        }

        
    }
}
