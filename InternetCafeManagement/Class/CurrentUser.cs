using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetCafeManagement.Class
{
    static public class CurrentUser
    {
        private static int id;

        public static int Id { get => id; set => id = value; }
    }
}
