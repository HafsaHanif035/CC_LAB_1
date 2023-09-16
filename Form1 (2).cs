using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GridView
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source = .; Initial Catalog = Sample; Integrated Security= true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
         
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if(txt_Name.Text != " " && txt_Class.Text != " ")
            {
                cmd = new SqlCommand("insert into tbl_Record(Name, Class) values (@namw, @class)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@class", txt_Class.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record inserted successfully");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Provide details!");
            }
        }
        private void DisplayData()
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from tbl_Record", con);
            adapt.Fill(dt);
            dataGridView1.DataSource= dt;
            con.Close();
        }

        private void ClearData()
        {
            txt_Name.Text= " ";
            txt_Class.Text= " ";
            ID = 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Class.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
