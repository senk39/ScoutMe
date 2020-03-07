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

                    //1
                    new IdolCharacter
                    {                     
                        NameEng = "Chika",
                        NameJp = "千歌",
                        SurnameEng = "Takami",
                        SurnameJp = "高海",
                        NameDefault = "Chika Takami",
                        Birthday = new DateTime(1970, 8, 1),
                        Group = "Aqours",
                        Subunit = "Cyaron",
                        YearOfSchoool = 2,
                        Height = 157,
                        BustSize = 82,
                        WaistSize = 59,
                        HipsSize = 83,
                        SeiyuuEng = "Inami Anju",
                        SeiyuuJp = "伊波杏樹",
                        Description = "",
                        Color = "orange",
                    },

                    //2
                    new IdolCharacter
                    {                     
                        NameEng = "Kanan",
                        NameJp = "果南",
                        SurnameEng = "Matsuura",
                        SurnameJp = "松浦",
                        NameDefault = "Kanan Matsuura",
                        Birthday = new DateTime(1970, 2, 10),
                        //tu koniec
                        Group = "Aqours",
                        Subunit = "Azalea",
                        YearOfSchoool = 3,
                        Height = 162,
                        BustSize = 83,
                        WaistSize = 58,
                        HipsSize = 84,
                        SeiyuuEng = "Suwa Nanaka",
                        SeiyuuJp = "諏訪ななか",
                        Description = "",
                        Color = "green",                                             
                    },

                    //3
                    new IdolCharacter
                    {                     
                        NameEng = "Dia",
                        NameJp = "ダイヤ",
                        SurnameEng = "Kurosawa",
                        SurnameJp = "黒澤",
                        NameDefault = "Dia Kurosawa",
                        Birthday = new DateTime(1970, 1, 1),
                        Group = "Aqours",
                        Subunit = "Azalea",
                        YearOfSchoool = 3,
                        Height = 162,
                        BustSize = 80,
                        WaistSize = 57,
                        HipsSize = 80,
                        SeiyuuEng = "Komiya Arisa",
                        SeiyuuJp = "小宮有紗",
                        Description = "",
                        Color = "red",
                    },

                    //4
                    new IdolCharacter
                    {                     
                        NameEng = "Mari",
                        NameJp = "鞠莉",
                        SurnameEng = "Ohara",
                        SurnameJp = "小原",
                        NameDefault = "Mari Ohara",
                        Birthday = new DateTime(1970, 6, 13),
                        Group = "Aqours",
                        Subunit = "Guilty Kiss",
                        YearOfSchoool = 3,
                        Height = 163,
                        BustSize = 87,
                        WaistSize = 60,
                        HipsSize = 84,
                        SeiyuuEng = "Suzuki Aina",
                        SeiyuuJp = "鈴木愛奈",
                        Description = "",
                        Color = "purple",
                    },

                    //5
                    new IdolCharacter
                    {                     
                        NameEng = "Riko",
                        NameJp = "梨子",
                        SurnameEng = "Sakurauchi",
                        SurnameJp = "桜内",
                        NameDefault = "Riko Sakurauchi",
                        Birthday = new DateTime(1970, 9, 19),
                        Group = "Aqours",
                        Subunit = "Guilty Kiss",
                        YearOfSchoool = 2,
                        Height = 160,
                        BustSize = 80,
                        WaistSize = 58,
                        HipsSize = 82,
                        SeiyuuEng = "Aida Rikako",
                        SeiyuuJp = "逢田梨香子",
                        Description = "",
                        Color = "light pink",
                    },

                    //6 - STARTUJ TUTAJ
                    new IdolCharacter
                    {                     
                        NameEng = "Ruby",
                        NameJp = "ルビィ",
                        SurnameEng = "Kurosawa",
                        SurnameJp = "黒澤",
                        NameDefault = "Ruby Kurosawa",
                        Birthday = new DateTime(1970, 9, 21),
                        Group = "Aqours",
                        Subunit = "Cyaron",
                        YearOfSchoool = 1,
                        Height = 154,
                        BustSize = 76,
                        WaistSize = 56,
                        HipsSize = 79,
                        SeiyuuEng = "Furihata Ai",
                        SeiyuuJp = "降幡愛",
                        Description = "",
                        Color = "magenta",
                    },

                    //7
                    new IdolCharacter
                    {                     
                        NameEng = "Hanamaru",
                        NameJp = "花丸",
                        SurnameEng = "Kunikida",
                        SurnameJp = "国木田",
                        NameDefault = "Hanamaru Kunikida",
                        Birthday = new DateTime(1970, 3, 4),
                        Group = "Aqours",
                        Subunit = "Azalea",
                        YearOfSchoool = 1,
                        Height = 152,
                        BustSize = 83,
                        WaistSize = 57,
                        HipsSize = 83,
                        SeiyuuEng = "Takatsuki Kanako",
                        SeiyuuJp = "高槻かなこ",
                        Description = "",
                        Color = "yellow",
                    },

                    //8
                    new IdolCharacter
                    {                     
                        NameEng = "Yoshiko",
                        NameJp = "善子",
                        SurnameEng = "Tsushima",
                        SurnameJp = "津島",
                        NameDefault = "Yoshiko Tsushima",
                        Birthday = new DateTime(1970, 7, 13),
                        Group = "Aqours",
                        Subunit = "Guilty Kiss",
                        YearOfSchoool = 1,
                        Height = 156,
                        BustSize = 79,
                        WaistSize = 58,
                        HipsSize = 80,
                        SeiyuuEng = "Kobayashi Aika",
                        SeiyuuJp = "小林愛香",
                        Description = "",
                        Color = "gray",
                    },

                    //9
                    new IdolCharacter
                    {                     
                        NameEng = "You",
                        NameJp = "曜",
                        SurnameEng = "Watanabe",
                        SurnameJp = "渡辺",
                        NameDefault = "You Watanabe",
                        Birthday = new DateTime(1970, 4, 17),
                        Group = "Aqours",
                        Subunit = "Cyaron",
                        YearOfSchoool = 2,
                        Height = 157,
                        BustSize = 82,
                        WaistSize = 57,
                        HipsSize = 81,
                        SeiyuuEng = "Saitou Shuka",
                        SeiyuuJp = "斉藤朱夏",
                        Description = "",
                        Color = "blue",
                    },
                };
                context.IdolCharacters.AddRange(idolCharacters);
                context.SaveChanges();
            }
        }       
    }
}