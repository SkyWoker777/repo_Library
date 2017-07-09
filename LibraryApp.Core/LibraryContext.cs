﻿using LibraryApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Core
{
    class LibraryContext
    {
        public IList<Book> Books { get; set; }

        public LibraryContext()
        {
            Initialize();
        }

        private void Initialize()
        {
            Books = new List<Book>
            {
                new Book(){ ID = 1, Name = "Крылья Феникса", Author = "Жданова Светлана", Year = 2009 },
                new Book(){ ID = 2, Name = "Метро 2033", Author = "Глуховский Д.А.", Year = 2007 },
                new Book(){ ID = 3, Name = "Застава", Author = "Лукьяненко Сергей", Year = 2001 },
                new Book(){ ID = 4, Name = "Сделка с дьяволом", Author = "Андерсон Эвангелина", Year = 2005 },
                new Book(){ ID = 5, Name = "Голодные игры", Author = "Коллинз Сьюзен", Year = 2010 },
            };
        }
    }
}