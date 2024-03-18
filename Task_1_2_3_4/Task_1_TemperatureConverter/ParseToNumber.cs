namespace Task_1_TemperatureConverter
{
    static class ParseToNumber
    {
        public static int TryParseToNumber(this string value)
        {
            int result = 0;
            if(!int.TryParse(value, out result))
                throw new ArgumentException("Input only numeric value!");
            return result;
        }
    }
}
