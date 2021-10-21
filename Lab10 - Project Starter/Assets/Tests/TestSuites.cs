using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuites
    {
        private float result = 0.0f;

        private void CalculatePair(float x, float y, string ob)
        {
            result = Calculator.CalculatePair(x, y, ob);
        }

        //addition
        [Test]
        public void TestAddition()
        {
            //Use the Assert class to test conditions
            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            //Use the Assert class to test conditions.
            //Use Yieid to skip a frame.
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }

        //subtraction
        [Test]
        public void TestSubtration()
        {
            //Use the Assert class to test conditions
            CalculatePair(10, 5, "-");
            Assert.AreEqual(result, 5);
        }



        [UnityTest]
        public IEnumerator TestUnitySubtration()
        {
            //Use the Assert class to test conditions.
            //Use Yieid to skip a frame.
            yield return null;

            CalculatePair(10, 5, "-");
            Assert.AreEqual(result, 5);
        }

        //Multiplication
        [Test]
        public void TestMultiplication()
        {
            //Use the Assert class to test conditions
            CalculatePair(10, 5, "/");
            Assert.AreEqual(result, 2);
        }



        [UnityTest]
        public IEnumerator TestUnityMultiplication()
        {
            //Use the Assert class to test conditions.
            //Use Yieid to skip a frame.
            yield return null;

            CalculatePair(10, 5, "/");
            Assert.AreEqual(result, 2);
        }

        //Division
        [Test]
        public void TestDivision()                               //We are sabaton! We play heavy metal! AND THIS IS GHOST DIVISIONNNNNN!   Fast as the wind, the invasion has begun! Shaking the ground with the force of thousand guns! First in the line of fire. First into hostile land. Tanks leading the way. Leading the wayyyyyy
        {
            //Use the Assert class to test conditions
            CalculatePair(10, 5, "/");
            Assert.AreEqual(result, 2);
        }



        [UnityTest]
        public IEnumerator TestUnityDivision()
        {
            //Use the Assert class to test conditions.
            //Use Yieid to skip a frame.
            yield return null;

            CalculatePair(10, 5, "/");
            Assert.AreEqual(result, 2);
        }

        //SquareRoot

        [Test]
        public void TestSqureRoot()                              
        {
            //Use the Assert class to test conditions
            CalculatePair(100, 0, "MathSqrt");
            Assert.AreEqual(result, 10);
        }



        [UnityTest]
        public IEnumerator TestUnitySqureRoot()
        {
            //Use the Assert class to test conditions.
            //Use Yieid to skip a frame.
            yield return null;

            CalculatePair(100, 0, "MathSqrt");
            Assert.AreEqual(result, 10);
        }

        //BY THE POWER OF GRAYSKULL! I HAVE THE POWERRRRRRRRRRRR!!!          HE-MAN
        [Test]
        public void TestPower()
        {
            //Use the Assert class to test conditions
            CalculatePair(5, 5, "Power");
            Assert.AreEqual(result, 3125);
        }



        [UnityTest]
        public IEnumerator TestUnityPower()
        {
            //Use the Assert class to test conditions.
            //Use Yieid to skip a frame.
            yield return null;

            CalculatePair(5, 5, "Power");
            Assert.AreEqual(result, 3125);
        }







    }
}
