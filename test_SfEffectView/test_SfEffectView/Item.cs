using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_SfEffectView
{
    public class Item
    {
        public Item()
        {
            Name = RandomString(10);
        }

        public string Name { get; set; }


        private static Random random = new Random();

        public static string RandomString(int length)
        {
            try
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
