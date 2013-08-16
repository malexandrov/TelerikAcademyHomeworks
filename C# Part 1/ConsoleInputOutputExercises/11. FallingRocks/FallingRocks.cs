using System;
using System.Collections.Generic;
using System.Threading;

struct Object
{
    public int x;
    public int y;
    public string form;
    public ConsoleColor color;
}

class FallingRocks
{
    static void DrawObject(int x, int y, string form, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(form);
    }
    
    static void DrawText(int x, int y, string text, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(text);
    }

    static void Main()
    {
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 41;

        Object dwarf = new Object();
        dwarf.form = "(O)";
        dwarf.x = Console.WindowWidth / 2 - dwarf.form.Length / 2;
        dwarf.y = Console.WindowHeight - 2;
        dwarf.color = ConsoleColor.White;

        int score = 0;
        Random randomGenerator = new Random();
        List<Object> rocks = new List<Object>();

        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }

                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + dwarf.form.Length < Console.WindowWidth)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }

            int rockDropPerCycle = randomGenerator.Next(0, 4);
            String[] forms = { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";"};
            string rockFormPerCycle = forms[randomGenerator.Next(0, forms.Length - 1)];
            List<Object> newRocks = new List<Object>();
            
            for (int i = 1; i <= rockDropPerCycle; i++)
            {
                Object newRock = new Object();
                newRock.x = randomGenerator.Next(0, Console.WindowWidth);
                newRock.y = 1;
                newRock.form = rockFormPerCycle;
                newRock.color = ConsoleColor.Yellow;
                rocks.Add(newRock);
            }
            
            for (int i = 0; i < rocks.Count; i++)
            {
                Object oldRockPossition = rocks[i];
                Object newRockPossition = new Object();
                newRockPossition.x = oldRockPossition.x;
                newRockPossition.y = oldRockPossition.y + 1;
                newRockPossition.color = oldRockPossition.color;
                newRockPossition.form = oldRockPossition.form;

                if (newRockPossition.y == dwarf.y && dwarf.x <= newRockPossition.x && newRockPossition.x <= (dwarf.x + dwarf.form.Length - 1))
                {
                    DrawText(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2 - 1, "GAME OVER ", ConsoleColor.DarkRed);
                    DrawText(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2, "Score: " + score, ConsoleColor.Green);
                    Console.ReadLine();
                    return;
                }
                if (newRockPossition.y < Console.WindowHeight)
                {
                    newRocks.Add(newRockPossition);
                }
                else score++;
            }
            rocks = newRocks;

            foreach (Object rock in rocks)
            {
                DrawObject(rock.x, rock.y, rock.form, rock.color);
            }

            DrawObject(dwarf.x, dwarf.y, dwarf.form, dwarf.color);

            DrawText(Console.WindowWidth / 2, 0, "Score:" + score, ConsoleColor.Green);
            Thread.Sleep(150);
            Console.Clear();
        }
    }
}


