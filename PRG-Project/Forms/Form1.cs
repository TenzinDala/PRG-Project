using PRG_Project.Forms;
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
        public static string SelectedItemID;
        public static string price;
        public static string productQuantity;
        public static string Sold;

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            DataTable vt = new DataTable();
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=PRG-Project.accdb";
            //string constr = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=PRG-Project.accdb";

            string sqlstr = "SELECT * FROM Products ORDER BY ComputerID ASC";

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
                if (vt.Rows.Count == 0)
                {
                    MessageBox.Show("No Products Found!!!");
                }
                else
                {
                    dataGridProducts.DataSource = vt;
                }
            }
            else
            {

                string sqlstr = "SELECT * FROM Products WHERE ComputerType LIKE '" + "%" + textBoxSearchBox.Text+ "%" + "'";

                DataTable vt = new DataTable();

                string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=PRG-Project.accdb";
                OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
                da.Fill(vt);
                da.Dispose();
                if (vt.Rows.Count == 0)
                {
                    MessageBox.Show("No Products Found!!!");
                }
                else
                {
                    dataGridProducts.DataSource = vt;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridProducts.SelectedRows[0];

                SelectedItemID = selectedRow.Cells[0].Value.ToString();
                productQuantity = selectedRow.Cells[3].Value.ToString();
                price = selectedRow.Cells[4].Value.ToString();
                Sold = selectedRow.Cells[5].Value.ToString();


                Information information = new Information();
                information.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a row!!!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
