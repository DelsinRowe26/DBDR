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

namespace DBDR
{
    public partial class Form2 : Form
    {
        SqlConnection sqlconn;
        string drtab;
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "delsinRowe26DataSet1.DRTable". При необходимости она может быть перемещена или удалена.
            this.dRTableTableAdapter.Fill(this.delsinRowe26DataSet1.DRTable);
            string connect = @"Data Source = NPK107K1\SQLEXPRESS; Initial Catalog = DelsinRowe26; Integrated Security = True";
            sqlconn = new SqlConnection(connect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reff;
            string sql = "SELECT * FROM [dbo].[DRTable]";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, sqlconn))
            {
                DataTable dTab = new DataTable();
                //dataAdapter.SelectCommand = new SqlCommand(sql, sqlconn);
                dataAdapter.Fill(dTab);

                reff = dTab.Rows[0][0].ToString();
                
                this.dataGridView1.DataSource = reff;
                MessageBox.Show(reff);
            }
            /*sqlconn.Open();
            
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand(sql, sqlconn);
            
            sqlconn.Close();*/
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM " + drtab;
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, sqlconn))
                {
                    DataTable dTab = new DataTable();
                    //dataAdapter.SelectCommand = new SqlCommand(sql, sqlconn);
                    dataAdapter.Fill(dTab);

                    this.dataGridView1.DataSource = dTab;
                }
                this.dRTableTableAdapter.Fill(this.delsinRowe26DataSet1.DRTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                drtab = "[dbo].[User]";
                try
                {
                    string sql = "SELECT * FROM " + drtab;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, sqlconn))
                    {
                        DataTable dTab = new DataTable();
                        //dataAdapter.SelectCommand = new SqlCommand(sql, sqlconn);
                        dataAdapter.Fill(dTab);

                        this.dataGridView1.DataSource = dTab;
                    }
                    this.dRTableTableAdapter.Fill(this.delsinRowe26DataSet1.DRTable);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                drtab = "[dbo].[DRTable]";
                try
                {
                    string sql = "SELECT * FROM " + drtab;
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, sqlconn))
                    {
                        DataTable dTab = new DataTable();
                        //dataAdapter.SelectCommand = new SqlCommand(sql, sqlconn);
                        dataAdapter.Fill(dTab);

                        this.dataGridView1.DataSource = dTab;
                    }
                    this.dRTableTableAdapter.Fill(this.delsinRowe26DataSet1.DRTable);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
