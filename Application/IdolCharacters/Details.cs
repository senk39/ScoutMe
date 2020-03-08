using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.IdolCharacters
{
    public class Details
    {
        public class Query : IRequest<IdolCharacter>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, IdolCharacter>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<IdolCharacter> Handle(Query request, CancellationToken cancellationToken)
            {
                var idolCharacter = await _context.IdolCharacters.FindAsync(request.Id);

                return idolCharacter;
            }
        }
    }
}