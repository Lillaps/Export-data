using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;

namespace WindowsFormsApp1
{
    class AdditiveDataToDB
    {
        public async void ExportDateToDB()
        {
            using (UserContext db = new UserContext())
            {
                db.Users.RemoveRange(db.Users);
                db.SaveChanges();
                string filepath = @"../../CreateUsersFile\\CreateUsersFile\\bin\\Debug\net5.0\\users.csv";
                var readcsv = File.ReadAllText(filepath);
                string[] csvfilerecord = readcsv.Split('\n');
                foreach (var row in csvfilerecord)
                {
                    if (!string.IsNullOrEmpty(row)) 
                    {
                        var cells = row.Split(';');
                        var user = new User
                        {
                            Date = cells[0],
                            FirstName = cells[1],
                            LastName = cells[2],
                            SurName = cells[3],
                            City = cells[4],
                            Country = cells[5],
                        };
                        await Task.Run(() => db.Users.Add(user));
                        await Task.Run(() => db.SaveChanges());
                    }
                }
            }
        }
    }
}
