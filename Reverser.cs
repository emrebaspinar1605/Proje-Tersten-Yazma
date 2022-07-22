using System;

namespace ProjeTers
{
    public class Reverser
    {
        public void ReverseWord()
        {
            Console.WriteLine("Lütfen Bir Cümle giriniz :");
            string text = Console.ReadLine();
            if(text.Length>text.LastIndexOf(' '))
            {
                text+=" ";
            }
            int a = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    for (int k = i; k >= a; k--)
                    { 
                        Console.Write(text[k]);
                    }
                    a = i;
                }
            }
        }
    }
}