using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaMgr
{
    public partial class MacierzBledu : Form
    {
        int a_tp, a_tn, a_fp, a_fn;
        public MacierzBledu(int p_tp, int p_tn, int p_fp, int p_fn)
        {
            InitializeComponent();
            a_fn = p_fn;
            a_tn = p_tn;
            a_tp = p_tp;
            a_fp = p_fp;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MacierzBledu_Load(object sender, EventArgs e)
        {
            tp.Text = a_tp.ToString();
            fn.Text = a_fn.ToString();
            tn.Text = a_tn.ToString();
            fp.Text = a_fp.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
