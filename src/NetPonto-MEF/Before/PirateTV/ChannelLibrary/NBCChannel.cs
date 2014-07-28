using Contracts;

namespace ChannelLibrary
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
