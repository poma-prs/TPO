namespace Lab2Lib
{
    public interface IBride
    {
        void Listen(string phrase);
    }

    public class Bride : Person, IBride
    {
        public Bride(string name, int age) : base(name, age)
        {
        }

        public void Listen(string phrase)
        {
            switch (phrase)
            {
                case "I love you!":
                    Mood += 50;
                    break;
                case "You look nice!":
                    Mood += 10;
                    break;
                case "Oh! You look bad...":
                    Mood -= 100;
                    break;
                case "Let's get married!":
                    Mood += Mood > 0 ? 100500 : -100;
                    break;
            }
        }
    }
}