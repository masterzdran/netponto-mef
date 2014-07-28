using System;
using System.ComponentModel.Composition;
using Contracts;

namespace FoxSportsChannel
{
    [Export(typeof(IChannel))]
    [ExportMetadata("Channel", "FOXS")]
    public class FoxSports:IChannel
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
                return "foxsports.jpg";
            }
        }
    }
}
