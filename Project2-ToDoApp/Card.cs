using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_ToDoApp
{
    class Card
    {
        public string Header;
        public string Content;
        public int PersonId;
        public size EnumSize;

        public Card()
        {

        }
        public Card(string header, string content, int personId, size enumSize)
        {
            Header = header;
            Content = content;
            PersonId = personId;
            EnumSize = enumSize;
        }

    }
    enum size
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}
