﻿using Api.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using Api.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public UpdateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCategoryCommand command)
        {
            var value = await _context.Categories.FindAsync(command.CategoryId);
            value.CategoryName = command.CategoryName;
            await _context.SaveChangesAsync();

        }

    }
}
