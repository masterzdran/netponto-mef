using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateTv_01_Channels_Lib
{
    public class DiscoveryChannel : IChannel
    {
        public string ChannelLogo
        {
            get
            {
                return "Discovery Channel";
            }
        }

        public string ChannelTV
        {
            get
            {
                return "Discovery.jpg";
            }
        }
    }
}
