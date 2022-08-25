using Dapper;
using Server.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes
{
    internal class Registration
    {
        public bool IsRegistered { get; set; }
        public bool sidn_in;
        string connectionString = @"Data Source=DESKTOP-54SAU6R\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void Regestration(string _email, string _pass)
        {
            try
            {
                List<User> usList = GetUsers();
                foreach (var item in usList)
                {
                    if (item.email == _email) { IsRegistered = true; }
                }
                if (IsRegistered) { Console.WriteLine("This E-mail is Exist !"); }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        User regestration = new User() { email = _email, password = new Crypt().Generate(_pass) };
                        connection.Execute("INSERT INTO Users (email, password) VALUES(@email,@password)", regestration);
                        Console.WriteLine("Registration is OK !");
                    }
                }
            }
            catch { Console.WriteLine("Conection Error"); }

        }
        public void signIn(string _email, string _pass)
        {
            try
            {
                List<User> usList = GetUsers();
                foreach (var item in usList)
                {
                    if (item.email == _email && new Crypt().veryfy(_pass, item.password) == true)
                    {
                        //Program.mainForm.sign = true;
                        sidn_in = true;
                    }
                }
            }
            catch { Console.WriteLine("Conection Error"); }
        }
        public List<User> GetUsers() { using (IDbConnection connection = new SqlConnection(connectionString)) { return connection.Query<User>($"SELECT * FROM [Users] ").ToList(); } }

    }
}
