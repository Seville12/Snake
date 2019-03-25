using Snake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake.Services
{
    /// <summary>
    /// Интерфейс персонажа
    /// </summary>
    public interface IPlayerService
    {
        /// <summary>
        /// Получение списка персонажей
        /// </summary>
        /// <param name="Name">Имя персонажа</param>
        Task<IEnumerable<Player>> GetPlayers(string Name);
        /// <summary>
        /// Получение описания персонажа по ID
        /// </summary>
        /// <param name="id">ID Персонажа</param>
        Task<Player> GetDetails(int id);
        /// <summary>
        /// Создание персонажа
        /// </summary>
        /// <param name="player">Персонаж</param>
        Task<int> CreatePlayer(Player player, string operation);
        /// <summary>
        /// Редактирование персонажа
        /// </summary>
        //Task<int> EditPlayer(Player player);
        /// <summary>
        /// Удаление персонажа
        /// </summary>
        /// <param name="id">Id персонажа</param>
        Task DeletePlayerAsync(int id);
    }
}
