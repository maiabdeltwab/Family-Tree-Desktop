using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Model
{
    public class PersonVM
    {
        public int Id { set; get; }
        public string FullName { set; get; }
        public bool IsMarriage { get; set; }
    }
}