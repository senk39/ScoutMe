using System;


namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.IdolCharacter.Any()){
                var idolchara = new List<IdolCharacters>
                {
                    new idolchara
                    {

                    }
                };

                context.IdolCharacters.AddRange(IdolCharacters);
                context.SaveChanges();
            }
        }
    }
}