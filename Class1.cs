//Amin Ahmadkhah

namespace lockkeyboardandcalculatenum
{
    public class LockKeyboard
    { 
        string s;
        ConsoleKeyInfo digit;
        public string locknum()
        {
            do
            {
                digit = Console.ReadKey(true);

            } while (!Char.IsDigit(digit.KeyChar) && digit.Key.ToString() != "Enter");

            return digit.KeyChar.ToString();
        }
        //public int Calculatenum(int number)
        //{
        //    if (digit.Key.ToString() != "Enter")
        //    {
        //        number = number * 10 + Convert.ToInt32(digit.KeyChar.ToString());
        //    }
        //    return number;
        //}
        public string continuewithlock()
        {
           

            Console.WriteLine("Do you want to continue ???(y/n)");
            do
            {
                s = Console.ReadKey(true).KeyChar.ToString();

            } while (s.ToLower() != "y" && s.ToLower() != "n");
            return s;
        }
    }
}
