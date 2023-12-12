using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _482618_Julius_Evan_ResponsiJuniorProject
{
    public class departemen
    {
        public int id_dep { get; set; }
        public string nama_dep { get; set; }

        public departemen()
        { }
        public departemen(int _id_dep, string _nama_dep)
        {
            this.id_dep = _id_dep;
            this.nama_dep = _nama_dep;
        }
    }
}
