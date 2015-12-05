using ChickenParmFinder.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ChickenParmFinder
{
    public class Restaurant
    {
        /// <summary>
        /// The name of the establishment
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The street address of the restaurant
        /// </summary>
        public string StreetAddress { get; private set; }

        /// <summary>
        /// The city the restaurant is located in
        /// </summary>
        public string City { get; private set; }

        /// <summary>
        /// The zipcode for the restaurant
        /// </summary>
        public int Zipcode { get; private set; }

        /// <summary>
        /// The <see cref="Parm"/>s served by this restaurant
        /// </summary>
        public ICollection<IParm> ChickenParms { get; } = new List<IParm>();

        /// <summary>
        /// Gets the average <see cref="Rating"/> of the restaurant's parms
        /// </summary>
        public Rating AverageRating
        {
            get
            {
                // There is a bug in this method
                return (Rating)(ChickenParms.Where(parm => parm.OverallRating != Rating.Unrated)
                    .Sum(parm => (int)parm.OverallRating) / ChickenParms.Count);
            }
        }
    }
}
