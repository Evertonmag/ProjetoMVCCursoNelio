using System;

namespace ProjetoMVCCusoNelio.Views.Sellers.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
