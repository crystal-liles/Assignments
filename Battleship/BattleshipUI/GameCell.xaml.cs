using System.Windows.Controls;


/*
 * Crystal Liles
 */

namespace BattleshipUI
{
    public partial class GameCell : UserControl
    { 

        public int GameCellRow { get; set; }
        public int GameCellColumn { get; set; }
        public ShipCellSegment ShipSegment { get; set; }

        private void BtnCellSegment_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }

}
