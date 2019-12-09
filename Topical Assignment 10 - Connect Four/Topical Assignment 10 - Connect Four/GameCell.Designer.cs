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
            this.SuspendLayout();
            // 
            // GameCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Topical_Assignment_10___Connect_Four.Properties.Resources.gamecellstates_clear;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GameCell";
            this.Size = new System.Drawing.Size(80, 80);
            this.Load += new System.EventHandler(this.gamecell_Click);
            this.ResumeLayout(false);

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
