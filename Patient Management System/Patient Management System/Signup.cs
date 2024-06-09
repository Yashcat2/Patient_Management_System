using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Management_System
{

    public partial class Signup : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yashodha\Documents\newHMS.mdf;Integrated Security=True;Connect Timeout=30");

        public Signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login logform = new Login();
            logform.Show();
            this.Hide();
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPass.Checked)
            {
                signup_password.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '●';
            }
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {

            if (signup_email.Text == "" || signup_username.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        con.Open();
                        string checkUsername = "SELECT * FROM admin WHERE username = '" + signup_username.Text.Trim() + "'";  //admin is our table name
                        using (SqlCommand checkUser = new SqlCommand(checkUsername, con))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin(email,username,pasword,date_created)"
                                  + "VALUES(@email, @username, @password ,@dateCreated)";

                                DateTime date = DateTime.Today;
                                using (SqlCommand cmd = new SqlCommand(insertData, con))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateCreated", date);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered succesfully ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //TO SWITCH THE FORM

                                    Login lform = new Login();
                                    lform.Show();
                                    this.Hide();


                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        con.Close();
                    }
                }

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
