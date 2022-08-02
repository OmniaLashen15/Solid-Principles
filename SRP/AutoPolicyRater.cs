using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class AutoPolicyRater:Rater
    {
        private readonly RatingEngine _engine;

        public AutoPolicyRater(RatingEngine engine)
        {
            _engine = engine;
        }

        public void Rate(Policy policy)
        {
            Console.WriteLine("Rating AUTO policy...");
            Console.WriteLine("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                Console.WriteLine("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _engine.Rating = 1000m;
                }
                _engine.Rating = 900m;
            }
        }
    }
}
