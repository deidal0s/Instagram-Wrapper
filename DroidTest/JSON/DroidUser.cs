using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidTest.JSON
{
    public class DroidUser
    {
        public ulong DiscordId { get; set; }

        public string Username { get; set; }

        public string WhitelistDate { get; set; }

        public int PlanType { get; set; }

        public List<DroidAccount> Accounts = new List<DroidAccount>();
    }
}
