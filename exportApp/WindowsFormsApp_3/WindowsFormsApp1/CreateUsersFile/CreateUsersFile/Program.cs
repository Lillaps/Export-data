using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace CreateUsersFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"users.csv";
            FileInfo fi1 = new FileInfo(file);
            if (!(fi1.Exists))
            {
                using (StreamWriter sw = fi1.CreateText()) ;
            }
            //using (var sw = new StreamWriter(file, false, Encoding.Default))
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        sw.WriteLine($"date{i};FirstName{i};LastName{i};SurName{i};City{i};Country{i}");
            //    }
            //}


            int k = 0;
            int year = 2022;
            using (var sw = new StreamWriter(file, false, Encoding.Default))
            {
                for (int y = 0; y < 137; y++)
                {
                    year--;
                    for (int kol = 0; kol < 20; kol++)
                    {
                        string yearS = Convert.ToString(year);
                        int month = 13;
                        for (int m = 0; m < 12; m++)
                        {
                            month--;
                            string monthS = month < 10 ? (Convert.ToString(0) + Convert.ToString(month)) : (Convert.ToString(month));
                            int day;
                            switch (month)
                            {
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10:
                                case 12:
                                    day = 32;
                                    break;
                                case 4:
                                case 6:
                                case 9:
                                case 11:
                                    day = 31;
                                    break;
                                default:
                                    //switch (year%4)
                                    //{
                                    //    case 0:
                                    //        day = 30;
                                    //    default:
                                    //        day = 29;
                                    //}
                                    day = 29;
                                    break;
                            }
                            int day_f = day;
                            for (int d = 1; d < day_f; d++)
                            {
                                day--;
                                string dayS = day < 10 ? (Convert.ToString(0) + Convert.ToString(day)) : (Convert.ToString(day));
                                k++;
                                string date = yearS + monthS + dayS;
                                sw.WriteLine($"{date};FirstName{k};LastName{k};SurName{k};City{k};Country{k};");
                            }
                        }
                    }
                }
            }
        }
    }
}
