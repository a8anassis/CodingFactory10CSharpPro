using System;
using System.Collections.Generic;
using System.Text;

namespace OOApp
{
    internal class Course
    {
        private int _id;
        private string? _name;

        public int Id { get => _id; init => _id = value; }                  // C#9 --> Object Initializer
        public string? Name { get => _name; private set => _name = value; } // Can not be used by object initializer, but can be set in constructor
    }
}
