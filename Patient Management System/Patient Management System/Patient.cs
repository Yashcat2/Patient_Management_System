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
        public partial class Patient : Form
        {
            public Patient()
            {
                InitializeComponent();
                DisplayPatient();
            }
            readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yashodha\Documents\newHMS.mdf;Integrated Security=True;Connect Timeout=30");
            private void DisplayPatient()
            {
                try
                {
                    con.Open();
                    string Query = "select * from Patient";
                    SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                    SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    Patient_DataGridView.DataSource = ds.Tables[0];
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            private void Patient_Load(object sender, EventArgs e)
            {
            // TODO: This line of code loads data into the 'newHMSDataSet2.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.newHMSDataSet2.Patient);
            DisplayPatient();
            }

            private void Patient_Add_Click(object sender, EventArgs e)
            {
                try
                {
                    if (P_ID.Text == "" || P_Name.Text == " " || P_Age.Text == " " || P_Gen.Text == " " || P_Address.Text == " " || P_BloodType.Text == " " || P_Phone.Text == " " || P_Disease.Text == " ")
                    {
                        MessageBox.Show("Missing Information");
                    }
                    else
                    {
                        con.Open();
                        string query = "insert into Patient Values ('" + P_ID.Text + "', '" + P_Name.Text + "', '" + P_Age.Text + "','" + P_Gen.Text + "','" + P_Address.Text + "','" + P_Disease.Text + "','" + P_BloodType.Text + "','" + P_Phone.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Entered Succesfully");
                        DisplayPatient();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            private void Patient_Update_Click(object sender, EventArgs e)
            {
                try
                {
                    if (P_ID.Text == "" || P_Name.Text == " " || P_Age.Text == " " || P_Gen.Text == " " || P_Address.Text == " " || P_BloodType.Text == " " || P_Phone.Text == " " || P_Disease.Text == " ")
                    {
                        MessageBox.Show("Missing Information ");
                    }
                    else
                    {
                        con.Open();
                        string query = "update Patient Set PName = @PName, PGen = @PGen , PAddress = @PAddress, PAge = @PAge, BloodGroup = @BloodGroup , MajorDisease=@MajorDisease ,PPhone = @PPhone where PId = @PId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@PName", P_Name.Text);
                        cmd.Parameters.AddWithValue("@PGen", P_Gen.Text);
                        cmd.Parameters.AddWithValue("@PAge", P_Age.Text);
                        cmd.Parameters.AddWithValue("@PAddress", P_Address.Text);
                        cmd.Parameters.AddWithValue("@BloodGroup", P_BloodType.Text);
                        cmd.Parameters.AddWithValue("@MajorDisease", P_Disease.Text);
                        cmd.Parameters.AddWithValue("@PPhone", P_Phone.Text);
                        cmd.Parameters.AddWithValue("@PID", P_ID.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated succefully");
                        DisplayPatient();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            private void Patient_Delete_Click(object sender, EventArgs e)
            {

                try
                {
                    if (P_ID.Text == " ")
                    {
                        MessageBox.Show("Enter the Patient Id");
                    }
                    else
                    {
                        con.Open();
                        string query = "delete from Patient WHERE PId ='" + P_ID.Text + "';";
                        SqlCommand cmd = new SqlCommand(query, con);
                        // cmd.Parameters.AddWithValue("@PID", Patient_ID.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Deleted Succesfully");
                        DisplayPatient();




                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            private void Patient_Reset_Click(object sender, EventArgs e)
            {
                P_ID.Text = " ";
                P_Name.Text = " ";
                P_Gen.Text = " ";
                P_BloodType.Text = " ";
                P_Disease.Text = " ";
                P_Phone.Text = " ";
                P_Age.Text = " ";
                P_Address.Text = " ";


            }

            private void Patient_Home_Click(object sender, EventArgs e)
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }

            private void Patient_Doctor_Click(object sender, EventArgs e)
            {
                Doctor obj = new Doctor();
                obj.Show();
                this.Hide();
            }

            private void Patient_Diagnosis_Click(object sender, EventArgs e)
            {
                Diagnosis obj = new Diagnosis();
                obj.Show();
                this.Hide();
            }

            private void Patient_Logout_Click(object sender, EventArgs e)
            {
                Welcome wobj = new Welcome();
                wobj.Show();
                this.Hide();
            }

            private void Patient_DataGridView_DoubleClick(object sender, EventArgs e)
            {
                try
                {
                    P_ID.Text = Patient_DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    P_Name.Text = Patient_DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    P_Age.Text = Patient_DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    P_Gen.Text = Patient_DataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    P_Address.Text = Patient_DataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    P_Disease.Text = Patient_DataGridView.SelectedRows[0].Cells[5].Value.ToString();
                    P_BloodType.Text = Patient_DataGridView.SelectedRows[0].Cells[6].Value.ToString();
                    P_Phone.Text = Patient_DataGridView.SelectedRows[0].Cells[7].Value.ToString();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        private void Patient_Logout_Click_1(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.ShowDialog();
            this.Hide();
        }

        private void Patient_DataGridView_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                P_ID.Text = Patient_DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                P_Name.Text = Patient_DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                P_Age.Text = Patient_DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                P_Gen.Text = Patient_DataGridView.SelectedRows[0].Cells[3].Value.ToString();
                P_Address.Text = Patient_DataGridView.SelectedRows[0].Cells[4].Value.ToString();
                P_Disease.Text = Patient_DataGridView.SelectedRows[0].Cells[5].Value.ToString();
                P_BloodType.Text = Patient_DataGridView.SelectedRows[0].Cells[6].Value.ToString();
                P_Phone.Text = Patient_DataGridView.SelectedRows[0].Cells[7].Value.ToString();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
    }
