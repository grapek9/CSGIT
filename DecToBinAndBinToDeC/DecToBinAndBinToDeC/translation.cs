using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBinAndBinToDeC
{
    class translation
    {
        public static void DecToBin()
        {
            int DecDigit = 0; String input;
            Console.WriteLine("Type Number you want to convert to Bin");
            input = Console.ReadLine();
            Int32.TryParse(input, out DecDigit);
            int[] array = new int[300];
            do{
                if (DecDigit % 2 == 0)
                {

                }
            }while(DecDigit>0);
            
        }
        public static void BinToDec()
        {

        }
        
    }
}
