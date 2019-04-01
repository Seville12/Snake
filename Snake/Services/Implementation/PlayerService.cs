using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Models;
using BAL.Services;
using Mapster;
using Snake.Models;

namespace Snake.Services.Implementation
{
    internal class PlayerService : IPlayerService
    {
        private readonly IPlayerBalService playerService;
        public PlayerService(IPlayerBalService playerService)
        {
            this.playerService = playerService;
        }
        public async Task<int> CreatePlayer(Player player)
        {
            var playerV = player.Adapt<BPlayer>();
            await this.playerService.CreatePlayer(playerV);
            return playerV.Id;
        }

        public Task DeletePlayerAsync(int id)
        {
            return this.playerService.DeletePlayerAsync(id);
        }

        public async Task<int> EditPlayer(Player player)
        {
            var playerV = player.Adapt<BPlayer>();
            await this.playerService.CreatePlayer(playerV);
            return playerV.Id;
        }

        public async Task<Player> GetDetails(int id)
        {
            return (await this.playerService.GetDetails(id)).Adapt<Player>();
        }

        public async Task<IEnumerable<Player>> GetPlayers(string Name)
        {
            return (await this.playerService.GetPlayers(Name)).Adapt<IEnumerable<Player>>();
        }
    }
    
}

