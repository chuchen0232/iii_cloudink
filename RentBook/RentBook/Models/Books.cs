﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentBook.Models
{
    public class Books
    {
        public int b_id { get; set; }
        public string b_Name { get; set; }
        public string b_Info { get; set; }
        public string b_Image { get; set; }
        public string b_Type { get; set; }
        public DateTime b_PublishedDate { get; set; }
        public int b_HourPrice { get; set; }
        public string b_ISBN { get; set; }
        public int b_AgeRating { get; set; }
        public int p_id { get; set; }

    }
}