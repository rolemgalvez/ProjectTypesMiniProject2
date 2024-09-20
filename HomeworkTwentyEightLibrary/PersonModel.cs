using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTwentyEightLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAlive { get; set; }
        public List<AddressModel> Addresses { get; set; }
    }
}
