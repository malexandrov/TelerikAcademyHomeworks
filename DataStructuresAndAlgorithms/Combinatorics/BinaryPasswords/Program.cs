namespace BinaryPasswords
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string template = Console.ReadLine();

            long asteriks = 0;
            for (int i = 0; i < template.Length; i++)
            {
                if (template[i] == '*')
	            {
                    asteriks++;
	            }
            }

            long answer = 1;
            for (int i = 1; i <= asteriks; i++)
            {
                answer *= 2;
            }

            Console.WriteLine(answer);
        }
    }
}
