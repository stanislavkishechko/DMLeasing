using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Common.Interfaces.Services
{
    public interface ITextFieldService
    {
        TextField GetTextFieldByCodeWord(string codeWord);
        IEnumerable<TextField> GetTextFields();
        void AddTextField(TextField entity);
        void UpdateTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
