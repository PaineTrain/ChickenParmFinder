using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenParmFinder.Interfaces
{
    public interface IParm
    {
        /// <summary>
        /// The menu name of the parm
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The overall rating of the chicken parm
        /// </summary>
        Rating OverallRating { get; }

        /// <summary>
        /// The quality of the chicken
        /// </summary>
        Rating ChickenRating { get; }

        /// <summary>
        /// The quality of the sauce
        /// </summary>
        Rating SauceRating { get; }

        /// <summary>
        /// The quality of the cheese
        /// </summary>
        Rating CheeseRating { get; }
    }
}
