namespace Topical_Assignment_10___Connect_Four
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerName = new System.Windows.Forms.Label();
            this.rows = new System.Windows.Forms.Label();
            this.column = new System.Windows.Forms.Label();
            this.playerNameTxt = new System.Windows.Forms.TextBox();
            this.rowTxt = new System.Windows.Forms.TextBox();
            this.columnTxt = new System.Windows.Forms.TextBox();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.pnlGameGrid = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(1, 5);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(70, 13);
            this.playerName.TabIndex = 0;
            this.playerName.Text = "Player Name:";
            // 
            // rows
            // 
            this.rows.AutoSize = true;
            this.rows.Location = new System.Drawing.Point(15, 27);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(61, 13);
            this.rows.TabIndex = 1;
            this.rows.Text = "Rows (4-8):";
            // 
            // column
            // 
            this.column.AutoSize = true;
            this.column.Location = new System.Drawing.Point(1, 47);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(77, 13);
            this.column.TabIndex = 2;
            this.column.Text = "Columns (5-10:";
            // 
            // playerNameTxt
            // 
            this.playerNameTxt.Location = new System.Drawing.Point(81, 1);
            this.playerNameTxt.Name = "playerNameTxt";
            this.playerNameTxt.Size = new System.Drawing.Size(109, 20);
            this.playerNameTxt.TabIndex = 3;
            // 
            // rowTxt
            // 
            this.rowTxt.Location = new System.Drawing.Point(86, 23);
            this.rowTxt.Name = "rowTxt";
            this.rowTxt.Size = new System.Drawing.Size(30, 20);
            this.rowTxt.TabIndex = 4;
            this.rowTxt.Validating += new System.ComponentModel.CancelEventHandler(this.rowTxt_Validating);
            // 
            // columnTxt
            // 
            this.columnTxt.Location = new System.Drawing.Point(86, 44);
            this.columnTxt.Name = "columnTxt";
            this.columnTxt.Size = new System.Drawing.Size(30, 20);
            this.columnTxt.TabIndex = 5;
            this.columnTxt.Validating += new System.ComponentModel.CancelEventHandler(this.columnTxt_Validating);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(8, 72);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(108, 23);
            this.newGameBtn.TabIndex = 6;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // pnlGameGrid
            // 
            this.pnlGameGrid.Location = new System.Drawing.Point(175, 47);
            this.pnlGameGrid.Margin = new System.Windows.Forms.Padding(0);
            this.pnlGameGrid.Name = "pnlGameGrid";
            this.pnlGameGrid.Size = new System.Drawing.Size(151, 152);
            this.pnlGameGrid.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 231);
            this.Controls.Add(this.pnlGameGrid);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.columnTxt);
            this.Controls.Add(this.rowTxt);
            this.Controls.Add(this.playerNameTxt);
            this.Controls.Add(this.column);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.playerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Connect Four - Crystal Liles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label rows;
        private System.Windows.Forms.Label column;
        private System.Windows.Forms.TextBox playerNameTxt;
        private System.Windows.Forms.TextBox rowTxt;
        private System.Windows.Forms.TextBox columnTxt;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Panel pnlGameGrid;
    }
}

