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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            DataTable vt = new DataTable();
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=PRG-Project.accdb";
            //string constr = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=PRG-Project.accdb";

            string sqlstr = "SELECT * FROM Products WHERE ComputerID LIKE '"+ MainPage.SelectedItemID  +"'";

            OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, constr);
            da.Fill(vt);
            da.Dispose();

            if (vt.Rows.Count > 0)
            {
                DataRow row = vt.Rows[0];

                labelName.Text = row["Model"].ToString();

                string modelName = labelName.Text;

                string imagePath = Path.Combine("..",".." ,"Images", $"{modelName}.jpg");
                //string imagePath = Path.Combine(Application.StartupPath, "Images", "SwiftBook Pro 15R.jpg");
                //string imagePath = @"..\Images\" +  $"{modelName}.jpg";

                if (File.Exists(imagePath))
                {
                    pictureBoxProduct.Image = Image.FromFile(imagePath);
                }

            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void pictureBoxProduct_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProduct.BackColor = Color.Red;
            pictureBoxProduct.Padding = new Padding(5);
        }

        private void pictureBoxProduct_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxProduct.BorderStyle = BorderStyle.None;
            pictureBoxProduct.BackColor = Color.White;
            pictureBoxProduct.Padding = new Padding(0);
        }

        private void buttonSubmit_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void buttonSubmit_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void buttonReturn_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void buttonReturn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            this.Hide();
        }
    }
}
