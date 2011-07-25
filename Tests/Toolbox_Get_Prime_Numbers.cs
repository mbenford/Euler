using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProjectEuler.Tools;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class Toolbox_Get_Prime_Numbers
    {
        [Test]
        public void Returns_2_When_Passing_2()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(2);
            CollectionAssert.AreEqual(new int[] { 2 }, primes);
        }

        [Test]
        public void Returns_2_3_When_Passing_3()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(3);
            CollectionAssert.AreEqual(new int[] { 2, 3 }, primes);
        }

        [Test]
        public void Returns_2_3_When_Passing_4()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(4);
            CollectionAssert.AreEqual(new int[] { 2, 3 }, primes);
        }

        [Test]
        public void Returns_2_3_5_When_Passing_5()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(5);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5 }, primes);
        }

        [Test]
        public void Returns_2_3_5_When_Passing_6()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(6);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_When_Passing_7()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(7);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_When_Passing_8()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(8);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_When_Passing_9()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(9);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_When_Passing_10()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(10);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_11_When_Passing_11()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(11);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7, 11 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_11_When_Passing_12()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(12);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7, 11 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_11_13_When_Passing_13()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(13);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7, 11, 13 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_11_13_When_Passing_14()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(14);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7, 11, 13 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_11_13_When_Passing_15()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(15);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7, 11, 13 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_11_13_When_Passing_16()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(16);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7, 11, 13 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_11_13_17_When_Passing_17()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(17);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7, 11, 13, 17 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_11_13_17_When_Passing_18()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(18);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7, 11, 13, 17 }, primes);
        }

        [Test]
        public void Returns_2_3_5_7_11_13_17_19_When_Passing_19()
        {
            IEnumerable<int> primes = Toolbox.GetPrimes(19);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7, 11, 13, 17, 19 }, primes);
        }

    }
}
