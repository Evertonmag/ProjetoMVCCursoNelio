using System;

namespace ProjetoMVCCusoNelio.Views.Sellers.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
