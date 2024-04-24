using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorRepairApp.Entities
{
    public partial class OrderDoor
    {
        public int Total
        {
            get
            {

                return Door.Price * Count;
            }
        }
    }
}