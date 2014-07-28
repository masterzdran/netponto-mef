using Contracts;

namespace ChannelLibrary
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
