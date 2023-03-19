// Amin Ahmadkhah       
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digidata.Operation
{
    public class DigikalaOperation
    {
        List<dataset> digikalas;

        public DigikalaOperation(List<dataset> digikaklas)
        {
            this.digikalas = digikaklas;
        }

        private List<int> AllSalesByYear(int year)
        {
            return digikalas.
             Where(x => x.DateTime_CartFinalize.Year == year)
             .Select(x => x.Amount_Gross_Order)
             .ToList();
        }
        public long SumSalesByYear(int year)
        {
            List<int> sales = AllSalesByYear(year);
            long total = 0;
            foreach(int sale in sales)
            {
                total += sale;
            }
            return total;
        }
        private List<int> AllSalesByCity(string city)
        {
            return digikalas.
                Where(x=>x.city_name_fa==city)
                .Select(x=>x.Amount_Gross_Order).ToList();
        }
        public long SumSalesByCity(string city)
        {
            List<int > sales =AllSalesByCity(city);
            long total = 0;

            foreach (int sale in sales)
            {
                total += sale;
            }
            return total;
        }
        private List<int> AllSalesByItem(int item)
        {
            return digikalas
                .Where(x => x.ID_Item == item)
                .Select(x => x.Amount_Gross_Order)
                .ToList();
        }
        public long SumSalesByItem (int item)
        {
            List<int> sales = AllSalesByItem(item);
            long total = 0;
            foreach (int sale in sales)
            {
                total+= sale;
            }
            return total;
        }
    }
}
