using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace therapy_application
{
    public partial class show_patient : Form
    {
        public show_patient()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_patient newform = new add_patient();
            newform.Show();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            edit_patient newform = new edit_patient();
            newform.Show();
        }

        private void button_choice_Click(object sender, EventArgs e)
        {

        }
    }
}
