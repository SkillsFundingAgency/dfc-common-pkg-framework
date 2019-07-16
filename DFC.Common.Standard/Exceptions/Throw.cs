﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DFC.Common.Standard.Exceptions
{
    public class Throw : IThrow
    {
        public void IfNull<T>(T argument, string name)
        {
            if (argument == null)
                throw new ArgumentNullException(name);
        }

        public void IfNullOrEmpty(string argument, string name)
        {
            if (string.IsNullOrEmpty(argument))
                throw new ArgumentException($"{name} cannot be null or empty.", name);
        }

        public void IfNullOrEmpty<T>(IEnumerable<T> argument, string name)
        {
            if (argument == null || !argument.Any())
                throw new ArgumentException($"{name} cannot be null or empty.", name);
        }

        public void IfNullOrWhiteSpace(string argument, string name)
        {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentException($"{name} cannot be null or empty or whitespace.", name);
        }

        public void IfLessThan(int limit, int argument, string name)
        {
            if (argument < limit)
                throw new ArgumentOutOfRangeException($"{name} cannot be less than {limit}.", name);
        }

        public void IfGreaterThan(int limit, int argument, string name)
        {
            if (argument > limit)
                throw new ArgumentOutOfRangeException($"{name} cannot be greater than {limit}.", name);
        }

        public void IfLessThan(decimal limit, decimal argument, string name)
        {
            if (argument < limit)
                throw new ArgumentOutOfRangeException($"{name} cannot be less than {limit}.", name);
        }

        public void IfGreaterThan(decimal limit, decimal argument, string name)
        {
            if (argument > limit)
                throw new ArgumentOutOfRangeException($"{name} cannot be greater than {limit}.", name);
        }
    }
}