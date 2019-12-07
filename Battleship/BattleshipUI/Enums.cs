using System;
using System.Collections.Generic;
using System.Text;

/*
 * Crystal Liles
 */

namespace BattleshipUI
{
    ///<summary>
    /// The ShipCellSegment enum represents to possible content
    /// of each cell (grid component) in the game.
    /// </summary>
    public enum ShipCellSegment
    {
        Unknown,
        Water,
        Single,
        Left,
        Right,
        Top,
        Bottom,
        Vertical,
        Horizontal
    }
}
