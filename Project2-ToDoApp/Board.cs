using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_ToDoApp
{
    class Board
    {
        public List<Card> TODO;
        public List<Card> InProgress;
        public List<Card> Done;
    
        public Board()
        {
            TODO = DefaultToDo();
            InProgress = DefaultİnProgress();
        }

        public static List<Card> DefaultToDo()
        {
            return new List<Card>()
            {
                new Card("Odev","Proje",4,size.XS),
                new Card("Odev","Proje",1,size.M)
            };
        }

        public static List<Card> DefaultİnProgress()
        {
            return new List<Card>()
            {
                new Card("Odev","Proje",2,size.S),
                
            };
        }
    }
}
