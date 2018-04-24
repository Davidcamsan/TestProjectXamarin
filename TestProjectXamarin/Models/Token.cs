﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TestProjectXamarin.Models
{
    public class Token
    {
        public Token()
        {
        }
        [PrimaryKey]
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DateTime expire_date { get; set; }


    }
}
