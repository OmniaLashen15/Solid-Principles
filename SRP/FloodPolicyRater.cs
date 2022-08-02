using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class FloodPolicyRater: Rater
    {
        private readonly RatingEngine _engine;
        public FloodPolicyRater(RatingEngine engine)
        {
            _engine = engine;
        }

        public void Rate(Policy policy)
        {
            Console.WriteLine("Rating FLOOD policy...");
            Console.WriteLine("Validating policy.");
            if(policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Console.WriteLine("Flood policy must specify Bomd Amount and Valuation.");
                return;
            }
            if(policy.ElevationAboveSeaLevelFeet <= 0)
            {
                Console.WriteLine("Flood Policy is not available for elevation at or below sea level.");
            }
            if(policy.BondAmount < 0.8m * policy.Valuation)
            {
                Console.WriteLine("Insufficent bond amount.");
                return ;
            }
            decimal multiple = 1.0m;
            if(policy.ElevationAboveSeaLevelFeet < 100)
            {
                multiple = 2.0m;
            }
            else if(policy.ElevationAboveSeaLevelFeet < 500)
            {
                multiple = 1.5m;
            }
            else if(policy.ElevationAboveSeaLevelFeet < 1000)
            {
                multiple = 1.1m;
            }
            _engine.Rating = policy.BondAmount * 0.05m * multiple;
        }
    }
}
