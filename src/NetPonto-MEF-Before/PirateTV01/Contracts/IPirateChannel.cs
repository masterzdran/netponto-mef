using System;
using Windows.UI.Xaml.Media;
namespace PirateTV01.Contracts
{
    public interface IPirateChannel
    {
        ImageBrush Channel { get; set; }
        string Logo { get; set; }
    }
}
