
using Solid.SRP.Incorrect.Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SRP.Incorrect.Repository
{
    public class UserService
    {
        public string CreateUser(UserRequest newUser)
        {
            bool isEmailValid = newUser.Email.Contains('@');

            if (!isEmailValid)
                return "The email is incorrect";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "ConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO User (NAME, EMAIL, PASSWORD) VALUES (@name, @email, @password)";

                cmd.Parameters.AddWithValue("email", newUser.Email);
                cmd.Parameters.AddWithValue("password", newUser.Password);
                cmd.Parameters.AddWithValue("name", newUser.Name);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("empresa@empresa.com", newUser.Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome";
            mail.Body = "Congratulations, you are registered";
            client.Send(mail);

            return "User successfully registered";
        }
    }
}
