using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Contracts
{
    public interface IFileInputReader
    {
        IList<string> ReadInput(string filePath);
    }
}
