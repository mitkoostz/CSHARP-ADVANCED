using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_by_Group
{
    class startup
    {
        public static void Main()
        {

            var input = Console.ReadLine();

            var students =  new List<Student>();

            while (input != "END")
            {
                string[] inputParams = input.Split(new[] { ' ' }, StringSplitOptions
                    .RemoveEmptyEntries);

                var firstName = inputParams[0];
                var lasttName = inputParams[1];
                var group = int.Parse(inputParams[2]);

                students.Add(new Student { FirstName = firstName
                    , LastName = lasttName,Group = group });

                input = Console.ReadLine();

            }


            var grouped = students
                .OrderBy(x => x.FirstName)
                .GroupBy(x => x.Group)
                .ToList();

            grouped = grouped.Where(x => x.Key == 2)
                .ToList();

            foreach (var kvp in grouped)
            {
                foreach (var item in kvp)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }
            }

    

          
                
                

        }
    }
}
