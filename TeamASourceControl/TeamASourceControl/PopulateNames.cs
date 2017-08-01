using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamASourceControl
{
    partial class Player
    {
        public string PlayerFullName
        {
            get
            {
                return PlayerFirstName + " " + PlayerLastName;
            }
        }
    }
}
