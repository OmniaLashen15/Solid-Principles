using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class UnknownPolicyRater : Rater
    {
        private readonly RatingEngine _engine;
        public UnknownPolicyRater(RatingEngine engine)
        {
            _engine = engine;
        }

        public void Rate(Policy policy)
        {
            Console.WriteLine("Unknown policy type");
        }
    }
}
