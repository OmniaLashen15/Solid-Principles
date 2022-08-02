using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    // factory design pattern
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
        {
            //more advanced

            //try
            //{
            //    return (Rater)Activator.CreateInstance(
            //        Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
            //        new object[] { engine });
            //}
            //catch
            //{
            //    return null;
            //}
            
            /// for simplicity this is the same as the lines above
            switch(policy.Type)
            {
                case PolicyType.Auto:
                    return new AutoPolicyRater(engine);

                case PolicyType.Land:
                    return new LandPolicyRater(engine);

                case PolicyType.Life:
                    return new LifePolicyRater(engine);

                case PolicyType.Flood:
                    return new FloodPolicyRater(engine);

                default:
                    return new UnknownPolicyRater(engine);
            }
        }
    }
}
