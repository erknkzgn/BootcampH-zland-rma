using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_ToDoApp
{
    class Team
    {
        private int Id;
        public string Name;

        public Team(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
    static class TakimManager
    {
        public static List<Team> TakimList;

        static TakimManager()
        {
            TakimList = DefaultTakim();
        }

        public static List<Team> DefaultTakim()
        {
            return new List<Team>()
            {
                new Team(1,"Canan Yıldırım"),
                new Team(2,"Arzu Bardakçı"),
                new Team(3,"Zekiye Şener"),
                new Team(4,"Yiğit Ai Türk"),
                new Team(5,"Sena Kurt"),
                new Team(6,"Beyza Topaloğlu"),
            };
        }
    }
}
