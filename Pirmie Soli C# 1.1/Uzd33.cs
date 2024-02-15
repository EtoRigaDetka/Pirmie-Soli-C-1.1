using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pirmie_Soli_C__1._1
{
    public partial class Uzd33 : Form
    {
        public Uzd33()
        {
            InitializeComponent();
        }


        private void tbToDouble_Enter(object sender, EventArgs e)
        {
            tbToDouble.Text = "Enter here";
        }

        private void tbToDouble_KeyUp(object sender, KeyEventArgs e)
        {
            if (!char.IsLetterOrDigit((char)e.KeyCode) && e.KeyCode != Keys.Back)
            {
                MessageBox.Show("Only letters and digits are allowed");
                tbToDouble.Text = tbToDouble.Text.Substring(0, tbToDouble.Text.Length - 1);
                tbToDouble.SelectionStart = tbToDouble.Text.Length;
            }   
            tbToDouble.Text += e.KeyCode.ToString().ToLower();
            tbToDouble.SelectionStart =  tbToDouble.Text.Length;
        }
    }
}
