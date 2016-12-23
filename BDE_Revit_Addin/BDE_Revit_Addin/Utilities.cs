namespace BDE
{
    public static class Utilities
    {
        /// <summary>
        /// Converts feet to Meters
        /// </summary>
        /// <param name="ftValue"></param>
        /// <returns></returns>
        public static double feetToMeters(double ftValue)
        {
            return ftValue * Constants._feetToMeters;
        }

        /// <summary>
        /// Converts Meters to degrees
        /// 1.11 meters approximately equal to decimal degrees 0.00001 
        /// 0.111 meters approximately equal to decimal degrees 0.000001
        /// </summary>
        /// <param name="ftValue"></param>
        /// <returns></returns>
        public static double MeterToDecimalDegress(double meter)
        {
            return meter * Constants._fifthDecimalPlaces;
        }
    }
}
