using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BAL.Models;
using DAL.Models;
using DAL.Services;
using Mapster;

namespace BAL.Services.Implementation
{
    internal class PlayerBalService : IPlayerBalService
    {
        private readonly IPlayerDalService playerService;
        public PlayerBalService(IPlayerDalService playerService)
        {
            this.playerService = playerService;
        }
               
        public Task DeletePlayerAsync(int id)
        {
            return this.playerService.DeletePlayer(id);
        }
          
        public async Task<BPlayer> GetDetails(int id)
        {
            var playerD = await this.playerService.GetDetails(id);
            return playerD.Adapt<BPlayer>();
        }

        public async Task<IList<BPlayer>> GetPlayers(string Name)
        {
            var playerD = await this.playerService.GetPlayers(Name);
            var players = new List<BPlayer>();
            foreach (var el in playerD)
            {
                var player = el.Adapt<BPlayer>();
                players.Add(player);
            }
            return players;
        }

        public async Task CreatePlayer(BPlayer player)
        {
            var playerD = player.Adapt<DPlayer>();
            await this.playerService.CreatePlayer(playerD);

        }

        public async Task EditPlayer(BPlayer player)
        {
            var playerD = player.Adapt<DPlayer>();
            await this.playerService.EditPlayer(playerD);
        }
    }
}

