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
                        Description = "jprdl mikaniara",
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
                        Description = "haguuu wyłaniam się spod wody niczym potwór z loch ness",
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
                        Description = "bu bu desu wa ta szkoła to strefa wolna od idolizacji",
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
                        Description = "jej stary to bill gates a jej stara to stomatolog w miliczu",
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
                        Description = "chopin z głową idolki i ciałem też idolki",
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
                        Description = "pigiiii idę po siostrę",
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
                        Description = "wpierdalam ci bułę zura",
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
                        Description = "piekielna kreatura",
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
                        Description = "jozoro sportowa baba",
                        Color = "blue",
                    },

                    //Muse1
                    new IdolCharacter
                    {                     
                        NameEng = "Honoka",
                        NameJp = "穂乃果",
                        SurnameEng = "Kosaka",
                        SurnameJp = "高坂",
                        NameDefault = "Honoka Kosaka",
                        Birthday = new DateTime(1970, 8, 3),
                        Group = "Muse",
                        Subunit = "Printemps",
                        YearOfSchoool = 2,
                        Height = 157,
                        BustSize = 78,
                        WaistSize = 58,
                        HipsSize = 82,
                        SeiyuuEng = "Nitta Emi",
                        SeiyuuJp = "新田恵海",
                        Description = "honk honk",
                        Color = "orange",
                    },

                    //Muse2
                    new IdolCharacter
                    {                     
                        NameEng = "Eli",
                        NameJp = "絵里",
                        SurnameEng = "Ayase",
                        SurnameJp = "絢瀬",
                        NameDefault = "Eli Ayase",
                        Birthday = new DateTime(1970, 10, 21),
                        Group = "Muse",
                        Subunit = "Bibi",
                        YearOfSchoool = 3,
                        Height = 162,
                        BustSize = 88,
                        WaistSize = 60,
                        HipsSize = 84,
                        SeiyuuEng = "Nanjou Yoshino",
                        SeiyuuJp = "南條愛乃",
                        Description = "totalitarna idolka xopowo",
                        Color = "ice-blue",
                    },

                    //Muse3
                    new IdolCharacter
                    {                     
                        NameEng = "Kotori",
                        NameJp = "ことり",
                        SurnameEng = "Minami",
                        SurnameJp = "南",
                        NameDefault = "Kotori Minami",
                        Birthday = new DateTime(1970, 9, 12),
                        Group = "Muse",
                        Subunit = "Printemps",
                        YearOfSchoool = 2,
                        Height = 159,
                        BustSize = 80,
                        WaistSize = 58,
                        HipsSize = 80,
                        SeiyuuEng = "Uchida Aya",
                        SeiyuuJp = "内田彩",
                        Description = "uwu meido",
                        Color = "gray",
                    },

                    //Muse4
                    new IdolCharacter
                    {                     
                        NameEng = "Umi",
                        NameJp = "海未",
                        SurnameEng = "Sonoda",
                        SurnameJp = "園田",
                        NameDefault = "Umi Sonoda",
                        Birthday = new DateTime(1970, 3, 15),
                        Group = "Muse",
                        Subunit = "lily white",
                        YearOfSchoool = 2,
                        Height = 159,
                        BustSize = 76,
                        WaistSize = 58,
                        HipsSize = 80,
                        SeiyuuEng = "Mimori Suzuko",
                        SeiyuuJp = "三森すずこ",
                        Description = "pan maruda niszczyciel dobrej zabawy pogromca uśmiechów dzieci",
                        Color = "deep blue",
                    },

                    //Muse5
                    new IdolCharacter
                    {                     
                        NameEng = "Rin",
                        NameJp = "凛",
                        SurnameEng = "Hoshizora",
                        SurnameJp = "星空",
                        NameDefault = "Rin Hoshizora",
                        Birthday = new DateTime(1970, 11, 1),
                        Group = "Muse",
                        Subunit = "lily white",
                        YearOfSchoool = 1,
                        Height = 155,
                        BustSize = 75,
                        WaistSize = 59,
                        HipsSize = 80,
                        SeiyuuEng = "Iida Riho",
                        SeiyuuJp = "飯田里穂",
                        Description = "nyaaa",
                        Color = "yellow",
                    },

                    //Muse6
                    new IdolCharacter
                    {                     
                        NameEng = "Maki",
                        NameJp = "真姫",
                        SurnameEng = "Nishikino",
                        SurnameJp = "西木野",
                        NameDefault = "Maki Nishikino",
                        Birthday = new DateTime(1970, 4, 19),
                        Group = "Muse",
                        Subunit = "Bibi",
                        YearOfSchoool = 1,
                        Height = 161,
                        BustSize = 78,
                        WaistSize = 56,
                        HipsSize = 83,
                        SeiyuuEng = "Saitou Shuka",
                        SeiyuuJp = "Pile (Hori Eriko)",
                        Description = "to nie tak że cię lubię baka",
                        Color = "red",
                    },

                    //Muse7
                    new IdolCharacter
                    {                     
                        NameEng = "Nozomi",
                        NameJp = "希",
                        SurnameEng = "Tojo",
                        SurnameJp = "東條",
                        NameDefault = "Nozomi Tojo",
                        Birthday = new DateTime(1970, 6, 9),
                        Group = "Muse",
                        Subunit = "lily white",
                        YearOfSchoool = 3,
                        Height = 159,
                        BustSize = 90,
                        WaistSize = 60,
                        HipsSize = 82,
                        SeiyuuEng = "Kusuda Aina",
                        SeiyuuJp = "楠田亜衣奈",
                        Description = "ara ara",
                        Color = "purple",
                    },

                    //Muse8
                    new IdolCharacter
                    {                     
                        NameEng = "Hanayo",
                        NameJp = "花陽",
                        SurnameEng = "Koizumi",
                        SurnameJp = "小泉",
                        NameDefault = "Hanayo Koizumi",
                        Birthday = new DateTime(1970, 1, 17),
                        Group = "Muse",
                        Subunit = "Printemps",
                        YearOfSchoool = 1,
                        Height = 156,
                        BustSize = 82,
                        WaistSize = 60,
                        HipsSize = 83,
                        SeiyuuEng = "Kubo Yurika",
                        SeiyuuJp = "久保ユリカ",
                        Description = "wincyj ryżu",
                        Color = "green",
                    },

                    //Muse9
                    new IdolCharacter
                    {                     
                        NameEng = "Nico",
                        NameJp = "にこ",
                        SurnameEng = "Yazawa",
                        SurnameJp = "矢澤",
                        NameDefault = "Nico Yazawa",
                        Birthday = new DateTime(1970, 7, 22),
                        Group = "Muse",
                        Subunit = "Bibi",
                        YearOfSchoool = 3,
                        Height = 154,
                        BustSize = 71,
                        WaistSize = 57,
                        HipsSize = 79,
                        SeiyuuEng = "Tokui Sora",
                        SeiyuuJp = "徳井青空",
                        Description = "raczek",
                        Color = "pink",
                    },

                    //Nijigasaki1
                    new IdolCharacter
                    {                     
                        NameEng = "Ayumu",
                        NameJp = "歩夢",
                        SurnameEng = "Uehara",
                        SurnameJp = "上原",
                        NameDefault = "Ayumu Uehara",
                        Birthday = new DateTime(1970, 3, 1),
                        Group = "Nijigasaki",
                        Subunit = "Azuna",
                        YearOfSchoool = 2,
                        Height = 159,
                        BustSize = 82,
                        WaistSize = 58,
                        HipsSize = 84,
                        SeiyuuEng = "Onishi Aguri",
                        SeiyuuJp = "大西亜玖璃",
                        Description = "co ja tu robie lol",
                        Color = "light pink",
                    },

                    //Nijigasaki2
                    new IdolCharacter
                    {                     
                        NameEng = "Kasumi",
                        NameJp = "かすみ",
                        SurnameEng = "Nakasu",
                        SurnameJp = "中須",
                        NameDefault = "Kasumi Nakasu",
                        Birthday = new DateTime(1970, 1, 23),
                        Group = "Nijigasaki",
                        Subunit = "Qu4rtz",
                        YearOfSchoool = 1,
                        Height = 155,
                        BustSize = 76,
                        WaistSize = 55,
                        HipsSize = 79,
                        SeiyuuEng = "Sagara Mayu",
                        SeiyuuJp = "相良茉優",
                        Description = "kasukasu besto aidoru",
                        Color = "pastel yellow",
                    },

                    //Nijigasaki3
                    new IdolCharacter
                    {                     
                        NameEng = "Shizuku",
                        NameJp = "しずく",
                        SurnameEng = "Osaka",
                        SurnameJp = "桜坂",
                        NameDefault = "Shizuku Osaka",
                        Birthday = new DateTime(1970, 4, 3),
                        Group = "Nijigasaki",
                        Subunit = "Azuna",
                        YearOfSchoool = 1,
                        Height = 157,
                        BustSize = 80,
                        WaistSize = 58,
                        HipsSize = 83,
                        SeiyuuEng = "Maeda Kaori",
                        SeiyuuJp = "前田佳織里",
                        Description = "arkady capitol",
                        Color = "light blue",
                    },

                    //Nijigasaki4
                    new IdolCharacter
                    {                     
                        NameEng = "Karin",
                        NameJp = "果林",
                        SurnameEng = "Asaka",
                        SurnameJp = "朝香",
                        NameDefault = "Karin Asaka",
                        Birthday = new DateTime(1970, 6, 29),
                        Group = "Nijigasaki",
                        Subunit = "DiverDiva",
                        YearOfSchoool = 3,
                        Height = 167,
                        BustSize = 88,
                        WaistSize = 57,
                        HipsSize = 89,
                        SeiyuuEng = "Kubota Miyu",
                        SeiyuuJp = "久保田未夢",
                        Description = "ara ara",
                        Color = "royal blue",
                    },

                    //Nijigasaki5
                    new IdolCharacter
                    {                     
                        NameEng = "Ai",
                        NameJp = "愛",
                        SurnameEng = "Miyashita",
                        SurnameJp = "宮下",
                        NameDefault = "Ai Miyashita",
                        Birthday = new DateTime(1970, 5, 30),
                        Group = "Nijigasaki",
                        Subunit = "DiverDiva",
                        YearOfSchoool = 2,
                        Height = 163,
                        BustSize = 84,
                        WaistSize = 53,
                        HipsSize = 86,
                        SeiyuuEng = "Murakami Natsumi",
                        SeiyuuJp = "村上奈津実",
                        Description = "strasburger",
                        Color = "orange",
                    },

                    //Nijigasaki6
                    new IdolCharacter
                    {                     
                        NameEng = "Kanata",
                        NameJp = "彼方",
                        SurnameEng = "Konoe",
                        SurnameJp = "近江",
                        NameDefault = "Kanata Konoe",
                        Birthday = new DateTime(1970, 12, 16),
                        Group = "Nijigasaki",
                        Subunit = "Qu4rtz",
                        YearOfSchoool = 3,
                        Height = 158,
                        BustSize = 85,
                        WaistSize = 60,
                        HipsSize = 86,
                        SeiyuuEng = "Kitou Akari",
                        SeiyuuJp = "鬼頭明里",
                        Description = "sleepy gurl",
                        Color = "violet",
                    },

                    //Nijigasaki7
                    new IdolCharacter
                    {                     
                        NameEng = "Setsuna",
                        NameJp = "せつ菜",
                        SurnameEng = "Yuki",
                        SurnameJp = "優木",
                        NameDefault = "Setsuna Yuki",
                        Birthday = new DateTime(1970, 8, 8),
                        Group = "Nijigasaki",
                        Subunit = "Azuna",
                        YearOfSchoool = 2,
                        Height = 154,
                        BustSize = 83,
                        WaistSize = 56,
                        HipsSize = 81,
                        SeiyuuEng = "Kusunoki Tomori",
                        SeiyuuJp = "楠木ともり",
                        Description = "hasziridaszita",
                        Color = "red",
                    },

                    //Nijigasaki8
                    new IdolCharacter
                    {                     
                        NameEng = "Emma",
                        NameJp = "エマ",
                        SurnameEng = "Verde",
                        SurnameJp = "ヴェルデ",
                        NameDefault = "Emma Verde",
                        Birthday = new DateTime(1970, 2, 5),
                        Group = "Nijigasaki",
                        Subunit = "Qu4rtz",
                        YearOfSchoool = 3,
                        Height = 166,
                        BustSize = 92,
                        WaistSize = 61,
                        HipsSize = 88,
                        SeiyuuEng = "Sashide Maria",
                        SeiyuuJp = "指出毬亜",
                        Description = "buono swiss boobies",
                        Color = "light green",
                    },

                    //Nijigasaki9
                    new IdolCharacter
                    {                     
                        NameEng = "Rina",
                        NameJp = "璃奈",
                        SurnameEng = "Tennoji",
                        SurnameJp = "天王寺",
                        NameDefault = "Rina Tennoji",
                        Birthday = new DateTime(1970, 11, 13),
                        Group = "Nijigasaki",
                        Subunit = "Qu4rtz",
                        YearOfSchoool = 1,
                        Height = 149,
                        BustSize = 71,
                        WaistSize = 52,
                        HipsSize = 75,
                        SeiyuuEng = "Tanaka Chiemi",
                        SeiyuuJp = "田中ちえ美",
                        Description = "mordeczka",
                        Color = "white",
                    },

                    
                };
                context.IdolCharacters.AddRange(idolCharacters);
                context.SaveChanges();
            }
        }       
    }
}