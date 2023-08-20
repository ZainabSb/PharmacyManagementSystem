using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void SignInButton_Click_Click(object sender, EventArgs e)
        {
            // Check if either of the text fields is empty
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Some Credentials are missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            query = "select * from users";
            ds = fn.getData(query);



            if (ds.Tables[0].Rows.Count == 0)
            {
                if (textBox1.Text == "root" && textBox2.Text == "root")
                {
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Hide();
                }
            }

            else
            {
                query = "select * from users where username = '" + textBox1.Text + "' and passcode='" + textBox2.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {
                        Administrator admin = new Administrator(textBox1.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist(textBox1.Text);
                        pharm.Show();
                        this.Hide();
                    }

                }

                else
                {
                    MessageBox.Show("User Not Found!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                // Show the password in plain text
                textBox2.PasswordChar = '\0'; // Set PasswordChar to null character ('\0')
            }
            else
            {
                // Hide the password behind asterisks
                textBox2.PasswordChar = '*';
            }
        }

    }
}
