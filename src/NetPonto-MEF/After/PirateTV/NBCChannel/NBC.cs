using System;
using System.ComponentModel.Composition;
using Contracts;

namespace NBCChannel
{
    [Export(typeof(IChannel))]
    [ExportMetadata("Channel", "NBC")]
    public class NBC:IChannel
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
                return "nbc.jpg";
            }
        }
    }
}
