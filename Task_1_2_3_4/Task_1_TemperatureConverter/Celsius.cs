namespace Task_1_TemperatureConverter
{
    public class Celsius
    {
        public double Degree { get; }

        public Celsius(double degree)
        {
            Degree = degree;
        }
        
        public static implicit operator Kelvin(Celsius celsius)
        {
            //0 Celcius = 273 Kelvin
            double kelvinDegree = celsius.Degree + 273;
            return new Kelvin(kelvinDegree);
        }
    }
}