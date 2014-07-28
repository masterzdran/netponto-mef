using System;
using System.ComponentModel.Composition;
using Contracts;

namespace FoxBusinessChannel
{
    [Export(typeof(IChannel))]
    [ExportMetadata("Channel", "FOXB")]
    public class FoxBusiness:IChannel
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
                return "foxb.jpg";
            }
        }
    }
}
