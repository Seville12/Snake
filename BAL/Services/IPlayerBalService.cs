using BAL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    /// <summary>
    /// Интерфейс персонажа
    /// </summary>
    public interface IPlayerBalService
    {
        /// <summary>
        /// Получение списка персонажей
        /// </summary>
        /// <param name="Name">Имя персонажа</param>
        Task<IList<BPlayer>> GetPlayers(string Name);
        /// <summary>
        /// Получение описания персонажа по ID
        /// </summary>
        /// <param name="id">ID Персонажа</param>
        Task<BPlayer> GetDetails(int id);
        /// <summary>
        /// Создание персонажа / редактирование персонажа
        /// </summary>
        /// <param name="player">Персонаж</param>
        Task CreatePlayer(BPlayer player);
        /// <summary>
        /// Редактирование персонажа
        /// </summary>
        Task EditPlayer(BPlayer player);
        /// <summary>
        /// Удаление персонажа
        /// </summary>
        /// <param name="id">Id персонажа</param>
        Task DeletePlayerAsync(int id);
    }
}
