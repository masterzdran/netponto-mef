using Contracts;

namespace ChannelLibrary
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
