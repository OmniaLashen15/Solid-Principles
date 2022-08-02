using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace SRP
{
    public class RatingEngine
    {
        public decimal Rating { get; set; }
        public void Rate()
        {
            Console.WriteLine("Starting rate.");
            Console.WriteLine("Loading policy.");

            // Loading policy - open file policy.json
            string policyJson = File.ReadAllText("C:/Users/Omnia.Lashen/Desktop/Solid/SRP/policy.json");
            var policy = JsonConvert.DeserializeObject<Policy>
                (policyJson, new StringEnumConverter());
            {
                //switch(policy.Type)
                //{
                //    case PolicyType.Auto:
                //        var rater = new AutoPolicyRater(this);
                //        rater.Rate(policy);
                //        break;

                //    case PolicyType.Land:
                //        var rater2 = new LandPolicyRater(this);
                //        rater2.Rate(policy);
                //        break;

                //    case PolicyType.Life:
                //        var rater3 = new LifePolicyRater(this);
                //        rater3.Rate(policy);
                //        break;

                //      default:
                //        Console.WriteLine("Unknown policy type");
                //        break;
                //}
            }

            var facrory = new RaterFactory();

            var rater = facrory.Create(policy, this);
            rater.Rate(policy);

            Console.WriteLine("Rating completed.");

        }
    }
}
