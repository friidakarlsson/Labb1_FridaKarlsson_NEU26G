
Console.WriteLine("Mata in text: ");
string input = Console.ReadLine();

long totalSumma = 0;

Console.WriteLine();

for (int i = 0; i < input.Length; i++)
{
    if (char.IsDigit(input[i]))
    {
        char startSiffra = input[i];
        int startPosition = i;

        for (int j = i + 1; j < input.Length; j++)
        {
            if (!char.IsDigit(input[j]))
            {
                break;
            }
            if (input[j]  == startSiffra)
            {
                int slutPosition = j;

                string delEtt = input.Substring(0, startPosition);
                string delTvaTalet = input.Substring(startPosition, slutPosition - startPosition + 1);
                string delTre = input.Substring(slutPosition + 1);

                FarglaggningAvHelaRaden(delEtt, delTvaTalet, delTre);

                totalSumma += Convert.ToInt64(delTvaTalet);
               
                break;
            }
        }

    }
}
    Console.WriteLine();
    Console.WriteLine($"Den totala summan är: {totalSumma}");


static void FarglaggningAvHelaRaden(string delEtt, string delTvaTalet, string delTre)
{
    Console.Write(delEtt);

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(delTvaTalet);

    Console.ResetColor();
    Console.WriteLine(delTre);
}
