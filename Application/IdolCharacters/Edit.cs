using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.IdolCharacters
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string NameDefault { get; set; }
            public string NameEng { get; set; }
            public string NameJp { get; set; }
            public string SurnameEng { get; set; }
            public string SurnameJp { get; set; }
            public DateTime? Birthday { get; set; }
            public string Group { get; set; }
            public string Subunit { get; set; }
            public int? YearOfSchoool { get; set; }
            public int? Height { get; set; }
            public int? BustSize { get; set; }
            public int? WaistSize { get; set; }
            public int? HipsSize { get; set; }
            public string SeiyuuEng { get; set; }
            public string SeiyuuJp { get; set; }
            public string Description { get; set; }
            public string Color { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var idolCharacter = await _context.IdolCharacters.FindAsync(request.Id);
                
                if (idolCharacter == null)
                    throw new Exception("Could not find idol character.");
                

                idolCharacter.NameEng       = request.NameEng       ?? idolCharacter.NameEng;
                idolCharacter.NameJp        = request.NameJp        ?? idolCharacter.NameJp;
                idolCharacter.SurnameEng    = request.SurnameEng    ?? idolCharacter.SurnameEng;
                idolCharacter.SurnameJp     = request.SurnameJp     ?? idolCharacter.SurnameJp;
                idolCharacter.NameDefault   = request.NameDefault   ?? idolCharacter.NameDefault;
                idolCharacter.Birthday      = request.Birthday      ?? idolCharacter.Birthday;
                idolCharacter.Group         = request.Group         ?? idolCharacter.Group;
                idolCharacter.Subunit       = request.Subunit       ?? idolCharacter.Subunit;
                idolCharacter.YearOfSchoool = request.YearOfSchoool ?? idolCharacter.YearOfSchoool;
                idolCharacter.Height        = request.Height        ?? idolCharacter.Height;
                idolCharacter.BustSize      = request.BustSize      ?? idolCharacter.BustSize;
                idolCharacter.WaistSize     = request.WaistSize     ?? idolCharacter.WaistSize;
                idolCharacter.HipsSize      = request.HipsSize      ?? idolCharacter.HipsSize;
                idolCharacter.SeiyuuEng     = request.SeiyuuEng     ?? idolCharacter.SeiyuuEng;
                idolCharacter.SeiyuuJp      = request.SeiyuuJp      ?? idolCharacter.SeiyuuJp;
                idolCharacter.Description   = request.Description   ?? idolCharacter.Description;
                idolCharacter.Color         = request.Color         ?? idolCharacter.Color;        

                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Problem saving changes");
            }
        }
    }
}