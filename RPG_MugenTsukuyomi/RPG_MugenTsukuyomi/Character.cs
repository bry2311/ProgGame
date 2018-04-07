using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_MugenTsukuyomi
{
    public abstract class Character
    {
        public abstract int Id { get; set; }
        public abstract int HealthPoint { get; set; }
        public abstract int Mana { get; set; }
        public abstract int Level { get; set; }
        public abstract int Experience { get; set; }
    }
}
