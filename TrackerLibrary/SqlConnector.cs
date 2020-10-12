using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    class SqlConnector : IDataConnection
    {
        ///TODO- Make the Create Prize method actually save to database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model"> the prize's information</param>
        /// <returns>The prize information, including identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
