using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroidTest.JSON
{
    public class Stuff
    {
        public List<DroidUser> Users = new List<DroidUser>();

        public List<ulong> Admins = new List<ulong>();

        public string Prefix = "ig.";
    }
}
