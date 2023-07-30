using Xunit;
using ChristmasBoxesImplementation;
using System.Collections.Generic;
using System.Linq;

namespace ChristmasBoxesImplementation.Tests
{
    public class ChristmasBoxServiceTests
    {
        [Fact]
        public void TestScenario1()
        {
            // Arrange
            var boxes = new List<ChristmasBox>
        {
            new ChristmasBox(5),
            new ChristmasBox(10),
            new ChristmasBox(7),
            new ChristmasBox(3)
        };

            // Act
            var result = boxes.GetShuffledPresentList().ToList();

            // Assert
            Assert.Equal(10, result[1].Weight); // Jordi should get the heaviest present
        }

        [Fact]
        public void TestScenario2()
        {
            // Arrange
            var boxes = new List<ChristmasBox>
        {
            new ChristmasBox(5),
            new ChristmasBox(10),
            new ChristmasBox(7),
            new ChristmasBox(3),
            new ChristmasBox(6),
            new ChristmasBox(9),
            new ChristmasBox(8),
            new ChristmasBox(4)
        };

            // Act
            var result = boxes.GetShuffledPresentList().ToList();

            // Assert
            Assert.Equal(10, result[1].Weight); // Jordi should get the heaviest present first
            Assert.Equal(9, result[5].Weight); // Jordi should get the second heaviest present next
        }

        [Fact]
        public void TestScenario1_FourPresents()
        {
            // Arrange
            var boxes = new List<ChristmasBox>
        {
            new ChristmasBox(5),
            new ChristmasBox(12),
            new ChristmasBox(7),
            new ChristmasBox(3)
        };

            // Act
            var result = boxes.GetShuffledPresentList().ToList();

            // Assert
            Assert.Equal(12, result[1].Weight); // Jordi should get the heaviest present
        }

        [Fact]
        public void TestScenario2_MoreThanFourPresents()
        {
            // Arrange
            var boxes = new List<ChristmasBox>
        {
            new ChristmasBox(33),
            new ChristmasBox(12),
            new ChristmasBox(8),
            new ChristmasBox(7),
            new ChristmasBox(7),
            new ChristmasBox(2),
            new ChristmasBox(1),
            new ChristmasBox(1)
        };

            // Act
            var result = boxes.GetShuffledPresentList().ToList();

            // Assert
            Assert.Equal(33, result[1].Weight); // Jordi should get the heaviest present first
            Assert.Equal(12, result[5].Weight); // Jordi should get the second heaviest present next
        }

        [Fact]
        public void TestAllPresentsSameWeight()
        {
            // Arrange
            var boxes = new List<ChristmasBox>
        {
            new ChristmasBox(5),
            new ChristmasBox(5),
            new ChristmasBox(5),
            new ChristmasBox(5)
        };

            // Act
            var result = boxes.GetShuffledPresentList().ToList();

            // Assert
            Assert.All(result, box => Assert.Equal(5, box.Weight)); // All boxes should have the same weight
        }
    }
}
