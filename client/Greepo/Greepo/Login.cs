using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Greepo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void inptEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void inptPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Create a new HttpClient object
            var client = new HttpClient();

            // Set the API endpoint URL
            var url = "http://localhost:2080/login";

            // Set the email and password values
            var email = inptEmail.Text;
            var password = inptPassword.Text;

            // Create a JSON object with the email and password values
            var json = $"{{\"email\":\"{email}\",\"password\":\"{password}\"}}";

            // Set the request content
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the POST request
            var response = await client.PostAsync(url, content);

            // Read the response body
            var responseBody = await response.Content.ReadAsStringAsync();

            // Check the value of the response
            if (responseBody == "true")
            {
                Options options = new Options();
                options.Show();
                Hide();
            }
            else if (responseBody == "false")
            {
                // Login failed
                MessageBox.Show("Login failed.", "Error");
            }
            else
            {
                // Unexpected response
                MessageBox.Show("Unexpected response: " + responseBody, "Error");
            }

            //reset form inputs
            Utilities.ResetAllControls(this);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }


        private void linkToSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            Hide();
        }

        private void linkRecoverPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recuperar Recuperar = new Recuperar();
            Recuperar.Show();
            Hide();
        }
    }
    public class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }
    }
}
