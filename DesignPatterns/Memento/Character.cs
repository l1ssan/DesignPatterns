
using System;

namespace DesignPatterns.Memento
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Xcor { get; set; }


        public byte HP { get; set; }
        public byte MP { get; set; }

        public byte Stamina { get; set; }

        public Character()
        {
            Id = 1;
            Name = "DefaultNoob";
            Xcor = 0.0;
            HP = 100;
            MP = 100;
            Stamina = 100;

        }

        public void Run()
        {
            if (Stamina > 0)
            {
                Stamina--;
                Xcor += 2;
                Console.WriteLine("{0} is runing. Stamina {1}. Xcor {2}", Name, Stamina, Xcor);

            }
            else
            {

                Stamina++;
                Xcor += 1;
                Console.WriteLine("{0} now walking. Stamina {1}. Xcor {2}", Name, Stamina, Xcor);

            }


        }


        public void CastSpell(string spellname)
        {
            if (MP > 0)
            {
                MP--;
                Console.WriteLine("{0} is custing {1}. MP {2}", Name, spellname, MP);
            }
            else
                Console.WriteLine("{0} not enough MP for {1}", Name, spellname);
        }

        // сохранение состояния
        public CharMemento SaveState()
        {
            Console.WriteLine("Quicksave.  Xcor: {0} HP: {1} MP:{2} Stamina:{3}", Xcor, HP, MP, Stamina);
            return new CharMemento(Id, Xcor, HP, MP, Stamina);
        }

        // восстановление состояния
        public void RestoreState(CharMemento memento)
        {
            Id = memento.Id;
            Xcor = memento.Xcor;
            HP = memento.HP;
            MP = memento.MP;
            Stamina = memento.Stamina;

            Console.WriteLine("Load the game. Xcor: {0} HP: {1} MP:{2} Stamina:{3}", Xcor, HP, MP, Stamina);
        }



    }
}
