﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDatabase
{
   public class Genre
    {
       public Genre(string name)
       {
           Name = name;
       }
        public string  Name { get; set; }
        public int Id { get; set; }
    }
}
