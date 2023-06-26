﻿namespace UC7.Models
{
    public class Player
    {
        public string Name { get; set; } = String.Empty;
        public int Age { get; set; }
        public int Experience { get; set; }
        public List<int> Skills { get; set; } = new List<int>();
    }

}
