using Dapper.Api.Domain;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Dapper.Api.Repository
{
    public sealed class SensorRepository : ISensorRepository
    {
        private readonly string _connectionString;

        public SensorRepository(IConfiguration configuration )
        {
            _connectionString = configuration.GetConnectionString("SensorDataServer");
        }
        public int Insert(long step)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "insert into sensor (step) values (@step)";
            var result = connection.Execute(query, new { step = step });
            return result;
        }

        public IEnumerable<Sensor> ListAll()
        {
            using var connection = new SqlConnection(_connectionString);
            var sensorData = connection.Query<Sensor>("select * from sensor");
            return sensorData;
        }
    }
}