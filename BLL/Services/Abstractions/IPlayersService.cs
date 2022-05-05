using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Abstractions
{
    public interface IPlayersService
    {
        public void GetClanLeavers(int clanId, string clanTag);
    }
}
