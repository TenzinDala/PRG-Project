using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_Project.Forms
{
    public partial class Reciept : Form
    {
        double hstRate = 0.13;
        public Reciept()
        {
            InitializeComponent();
        }

        private void Reciept_Load(object sender, EventArgs e)
        {
            //Updating the Cost Label

            double amount = Int32.Parse(MainPage.price) * hstRate;
            labelCos.Text = amount.ToString();

            DataTable vt = new DataTable();
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=PRG-Project.accdb";
            //string constr = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=PRG-Project.accdb";

            //string sqlstr = "SELECT Products.FirstName, Products.LastName, Products.Address, Products.TelephoneNumber, Orders.OrderID FROM Products JOIN Orders ON Products.ComputerID = Orders.ProductID WHERE Products.ComputerID = '"+MainPage.SelectedItemID+"'";
            string sqlstr = "SELECT * FROM Customers WHERE Address LIKE '"+Order.address+"'";


            OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
            da.Fill(vt);
            da.Dispose();

            if (vt.Rows.Count > 0)
            {
                DataRow row = vt.Rows[0];

                labelMod.Text = MainPage.SelectedModel;
                labelFName.Text = row["FirstName"].ToString();
                labelLName.Text = row["LastName"].ToString();
                labelAdd.Text = row["Address"].ToString();
                labelNum.Text = row["TelephoneNumber"].ToString();
                labelQuant.Text = Order.quantity.ToString();

            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
