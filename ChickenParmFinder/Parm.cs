using ChickenParmFinder.Interfaces;
using System;

namespace ChickenParmFinder
{
    /// <summary>
    /// Represents a chicken parm
    /// </summary>
    public class Parm : IParm
    {
        /// <summary>
        /// Creates a new instance of a <see cref="Parm"/> object
        /// </summary>
        /// <param name="name">The name of the Parm</param>
        /// <param name="chickenRating">The <see cref="Rating"/> for the Parm's chicken ingredient</param>
        /// <param name="sauceRating">The <see cref="Rating"/> for the Parm's sauce ingredient</param>
        /// <param name="cheeseRating">The <see cref="Rating"/> for the Parm's cheese ingredient</param>
        public Parm(string name,
            Rating chickenRating,
            Rating sauceRating,
            Rating cheeseRating)
        {
            ChickenRating = chickenRating;
            SauceRating = sauceRating;
            CheeseRating = cheeseRating;
        }

        /// <summary>
        /// The menu name of the Parm
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The overall rating of the chicken parm
        /// </summary>
        public Rating OverallRating
        {
            get
            {
                //TODO: Implement a method that averages the Chicken/Sauce/Cheese ratings
                throw new NotImplementedException("Implement this");
            }
        }

        /// <summary>
        /// The quality of the chicken
        /// </summary>
        public Rating ChickenRating { get; private set; }

        /// <summary>
        /// The quality of the sauce
        /// </summary>
        public Rating SauceRating { get; private set; }

        /// <summary>
        /// The quality of the cheese
        /// </summary>
        public Rating CheeseRating { get; private set; }
    }
}
