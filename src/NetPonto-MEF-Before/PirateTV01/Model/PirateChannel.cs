using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PirateTV01.Contracts;
using Windows.UI.Xaml.Media;

namespace PirateTV01.Model
{
    public sealed class PirateChannel : IPirateChannel
    {
        public ImageBrush Channel { get; set; }
        public String Logo { get; set; }
    }
}
