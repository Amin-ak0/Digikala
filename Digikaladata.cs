using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Amin Ahmadkhah

namespace digidata
{
    public class Digikaladata
    {

        public List<dataset> digikalas { get; }
        private dataset info;
        private string line;

        public Digikaladata(string address)
        {
            digikalas = new List<dataset>();
        
            using (StreamReader srreader = new StreamReader(address))
            {
                srreader.ReadLine();
                while (!srreader.EndOfStream)
                {
                    info = new dataset();
                    line = srreader.ReadLine();

                    info.ID_Order = Convert.ToInt32(line.Split(",")[0]);
                    info.ID_Customer = Convert.ToInt32(line.Split(",")[1]);
                    info.ID_Item = Convert.ToInt32(line.Split(",")[2]);
                    info.DateTime_CartFinalize = Convert.ToDateTime(line.Split(",")[3]);
                    info.Amount_Gross_Order = Convert.ToInt32(line.Split(",")[4].Replace(".0", ""));
                    info.city_name_fa = line.Split(",")[5];
                    info.Quantity_item = Convert.ToInt32(line.Split(",")[6].Replace(".0",""));

                    digikalas.Add(info);
                }
            }
        }
    }
}
