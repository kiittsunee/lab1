using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class TodoItemDTO
    {

       
        public TodoItemDTO(long Id, string? Name, string TypeOfRoom,bool IsComplete )
        {
        }
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
    class TodoItem
    {


        public TodoItem(long Id, string? Name, string TypeOfRoom, bool IsComplete )
        {
        }
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
    }

}
