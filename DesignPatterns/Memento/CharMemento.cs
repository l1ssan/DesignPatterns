

namespace DesignPatterns.Memento
{
    public class CharMemento
    {
        public int Id { get; set; }

        public double Xcor { get; set; }


        public byte HP { get; set; }
        public byte MP { get; set; }

        public byte Stamina { get; set; }

        public CharMemento(int id, double xcor, byte hp, byte mp, byte stamina)
        {
            Id = id;
            Xcor = xcor;
            HP = hp;
            MP = mp;
            Stamina = stamina;
        }
        
    }

}
