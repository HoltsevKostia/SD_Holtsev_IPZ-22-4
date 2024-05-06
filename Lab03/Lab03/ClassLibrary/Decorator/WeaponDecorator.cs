using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Decorator
{
    public class WeaponDecorator : InventoryDecorator
    {
        private int _weaponAttack = 5;

        public WeaponDecorator(IHero hero) : base(hero)
        {
            _hero.Attack += _weaponAttack;
        }

        public override void DisplayInfo()
        {            
            base.DisplayInfo();
        }
    }
}
