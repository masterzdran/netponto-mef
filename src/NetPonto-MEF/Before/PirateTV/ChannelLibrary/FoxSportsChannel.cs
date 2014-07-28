using Contracts;

namespace ChannelLibrary
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
