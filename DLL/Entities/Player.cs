using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Entities
{
    public class Player
    {
        public Player()
        {
            PlayerTanks = new List<PlayerTank>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Nickname { get; set; }
        public int LeaveClanId { get; set; }
        public string LeaveClan { get; set; }
        public string TanksIds { get; set; }
        public double Wn8 { get; set; }
        public double Wn81000 { get; set; }
        public double WinRate { get; set; }
        public double Re { get; set; }
        public double Re1000 { get; set; }
        public int StrongholdDefenseBattles { get; set; }
        public int StrongholdDefenseAvgDmg { get; set; }
        public int StrongholdAttackBattles { get; set; }
        public int StrongholdAttackAvgDmg { get; set; }
        public int RandomBattles { get; set; }
        public int RandomDmg { get; set; }
        public DateTime LastActive { get; set; }
        public int BattlesPerDay { get; set; }
        public string Server { get; set; }
        public List<PlayerTank> PlayerTanks { get; set; }
    }
}
