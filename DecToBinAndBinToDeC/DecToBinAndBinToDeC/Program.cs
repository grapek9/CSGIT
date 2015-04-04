using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBinAndBinToDeC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to simple conversion program , from Bin to Dec and backwards");
            String loopControl="nothing";
            int caseSwitch = 1;
            do{
                Console.WriteLine("Simple Menu");
                Console.WriteLine("1)Dec To Bin, 2)Bin To Dec, 3)Clean Screen ");
                caseSwitch = Int32.Parse(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        translation.DecToBin();
                        break;
                    case 2:
                        translation.BinToDec();
                        break;
                    case 3:
                        Console.Clear();
                        break;
                }
                Console.WriteLine("If you wish to exit program type exit");
                loopControl=Console.ReadLine();
            }while(String.Compare(loopControl,"exit",true)!=0);
        }
    }
}
