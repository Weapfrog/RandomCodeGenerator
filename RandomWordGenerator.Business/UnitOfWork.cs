using RandomWordGenerator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWordGenerator.Business
{
    public class UnitOfWork : IUnitOfWork
    {
        DatabaseHelper helper = new DatabaseHelper();

        public (bool Success, string Message) Insert(string wordName)
        {
            try
            {
                helper.Insert(wordName);
                return (true, "Success!");
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }
        }
    }
}
