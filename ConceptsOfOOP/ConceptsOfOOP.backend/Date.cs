namespace ConceptsOfOPP.Backend
{
    public class Date : Object
    {
        //create private attributes 
        private int _year;
        private int _month;
        private int _day;

        //create constructor for date
        public Date()
        {
            _year = 1900;
            _month = 1;
            _day = 1;
        }

        public Date(int year, int month, int day) //parameters
        {
            Year = year;
            Month = month;
            Day = day;
        }

        //create properties
        public int Year
        {
            get => _year;
            set => _year = ValidateYear(value); //connect private attributes to public properties through validation methods
        }

        public int Month
        {
            get => _month;
            set => _month = ValidateMonth(value);
        }

        public int Day
        {
            get => _day;
            set => _day = ValidateDay(value);
        }

        //overwrite ToString() method 
        public override string ToString()
        {
            return $"{Year:0000}/{Month:00}/{Day:00}";
        }

        //create private methods for date validations
        private int ValidateYear(int year)
        {
            if (year < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(year), "Year MUST be greater than 0.");
            }
            return year;
        }

        private int ValidateMonth(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month), "Month MUST be a number between 1 and 12.");
            }
            return month;
        }

        private int ValidateDay(int day)
        {
            if (day < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(day), "Day must be GREATER than 0.");
            }

            if (day == 29 && Month == 2 && IsLeapYear(Year))
            {
                return day;
            }

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (day > daysInMonth[Month - 1])
            {
                throw new ArgumentOutOfRangeException(nameof(day), $"Day must be BETWEEN 1 and {daysInMonth[Month - 1]} for month {Month}.");
            }
            return day;
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
