using System;
using Mod2HW6.Models.ElectricalApps;

namespace Mod2HW6.Extensions
{
    public static class ArrayExtension
    {
        public static ElectricalApps[] Filter(this ElectricalApps[] array, string name = null, int? maxPower = null)
        {
            var result = new ElectricalApps[array.Length];
            var resultCapacity = 0;

            if (string.IsNullOrEmpty(name) && maxPower.Equals(null))
            {
                return array;
            }

            if (maxPower.Equals(null))
            {
                for (var i = 0; i < array.Length; i++)
                {
                    if (array[i].Name.Contains(name, System.StringComparison.OrdinalIgnoreCase))
                    {
                        result[resultCapacity] = array[i];
                        resultCapacity++;
                    }
                }

                Array.Resize(ref result, resultCapacity);
                return result;
            }

            if (string.IsNullOrEmpty(name))
            {
                for (var i = 0; i < array.Length; i++)
                {
                    if (array[i].Power <= maxPower)
                    {
                        result[resultCapacity] = array[i];
                        resultCapacity++;
                    }
                }

                Array.Resize(ref result, resultCapacity);
                return result;
            }

            for (var i = 0; i < array.Length; i++)
            {
                if ((array[i].Power <= maxPower) && array[i].Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                {
                    result[resultCapacity] = array[i];
                    resultCapacity++;
                }
            }

            Array.Resize(ref result, resultCapacity);
            return result;
        }
    }
}
