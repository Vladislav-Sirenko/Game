using AutoMapper;
using BLL;
using BLL.DTO;
using PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PL.Controllers
{
    public class GameController : ApiController
    {
        IGameService GameService;
        public GameController(IGameService Gameserv)
        {
            GameService = Gameserv;
        }
        // GET: api/Games
        public IEnumerable<GameViewModel> Get()
        {
            IEnumerable<GameDTO> gameDTO = GameService.GetGames();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GameDTO, GameViewModel>()).CreateMapper();
            IEnumerable<GameViewModel> gameView = mapper.Map<IEnumerable<GameDTO>, IEnumerable<GameViewModel>>(gameDTO);
            return gameView;
        }

        // GET: api/Game/5
        public HttpResponseMessage Get(HttpRequestMessage request, int? id)
        {
            if (id == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GameDTO, GameViewModel>()).CreateMapper();
            GameViewModel gameView = mapper.Map<GameDTO, GameViewModel>(GameService.GetGame(id));

            if (gameView == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            return request.CreateResponse(HttpStatusCode.OK, gameView);
        }

        // POST: api/Game
        public HttpResponseMessage Post([FromBody]GameViewModel gameView)
        {
            if (ModelState.IsValid)
            {
               var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GameViewModel, GameDTO>()).CreateMapper();
                GameDTO gameDTO = mapper.Map<GameViewModel, GameDTO>(gameView);
                GameService.EditGame(gameDTO);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return new HttpResponseMessage(HttpStatusCode.Conflict);
        // PUT: api/Game/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Game/5
        public HttpResponseMessage Delete(int? id)
        {
            if (id == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<GameDTO, GameViewModel>()).CreateMapper();
            GameViewModel gameView = mapper.Map<GameDTO, GameViewModel>(GameService.GetGame(id));

            if (gameView == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            else {
                GameService.DeleteGame(id);
                return new HttpResponseMessage(HttpStatusCode.OK);
                    }
        }
    }
}
