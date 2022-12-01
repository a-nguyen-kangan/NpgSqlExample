using Npgsql;
using NpgSqlExample.models;

namespace NpgSqlExample.DbHandler
{
    public class DbHandler
    {
        private const string CONNECTION_STRING = "Host=db.wifiandinternetsolutions.com.au;" +
            "Username=anh;" +
            "Password=kangan;" +
            "Database=anhdb01";
        private NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING);

        public List<Car> GetCars() {
            // start connection
            this.connection.Open();

            // set up a query
            NpgsqlCommand command = new NpgsqlCommand("Select * from Cars;", this.connection);

            // execute the query
            NpgsqlDataReader reader = command.ExecuteReader();
            var cars = new List<Car>();

            while(reader.Read()) {
                System.Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]}");
                cars.Add(new Car(reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
            }

            return cars;
        }
    }
}