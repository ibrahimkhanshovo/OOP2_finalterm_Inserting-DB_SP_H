
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;
            using System.Data.SqlClient;

namespace Insert_into_db
    {
        class Database
        {
            public static SqlConnection conn;
            public static SqlConnection ConnectDB()
            {
                string connString = @"Server=IBRAHIM\SQLEXPRESS;Database=course;Integrated Security=true";
                SqlConnection conn = new SqlConnection(connString);
                return conn;
            }
        }
    }
© 2021 GitHub, Inc.
        }
    }
}
