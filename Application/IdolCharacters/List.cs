using System.Collections.Generic;
using MediatR;
using Domain;
using System.Threading.Tasks;
using System.Threading;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.IdolCharacters
{
    public class List
    {
        public class Query : IRequest<List<IdolCharacter>> { }

        public class Handler : IRequestHandler<Query, List<IdolCharacter>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<IdolCharacter>> Handle(Query request,
                CancellationToken cancellationToken)
            {
                var idolCharacters = await _context.IdolCharacters.ToListAsync();

                return idolCharacters;
            }
        }
    }
}