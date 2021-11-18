using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Satge2_Inventoey_management_system
{
    static class Newinventory
    {
        public static SqlConnection NewInventory;

        static Newinventory()
        {
            NewInventory = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\navee\Downloads\stage1\Newstage1.mdf;Integrated Security=True;Connect Timeout=30");
        }

    }
}

