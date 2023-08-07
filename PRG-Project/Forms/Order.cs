using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_Project.Forms
{
    public partial class Order : Form
    {
        public static int quantity;
        public static string address;
        public Order()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            try
            {
                //To Detect if quantity is left and also to update quantity in Products Table
                quantity = Convert.ToInt32(textBoxQuantity.Text);
                int quantityNew = Int32.Parse(MainPage.productQuantity) - quantity;
                if (quantityNew <= 0)
                {
                    MessageBox.Show("Quantity is more than available Stock!!!");
                }
                else
                {
                    int SoldNew = Int32.Parse(MainPage.Sold) + quantity;

                    string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=PRG-Project.accdb";

                    //string sqlstrUpdateCustomerTable = "UPDATE Products SET Quantity= 0 WHERE ComputerID= 1";
                    string sqlstrUpdateCustomerTable = "UPDATE Products SET Quantity = " + quantityNew + ", Sold = " + SoldNew + " WHERE ComputerID = " + Int32.Parse(MainPage.SelectedItemID);


                    OleDbDataAdapter daUpdateCustomerTable = new OleDbDataAdapter();

                    OleDbConnection conUpdateCustomerTable = new OleDbConnection(constr);
                    conUpdateCustomerTable.Open();

                    //string sqlstrUpdateCustomerTable = "UPDATE Products SET Quantity = "+quantityNew+", Sold = "+quantity+" WHERE CustomerID = "+Int32.Parse(MainPage.SelectedItemID);
                    //string sqlstrUpdateCustomerTable = "UPDATE Products SET Quantity="+quantityNew+" WHERE CustomerID='"+MainPage.SelectedItemID+"'";


                    daUpdateCustomerTable.UpdateCommand = new OleDbCommand(sqlstrUpdateCustomerTable, conUpdateCustomerTable);
                    daUpdateCustomerTable.UpdateCommand.ExecuteNonQuery();
                    conUpdateCustomerTable.Close();

                    //For Inserting into the Customers Table
                    OleDbDataAdapter daCustomerTable = new OleDbDataAdapter();

                    OleDbConnection con = new OleDbConnection(constr);
                    con.Open();

                    string sqlstr = "INSERT INTO Customers(FirstName,LastName,CreditCard,Address,TelephoneNumber)" + "VALUES('" + textBoxFirstName.Text + "','" + textBoxLastName.Text + "','" + textBoxCardNumber.Text + "', '" + textBoxAddress.Text + "', '" + textBoxNumber.Text + "')";
                    address = textBoxAddress.Text;
                    daCustomerTable.InsertCommand = new OleDbCommand(sqlstr, con);
                    daCustomerTable.InsertCommand.ExecuteNonQuery();
                    con.Close();

                    //Retrieving Customer ID to place in Orders Table

                    DataTable vt = new DataTable();

                    string sqlstrSelectCustomerTable = "SELECT * FROM Customers WHERE FirstName LIKE '" + textBoxFirstName.Text + "' AND LastName LIKE '" + textBoxLastName.Text + "'";

                    OleDbDataAdapter daOrderTable = new OleDbDataAdapter(sqlstrSelectCustomerTable, constr);
                    daOrderTable.Fill(vt);
                    daOrderTable.Dispose();
                    int customerID = Convert.ToInt32(vt.Rows[0]["CustomerID"]);

                    //Updating in Orders Table with CustomerID, ProductID and Quantities

                    string sqlstrUpdateOrdersTable = "INSERT INTO Orders(CustomerID,ProductID,Quantities)" + "VALUES(" + customerID + ",'" + MainPage.SelectedItemID + "'," + quantity + ")";
                    OleDbConnection conOrdersTable = new OleDbConnection(constr);
                    OleDbDataAdapter daUpdateOrderTable = new OleDbDataAdapter();
                    conOrdersTable.Open();
                    daUpdateOrderTable.InsertCommand = new OleDbCommand(sqlstrUpdateOrdersTable, conOrdersTable);
                    daUpdateOrderTable.InsertCommand.ExecuteNonQuery();
                    conOrdersTable.Close();


                    MessageBox.Show("Checked Out Succesfully!!!");
                    Reciept reciept = new Reciept();
                    reciept.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
