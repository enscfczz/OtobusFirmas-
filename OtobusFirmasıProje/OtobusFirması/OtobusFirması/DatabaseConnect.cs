using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusFirması
{
    public static class DatabaseConnect
    {
        public static NpgsqlConnection Connection;
        public static void ConnectDatabase()
        {
           Connection= new NpgsqlConnection("server=localHost; port=5432; Database=OtobusFirması; user ID=postgres; password=enesenes1");
        }
    }
}
