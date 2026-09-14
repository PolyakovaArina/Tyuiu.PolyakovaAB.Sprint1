using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PolyakovaAB.Sprint1.Task1.V8.Lib
{
    public class DataService : ISprint1Task1V8
    {
        public double Calculate(double a, double x)
        {
            double Pi = Math.PI;
            return (x * Pi) / a;
        }
    }
}
