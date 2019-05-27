using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07ProgramTableOfSquaresPROJ
{
    public partial class frmMain : Form
    {
        //private Label label2;
        //private TextBox txtStart;
        //private TextBox txtEnd;
        //private Button btnCalculate;
        //private Button btnClear;
        //private Button btnClose;
        //private ListBox lstOutput;
        //private Label label3;
        //private Label label4;
        //private Label label1;

        #region Windows code // This code is hidden...
        public frmMain()
        {
            InitializeComponent();
        }
        //public static void Main()
        //{
        //    frmMain main = new frmMain();
        //    Application.Run(main);
        //}
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            int i;
            int start;
            int end;
            string buff;
            //================ Gather inputs ======================
            // Convert start from text to int
            flag = int.TryParse(txtStart.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtStart.Focus();
                return;
            }
            // Convert end from text to int
            flag = int.TryParse(txtEnd.Text, out end);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtEnd.Focus();
                return;
            }
            if (start >= end) // Reasonable values?
            {
                MessageBox.Show("Start greater than end.", "Input Error");
                txtStart.Focus();
                return;
            }
            //================= Process and Display ==============
            for (i = start; i <= end; i++)
            {
                buff = string.Format("{0, 5}{1, 20}", i, i * i);
                lstOutput.Items.Add(buff);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStart.Clear();
            txtEnd.Clear();
            lstOutput.Items.Clear();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
#endregion
