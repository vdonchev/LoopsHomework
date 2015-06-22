using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode; // set encoding to utf8

        for (int card = 2; card <= 14; card++)
        {
            for (int type = 3; type < 7; type++)
            {
                switch (card)
                {
                    case 11:
                        Console.Write("{0,2}{1} ", 'J', (char)type);
                        break;
                    case 12:
                        Console.Write("{0,2}{1} ", 'Q', (char)type);
                        break;
                    case 13:
                        Console.Write("{0,2}{1} ", 'K', (char)type);
                        break;
                    case 14:
                        Console.Write("{0,2}{1} ", 'A', (char)type);
                        break;
                    default:
                        Console.Write("{0,2}{1} ", card, (char)type);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}