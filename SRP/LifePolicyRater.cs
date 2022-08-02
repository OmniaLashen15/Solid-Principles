using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class LifePolicyRater:Rater
    {
        private readonly RatingEngine _engine;

        public LifePolicyRater(RatingEngine engine)
        {
            _engine = engine;
        }

        public void Rate(Policy policy)
        {
            Console.WriteLine("Rating LIFE policy...");
            Console.WriteLine("Validating policy.");
            if (policy.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("Life policy must include Date of Birth.");
                return;
            }
            if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                Console.WriteLine("Centenarians are not eligible for coverage.");
                return;
            }
            if (policy.Amount == 0)
            {
                Console.WriteLine("Life policy must include an Amount.");
                return;
            }
            int age = DateTime.Today.Year - policy.DateOfBirth.Year;
            if (policy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < policy.DateOfBirth.Day ||
                DateTime.Today.Month < policy.DateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = policy.Amount * age / 200;
            if (policy.IsSmoker)
            {
                _engine.Rating = baseRate * 2;
                return;
            }
            _engine.Rating = baseRate;
        }
    }
}
