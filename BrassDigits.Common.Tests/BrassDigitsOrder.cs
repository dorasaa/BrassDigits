using System;
using NUnit.Framework;
namespace BrassDigits.Common.Tests
{
    [TestFixture]
    public class BrassDigitsOrder
    {
        BrassPlatesProcessor BrassPlatesProcessorObject;
        [SetUp]
        public void setup()
        {
            BrassPlatesProcessorObject = new BrassPlatesProcessor();
        }
        [Test]
        public void CheckNumberOfPlatesRequiredAsZeroWhenZeroRoomNumberIsEntered()
        {
            var ResultDictionatyObject        =BrassPlatesProcessorObject.ProcessDigits(0);
            long CheckRooms=0;
            foreach (var digit in ResultDictionatyObject)
            {
                CheckRooms = digit.Value;
            }
            Assert.AreEqual(0, CheckRooms);
        }

        [Test]
        public void CheckBrassPlatesProcessorReturnsZeroWhenNegativeRoomNumberIsEntered()
        {
            var ResultDictionatyObject = BrassPlatesProcessorObject.ProcessDigits(-4);
            long CheckRooms = 0;
            foreach (var digit in ResultDictionatyObject)
            {
                CheckRooms = digit.Value;
            }
            Assert.AreEqual(0, CheckRooms);
        }

        [Test]
        public void TestRequiredPlates2_WhenRooms10()
        {
            var ResultDictionatyObject = BrassPlatesProcessorObject.ProcessDigits(10);
            long NumberOfPlatesRequired= 0;

            if (ResultDictionatyObject.TryGetValue(1,out NumberOfPlatesRequired))
            {
                Assert.AreEqual(2, NumberOfPlatesRequired);
            } 
        }

        
        [TestCase(0, 200, 31)]//200 rooms
        [TestCase(1, 200, 140)]//200 rooms
        [TestCase(2, 200, 41)]//200 rooms
        [TestCase(3, 200, 40)]//200 rooms
        [TestCase(4, 200, 40)]//200 rooms
        [TestCase(5, 200, 40)]//200 rooms
        [TestCase(6, 200, 40)]//200 rooms
        [TestCase(7, 200, 40)]//200 rooms
        [TestCase(8, 200, 40)]//200 rooms
        [TestCase(9, 200, 40)]//200 rooms
        [TestCase(0, 500, 91)] //500 rooms
        [TestCase(1, 500, 200)]//500 rooms
        [TestCase(2, 500, 200)]//500 rooms 
        [TestCase(3, 500, 200)]//500 rooms
        [TestCase(4, 500, 200)]//500 rooms
        [TestCase(5, 500, 101)]//500 rooms
        [TestCase(6, 500, 100)]//500 rooms
        [TestCase(7, 500, 100)]//500 rooms
        [TestCase(8, 500, 100)]//500 rooms
        [TestCase(9, 500, 100)]//500 rooms
        public void TestRequiredPlatesForEachDigitFor200Rooms(int dig,long Rooms,int expectedBrassPlateCount)
        {
            var ResultDictionatyObject = BrassPlatesProcessorObject.ProcessDigits(Rooms);
            long NumberOfPlatesRequired = 0;

            if (ResultDictionatyObject.TryGetValue(dig, out NumberOfPlatesRequired))
            {
                Assert.AreEqual(expectedBrassPlateCount, NumberOfPlatesRequired);
            }
        }
        [TearDown]
        public void DisposeOffAllObjects()
        {
            BrassPlatesProcessorObject = null;
        }
    }
}
