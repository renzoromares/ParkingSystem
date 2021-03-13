using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem_SSD
{
    class ConnectionString
    {
        public static readonly string connect = "Server=.\\;" +
                                                 "Database=PARKING_MANAGEMENT;" +
                                                 "User Id=sa;" +
                                                 "Password=noname101;" +
                                                 "MultipleActiveResultSets=true";
    }
}
