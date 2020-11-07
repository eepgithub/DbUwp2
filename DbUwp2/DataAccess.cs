using DbUwp2.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbUwp2
{
    public static class DataAccess
    {
        private static readonly string connectionString = @"Server=tcp:ecsqlserver.database.windows.net,1433;Initial Catalog=SqlUwp2;Persist Security Info=False;User ID=Epadmin;Password=Bytmig123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public static async Task AddAsync(Problem problem)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();



                var query = "INSERT INTO Problemm (Customer, Title, Status, Created, Description) VALUES(@Customer, @Title, @Status, @Created, @Description)";
                SqlCommand cmd = new SqlCommand(query, sqlConn);




                cmd.Parameters.AddWithValue("@Customer", problem.Customer);
                cmd.Parameters.AddWithValue("@Title", problem.Title);
                cmd.Parameters.AddWithValue("@Status", problem.Status);
                cmd.Parameters.AddWithValue("@Created", problem.Created);
                cmd.Parameters.AddWithValue("@Description", problem.Description);



                await cmd.ExecuteReaderAsync();



                sqlConn.Close();
            }



        }

        public static async Task UpdateAsync(int problemid, string status)
        {
            using (SqlConnection Sqlconn = new SqlConnection(connectionString))
            {
                Sqlconn.Open();

                var query = "UPDATE Problemm SET Status = @Status WHERE ProblemId = @ProblemId";

                SqlCommand cmd = new SqlCommand(query, Sqlconn);


                cmd.Parameters.AddWithValue("@ProblemId", problemid);
                cmd.Parameters.AddWithValue("@Status", status);

                await cmd.ExecuteReaderAsync();
                Sqlconn.Close();
            }
        }

        public static IEnumerable<Problem> GetAllActive()
        {

            var problemList = new List<Problem>();


            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {



                sqlConn.Open();
                var query = "SELECT * FROM Problemm WHERE Problemm.Status = 'Active'";


                SqlCommand cmd = new SqlCommand(query, sqlConn);

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    int ProblemId = result.GetInt32(0);
                    string Customer = result.GetString(1);
                    string Title = result.GetString(2);
                    string Status = result.GetString(3);
                    DateTime Created = result.GetDateTime(4);
                    string Description = result.GetString(5);

                    problemList.Add(new Problem(ProblemId, Customer, Title, Status, Created, Description));
                }

                sqlConn.Close();
                return problemList;


            }
        }

        public static IEnumerable<Problem> GetAllClosed()
        {

            var problemList = new List<Problem>();


            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {



                sqlConn.Open();
                var query = "SELECT * FROM Problemm WHERE Problemm.Status = 'Closed'";


                SqlCommand cmd = new SqlCommand(query, sqlConn);

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    int ProblemId = result.GetInt32(0);
                    string Customer = result.GetString(1);
                    string Title = result.GetString(2);
                    string Status = result.GetString(3);
                    DateTime Created = result.GetDateTime(4);
                    string Description = result.GetString(5);

                    problemList.Add(new Problem(ProblemId, Customer, Title, Status, Created, Description));
                }

                sqlConn.Close();
                return problemList;




            }
        }

        public static IEnumerable<Problem> GetAllNew()
        {

            var problemList = new List<Problem>();


            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {



                sqlConn.Open();
                var query = "SELECT * FROM Problemm WHERE Problemm.Status = 'New'";


                SqlCommand cmd = new SqlCommand(query, sqlConn);

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    int ProblemId = result.GetInt32(0);
                    string Customer = result.GetString(1);
                    string Title = result.GetString(2);
                    string Status = result.GetString(3);
                    DateTime Created = result.GetDateTime(4);
                    string Description = result.GetString(5);

                    problemList.Add(new Problem(ProblemId, Customer, Title, Status, Created, Description));
                }

                sqlConn.Close();
                return problemList;




            }
        }

       
    }
}
