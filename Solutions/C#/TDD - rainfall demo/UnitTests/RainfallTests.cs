using NUnit.Framework;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class RainfallTests
    {
        [Test]
        public void CalculateAverageRainfall_SingleMeasurement()
        {
            int[] rainfalls = new int[] { 5 };
            RainfallAnalyzer analyzer = new RainfallAnalyzer();
            double result = analyzer.CalculateAverageRainfall(rainfalls);
            Assert.AreEqual(5.0, result);
        }

        [Test]
        public void CalculateAverageRainfall_MultipleValidMeasurements()
        {
            int[] rainfalls = new int[] { 5, 5, 2 };
            RainfallAnalyzer analyzer = new RainfallAnalyzer();
            double result = analyzer.CalculateAverageRainfall(rainfalls);
            Assert.AreEqual(4.0, result);
        }

        [Test]
        public void CalculateAverageRainfall_MultipleMeasurements_IncludingRogue()
        {
            int[] rainfalls = new int[] { 5, -1, 7, -99 };
            RainfallAnalyzer analyzer = new RainfallAnalyzer();
            double result = analyzer.CalculateAverageRainfall(rainfalls);
            Assert.AreEqual(6.0, result);
        }

        [Test]
        public void CalculateAverageRainfall_MultipleValidMeasurements_IncludingZero()
        {
            int[] rainfalls = new int[] { 5, 5, 0, 2 };
            RainfallAnalyzer analyzer = new RainfallAnalyzer();
            double result = analyzer.CalculateAverageRainfall(rainfalls);
            Assert.AreEqual(3.0, result); // 12 / 4
        }

        [Test]
        public void CalculateAverageRainfall_EmptyList()
        {
            int[] rainfalls = new int[] { };
            RainfallAnalyzer analyzer = new RainfallAnalyzer();
            double result = analyzer.CalculateAverageRainfall(rainfalls);
            Assert.AreEqual(0.0, result);
        }
    }
}
