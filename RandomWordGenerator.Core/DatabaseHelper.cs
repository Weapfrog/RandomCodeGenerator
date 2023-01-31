using RandomWordGenerator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWordGenerator.Core
{
    public class DatabaseHelper : IDatabaseHelper
    {
        DatabaseEntity db = new DatabaseEntity();

        public DatabaseHelper()
        {
            if (!db.Database.Exists())
            {
                db.Database.Create();
            }
        }
        public (bool Success, string Message) Insert(string wordName)
        {
            try
            {
                Word nextWord = new Word()
                {
                    WordName = wordName
                };
                db.Words.Add(nextWord);
                db.SaveChanges();
                return (true, "Success!");
            }
            catch (Exception ex)
            {
                return (false, ex.ToString());
            }
        }
    }
}
