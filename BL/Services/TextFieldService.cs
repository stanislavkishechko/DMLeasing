using BL.Common.Interfaces.Repositories;
using BL.Common.Interfaces.Services;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class TextFieldService : ITextFieldService
    {
        private readonly ITextFieldRepository _textFieldRepository;

        public TextFieldService(ITextFieldRepository textFieldRepository)
        {
            _textFieldRepository = textFieldRepository;
        }

        public IEnumerable<TextField> GetTextFields()
        {
            return _textFieldRepository.GetAll();
        }

        public void AddTextField(TextField entity)
        {
            _textFieldRepository.Insert(entity);
            _textFieldRepository.Save();
        }
        public void DeleteTextField(Guid id)
        {
            _textFieldRepository.Delete(id);
        }

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return _textFieldRepository.GetTextFieldByCodeWord(codeWord);
        }

        public void UpdateTextField(TextField entity)
        {
            _textFieldRepository.Update(entity);
            _textFieldRepository.Save();
        }
    }
}
