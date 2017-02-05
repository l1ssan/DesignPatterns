using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract_Factory
{
   public class Player
   {
       private Weapon weapon;
       private Movement movement;

       public Player(PlayerFactory factory)
       {
           weapon = factory.CreateWeapon();
           movement = factory.CreateMovement();
       }

       public void Run()
       {
          Console.WriteLine(movement.Move() + " moved");
       }
        public void Hit()
        {
            Console.WriteLine(weapon.Hit() + " point");
        }

    }
}
