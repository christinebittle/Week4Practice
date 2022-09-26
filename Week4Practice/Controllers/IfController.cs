using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week4Practice.Controllers
{
    public class IfController : ApiController
    {
        /// <summary>
        /// Computes the cost of a wedding plan
        /// </summary>
        /// <returns>If the wedding is under or over budget</returns>
        /// <param name="Budget">The overall budget for the wedding in $CAD</param>
        /// <param name="NumGuests">The number of guests to attend the wedding</param>
        /// <param name="VenueSize">The venue size in square feet</param>
        /// <example>
        /// GET: /api/If/WeddingCalculator/10/2500/30000 ->
        ///     "Wedding is under budget"
        /// </example>
        /// <example>
        /// GET: /api/If/WeddingCalculator/50/6000/10 >
        ///     "Wedding is over budget"
        /// </example>
        [Route("api/If/WeddingCalculator/{NumGuests}/{VenueSize}/{Budget}")]
        [HttpGet]
        public string WeddingCalculator(int NumGuests, int VenueSize, int Budget)
        {
            int WeddingCost = NumGuests * VenueSize;

            if (WeddingCost < Budget)
            {
                return "Wedding is under budget";
            }
            else if (WeddingCost==Budget)
            {
                return "Wedding is exactly on budget";
            }
            else
            {
                return "Wedding is over budget";

            }


            
        }

        
        [HttpPost]
        public string GoodBye()
        {
            return "Goodbye";
        }

    }
}
