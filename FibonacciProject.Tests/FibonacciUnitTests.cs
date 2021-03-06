﻿using FibonacciTests;
using Xunit;

namespace FibonacciProject.Tests
{
    public class FibonacciUnitTests
    {
        [Fact]
        public void Fib_Given0_Return0()
        {
            //arrange
            int n = 0;

            //act
            int result = Fibonacci.Fib(n);

            //assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Fib_Geven1_Return1()
        {
            //arrange
            int n = 1;

            //act
            int result = Fibonacci.Fib(n);

            //assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Fib_Geven2_Return1()
        {
            //arrange
            int n = 2;

            //act
            int result = Fibonacci.Fib(n);

            //assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Fib_Geven3_Return2()
        {
            //arrange
            int n = 3;

            //act
            int result = Fibonacci.Fib(n);

            //assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Fib_Geven4_Return3()
        {
            //arrange
            int n = 4;

            //act
            int result = Fibonacci.Fib(n);

            //assert
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        public void Fib_GevenN_ReturnM(int n, int m)
        {
            //arrage
            int input = n;

            //act
            int result = Fibonacci.Fib(input);

            //assert
            Assert.Equal(m, result);
        }
    }
}
