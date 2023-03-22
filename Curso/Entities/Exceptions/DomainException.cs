using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string massage) :base(massage) 
        { 

        }   
        
    }
}
