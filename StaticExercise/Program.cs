namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine($"{32} F = {TempConverter.FahrenheitToCelsius(32)} C");
			Console.WriteLine($"{0} C = {TempConverter.CelsiusToFahrenheit(0)} F");
		}
    }

    public static class TempConverter
    {
		public static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double c)
        {
            return (c * 9) / 5 + 32;
        }
	}
}
