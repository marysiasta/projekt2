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
    public partial class general : Form
    {
        public general()
        {
            InitializeComponent();
        }

        private void general_Load(object sender, EventArgs e)
        {

        }

        private void button_patient_Click(object sender, EventArgs e)
        {
            show_patient newform = new show_patient();
            newform.Show();
        }

        private void button_therapy_Click(object sender, EventArgs e)
        {
            show_therapy newform = new show_therapy();
            newform.Show();
        }
    }
}
