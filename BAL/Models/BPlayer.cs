using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Models
{
    /// <summary>
    /// Персонаж
    /// </summary>
    public class BPlayer
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
