using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateTv_01_Channels_Lib
{
    public class FoxSportsChannel : IChannel
    {
        public string ChannelLogo
        {
            get
            {
                return "Fox Sports";
            }
        }

        public string ChannelTV
        {
            get
            {
                return "Fox-Sports.jpg";
            }
        }
    }
}
