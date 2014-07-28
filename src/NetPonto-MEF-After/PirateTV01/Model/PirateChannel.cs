using PirateTV01.Contracts;
using System;

namespace PirateTV01.Model
{
    public sealed class PirateChannel : IPirateChannel
    {
        public String Channel { get; set; }
        public String Logo { get; set; }
    }
}
