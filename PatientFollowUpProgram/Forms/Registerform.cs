using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientFollowUpProgram.Forms
{
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();
        }

        private void backtologinbutton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            Close();
        }

        private void kayitbutton_Click(object sender, EventArgs e)
        {

        }

        private void GetWriteData()
        {
            string username = kayittctextbox.Text.Trim();
            string password = kayitsifretextbox.Text.Trim();


        }

    }
}
