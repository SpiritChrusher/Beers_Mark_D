using System;
using System.Collections.Generic;
using System.Text;

namespace Beers_MarkD.Backend
{
   public class Beers
    {
      public string name { get; set; }

      public decimal alcohol { get; set; }

        public List<string> taste { get; set; }

        public string origin { get; set; }

        public List<string> type { get; set; }

        public string manufacturer;

        public string consumption;

        public int price;

        public decimal quality;

        public List<string> acquisition;

        public decimal packformat;

        public Beers(){}

        public Beers(string aname, decimal aalcohol, List<string> ataste, string aorigin, List<string> atype, 
            string amanufacturer, string aconsumption, int aprice, decimal aquality, List<string> aacquistion, decimal apackformat) 
        {
            name = aname;
            alcohol = aalcohol;
            taste = ataste;
            origin = aorigin;
            type = atype;
            manufacturer = amanufacturer;
            consumption = aconsumption;
            price = aprice;
            quality = aquality;
            acquisition = aacquistion;
            packformat = apackformat;
        }


    }
}
