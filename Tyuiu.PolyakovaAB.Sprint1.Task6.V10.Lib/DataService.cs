using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PolyakovaAB.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string f, k;
            string d = "";
            string[] b = value.Split(' ');
            for (int i = 0; i < b.Length; i++)
            {
                f = b[i];
                if (f.Length % 2 != 0 && f.Length > 1)
                {
                    k = f.Remove(f.Length / 2, 1);
                }
                else
                {
                    k = f;
                }
                if (d.Length > 0)
                {
                    d += ' ';
                }
                d += k;
            }
            return d;
        }
    }
}
