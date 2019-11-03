using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;



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

        private bool _shipSegmentShown;
        public bool ShipSegmentShown {
            get => _shipSegmentShown;
            set
            {
                _shipSegmentShown = value;
                DisplayButtonBackground();
            } }

        private ShipCellSegment _shipSegment = ShipCellSegment.Unknown;
        public ShipCellSegment ShipSegment
        {
            get => _shipSegment;
            set
            {
                _shipSegment = value;
                DisplayButtonBackground();
            }
        }

        private readonly IDictionary<ShipCellSegment, Uri> _shipCellSegmentUri =
            new Dictionary<ShipCellSegment, Uri>
            {
                {ShipCellSegment.Unknown, new Uri("Images/battleship_unknown.png", UriKind.Relative)},
                {ShipCellSegment.Water, new Uri("Images/battleship_tile.png", UriKind.Relative)},
                {ShipCellSegment.Single, new Uri("Images/battleship_single.png", UriKind.Relative)},
                {ShipCellSegment.Left, new Uri("Images/battleship_left.png", UriKind.Relative)},
                {ShipCellSegment.Right, new Uri("Images/battleship_right.png", UriKind.Relative)},
                {ShipCellSegment.Top, new Uri("Images/battleship_top.png", UriKind.Relative)},
                {ShipCellSegment.Bottom, new Uri("Images/battleship_bottom.png", UriKind.Relative)},
                {ShipCellSegment.Vertical, new Uri("Images/battleship_vert.png", UriKind.Relative)},
                {ShipCellSegment.Horizontal, new Uri("Images/battleship_horz.png", UriKind.Relative)},
            };
        private void DisplayButtonBackground()
        {
            if (_shipSegmentShown)
            {
                /*
                 * ProfReynolds
                 * you need the other cases!
                 * I added stubs for you to populate
                 */
                switch (_shipSegment)
                {
                    case ShipCellSegment.Unknown:
                    {
                        var uri = _shipCellSegmentUri[ShipCellSegment.Unknown];
                        var bitmapImage = new BitmapImage(uri);
                        var brush = new ImageBrush();
                        brush.ImageSource = bitmapImage;
                        brush.Stretch = Stretch.Fill;
                        BtnCellSegment.Background = brush;
                        break;
                    }
                    case ShipCellSegment.Water:
                        break;
                    case ShipCellSegment.Single:
                        break;
                    case ShipCellSegment.Left:
                        break;
                    case ShipCellSegment.Right:
                        break;
                    case ShipCellSegment.Top:
                        break;
                    case ShipCellSegment.Bottom:
                        break;
                    case ShipCellSegment.Vertical:
                        break;
                    case ShipCellSegment.Horizontal:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                var uri = new Uri("Images/battleship_unknown.png", UriKind.Relative);
                var bitmapImage = new BitmapImage(uri);
                var brush = new ImageBrush();
                brush.ImageSource = bitmapImage;
                brush.Stretch = Stretch.Fill;
                BtnCellSegment.Background = brush;
            }
        }
        private void BtnCellSegment_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ShipSegmentShown = true;
        }

       
    }

}
