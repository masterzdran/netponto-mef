using Contracts;
using System;
using System.ComponentModel.Composition;

namespace CartoonNetworkChannel
{
    [Export(typeof(IChannel))]
    [ExportMetadata("Channel", "CN")]
    public class CartoonNetwork : IChannel
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
                return "cartoon.png";
            }
        }
    }
}
