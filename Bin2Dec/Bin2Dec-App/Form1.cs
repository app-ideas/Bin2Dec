using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bin2Dec_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBinary_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '1' || e.KeyChar == '0')
            {
                //do nothing
            }
            else
            {
                MessageBox.Show("Only Binary Numbers allowed", "Error", MessageBoxButtons.OK);
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBinary.Text))
            {
                MessageBox.Show("Please enter a binary number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               txtDecimal.Text = Bin2DecConvertor.ConvertBinarytoDecimal(Convert.ToInt32(txtBinary.Text)).ToString();
            }
            
        }
    }
}
