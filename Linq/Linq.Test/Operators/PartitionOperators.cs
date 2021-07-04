using System;
using System.Linq;
using EnumerableExtensions;
using NUnit.Framework;

namespace Linq.Test.Operators
{
    [TestFixture]
    public class PartitionOperators
    {
        [Test]
        public void TakeElements()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            var first3Numbers = numbers.Take(3);

            Console.WriteLine("First 3 numbers:");
            first3Numbers.ForEach(Console.WriteLine);
        }

        [Test]
        public void TakeWhile()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);
            Console.WriteLine("First numbers less than 6: ");
            firstNumbersLessThan6.ForEach(Console.WriteLine);
        }

        [Test]
        public void TakeWhileWithIndex()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);
            Console.WriteLine("First numbers not less than their position: ");
            firstSmallNumbers.ForEach(Console.WriteLine);
        }

        [Test]
        public void SkipElements()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var first3Numbers = numbers.Skip(4);

            Console.WriteLine("All but first 4 numbers:");
            first3Numbers.ForEach(Console.WriteLine);
        }

        [Test]
        public void SkipWhile()
        {
            int[] numbers = {5, 9, 1, 4, 9, 8, 6, 7, 2, 0};
            var allButFirstOddNumbers = numbers.SkipWhile(n => n % 2 != 0);
            Console.WriteLine("All but first odd numbers:");
            allButFirstOddNumbers.ForEach(Console.WriteLine);
        }

        [Test]
        public void SkipWhileWithIndex()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var laterNumbers = numbers.SkipWhile((n, index) => n >= index);
            Console.WriteLine("All elements starting from first element less than its position:");
            laterNumbers.ForEach(Console.WriteLine);
        }
    }
}