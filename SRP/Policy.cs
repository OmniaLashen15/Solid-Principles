using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Policy
    {
        public PolicyType Type { get; set; }
        #region Life Insurance
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsSmoker { get; set; }
        public decimal Amount { get; set; }
        #endregion

        #region Land Insurance
        public string Address { get; set; }
        public decimal Size { get; set; }
        public decimal Valuation { get; set; }
        public decimal BondAmount { get; set; }
        #endregion

        #region Life Insurance
        public string Make { get; set; }
        public string Model { get; set; }
        public int year { get; set; }
        public int Miles { get; set; }
        public decimal Deductible { get; set; }
        #endregion

        #region Flood Insurance
        public decimal ElevationAboveSeaLevelFeet { get; set; }

        #endregion


    }
}
