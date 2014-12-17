﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDWeatherUpdateApp
{
        public class JsonData
        {
            public string cod { get; set; }
            public float message { get; set; }
            public City city { get; set; }
            public int cnt { get; set; }
            public List[] list { get; set; }
        }

        public class City
        {
            public string id { get; set; }
            public string name { get; set; }
            public Coord coord { get; set; }
            public string country { get; set; }
            public int population { get; set; }
        }

        public class Coord
        {
            public float lon { get; set; }
            public float lat { get; set; }
        }

        public class List
        {
            public float dt { get; set; }
            public Temp temp { get; set; }
            public float pressure { get; set; }
            public int humidity { get; set; }
            public Weather[] weather { get; set; }
            public float speed { get; set; }
            public int deg { get; set; }
            public int clouds { get; set; }
            public float rain { get; set; }
        }

        public class Temp
        {
            public float day { get; set; }
            public float min { get; set; }
            public float max { get; set; }
            public float night { get; set; }
            public float eve { get; set; }
            public float morn { get; set; }
        }

        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

    
}
