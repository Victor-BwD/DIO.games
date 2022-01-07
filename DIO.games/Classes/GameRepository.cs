using System;
using System.Collections.Generic;
using System.Text;
using DIO.games.Interfaces;

namespace DIO.games
{
    class GameRepository : iRepository<Games> // it will replace the T in iRepository with Games.
    {
        private List<Games> listGames = new List<Games>();

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Games entity)
        {
            throw new NotImplementedException();
        }

        public List<Games> Lista()
        {
            throw new NotImplementedException();
        }

        public int NextId()
        {
            throw new NotImplementedException();
        }

        public Games ReturnById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Games entity)
        {
            throw new NotImplementedException();
        }
    }
}
