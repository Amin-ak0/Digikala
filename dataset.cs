//Amin Ahmadkhah

using Microsoft.VisualBasic;

namespace digidata
{
    public class dataset
    {
        public int ID_Order { get; set; }
        public int ID_Customer { get; set; }
        public int ID_Item { get; set; }
        public DateTime DateTime_CartFinalize { get; set; }
        public int Amount_Gross_Order { get; set; }
        public string city_name_fa { get; set; }
        public int Quantity_item { get; set; }
    }
}
