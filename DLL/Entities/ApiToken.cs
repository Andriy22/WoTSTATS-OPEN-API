using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Entities
{
    public class ApiToken
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public int Requests { get; set; }
        public string MacAddress { get; set; }
        public string Service { get; set; }
        public string ServiceName { get; set; }
        public User User { get; set; }
    }
}
