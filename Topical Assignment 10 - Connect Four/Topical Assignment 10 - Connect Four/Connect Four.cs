using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topical_Assignment_10___Connect_Four
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void columnTxt_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tbox)
            {
                var suggestedColumns = tbox.Text.ToInt();
                e.Cancel = suggestedColumns < 5 || suggestedColumns > 10;
            }
        }

        
        private void rowTxt_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox tbox)
            {
                var suggestedRows = tbox.Text.ToInt();
                e.Cancel = suggestedRows < 4 || suggestedRows > 8;
            }
        }
    }
}
