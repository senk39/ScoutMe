using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.IdolCharacters
{
    public class Create
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
                var idolCharacter = new IdolCharacter
                {
                    Id = request.Id,
                    NameDefault = request.NameDefault,
                    NameEng = request.NameEng,
                    NameJp = request.NameJp,
                    SurnameEng = request.SurnameEng,
                    SurnameJp = request.SurnameJp,
                    Birthday = request.Birthday,
                    Group = request.Group,
                    Subunit = request.Subunit,
                    YearOfSchoool = request.YearOfSchoool,
                    Height = request.Height,
                    BustSize = request.BustSize,
                    WaistSize = request.WaistSize,
                    HipsSize = request.HipsSize,
                    SeiyuuEng = request.SeiyuuEng,
                    SeiyuuJp = request.SeiyuuJp,
                    Description = request.Description,
                    Color = request.Color
                };

                _context.IdolCharacters.Add(idolCharacter);
                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Problem saving changes");
            }
        }
    }
}