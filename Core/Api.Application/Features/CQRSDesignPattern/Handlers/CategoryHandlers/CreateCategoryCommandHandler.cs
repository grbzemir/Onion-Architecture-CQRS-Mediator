using Api.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using Api.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public CreateCategoryCommandHandler(MovieContext context)
        {
            _context = context;

        }

        public async Task Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Domain.Entities.Category
            {
                CategoryName = command.CategoryName,
            });
            await _context.SaveChangesAsync();
        }
    }
}
