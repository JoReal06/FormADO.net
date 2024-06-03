using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMS
{
    public class Inventory
    {
        public int Id { set; get; }
        public int MakeId { set; get;}
        public string Color { set; get; }
        public string PetName { set; get; }
        public byte[] TimeStamp { set; get; }
    }
}
