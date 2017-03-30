

namespace DesignPatterns.Abstract_Factory
{
   public abstract class PlayerFactory
   {
       public abstract Weapon CreateWeapon();
       public abstract Movement CreateMovement();
   }

}
