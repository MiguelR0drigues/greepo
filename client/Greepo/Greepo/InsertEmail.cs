using Accord.Statistics.Filters;
using Microsoft.TeamFoundation.Test.WebApi;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Greepo
{
    public partial class Recuperar : Form
    {
        public Recuperar()
        {
            InitializeComponent();
        }

        private void inptEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSendToken_Click(object sender, EventArgs e)
        {
            
            try
            {
                MailAddress email = new MailAddress(inptEmail.Text);
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"http://localhost:2080/user-exist/{inptEmail.Text}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("This email doesn't exist!");
                    }
                    else
                    {
                        var token = GenerateToken();
                        HttpResponseMessage resp = await client.GetAsync($"http://localhost:2080/send-token/{inptEmail.Text}/{token}");
                        if (resp.IsSuccessStatusCode)
                        {
                            // Send email to inptEmail.Text
                            using (SmtpClient smtp = new SmtpClient())
                            {
                                MailMessage mail = new MailMessage();
                                mail.From = new MailAddress("greepo_tech@outlook.com");
                                mail.To.Add(inptEmail.Text);
                                mail.Subject = "Activation token - Greepo Tech";
                                mail.Body = "Here is your activation token: " + token;
                                smtp.Host = "smtp.outlook.com";
                                smtp.Port = 587;
                                smtp.EnableSsl = true;
                                smtp.UseDefaultCredentials = false;
                                smtp.Credentials = new NetworkCredential("greepo_tech@outlook.com", "SAD_nova99");
                                smtp.Send(mail);
                            }
                            Token page = new Token(inptEmail.Text);
                            page.Show();
                            Hide();
                                
                        }
                        else
                        {
                            MessageBox.Show("Error getting response from the API. Status Code: " + response.StatusCode);
                        }


                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid email format.");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }

        private string GenerateToken()
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 5)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }
    }
}
