using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonFramework.Core;

namespace Topical_Assignment_10___Connect_Four
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * ProfReynolds
         * I changed the event from TextChanged to Validating. The Validating event supports the.Cancel property
         * I moved your code into this Validating event
         */

        private void columnTxt_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox tbox)
            {
                var suggestedColumns = tbox.Text.ToInt();

                /*
                 * ProfReynolds
                 * .Cancel is part of the TextValidating
                 */
                e.Cancel = suggestedColumns < 5 || suggestedColumns > 10;
            }
        }

        private void rowTxt_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox tbox)
            {
                /*
                 * ProfReynolds
                 * see above
                 */
                var suggestedRows = tbox.Text.ToInt();
                e.Cancel = suggestedRows < 4 || suggestedRows > 8;
            }
        }
    }
}
