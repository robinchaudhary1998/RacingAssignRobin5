using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingAssignNw
{
  public class runner
    {
        //this class is used to generate the random no for the running of the Rabbit
        Random instance_Random = new Random();

        //.this method pass the integer no to the main method
        public int generate_Number() {
            return instance_Random.Next(1, 50);

        }

    }
}
