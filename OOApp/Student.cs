using System;
using System.Collections.Generic;
using System.Text;

namespace OOApp
{
    internal class Student
    {
        private readonly int _id;
        private readonly string? _firstname;
        private readonly string? _lastname;

        public int Id { get => _id; }
        public string? Firstname { get => _firstname; }
        public string? Lastname { get => _lastname; }
    }
}
