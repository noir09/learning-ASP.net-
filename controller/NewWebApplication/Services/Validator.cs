using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebApplication.Services
{
    public class Validate : IValidator
    {
        private const double _minPossibleCelsiumValue = -273.15d;

        public string Check(double C)
        {
            string Errors;

            if (C <= _minPossibleCelsiumValue)
            {
                Errors="Значение меньше чем -273.15 ";
                return Errors;
            }
            else 
            {
                return null;
            }
        }
    }
}
