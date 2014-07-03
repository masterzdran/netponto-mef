using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateTv_01_Channels_Lib
{
    public class FoxBusinessChannel : IChannel
    {
        public string ChannelLogo
        {
            get
            {
                return "Fox Business";
            }
        }

        public string ChannelTV
        {
            get
            {
                return "fox-business-logo.jpg";
            }
        }
    }
}
