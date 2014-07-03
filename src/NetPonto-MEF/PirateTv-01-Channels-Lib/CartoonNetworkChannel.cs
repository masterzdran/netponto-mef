using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateTv_01_Channels_Lib
{
    public class CartoonNetworkChannel : IChannel 
    {
        public string ChannelLogo
        {
            get
            {
                return "Cartoon Network";
            }
        }

        public string ChannelTV
        {
            get
            {
                return "Cartoon_Network_2010_Logo.png";
            }
        }
    }
}
