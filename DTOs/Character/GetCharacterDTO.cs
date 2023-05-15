using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.DTOs.Weapon;

namespace web_api.DTOs.Character
{
    public class GetCharacterDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = "Sly";
        public int HitPoints { get; set; } = 100;
        public int Attack { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        public CharacterClass Class { get; set; } = CharacterClass.Fighter;
        public GetWeaponDTO? Weapon { get; set; }
    }
}