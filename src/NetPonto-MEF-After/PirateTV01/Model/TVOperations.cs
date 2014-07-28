using PirateTV01.Contracts;
using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ServiceModel.Channels;


namespace PirateTV01.Model
{
    public sealed class TVOperations: ITVOperations
    {
        private readonly String pluginLocationPath = "c:/dev/mef/plugin";

        private int channelNbr = 1;
        private CompositionContainer _container;

        [Import(typeof(IChannel))]
        private IChannel channel;

        private IPirateChannel[] pirateChannels;

        public TVOperations()
        {
            //An aggregate catalog that combines multiple catalogs
            var catalog = new AggregateCatalog();
            //Adds all the parts found in the same assembly as the Program class
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(TVOperations).Assembly));
            catalog.Catalogs.Add(new DirectoryCatalog(pluginLocationPath));

            //Create the CompositionContainer with the parts in the catalog
            _container = new CompositionContainer(catalog);

            //Fill the imports of this object
            try
            {
                this._container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }
        public IPirateChannel ChannelUp()
        {
            channelNbr = (++channelNbr >= pirateChannels.Length) ? 1 : channelNbr;
            return pirateChannels[channelNbr];
        }

        public IPirateChannel ChannelDown()
        {
            channelNbr = (--channelNbr <= 0) ? pirateChannels.Length - 1 : channelNbr;
            return pirateChannels[channelNbr];
        }

    }
}
