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

namespace DBDR
{
    public partial class Form1 : Form
    {
        SqlConnection sqlconn;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string myselectquery = "SELECT * FROM [dbo].[DRTable] WHERE [Name]= '" + tbName.Text + "' and [Password]='" + tbPassw.Text + "'";


            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(myselectquery, sqlconn))
            {
                DataTable table = new DataTable();

                dataAdapter.Fill(table);//Вылетает ошибка

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Ошибка, вы ввели неправильное имя, либо фамиилию, либо отчество");
                }
                else
                {
                    MessageBox.Show("Добро пожаловать " + table.Rows[0][1].ToString(), "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly);



                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connect = @"Data Source = NPK107K1\SQLEXPRESS; Initial Catalog = DelsinRowe26; Integrated Security = True";
            sqlconn = new SqlConnection(connect);
        }
    }
}
