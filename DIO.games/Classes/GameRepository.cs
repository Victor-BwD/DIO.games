using System;
using System.Collections.Generic;
using System.Text;
using DIO.games.Interfaces;

namespace DIO.games
{
    // Implementar uma classe para a interface iRepository
    // Class used in program.cs
    class GameRepository : iRepository<Games> // it will replace the T in iRepository with Games.
    {
        private List<Games> listGames = new List<Games>();

        public void Delete(int id)
        {
            listGames[id].Exclude();
        }

        public void Insert(Games obj)
        {
            listGames.Add(obj);
        }

        public List<Games> Lista()
        {
            return listGames;
        }

        public int NextId()
        {
            return listGames.Count;
        }

        public Games ReturnById(int id)
        {
            return listGames[id];
        }

        public void Update(int id, Games obj)
        {
            listGames[id] = obj;
        }
    }
}
