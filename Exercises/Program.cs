// #####
// ####
// ###
// ##
// #

// key: # is the same as 6 - row

for (int row = 1; row <= 5; row++)
{
    for (int col = 1; col <= 6 - row; col++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}

Console.ReadKey();
