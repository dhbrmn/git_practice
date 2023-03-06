using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.tsv")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();

            //Task 1.
            /*foreach (Language lang in languages)
            {
              Console.WriteLine(lang.Prettify());
            }*/

            //Task 10.1
            //PrettyPrintAll(languages);

            //Task 2.
            var lines = languages.Select(h => h.Prettify());
            /*   foreach (string l in lines)
               {
                 Console.WriteLine(l);
               }*/

            //Task 11.2
            //PrintAll(lines);        

            //Task 3.
            var date = languages.Where(h => h.Name.Contains("C#"));
            /*foreach (Language a in date)
            {
              Console.WriteLine(a.Prettify());
            }*/

            //Task 10.3
            //PrettyPrintAll(date);

            //Task 4.
            var fromMicrosoft = languages.Where(h => h.ChiefDeveloper.Contains("Microsoft"));
            /*foreach (Language m in fromMicrosoft)
            {
              Console.WriteLine(m.Prettify());
            }*/

            //Task 10.4
            //PrettyPrintAll(fromMicrosoft);

            //Task 5.
            var fromLisp = languages.Where(h => h.Predecessors.Contains("Lisp"));
            /*foreach (Language lisp in fromLisp)
            {
              Console.WriteLine(lisp.Prettify());
            }*/

            //Task 10.5
            //PrettyPrintAll(fromLisp);

            //Task 6.
            var name = from n in languages
                       where n.Name.Contains("Script")
                       select n.Name;

            /*foreach (string n in name)
            {
              Console.WriteLine(n);
            }*/

            //Task 11.6
            //PrintAll(name);

            // Task 7.
            //Console.WriteLine(languages.Count());

            //Task 8. && 9.
            var between = languages
            .Where(b => b.Year >= 1995 && b.Year <= 2005)
            .Select(b => $"{b.Name} was invented in {b.Year}");

            /*Console.WriteLine(between.Count());*/

            /*foreach (string b in between)
            {
              Console.WriteLine(b);
            }*/

            //Task 11.9
            //PrintAll(between);

            //Task 12.

            IEnumerable<Language> nameSortedLanguages = languages.OrderBy(lang => lang.Name);
            //PrettyPrintAll(nameSortedLanguages);

            int oldest = languages.Min(lang => lang.Year);
            var oldestLang = languages.Where(l => l.Year == oldest);
            //PrettyPrintAll(oldestLang);



        }

        //Task 10.
        public static void PrettyPrintAll( IEnumerable<Language> langs )
        {
            foreach (Language l in langs)
            {
                Console.WriteLine(l.Prettify());
            }
        }

        //Task 11.
        public static void PrintAll( IEnumerable<Object> obj )
        {
            foreach (Object o in obj)
            {
                Console.WriteLine(o);
            }
        }

    }
}
