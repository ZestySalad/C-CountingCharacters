using System;

namespace Counting 
{  class Program {
        static void Main(string[] args)
{
            string phrase = "C# is amazing!";
            
            int result1 = phrase.Length - phrase.Replace("C", "").Length;
            
            int result2 = phrase.Split('C').Length - 1;
            int result3 = phrase.ToCharArray().Count(c => c == 'C');
            
            
            
              Console.WriteLine( phrase.Length);
              Console.ReadLine();

}
}
}