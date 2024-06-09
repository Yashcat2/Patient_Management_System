using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Home_Doctor_btn_Click(object sender, EventArgs e)
        {
            Doctor dform = new Doctor();
            dform.ShowDialog();
            this.Hide();
        }

        private void Home_Logout_picture_Button_Click(object sender, EventArgs e)
        {
            Login logform = new Login();
            logform.Show();
            this.Hide();
        }

        private void Home_Diagnosis_Button_Click(object sender, EventArgs e)
        {
            Diagnosis diagnosis = new Diagnosis();
            diagnosis.Show();
            this.Hide();
        }

        private void Home_Patient_Button_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.ShowDialog();
            this.Hide();
        }
    }
}
