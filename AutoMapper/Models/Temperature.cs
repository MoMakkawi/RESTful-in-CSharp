﻿namespace AutoMapper.Models
{
    public class Temperature
    {
        public int Id { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
