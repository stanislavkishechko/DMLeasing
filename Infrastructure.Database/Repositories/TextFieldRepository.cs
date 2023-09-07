using BL.Common.Interfaces.Repositories;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.Repositories
{
    public class TextFieldRepository : Repository<TextField>, ITextFieldRepository
    {
        private readonly DbSet<TextField> _dbSet;
        public TextFieldRepository(AppDbContext dbContext) : base(dbContext) 
        {
            _dbSet = dbContext.Set<TextField>();
        }

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return _dbSet.FirstOrDefault(e => e.CodeWord == codeWord);
        }
    }
}
