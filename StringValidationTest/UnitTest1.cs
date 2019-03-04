using NUnit.Framework;
using StringValidation;
using System.Collections.Generic;

namespace Tests
{
    public class LongerRunTests
    {
        private StringLongerRunValidation _strLongerRunValidation;
        private List<LongerRun> _lstLongerRun;
        private string _strTest1 = "a";
        private string _strTest2 = "ab";
        private string _strTest3 = "abc";
        private string _strTest4 = "abcdd";
        private string _strTest5 = "abcddczzzdd";

        public LongerRunTests()
        {
            _strLongerRunValidation = new StringLongerRunValidation();
        }

        [Test]
        public void ValidateOneCharacter()
        {
            _lstLongerRun = new List<LongerRun>();
            _lstLongerRun = _strLongerRunValidation.GetLongerRun(_strTest1);

            Assert.IsTrue(_lstLongerRun[0].character == "a" && _lstLongerRun[0].qty == 1);
        }

        [Test]
        public void ValidateTwoCharacters()
        {
            _lstLongerRun = new List<LongerRun>();
            _lstLongerRun = _strLongerRunValidation.GetLongerRun(_strTest2);

            Assert.IsTrue(_lstLongerRun[0].character == "a" && _lstLongerRun[0].qty == 1);
            Assert.IsTrue(_lstLongerRun[1].character == "b" && _lstLongerRun[1].qty == 1);
        }

        [Test]
        public void ValidateThreeCharacters()
        {
            _lstLongerRun = new List<LongerRun>();
            _lstLongerRun = _strLongerRunValidation.GetLongerRun(_strTest3);

            Assert.IsTrue(_lstLongerRun[0].character == "a" && _lstLongerRun[0].qty == 1);
            Assert.IsTrue(_lstLongerRun[1].character == "b" && _lstLongerRun[1].qty == 1);
            Assert.IsTrue(_lstLongerRun[2].character == "c" && _lstLongerRun[2].qty == 1);
        }

        [Test]
        public void ValidateTwoDCharacters()
        {
            _lstLongerRun = new List<LongerRun>();
            _lstLongerRun = _strLongerRunValidation.GetLongerRun(_strTest4);

            Assert.IsTrue(_lstLongerRun[0].character == "d" && _lstLongerRun[0].qty == 2);
        }

        [Test]
        public void ValidateThreeZCharacters()
        {
            _lstLongerRun = new List<LongerRun>();
            _lstLongerRun = _strLongerRunValidation.GetLongerRun(_strTest5);

            Assert.IsTrue(_lstLongerRun[0].character == "z" && _lstLongerRun[0].qty == 3);
        }
    }
}