﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDatabase
{
    public class Book
    {
        private IList<Publisher> publishers;

        public Book(string authorname,string title)
        {
            AuthorName = authorname;
            Title = title;
            publishers=new List<Publisher>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public virtual Genre Genre  { get; set; }

        public virtual IList<Publisher> Publishers
        {
            get { return publishers; }
            set { publishers = value;}
        }
    }

    
}
