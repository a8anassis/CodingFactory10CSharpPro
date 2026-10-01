using System;
using System.Collections.Generic;
using System.Text;

namespace OOApp
{
    internal sealed class Region
    {
        public int Id { get; }
        public string? Name { get; }

        public Region()
        {
        }

        public Region(int id, string? name)
        {
            Id = id;
            Name = name;
        }
    }
}
