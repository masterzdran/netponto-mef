using System;
using System.Windows.Media;

namespace Television.Contracts
{
    public interface IPirateChannel
    {
        ImageBrush Channel { get; set; }
        String Logo { get; set; }
    }
}
