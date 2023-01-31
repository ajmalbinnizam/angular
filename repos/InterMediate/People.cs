using System;

namespace InterMediate
{
    public class People 
    {
        public People(DateTime birthdate)
        {
            this.birthdate = birthdate; 
        }
        public int Id { get; set; }
        public DateTime birthdate { get; private set; }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
