using System;

namespace Lab2Lib
{
    public class Contract
    {
        public Contract(Groom groom, Bride bride, DateTime date)
        {
            Groom = groom;
            Bride = bride;
            Date = date;
        }

        public Groom Groom { get; }
        public Bride Bride { get; }
        public DateTime Date { get; }
    }
}