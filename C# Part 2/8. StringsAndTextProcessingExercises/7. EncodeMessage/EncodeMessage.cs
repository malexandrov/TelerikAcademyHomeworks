using System;
using System.Text;

class EncodeMessage
{
    static void Main()
    {
        string message = "An extremely smart message to encrypt.";
        string key = "123456";
        Console.WriteLine( Encode(message, key) ); 
        Console.WriteLine( Decode(Encode(message, key),key) );
    }

    static string Encode(string message, string key)
    {
        StringBuilder encodedMessage= new StringBuilder();
        for (int i = 0; i < message.Length; i++)
        {
            encodedMessage.Append((char)(message[i] ^ key[i % key.Length]));
        }
       return encodedMessage.ToString();
    }

    static string Decode(string message, string key)
    {
       return Encode(message, key);
    }
}