using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api.Models
{
    public class Character
    {
        public int Id { get; set; }

        // Either set a default value or put a question mark to make it nullable => string?
        public string Name { get; set; } = "Sly";
        public int HitPoints { get; set; } = 100;
        public int Attack { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        public CharacterClass Class { get; set; } = CharacterClass.Fighter;
    }
}