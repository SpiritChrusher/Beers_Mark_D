using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Beers_MarkD.Backend
{
    class BeersDAO
    {
        public static List<Beers> ReadBeer()
        {
            var jsonString = File.ReadAllText("Allbeers.json");
            List<Beers> beerlist = JsonSerializer.Deserialize<List<Beers>>(jsonString);
            return beerlist;
        }
    }
}
