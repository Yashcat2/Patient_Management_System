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
using System.Xml.Linq;

namespace Patient_Management_System
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Yashodha\Documents\newHMS.mdf;Integrated Security=True;Connect Timeout=30") ;
        private void DisplayDoctor()
        {
            try
            {
                con.Open();
                string Query = "select * from Doctor";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                guna2DataGridView1.DataSource = ds.Tables[0];
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


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Doctor_Home_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void Doctor_Add_Click(object sender, EventArgs e)
        {
            try
            {
               if(Doc_ID.Text == "" || Doc_Name.Text ==" " || Doc_gen.Text == " " || Doc_Ex.Text==" " || Doc_Lcn.Text== " " || Doc_Nmbr.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "insert into Doctor Values (' " + Doc_ID.Text + "' , '" + Doc_Name.Text + "' , '" + Doc_gen.Text + "','" + Doc_Ex.Text + "','" + Doc_Lcn.Text + "','" + Doc_Nmbr.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Entered Succesfully");
                    DisplayDoctor();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close() ;
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newHMSDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter2.Fill(this.newHMSDataSet.Doctor);
            // TODO: This line of code loads data into the 'hMSDataSet.Doctor' table. You can move, or remove it, as needed.
            //this.doctorTableAdapter1.Fill(this.hMSDataSet.Doctor);
            // TODO: This line of code loads data into the 'docDataSet.doctor' table. You can move, or remove it, as needed.
            // this.doctorTableAdapter.Fill(this.docDataSet.doctor);
            DisplayDoctor();
        }

        private void Doctor_Reset_Click(object sender, EventArgs e)
        {
            Doc_ID.Text = " ";
            Doc_Name.Text = " ";
            Doc_gen.Text = " ";
            Doc_Ex.Text = " ";
            Doc_Lcn.Text = " ";
            Doc_Nmbr.Text = " ";


        }

        private void Doctor_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(Doc_ID.Text == " ")
                {
                    MessageBox.Show("Enter the Doctor Id");
                }
                else
                {
                    con.Open();
                    string query = "delete from Doctor where DocId ='" + Doc_ID.Text + "';";
                    SqlCommand cmd = new SqlCommand (query, con);
                   // cmd.Parameters.AddWithValue("@DocID", Doc_ID.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Succesfully");
                    DisplayDoctor();
                    
                    
                    
                    
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close ();
            }
        }

        private void Doctor_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Doc_ID.Text == " " || Doc_Name.Text == " " || Doc_gen.Text == " "|| Doc_Ex.Text == " "|| Doc_Lcn.Text == " "|| Doc_Nmbr.Text == " ")
                {
                    MessageBox.Show("Missing Information ");
                }
                else
                {
                    con.Open ();
                    string query = "update Doctor Set DocName = @DocName, DocGen = @DocGen , Experience = @Experience , Licsence=@Licsence ,PhoneNumber = @PhoneNumber where DocId = @DocId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@DocName", Doc_Name.Text);
                    cmd.Parameters.AddWithValue("@DocGen", Doc_gen.Text);
                    cmd.Parameters.AddWithValue("@Experience", Doc_Ex.Text);
                    cmd.Parameters.AddWithValue("@Licsence", Doc_Lcn.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", Doc_Nmbr.Text);
                    cmd.Parameters.AddWithValue("@DocID", Doc_ID.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated succefully");
                    DisplayDoctor();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close () ;
            }
        }

        

     

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Doc_ID.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Doc_Name.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Doc_gen.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Doc_Ex.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Doc_Lcn.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Doc_Nmbr.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();


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

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Doctor_Patient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Show();
            this.Hide();

        }

        private void Doctor_Diagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis diagnosis = new Diagnosis();
            diagnosis.Show();
            this.Hide();
        }

        private void Doctor_Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();    
        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Doc_ID.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                Doc_Name.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Doc_gen.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Doc_Ex.Text = guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                Doc_Lcn.Text = guna2DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Doc_Nmbr.Text = guna2DataGridView1.SelectedRows[0].Cells[5].Value.ToString();


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
