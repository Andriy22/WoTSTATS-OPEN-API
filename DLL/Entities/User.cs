using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DLL.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            ApiTokens = new List<ApiToken>();
        }
        public int WgId { get; set; }
        public string NickName { get; set; }
        public string HardwareId { get; set; }
        public string MacAddress { get; set; }
        public List<ApiToken> ApiTokens { get; set; }
    }
}
