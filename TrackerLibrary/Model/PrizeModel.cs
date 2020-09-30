using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Place number of the team
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Place title holder
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// How much money for the prize title
        /// </summary>
        public decimal PrizeAmount { get; set; }
        
        /// <summary>
        /// What prize percentage goes to each place
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
