using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Compiler.Model
{
    internal class DocumentModel : BaseModel
    {
        private string _fileName;
        private string _filePath;
        private FlowDocument _document;

        public string FileName
        {
            get => _fileName;
            set => _fileName = value;
        }
        public string FilePath
        {
            get => _filePath;
            set => _filePath = value;
        }
        public DocumentModel() { }
    }
}
