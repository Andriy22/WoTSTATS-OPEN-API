using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.ClanLeavers
{
    public class ClanLeavers
    {
        public string subtype { get; set; }
        public string group { get; set; }
        public int? initiator_id { get; set; }
        public DateTime created_at { get; set; }
        public List<int> accounts_ids { get; set; }
    }
}
