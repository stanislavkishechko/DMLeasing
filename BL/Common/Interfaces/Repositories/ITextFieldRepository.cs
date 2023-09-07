using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Common.Interfaces.Repositories
{
    public interface ITextFieldRepository : IRepository<TextField>
    {
        public TextField GetTextFieldByCodeWord(string codeWord);
    }
}
