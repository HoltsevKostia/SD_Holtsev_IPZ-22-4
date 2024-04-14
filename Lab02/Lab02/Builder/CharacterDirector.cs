using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CharacterDirector
    {
        public Character Construct(ICharacterBuilder builder)
        {
            return builder
                .SetName("Default Name")
                .SetHeight(180)
                .SetBuild("Average")
                .SetHairColor("Brown")
                .SetEyeColor("Blue")
                .SetClothing("Casual")
                .AddToInventory("Sword")
                .AddToInventory("Shield")
                .Build();
        }
    }
}
