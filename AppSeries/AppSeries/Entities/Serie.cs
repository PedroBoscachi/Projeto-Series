using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSeries.Enums;

namespace AppSeries.Entities
{
    class Serie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SeriesGenrer MovieGenrer { get; set; }
        public string Year { get; set; }

        public Serie(int id, string name, SeriesGenrer movieGenrer, string year)
        {
            Id = id;
            Name = name;
            MovieGenrer = movieGenrer;
            Year = year;
        }
    }
}
