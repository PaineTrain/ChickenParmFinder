using ChickenParmFinder.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickenParmFinder.Tests.Series1Tests
{
    [TestClass]
    public class ParmTests
    {
        [TestMethod]
        public void UnratedParmDoesntAffectAverage()
        {
            var testParm1 = new Mock<IParm>();
            testParm1.Setup(parm => parm.OverallRating).Returns(Rating.Fair);

            var testParm2 = new Mock<IParm>();
            testParm2.Setup(parm => parm.OverallRating).Returns(Rating.Unrated);

            var testRestaurant = new Restaurant();
            testRestaurant.ChickenParms.Add(testParm1.Object);
            testRestaurant.ChickenParms.Add(testParm2.Object);
            var unratedParms = testRestaurant.ChickenParms.Where(parm => parm.OverallRating == Rating.Unrated).ToList();
            Assert.IsTrue(testRestaurant.AverageRating == Rating.Fair);
        }
    }
}
