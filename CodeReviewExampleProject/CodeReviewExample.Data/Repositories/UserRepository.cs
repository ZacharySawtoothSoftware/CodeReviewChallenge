using CodeReviewExample.Client.Abstractions.Dto;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CodeReviewExample.Data.Repositories
{
    public class UserRepository
    {
        public string ConnectionString = "Server=exampleServer;Database=exampleDatabase;User Id=exampleUser;Password=examplePassword;";
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }

        public IList<double> GetScores(RequestModel request)
        {
            IList<double> scores = new List<double>();
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            for (int i = 0; i < request.Ids.Count; i++)
            {
                string sql = $"SELECT Score FROM ScoresTable WHERE Id='{request.Ids[i]}'";
                Command = new SqlCommand(sql, Connection);
                double score = (double) Command.ExecuteScalar();
                scores.Add(score);
            }
            return scores;
        }
    }
}
