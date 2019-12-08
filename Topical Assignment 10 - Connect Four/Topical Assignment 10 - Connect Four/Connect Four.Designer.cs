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
            this.SuspendLayout();
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(3, 12);
            this.playerName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(186, 32);
            this.playerName.TabIndex = 0;
            this.playerName.Text = "Player Name:";
            // 
            // rows
            // 
            this.rows.AutoSize = true;
            this.rows.Location = new System.Drawing.Point(40, 64);
            this.rows.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(159, 32);
            this.rows.TabIndex = 1;
            this.rows.Text = "Rows (4-8):";
            // 
            // column
            // 
            this.column.AutoSize = true;
            this.column.Location = new System.Drawing.Point(3, 112);
            this.column.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(208, 32);
            this.column.TabIndex = 2;
            this.column.Text = "Columns (5-10:";
            // 
            // playerNameTxt
            // 
            this.playerNameTxt.Location = new System.Drawing.Point(216, 2);
            this.playerNameTxt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.playerNameTxt.Name = "playerNameTxt";
            this.playerNameTxt.Size = new System.Drawing.Size(284, 38);
            this.playerNameTxt.TabIndex = 3;
            // 
            // rowTxt
            // 
            this.rowTxt.Location = new System.Drawing.Point(229, 55);
            this.rowTxt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rowTxt.Name = "rowTxt";
            this.rowTxt.Size = new System.Drawing.Size(73, 38);
            this.rowTxt.TabIndex = 4;
            this.rowTxt.Validating += new System.ComponentModel.CancelEventHandler(this.rowTxt_Validating);
            // 
            // columnTxt
            // 
            this.columnTxt.Location = new System.Drawing.Point(229, 105);
            this.columnTxt.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.columnTxt.Name = "columnTxt";
            this.columnTxt.Size = new System.Drawing.Size(73, 38);
            this.columnTxt.TabIndex = 5;
            this.columnTxt.Validating += new System.ComponentModel.CancelEventHandler(this.columnTxt_Validating);
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(21, 172);
            this.newGameBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(288, 55);
            this.newGameBtn.TabIndex = 6;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1141, 551);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.columnTxt);
            this.Controls.Add(this.rowTxt);
            this.Controls.Add(this.playerNameTxt);
            this.Controls.Add(this.column);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.playerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

