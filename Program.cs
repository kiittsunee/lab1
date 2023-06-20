using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class program
    {
        
        static void Main(string[] args)
        {
            List<TodoItem> lst = new List<TodoItem>();
            List<TodoItemDTO> lst1 = new List<TodoItemDTO>();
            var any = from p in lst
                      from c in lst1
                        select new
                        {
                            V = p.Id = c.Id,
                            W = p.IsComplete = c.IsComplete
                        };

        }

    }
}