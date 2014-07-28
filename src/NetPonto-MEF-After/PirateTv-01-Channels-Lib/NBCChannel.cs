using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateTv_01_Channels_Lib
{
    public class NBCChannel : IChannel
    {
        public string ChannelLogo
        {
            get
            {
                return "NBC";
            }
        }

        public string ChannelTV
        {
            get
            {
                return "nbc.png";
            }
        }
    }
}
