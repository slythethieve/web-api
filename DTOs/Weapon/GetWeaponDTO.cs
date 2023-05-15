using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api.DTOs.Weapon
{
    public class GetWeaponDTO
    {
        public string Name { get; set; } = string.Empty;

        public int Damage { get; set; }

    }
}