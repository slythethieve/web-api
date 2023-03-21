using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {

        // Static mock character
        private static List<Character> characters = new List<Character>() {
            new Character(),
            new Character{ Id = 1, Name = "Douchebag"}
        };

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            // To fix possible argument null exception
            var character = characters.FirstOrDefault(c => c.Id == id);
            if (character is not null)
                return character;
            throw  new Exception("Character not found");
        }
    }
}