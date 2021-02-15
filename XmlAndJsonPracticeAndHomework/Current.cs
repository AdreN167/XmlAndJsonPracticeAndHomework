namespace XmlAndJsonPracticeAndHomework
{
    public class Current
    {
        public string ObservationTime { get; set; }
        public int Temperature { get; set; }
        public int WeatherCode { get; set; }
        public string[] WeatherIcons { get; set; }
        public string[] WeatherDescriptions { get; set; }
        public int WindSpeed { get; set; }
        public int WindDegree { get; set; }
        public Direction WindDir { get; set; }
        public int Pressure { get; set; }
        public int Precipe { get; set; }
        public int Humidity { get; set; }
        public int Cloudcover { get; set; }
        public int Feelslike { get; set; }
        public int UvIndex { get; set; }
        public int Visibility { get; set; }
        public bool IsDay { get; set; }

    }
}