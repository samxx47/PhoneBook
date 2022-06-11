using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PhoneBook.Models
{
    public class Post
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; } 
        public string Name { get; set; }   
        public string PhoneNumber { get; set; }
    }
}
