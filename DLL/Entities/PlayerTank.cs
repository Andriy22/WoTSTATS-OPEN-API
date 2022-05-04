using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Entities
{
    public class PlayerTank
    {
        public int Id { get; set; }
        public int TankId { get; set; }
        public string TankName { get; set; }
        public int RandomBattles { get; set; }
        public double RandomAvgDmg { get; set; }
        public double Wn8 { get; set; }
        public int StrongholdDefenseBattles { get; set; }
        public double StrongholdDefenseAvgDmg { get; set; }
        public int StrongholdAttackBattles { get; set; }
        public double StrongholdAttackAvgDmg { get; set; }
    }
}
