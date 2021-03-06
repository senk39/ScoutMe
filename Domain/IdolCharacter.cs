using System;

namespace Domain
{
    public class IdolCharacter
    {
        public Guid Id {get; set;}
        public string NameDefault { get; set; }
        public string NameEng { get; set; }
        public string NameJp { get; set; }
        public string SurnameEng { get; set; } 
        public string SurnameJp { get; set; }
        public DateTime ? Birthday { get; set; }      
        public string Group { get; set; }
        public string Subunit { get; set; }
        public int ? YearOfSchoool { get; set; }
        public int ? Height { get; set; }  
        public int ? BustSize { get; set; }
        public int ?  WaistSize { get; set; }
        public int ?  HipsSize { get; set; }
        public string SeiyuuEng { get; set; }
        public string SeiyuuJp { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }      
    }
}