using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] moves = new string[32];
        bool movesAreDone = false;
        int iterator = 0;
        int nbreSuiteDePas = 0;
        string nbreSuitePasString;


        while (!movesAreDone && iterator < moves.Length)
        {
            Console.WriteLine("Quel est le pas suivant ? ");
            moves[iterator] = Console.ReadLine();
            if (moves[iterator] == "done")
            {
                movesAreDone = true;
                Console.WriteLine("Vous avez fini la suite de pas.");

            }
            else
            {
                iterator = iterator + 1;
            }
        }
        Console.WriteLine("Combien de fois, vous souhaitez répéter la suite de pas ? ");

        nbreSuitePasString = Console.ReadLine();
        nbreSuiteDePas = Convert.ToInt32(nbreSuitePasString);

        for (int i = 0; i < nbreSuiteDePas; i++)
        {
            for (int j = 0; j < iterator; j++)
            {
                {
                    Console.WriteLine("Pas : " +moves[j]);
                                    }
            }
        }
    }
}
