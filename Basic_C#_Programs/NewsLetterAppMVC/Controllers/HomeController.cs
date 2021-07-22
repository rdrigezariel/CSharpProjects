using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES (@FirstName, @LastName, @EmailAddress)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                return View("Success");
            }
        }

        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber FROM SignUps";
            List<NewsletterSignUp> signUps = new List<NewsletterSignUp>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                Trace.WriteLine("Test");

                while (reader.Read())
                {
                    Trace.WriteLine(reader["SocialSecurityNumber"]);
                    var signUp = new NewsletterSignUp();
                    signUp.Id = Convert.ToInt32(reader["Id"]);
                    signUp.FirstName = reader["FirstName"].ToString();
                    signUp.LastName = reader["LastName"].ToString();
                    signUp.EmailAddress = reader["EmailAddress"].ToString();
                    signUp.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();

                    signUps.Add(signUp);
                }
            }
            var signUpVms = new List<SignUpVm>();
            foreach (var signUp in signUps)
            {
                var signupVm = new SignUpVm();
                signupVm.FirstName = signUp.FirstName;
                signupVm.LastName = signUp.LastName;
                signupVm.EmailAddress = signUp.EmailAddress;
                signUpVms.Add(signupVm);
            }

            return View(signUpVms);
        }
    }
}