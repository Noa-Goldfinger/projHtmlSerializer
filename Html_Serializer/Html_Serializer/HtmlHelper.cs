﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Html_Serializer
{
    internal class HtmlHelper
    {
        private readonly static HtmlHelper _instance = new HtmlHelper();
        public static HtmlHelper Instance=>_instance;    
        public string[] AllTags { get; set; }
        public string[] SelfClosingTags { get; set; }
        private HtmlHelper()
        {
            AllTags = LoadTagsFromFile("seed/HtmlTags.json");
            SelfClosingTags = LoadTagsFromFile("seed/HtmlVoidTags.json");
        }
        private string[] LoadTagsFromFile(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<string[]>(jsonString);
        }


    }
}
