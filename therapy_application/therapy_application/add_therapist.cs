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
    public partial class add_therapist : Form
    {
        public add_therapist()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
            textBox_password.MaxLength = 10;
            textBox_password2.PasswordChar = '*';
            textBox_password2.MaxLength = 10;

        }


        private void add_therapist_Load(object sender, EventArgs e)
        {

        }


    }
}
