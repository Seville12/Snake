using DAL.Data;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Services.Implementation
{
    internal class PlayerDalService :IPlayerDalService
    {
        private ApplicationDbContext _context;
        public PlayerDalService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<DPlayer>> GetPlayers(string Name)
        {
            return await _context.DPlayer.ToListAsync();
        }

        public async Task<DPlayer> GetDetails(int id)
        {
            var player =  _context.DPlayer
                .FirstOrDefaultAsync(m => m.Id == id);
            return await player;
        }

        public async Task CreatePlayer(DPlayer player)
        {
            _context.Add(player);
            await _context.SaveChangesAsync();
        }

        public async Task EditPlayer (DPlayer player)
        {
            _context.Update(player);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePlayer(int id)
        {
            var player = await _context.DPlayer.FindAsync(id);
            _context.DPlayer.Remove(player);
            await _context.SaveChangesAsync();
        }

    }
}
