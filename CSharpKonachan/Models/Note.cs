﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKonachan.Models
{
    public class Note
    {
        public int id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public int creator_id { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool is_active { get; set; }
        public int post_id { get; set; }
        public string body { get; set; }
        public int version { get; set; }
    }
}
