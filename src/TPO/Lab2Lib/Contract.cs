using System;

namespace Lab2Lib
{
    public class Contract
    {
        public Contract(Groom groom, Bride bride, DateTime date)
        {
            if (groom == null)
                throw new ArgumentException("Groom is null");
            if (bride == null)
                throw new ArgumentException("Bride is null");
            Groom = groom;
            Bride = bride;
            Date = date;
            Groom.Bride = bride;
        }

        public Groom Groom { get; }
        public Bride Bride { get; }
        public DateTime Date { get; }
    }
}