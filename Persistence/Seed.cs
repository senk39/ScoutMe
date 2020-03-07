using System.Collections.Generic;
using System.Linq;
using System;
using Domain;

namespace Persistence.Migrations
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.IdolCharacters.Any())
            {
                var idolCharacters = new List<IdolCharacter> 
                {
                    new IdolCharacter
                    {                     
                        NameEng = "Chika",
                        NameJp = "千歌",
                        SurnameEng = "Takami",
                        SurnameJp = "高海",
                        NameDefault = "Chika Takami",
                        Birthday = new DateTime(0, 8, 1),
                        Group = "Aqours",
                        Subunit = "Cyaron",
                        YearOfSchoool = 2,
                        BustSize = 82,
                        WaistSize = 59,
                        HipsSize = 83,
                        SeiyuuEng = "Inami Anju",
                        SeiyuuJp = "伊波杏樹",
                        Description = "",
                        Color = "orange",
                    },

                    new IdolCharacter
                    {                     
                        NameEng = "Kanan",
                        NameJp = "果南",
                        SurnameEng = "Matsuura",
                        SurnameJp = "松浦",
                        NameDefault = "Kanan Matsuura",
                        Birthday = new DateTime(0, 2, 10),
                        //tu koniec
                        Group = "Aqours",
                        Subunit = "Cyaron",
                        YearOfSchoool = 2,
                        BustSize = 82,
                        WaistSize = 59,
                        HipsSize = 83,
                        SeiyuuEng = "Inami Anju",
                        SeiyuuJp = "伊波杏樹",
                        Description = "",
                        Color = "orange",
                    },

                    new IdolCharacter
                    {                     
                        NameEng = "Chika",
                        NameJp = "千歌",
                        SurnameEng = "Takami",
                        SurnameJp = "高海",
                        NameDefault = "Chika Takami",
                        Birthday = new DateTime(0, 8, 1),
                        Group = "Aqours",
                        Subunit = "Cyaron",
                        YearOfSchoool = 2,
                        BustSize = 82,
                        WaistSize = 59,
                        HipsSize = 83,
                        SeiyuuEng = "Inami Anju",
                        SeiyuuJp = "伊波杏樹",
                        Description = "",
                        Color = "orange",
                    },

                    new IdolCharacter
                    {                     
                        NameEng = "Chika",
                        NameJp = "千歌",
                        SurnameEng = "Takami",
                        SurnameJp = "高海",
                        NameDefault = "Chika Takami",
                        Birthday = new DateTime(0, 8, 1),
                        Group = "Aqours",
                        Subunit = "Cyaron",
                        YearOfSchoool = 2,
                        BustSize = 82,
                        WaistSize = 59,
                        HipsSize = 83,
                        SeiyuuEng = "Inami Anju",
                        SeiyuuJp = "伊波杏樹",
                        Description = "",
                        Color = "orange",
                    },

                    new IdolCharacter
                    {                     
                        NameEng = "Chika",
                        NameJp = "千歌",
                        SurnameEng = "Takami",
                        SurnameJp = "高海",
                        NameDefault = "Chika Takami",
                        Birthday = new DateTime(0, 8, 1),
                        Group = "Aqours",
                        Subunit = "Cyaron",
                        YearOfSchoool = 2,
                        BustSize = 82,
                        WaistSize = 59,
                        HipsSize = 83,
                        SeiyuuEng = "Inami Anju",
                        SeiyuuJp = "伊波杏樹",
                        Description = "",
                        Color = "orange",
                    },



                };
            }
        }

        
    }
}