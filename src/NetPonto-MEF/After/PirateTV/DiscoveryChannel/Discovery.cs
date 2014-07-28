using System;
using System.ComponentModel.Composition;
using Contracts;

namespace DiscoveryChannel
{
    [Export(typeof(IChannel))]
    [ExportMetadata("Channel", "DC")]
    public class Discovery:IChannel
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
