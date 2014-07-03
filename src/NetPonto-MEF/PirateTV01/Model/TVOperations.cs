using PirateTv_01_Channels_Lib;
using PirateTV01.Contracts;
using System;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace PirateTV01.Model
{
    public sealed class TVOperations: ITVOperations
    {
        private int channel = 1;
        private IPirateChannel[] pirateChannels;

        public TVOperations()
        {
               IChannel[] channels = new IChannel[6]{
                    null,
                    new NBCChannel(),
                    new FoxBusinessChannel(),
                    new FoxSportsChannel(),
                    new DiscoveryChannel(),
                    new CartoonNetworkChannel()
                };
               pirateChannels = new IPirateChannel[6];
            for (int i = 1; i < channels.Length; i++)
            {
                ImageBrush c = new ImageBrush();
                c.ImageSource = new BitmapImage(new Uri("ms-appx:/Images/" + channels[i].ChannelTV, UriKind.Absolute));
                IPirateChannel pc = new PirateChannel();
                pc.Channel = c;
                pc.Logo = channels[i].ChannelLogo;

                pirateChannels[i] = pc;
            }

        }
        public IPirateChannel ChannelUp()
        {
            channel = (++channel >= pirateChannels.Length) ? 1 : channel;
            return pirateChannels[channel];
        }

        public IPirateChannel ChannelDown()
        {
            channel = (--channel <= 0) ? pirateChannels.Length - 1 : channel;
            return pirateChannels[channel];
        }

    }
}
