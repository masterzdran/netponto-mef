using Contracts;
using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Television.Contracts;

namespace Television.Model
{
    public sealed class TVOperations: ITVOperations
    {
        private int channelNbr = 1;
        private readonly IPirateChannel[] pirateChannels;
        
        
        private readonly CompositionContainer container;

        [ImportMany(typeof(IChannel))]
        public IChannel[] channels;

        public TVOperations()
        {

            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Properties.Settings.Default.PluginsPath));

            //Create the CompositionContainer with the parts in the catalog
            container = new CompositionContainer(catalog);


            //Fill the imports of this object
            try
            {
                container.ComposeParts(this);
                pirateChannels = new IPirateChannel[channels.Length];
                for (int i = 0; i < channels.Length; i++)
                {
                    ImageBrush c = new ImageBrush();
                    c.ImageSource = new BitmapImage(new Uri(@"Images/" + channels[i].ChannelTV, UriKind.Relative));
                    IPirateChannel pc = new PirateChannel();
                    pc.Channel = c;
                    pc.Logo = channels[i].ChannelLogo;

                    pirateChannels[i] = pc;
                }
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }
        public IPirateChannel ChannelUp()
        {
            channelNbr = (++channelNbr >= pirateChannels.Length) ? 0 : channelNbr;
            return pirateChannels[channelNbr];
        }

        public IPirateChannel ChannelDown()
        {
            channelNbr = (--channelNbr < 0) ? pirateChannels.Length - 1 : channelNbr;
            return pirateChannels[channelNbr];
        }

    }
}
