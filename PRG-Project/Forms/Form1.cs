using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_Project
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            DataTable vt = new DataTable();
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=PRG-Project.accdb";
            //string constr = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=PRG-Project.accdb";

            string sqlstr = "SELECT TOP 5 * FROM Products";

            OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
            da.Fill(vt);
            da.Dispose();
            dataGridProducts.DataSource = vt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedItem == null)
            {
                MessageBox.Show("Select a filter from Drop Down !!!");


            }
            else if(comboBoxFilter.SelectedItem.ToString() == "Model")
            {
                string sqlstr = "SELECT * FROM Products WHERE Model LIKE '" +textBoxSearchBox.Text + "%"+ "'";

                DataTable vt = new DataTable();

                string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=PRG-Project.accdb";
                OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
                da.Fill(vt);
                da.Dispose();
                dataGridProducts.DataSource = vt;
            }
            else
            {

                string sqlstr = "SELECT * FROM Products WHERE ComputerType LIKE '" + "%"  + textBoxSearchBox.Text+ "%" + "'";

                DataTable vt = new DataTable();

                string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=PRG-Project.accdb";
                OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
                da.Fill(vt);
                da.Dispose();
                dataGridProducts.DataSource = vt;

            }

        }
    }
}
