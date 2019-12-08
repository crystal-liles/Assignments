using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topical_Assignment_10___Connect_Four
{
    public partial class GameCell : UserControl
    {
        public GameCell()
        {
            InitializeComponent();
        }

        public GameCellStates GameCellsState
        {
            get => _gameCellStates;
            set
            {
                _gameCellStates = value;
                DisplayButtonBackground();
            }
        }

        private readonly IDictionary<GameCellStates, Uri> _gameCellStatesUri =
            new Dictionary<GameCellStates, Uri>
            {
                {GameCellStates.Clear, new Uri("Images/gamecellstates_clear.png", UriKind.Relative)},
                {GameCellStates.Computer, new Uri("Images/gamecellstates_computer.png", UriKind.Relative)},
                {GameCellStates.Error, new Uri("Images/gamecellstates_error.png", UriKind.Relative)},
                {GameCellStates.Player, new Uri("Images/gamecellstates_player.png", UriKind.Relative)},
            };

        private void DisplayButtonBackground()
        {
            switch (_gameCellStates)
            {
                case GameCellStates.Clear:
                {
                    var uri = _gameCellStatesUri[GameCellStates.Clear];
                    //var bitmapImage = new BitmapImage(uri);
                    //var brush = new ImageBrush();
                    //brush.ImageSource = bitmapImage;
                    //brush.Stretch = Stretch.Fill;
                    //BtnCellSegment.Background = brush;
                    break;
                }
                case GameCellStates.Computer:
                {
                    var uri = _gameCellStatesUri[GameCellStates.Computer];
                    //var bitmapImage = new BitmapImage(uri);
                    //var brush = new ImageBrush();
                    //brush.ImageSource = bitmapImage;
                    //brush.Stretch = Stretch.Fill;
                    //BtnCellSegment.Background = brush;
                        break;
                }
                case GameCellStates.Error:
                {
                    var uri = _gameCellStatesUri[GameCellStates.Error];
                    //var bitmapImage = new BitmapImage(uri);
                    //var brush = new ImageBrush();
                    //brush.ImageSource = bitmapImage;
                    //brush.Stretch = Stretch.Fill;
                    //BtnCellSegment.Background = brush;
                        break;
                }
                case GameCellStates.Player:
                {
                    var uri = _gameCellStatesUri[GameCellStates.Player];
                    //var bitmapImage = new BitmapImage(uri);
                    //var brush = new ImageBrush();
                    //brush.ImageSource = bitmapImage;
                    //brush.Stretch = Stretch.Fill;
                    //BtnCellSegment.Background = brush;
                        break;
                }
            }
        }
    }
}
