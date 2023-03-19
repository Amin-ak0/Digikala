//Amin Ahmadkhah           Console.OutputEncoding = Encoding.UTF8;
using digidata;
using digidata.Operation;
using lockkeyboardandcalculatenum;

string address = @"F:\data set\orders.csv";
Digikaladata data = new Digikaladata(address);
DigikalaOperation op = new DigikalaOperation(data.digikalas);
LockKeyboard lk = new LockKeyboard();



    Console.WriteLine("-----------------------------------------!!welcome to the Digikala dataset!!-----------------------------------------");


do
{

    Console.WriteLine("1) If you want to see SumSalesByYear preess 1!!");
    Console.WriteLine("2) If you want to see SumSalesByCity preess 2!!");
    Console.WriteLine("3) If you want to see SumSalesByItem preess 3!!");
    Console.WriteLine("Pls enter your choice:");
    lk.locknum();
    string ch = Console.ReadLine();
    switch (ch.ToLower())
    {
        case "1":
            Console.WriteLine("which year do you want to see??");
            lk.locknum();
            ch = Console.ReadLine();
            switch (ch.ToLower())
            {
                case "2013":
                    Console.WriteLine(op.SumSalesByYear(2013));
                    break;
                case "2014":
                    Console.WriteLine(op.SumSalesByYear(2014));
                    break;
                case "2015":
                    Console.WriteLine(op.SumSalesByYear(2015));
                    break;
                case "2016":
                    Console.WriteLine(op.SumSalesByYear(2016));
                    break;
                case "2017":
                    Console.WriteLine(op.SumSalesByYear(2017));
                    break;
                case "2018":
                    Console.WriteLine(op.SumSalesByYear(2018));
                    break;
                default:
                    Console.WriteLine("Pls enter 2013 <= ch <= 2018 ");
                    break;
            }
            break;
        case "2":
            Console.WriteLine("which city do you want to see??");
            ch = Console.ReadLine();
            Console.WriteLine(op.SumSalesByCity(ch));
            break;
        case "3":
            Console.WriteLine("Pls enter your id item !!");
            lk.locknum();
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(op.SumSalesByItem(n));
            break;
        default:
            Console.WriteLine("Pls enter correct input!!");
            break;
    }

} while (lk.continuewithlock() == "y");

