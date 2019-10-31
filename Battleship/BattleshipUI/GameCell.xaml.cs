using System;
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

        public bool ShipSegmentShown
        {
            get => _shipSegmentShown;
            set
            {
                _shipSegmentShown = value;
                DisplayButtonBackground();
            }
        }

        private ShipCellSegment _shipSegment = ShipCellSegment.Unknown;
        public ShipCellSegment ShipSegment
        {
            get => _shipSegmentShown;
            set
            {
                _shipSegmentShown = value;
                DisplayButtonBackground();
            }
        }

        private void DisplayButtonBackground()
        {
            if (_shipSegmentShown)
            {
                switch (_shipSegment)
                {
                    case ShipCellSegment.Unknown:
                    {
                        CalendarDateChangedEventArgs uri = _shipSegmentUri[ShipCellSegmetn.Unkown];
                        var bitmapImage = new BitmapImage(uri);
                        var brush = new ImageBrush();
                        brush.ImageSource = bitmapImage;
                        brush.Stretch = Stretch.Fill;
                        BtnCellSegment.Background = brush;
                        break;
                    }
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
