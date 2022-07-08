using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfo
{
    public partial class Form1 : Form
    {
        
        string coString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stdnt.accdb";
        public Form1()
        {
            InitializeComponent();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtid.Text) && string.IsNullOrWhiteSpace(txtfn.Text) && string.IsNullOrWhiteSpace(txtln.Text) && string.IsNullOrWhiteSpace(txtmi.Text) && string.IsNullOrWhiteSpace(txtcrs.Text))
            {
                MessageBox.Show("Kindly fill in all required data.", "Missing Input");
                txtid.Focus();
            }
            else if(string.IsNullOrWhiteSpace(txtid.Text) | string.IsNullOrWhiteSpace(txtfn.Text) | string.IsNullOrWhiteSpace(txtln.Text) | string.IsNullOrWhiteSpace(txtmi.Text) | string.IsNullOrWhiteSpace(txtcrs.Text))
            {
                MessageBox.Show("Kindly fill in all required data.", "Record Incomplete");
            }
            else
            {
                OleDbConnection con = new OleDbConnection(coString);
                OleDbCommand cmd = con.CreateCommand();
                //this cmd represents the SQL queries sets of instructions to be passed on to Database using OLEDBCommand, and this can only be possible if you opened the connection
                con.Open();
                cmd.CommandText = "select * from StudentInfo where id=" + txtid.Text.Trim();
                //the trim method removes empty, white spaces from the current textbox or whatever control you are using
                cmd.Connection = con;
                var rdr = cmd.ExecuteReader();
                //The ExecuteReader() in C# SqlCommand Object sends the SQL statements to the Connection object
                //command text is an object of CMD that needs to use Execute reader to be executed from the Command text
                // bool temp = false;
                if (rdr.Read() == false)
                {
                    OleDbCommand cmdI = con.CreateCommand();
                    cmdI.CommandText = "Insert into StudentInfo(id, fname, lname, mi, crse)Values('" + txtid.Text + "','" + txtfn.Text + "','" + txtln.Text + "','" + txtmi.Text + "', '" + txtcrs.Text + "')";
                    cmd.Connection = con;
                    cmdI.ExecuteNonQuery();
                    MessageBox.Show("Congratulations! Record successfully added!", "Record Added & Saved");
                    con.Close();
                    txtid.Text = "";
                    txtfn.Text = "";
                    txtln.Text = "";
                    txtmi.Text = "";
                    txtcrs.Text = "";
                    txtid.Focus();
                    //SearchIDtxt.Text = "";
                    //btndisplay.Enabled = true;
                }
                else
                {
                    MessageBox.Show("This ID Number is already taken.", "Existing Data");
                    txtid.Text = "";
                    txtid.Focus();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //btndelete.Enabled = true;
            if (SearchIDtxt.Text == "Enter ID number to search" | SearchIDtxt.Text == "")
            {
                MessageBox.Show("Kindly enter an ID number to search.", "Missing Input");
                txtid.Text = "";
                txtfn.Text = "";
                txtln.Text = "";
                txtmi.Text = "";
                txtcrs.Text = "";
                SearchIDtxt.Focus();
            }
            else
            {
                OleDbConnection con = new OleDbConnection(coString);
                OleDbCommand cmd = con.CreateCommand();
                //this cmd represents the SQL queries sets of instructions to be passed on to Database using OLEDBCommand, and this can only be possible if you opened the connection
                con.Open();
                cmd.CommandText = "select * from StudentInfo where id=" + SearchIDtxt.Text.Trim();
                //the trim method removes empty, white spaces from the current textbox or whatever control you are using
                cmd.Connection = con;
                var rdr = cmd.ExecuteReader();
                //The ExecuteReader() in C# SqlCommand Object sends the SQL statements to the Connection object
                //command text is an object of CMD that needs to use Execute reader to be executed from the Command text
                bool temp = false;
                while (rdr.Read())
                {
                    //textBox1.Text = rdr.GetString(0);
                    txtid.Text = SearchIDtxt.Text;
                    txtfn.Text = rdr.GetString(1);
                    txtln.Text = rdr.GetString(2);
                    txtmi.Text = rdr.GetString(3);
                    txtcrs.Text = rdr.GetString(4);
                    //textBox6.Text = rdr.GetString(5);
                    //textBox7.Text = rdr.GetString(6);
                    //textBox8.Text = rdr.GetString(7);
                    //textBox9.Text = rdr.GetString(8);
                    //textBox10.Text = rdr.GetString(9);
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("Not found!", "Search Record");
                con.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtfn.Text = "";
            txtln.Text = "";
            txtmi.Text = "";
            txtcrs.Text = "";
            dgv.DataSource = null;
            txtid.Focus();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(coString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "select * from StudentInfo";
            cmd.Connection = con;
            var rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
                //to load the table while reading it through execute reader
            dgv.DataSource = dt;
            //container/controls where the values of the New table (dt), through an instantiation using DT will be displayed linked by the use of .data source since you cannot directly pass the values in the control itself
            txtid.Focus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text) && string.IsNullOrWhiteSpace(txtfn.Text) && string.IsNullOrWhiteSpace(txtln.Text) && string.IsNullOrWhiteSpace(txtmi.Text) && string.IsNullOrWhiteSpace(txtcrs.Text))
            {
                MessageBox.Show("Kindly input an ID number to update.", "Missing Input");
            }
            else if (string.IsNullOrWhiteSpace(txtid.Text) | string.IsNullOrWhiteSpace(txtfn.Text) | string.IsNullOrWhiteSpace(txtln.Text) | string.IsNullOrWhiteSpace(txtmi.Text) | string.IsNullOrWhiteSpace(txtcrs.Text))
            {
                MessageBox.Show("Kindly input an ID number to update.", "Record Incomplete");
            }
            else
            {
                OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stdnt.accdb");
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "update StudentInfo set fname = '" + this.txtfn.Text + "',lname = '" + this.txtln.Text + "',mi = '" + this.txtmi.Text + "',crse = '" + this.txtcrs.Text + "' where id=" + this.txtid.Text + " ";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                const string message = "Are you sure you want to Update record?";
                const string caption = "Update Record";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Record has been successfully updated!", "Record Updated");
                    con.Close();
                    txtid.Text = "";
                    txtfn.Text = "";
                    txtln.Text = "";
                    txtmi.Text = "";
                    txtcrs.Text = "";
                    SearchIDtxt.Text = "Enter ID number to search";
                    txtid.Focus();
                }
                else if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=stdnt.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "CREATE TABLE emp(studentid INTEGER PRIMARY KEY,stuname CHAR(50), stuaddress CHAR(255), stubalance FLOAT)";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Table created", "Congrats");
            con.Close();
            txtid.Text = "";
            txtfn.Text = "";
            txtln.Text = "";
            txtmi.Text = "";
            txtcrs.Text = "";
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to exit application?";
            const string caption = "EXIT - Student Information Registry";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnclearsearch_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtfn.Text = "";
            txtln.Text = "";
            txtmi.Text = "";
            txtcrs.Text = "";
            SearchIDtxt.Text = "Enter ID number to search";
            //dgv.DataSource = null;
            SearchIDtxt.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (SearchIDtxt.Text == "Enter ID number to search" | SearchIDtxt.Text == "")
            {
                MessageBox.Show("Kindly enter an ID number in the search box to delete.", "Missing Input");
                txtid.Text = "";
                txtfn.Text = "";
                txtln.Text = "";
                txtmi.Text = "";
                txtcrs.Text = "";
                SearchIDtxt.Focus();
            }
            else
            {
                OleDbConnection con = new OleDbConnection(coString);
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "Delete id from StudentInfo where id=" + SearchIDtxt.Text.Trim();
                cmd.ExecuteNonQuery();
                cmd.Connection = con;
                const string message = "Are you sure you want to delete record?";
                const string caption = "Delete Record";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Record is deleted successfully.", "Delete Record");
                    con.Close();
                    txtid.Text = "";
                    txtfn.Text = "";
                    txtln.Text = "";
                    txtmi.Text = "";
                    txtcrs.Text = "";
                    SearchIDtxt.Text = "Enter ID number to search";
                }
                else if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void SearchIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int parsedValue;
            //btndelete.Enabled = false;
            //btndisplay.Enabled = false;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void SearchIDtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtfn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtln_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtmi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtcrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }
    }
}
