using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Microsoft.Data.SqlClient;


namespace GradingSystem.Class_collection
{
    public class Students : User
    {
        private string connectionString;
        string tableName = "Student";

        public Students(string connectionString)
        {
            this.connectionString = connectionString;
        }

    }
}
