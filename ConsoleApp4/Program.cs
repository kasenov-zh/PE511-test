using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*char c1 = 'H';
      string s1 = "Hello";
      char[] c2 = { 'H', 'e', 'l', 'l', 'o' };
      byte[] b2 = Encoding.UTF8.GetBytes(s1);
      char[] c3 = Encoding.UTF8.GetChars(b2);
      c3[0] = 'A';*/
      // "(1.23 + (4.5 - 3.14)*2 + 10) / 3 + 7" - обработка с помощью
      //                                          польской обратной записи
      // "1 + 4 - 3 + 10"
      
      double q1 = (1.23 + (4.5 - 3.14) * 2 + 10) / 3 + 7;

      string s1 = "12 + 41 - 73 + 10";
      string[] s2 = s1.Split( new char[]{ '+','-'} );
      Console.WriteLine( String.Join(",", s2) );

      int[]data = new int[s2.Length];
      /*int i = 0;
      foreach( string s in s2 )
      {
        data[i++] = int.Parse( s );
      }*/

      for (int i = 0; i < s2.Length; i++)
      {
        data[i] = int.Parse( s2[i] );
      }
      foreach (int num in data )
      {
        Console.WriteLine( num );
      }
      int k = 1;
      int res = data[0];
      foreach( char c in s1 )
      {
        switch (c)
        {
          case '+':
            res = res + data[k];
            k++;
            break;
          case '-':
            res = res - data[k];
            k++;
            break;
        }
      }
      Console.WriteLine( $"Res = {res}" );
      Console.ReadLine();
    }
  }
}
