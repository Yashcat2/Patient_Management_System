using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Patient_Management_System
{
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
            DisplayDiagnosis();
            DisplayPatientId();
            //DisplaPatientName();
        }
        readonly SqlConnection con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Yashodha\Documents\newHMS.mdf"";Integrated Security=True;Connect Timeout=30");
        private void DisplayDiagnosis()
        {
            try
            {
                con.Open();
                string Query = "select * from Diagnosis";
                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                Diagnosis_GridView.DataSource = ds.Tables[0];
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

        
        private void Diagnosis_Add_Click(object sender, EventArgs e)
        {

            try
            {
                if (D_Id.Text == "" || D_PId.Text == " " || D_PName.Text == " " || D_Symptoms.Text == " " || D_Tests.Text == " " || D_Med.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "insert into Diagnosis Values (' " + D_Id.Text + "' , '" + D_PId.Text + "' , '" + D_PName.Text + "','" + D_Symptoms.Text + "','" + D_Tests.Text + "','" + D_Med.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Entered Succesfully");
                    DisplayDiagnosis();
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

        private void Diagnosis_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (D_Id.Text == "" || D_PId.Text == " " || D_PName.Text == " " || D_Symptoms.Text == " " || D_Tests.Text == " " || D_Med.Text == " ")
                {
                    MessageBox.Show("Missing Information ");
                }
                else
                {
                    con.Open();
                    string query = "update Diagnosis Set PatientID = @PatientID, PatientName = @PatientName , Symptoms = @Symptoms , Test=@Test ,Medicines = @Medicines where DId = @DId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PatientID", D_PId.Text);
                    cmd.Parameters.AddWithValue("@DID", D_Id.Text);
                    cmd.Parameters.AddWithValue("@PatientName", D_PName.Text);
                    cmd.Parameters.AddWithValue("@Symptoms", D_Symptoms.Text);
                    cmd.Parameters.AddWithValue("@Test", D_Tests.Text);
                    cmd.Parameters.AddWithValue("@Medicines", D_Med.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Updated succefully");
                    DisplayDiagnosis();

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

        private void Diagnosis_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (D_Id.Text == " ")
                {
                    MessageBox.Show("Enter the Diagnosis Id");
                }
                else
                {
                    con.Open();
                    string query = "delete from Diagnosis WHERE DID ='" + D_Id.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    // cmd.Parameters.AddWithValue("@DocID", Doc_ID.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Succesfully");
                    DisplayDiagnosis();




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

        private void Diagnosis_Reset_Click(object sender, EventArgs e)
        {
            D_Id.Text = " ";
            D_PId.Text = " ";
            D_PName.Text = " ";
            D_Symptoms.Text = " ";
            D_Tests.Text = " ";
            D_Med.Text = " ";

        }

        private void Diagnosis_GridView_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                D_Id.Text = Diagnosis_GridView.SelectedRows[0].Cells[0].Value.ToString();
                D_PId.Text = Diagnosis_GridView.SelectedRows[0].Cells[1].Value.ToString();
                D_PName.Text = Diagnosis_GridView.SelectedRows[0].Cells[2].Value.ToString();
                D_Symptoms.Text = Diagnosis_GridView.SelectedRows[0].Cells[3].Value.ToString();
                D_Tests.Text = Diagnosis_GridView.SelectedRows[0].Cells[4].Value.ToString();
                D_Med.Text = Diagnosis_GridView.SelectedRows[0].Cells[5].Value.ToString();
                label1.Text = Diagnosis_GridView.SelectedRows[0].Cells[2].Value.ToString();
                label3.Text = Diagnosis_GridView.SelectedRows[0].Cells[3].Value.ToString();
                label15.Text = Diagnosis_GridView.SelectedRows[0].Cells[4].Value.ToString();
                label16.Text = Diagnosis_GridView.SelectedRows[0].Cells[5].Value.ToString();



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
        private void DisplayPatientId()
        {

            try
            {
                con.Open();
                string sql = "Select PID from Patient";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader rdr;
                DataTable dt = new DataTable();
                dt.Columns.Add("PID", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                D_PId.ValueMember = "PID";
                D_PId.DisplayMember = "PID";
                D_PId.DataSource = dt;
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

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newHMSDataSet1.Diagnosis' table. You can move, or remove it, as needed.
           // this.diagnosisTableAdapter.Fill(this.newHMSDataSet1.Diagnosis);
            DisplayPatientId();
        }

        //string pname;
        private void DisplaPatientName()
        {
            try
            {
                con.Open();
                string ss = "select * from Patient where PID =" + D_PId.SelectedValue.ToString() +""; 

                SqlCommand cmd = new SqlCommand(ss, con);
                DataTable dt = new DataTable();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dt);
                foreach (DataRow dr in dt.Rows) 
                {

                    D_PName.Text = dr["PName"].ToString();
                     
                } 
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

        private void D_PId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DisplaPatientName();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            this.Hide();
        }
    }
    
}
    

