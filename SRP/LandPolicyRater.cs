using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class LandPolicyRater:Rater
    {
        private readonly RatingEngine _engine;
        public LandPolicyRater(RatingEngine engine)
        {
            _engine = engine;
        }
        public void Rate(Policy policy)
        {
            Console.WriteLine("Rating LAND policy...");
            Console.WriteLine("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Console.WriteLine("Land policy must specify Bond Amount and Validation.");
                return;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Console.WriteLine("Insufficient bond amount.");
                return;
            }
            _engine.Rating = policy.BondAmount * 0.05m;
        }
    }
}
