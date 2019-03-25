using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    /// <summary>
    /// Персонаж
    /// </summary>
    public class DPlayer
    {
        /// <summary>
        /// Идентификатор персонажа
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя персонажа
        /// </summary>
        public string Name { get; set; }
         /// <summary>
        /// Описание персонажа
        /// </summary>
        public string Description { get; set; }
    }
}
