using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirateTv_01_Channels_Lib
{
    public interface IChannel
    {
        String ChannelLogo { get; }
        String ChannelTV { get; }
    }
}
