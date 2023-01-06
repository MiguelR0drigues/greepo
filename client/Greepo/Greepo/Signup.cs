using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Greepo
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            inptName.TabIndex=0;
            inptEmail.TabIndex=1;
            ddGender.TabIndex=2;
            inptPassword.TabIndex=3;
            inptConfirmPassword.TabIndex=4;
        }
        private void ddGender_Load(object sender, EventArgs e)
        {
            ddGender.Items.Add("Male");
            ddGender.Items.Add("Female");
            ddGender.Items.Add("Non-Binary");
            ddGender.Items.Add("Other");
            ddGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void ddGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inptPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void inptEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void inptName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }


        private void richbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inptConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            string gender = ddGender.Text;
            string name = inptName.Text;
            string email = inptEmail.Text;
            string password = inptPassword.Text;
            string confirmPassword = inptConfirmPassword.Text;

            if(string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Every field is mandatory!", "Error");
                return;
            }
            // Handle invalid gender option
            if (!ddGender.Items.Contains(gender) && !string.IsNullOrEmpty(gender))
            {
                // The selected item is NOT a valid option.
                MessageBox.Show("Invalid gender option!", "Error");
                return;

            }

            //Handle different passwords
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords don't match!", "Error");
                return;
            }

            {
                // Create a new HttpClient object
                var client = new HttpClient();

                // Set the API endpoint URL
                var url = "http://localhost:2080/signup";


                // Create a JSON object with the email and password values
                var json = $"{{\"name\":\"{name}\",\"gender\":\"{gender}\",\"email\":\"{email}\",\"password\":\"{password}\"}}";

                // Set the request content
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send the POST request
                var response = await client.PostAsync(url, content);

                // Read the response body
                var responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show(responseBody, "Info");

                // Check the value of the response
                if (responseBody == "true")
                {
                    // Signup was successful
                    MessageBox.Show("SignUp Successful!", "Info");
                }
                else if (responseBody == "false")
                {
                    // Signup failed
                    MessageBox.Show("SignUp failed, check for invalid options or for email already in use!", "Error");
                }
                else
                {
                    // Unexpected response
                    MessageBox.Show("Unexpected error! " + responseBody, "Error");

                }

                //reset form inputs
                //Utilities.ResetAllControls(this);

            }

        }

        private void linkToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }
    }
}
