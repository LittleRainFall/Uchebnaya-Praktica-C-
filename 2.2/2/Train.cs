namespace ConsoleApp3
{
    public class Train
    {
        public string NameOfPlace { get; set; }
        public int NumberOfTrain { get; set; }
        public string NumberOfDate { get; set; }

        public Train(string NameOfPlace, int numberOfTrain, string NumberOfDate)
        {
            this.NameOfPlace = NameOfPlace;
            this.NumberOfTrain = numberOfTrain;
            this.NumberOfDate = NumberOfDate;
        }

        public int GetNumber
        {
            get
            {
                return NumberOfTrain;
            }
        }


        public string ShowTrain()
        {
            return ($"Пункт назначения: {NameOfPlace}\n" +
                    $"Номер поезда: {NumberOfTrain}\n" +
                    $"Дата отправления: {NumberOfDate}");


        }
    }
}