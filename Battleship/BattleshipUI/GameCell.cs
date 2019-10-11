using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

/*
 * Crystal Liles
 */

namespace BattleshipUI
{
    public partial class GameCell : UserControl
    {
        public GameCell()
        {
            InitializeComponent();
        }

        public int GameCellRow { get; set; }
        public int GameCellColumn { get; set; }
        public ShipCellSegment { get; set; }

    }
}
