namespace Project_2.Airplane;

public class Airplane
{
    public static void type(string type)
    {
        if (type == "A359")
        {
            string[,] salon = new string[13, 60]
            {
                {
                    " ", "|", "58", "57", "56", "55", "54", "53", "52", "51", "50", "49", "48", "47", "46", "45", "44",
                    "43", "42", "41", " ", "39", "38", "37", "36", "35", "34", "33", "32", "31", "30", "29", "28", "27",
                    "26", "25", "24", " ", "22", "21", "20", "19", "18", "17", "16", "15", "14", "13", "12", "11", "10",
                    "09", "08", "07", "06", "05", "04", "03", "02", "01"
                },
                {
                    "A", "|", "1", "1", "2", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1",
                    "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"
                },
                {
                    "B", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1",
                    "1", "1", "1", "1", "1", "1", "2", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"
                },
                {
                    "C", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1",
                    "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"
                },
                {
                    " ", "|", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
                    "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
                    "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"
                },
                {
                    "D", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1",
                    "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"
                },
                {
                    "E", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1",
                    "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"
                },
                {
                    "F", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1",
                    "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"
                },
                {
                    "G", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1",
                    "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"
                },
                {
                    " ", "|", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
                    "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
                    "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"
                },
                {
                    "H", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1",
                    "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"
                },
                {
                    "J", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1",
                    "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"
                },
                {
                    "K", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "0", "1", "1",
                    "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"
                },

            };

            // for (int i = 0; i < salon.GetLength(1); i++)
            // {
            //     for (int j = 0; j < salon.GetLength(0); j++)
            //     {
            //         if (salon[j, i] == "1")
            //         {
            //             Console.Write(" ■  ");
            //         }
            //         else if (salon[j, i] == "0")
            //         {
            //             Console.Write("   ");
            //         }
            //         else if (salon[j, i] == "2")
            //         {
            //             Console.Write(" □  ");
            //         }
            //         else
            //         {
            //             Console.Write($" {salon[j, i]} ");
            //         }
            //
            //     }
            //
            //     Console.WriteLine();
            // }
            
            for (int i = 0; i < salon.GetLength(0); i++)
            {
                for (int j = 0; j < salon.GetLength(1); j++)
                {
                    if (salon[i, j] == "1")
                    {
                        Console.Write(" ■  ");
                    }
                    else if (salon[i, j] == "0")
                    {
                        Console.Write("   ");
                    }
                    else if (salon[i, j] == "2")
                    {
                        Console.Write(" □  ");
                    }
                    else
                    {
                        Console.Write($" {salon[i, j]} ");
                    }

                }

                Console.WriteLine();
            }
        }
        else if (type == "A319")
        {
            string[,] salon = new string[8, 35]
            {
                {
                    " ", "|", "33", "32", "31", "30", "29", "28", "27",
                    "26", "25", "24", "23", "22", "21", "20", "19", "18", "17", "16", " ", "14", "13", "12", "11", "10",
                    "09", "08", "07", "06", "05", "04", "03", "02", "01"
                },
                {
                    "A", "|", "1", "1", "2", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                {
                    "B", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                {
                    "C", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                {
                    " ", "|", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
                    "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {
                    "D", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                {
                    "E", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                {
                    "F", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},

            };
            
            for (int i = 0; i < salon.GetLength(0); i++)
            {
                for (int j = 0; j < salon.GetLength(1); j++)
                {
                    if (salon[i, j] == "1")
                    {
                        Console.Write(" ■  ");
                    }
                    else if (salon[i, j] == "0")
                    {
                        Console.Write("   ");
                    }
                    else if (salon[i, j] == "2")
                    {
                        Console.Write(" □  ");
                    }
                    else
                    {
                        Console.Write($" {salon[i, j]} ");
                    }

                }

                Console.WriteLine();
            }
        }
        
        else
        {
            string[,] salon = new string[8, 35]
            {
                {
                    " ", "|", "33", "32", "31", "30", "29", "28", "27",
                    "26", "25", "24", "23", "22", "21", "20", "19", "18", "17", "16", " ", "14", "13", "12", "11", "10",
                    "09", "08", "07", "06", "05", "04", "03", "02", "01"
                },
                {
                    "A", "|", "1", "1", "2", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                {
                    "B", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                {
                    "C", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                {
                    " ", "|", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0",
                    "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"},
                {
                    "D", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                {
                    "E", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},
                {
                    "F", "|", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1",
                    "0", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1", "1"},

            };
            
            for (int i = 0; i < salon.GetLength(0); i++)
            {
                for (int j = 0; j < salon.GetLength(1); j++)
                {
                    if (salon[i, j] == "1")
                    {
                        Console.Write(" ■  ");
                    }
                    else if (salon[i, j] == "0")
                    {
                        Console.Write("   ");
                    }
                    else if (salon[i, j] == "2")
                    {
                        Console.Write(" □  ");
                    }
                    else
                    {
                        Console.Write($" {salon[i, j]} ");
                    }

                }

                Console.WriteLine();
            }
        }
    }
}