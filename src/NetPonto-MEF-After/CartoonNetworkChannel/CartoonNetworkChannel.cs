using ChannelContract;
using System.Composition;

namespace CartoonNetworkChannel
{
    [Export(typeof(IChannel))]
    [ExportMetadata("Channel", "CN")]
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
