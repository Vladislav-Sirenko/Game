using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IGameService
    {
        IEnumerable<GameDTO> GetGames();
        void CreateGame(GameDTO testDTO);
        void EditGame(GameDTO testDTO);
        GameDTO GetGame(int? id);
        void DeleteGame(int? id);
        void Dispose();
    }
}
