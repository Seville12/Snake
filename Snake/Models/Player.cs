﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class Player
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
