using System;
using System.Windows.Media;
using Television.Contracts;

namespace Television.Model
{
    public sealed class PirateChannel : IPirateChannel
    {
        public ImageBrush Channel { get; set; }
        public String Logo { get; set; }
    }
}
