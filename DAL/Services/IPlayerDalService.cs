using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    /// <summary>
    /// реализовывает интерфейс персонажа
    /// </summary>
    public interface IPlayerDalService
    {
        /// <summary>
        /// Получение списка персонажей
        /// </summary>
        /// <param name="Name">Имя персонажа</param>
        Task<IList<DPlayer>> GetPlayers(string Name);
        /// <summary>
        /// Получение описания персонажа по ID
        /// </summary>
        /// <param name="id">ID Персонажа</param>
        Task<DPlayer> GetDetails(int id);
       /// <summary>
       /// Создание персонажа
       /// </summary>
       /// <param name="player">Персонаж</param>
        Task CreatePlayer(DPlayer player);
        /// <summary>
        /// Редактирование персонажа
        /// </summary>
        Task EditPlayer(DPlayer dPlayer);
        /// <summary>
        /// Удаление персонажа
        /// </summary>
        /// <param name="id">Id персонажа</param>
        Task DeletePlayer(int id);
    }
}
