using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Data;
using DAL.Models;
using DAL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Snake.Models;
using Snake.Services;

namespace Snake.Controllers
{
    [Authorize]
    public class PlayersController : Controller
    {
        private readonly IPlayerService _playerService;
        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        /// <summary>
        /// Список персонажей
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View( "Index", await this._playerService.GetPlayers(HttpContext.User.Identity.Name));
        }

        // GET: Players/Details/5
        /// <summary>
        /// Получение данных о персонаже
        /// </summary>
        /// <param name="id">Id Персонажа</param>
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _playerService.GetDetails((int) id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }


        // GET: Players/Create
        /// <summary>
        /// Получение старницы создания персонажа
        /// </summary>
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Создание нового пользователя и запись в БД
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Create(Player player)
        {
            if (ModelState.IsValid)
            {
                await _playerService.CreatePlayer(player);
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }

        
        // GET: Players/Edit/5
        /// <summary>
        /// Получение страницы редактирования персонажа
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _playerService.GetDetails((int)id);
            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }

        /// <summary>
        /// Редактирование данных персонажа
        /// </summary>
        /// <param name="id">Id Персонажа</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Edit(int id, Player player)
        {
            if (id != player.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _playerService.EditPlayer(player);
                return RedirectToAction(nameof(Index));
             }
            return View(player);
        }

        // GET: Players/Delete/5
        /// <summary>
        /// Получение страницы персонажа для удаления
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _playerService.GetDetails((int)id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: Players/Delete/5
        /// <summary>
        /// Удаление персонажа
        /// </summary>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _playerService.DeletePlayerAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //private bool PlayerExists(int id)
        //{
        //    return _context.DPlayer.Any(e => e.Id == id);
        //}
    }
}
