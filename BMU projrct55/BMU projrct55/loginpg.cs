using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMU_projrct55
{
    public partial class loginpg : Form
    {
        public loginpg()
        {
            InitializeComponent();
            

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show("Login Successfull!");
            frmDBsetting form = new frmDBsetting();
            form.Show();

        }
    }
}
