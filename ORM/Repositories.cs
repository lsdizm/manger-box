using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MangerBox.Models;

namespace MangerBox.ORM
{    
    public class Repositories
    {    
        private readonly string _connectionString;

        public Repositories()
        {
            _connectionString = "Server=127.0.0.0;user id=mj;password=20121104;Database=mj;";    
        }

        public async Task<List<TestDataTable>> GetTest()
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                var query = "select * from testdatatable";
                var result = await connection.QueryAsync<TestDataTable>(query).ConfigureAwait(false);
                return result.ToList();
            }
        }
    }    
}   