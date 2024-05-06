using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Decorator
{
    public class ArmorDecorator : InventoryDecorator
    {
        private int _armorDefense = 3;

        public ArmorDecorator(IHero hero) : base(hero)
        {
            _hero.Defense += _armorDefense;
        }

        public override void DisplayInfo()
        {
            
            base.DisplayInfo();
        }
    }
}
