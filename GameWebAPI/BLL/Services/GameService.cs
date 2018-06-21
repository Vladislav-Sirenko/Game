using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using DAL.UOF;

namespace BLL.Services
{
    public class GameService : IGameService
    {
        IUnitOfWork Database { get; set; }
        public GameService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void CreateGame(GameDTO gameDTO)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GameDTO, Game>()).CreateMapper();
            Game game = mapper.Map<GameDTO, Game>(gameDTO);
            Database.Games.Create(game);

        }

        public void DeleteGame(int? id)
        {
            Database.Games.Delete(id);
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public void EditGame(GameDTO testDTO)
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GameDTO, Game>()).CreateMapper();
            Game game = mapper.Map<GameDTO, Game>(testDTO);
            Database.Games.Update(game);
        }

        public GameDTO GetGame(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Не найден id игры");
            }
            Game game = Database.Games.Get(id.Value);
            var maper = new MapperConfiguration(cfg => cfg.CreateMap<Game, GameDTO>()).CreateMapper();
            GameDTO gameDTO = maper.Map<Game, GameDTO>(game);
            return (gameDTO);
        }

        public IEnumerable<GameDTO> GetGames()
        {
            IEnumerable<Game> games = Database.Games.GetAll();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Game, GameDTO>()).CreateMapper();
            var gamesDTO = mapper.Map<IEnumerable<Game>, IEnumerable<GameDTO>>(games);
            return gamesDTO;
        }
    }
}
