using Contracts;

namespace ChannelLibrary
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
