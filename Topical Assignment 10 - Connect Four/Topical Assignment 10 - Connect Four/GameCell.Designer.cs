using System;

namespace Topical_Assignment_10___Connect_Four
{
    partial class GameCell
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }

        #endregion

        public int GameCellRow { get; set; }
        public int GameCellCol { get; set; }
        private GameCellStates _gameCellStates = GameCellStates.Clear;

        public GameCellStates GameCellState
        {
            get => _gameCellStates;
            set
            {
                _gameCellStates = value;
                DisplayButtonBackground();
            }
        }
    }
}
