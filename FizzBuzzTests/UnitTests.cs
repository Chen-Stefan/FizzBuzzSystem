namespace FizzBuzzTests;
using FizzBuzzLibrary;
using Xunit;

public class UnitTests
{ 
  [Fact]
  public void Given1Output1()
  {
    FizzBuzzLogic fb = new FizzBuzzLogic();
    string? actual = fb.GetOutput(1);
    string? expected = "1 ";
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given3Output12Fizz()
  {
    FizzBuzzLogic fb = new FizzBuzzLogic();
    string? actual = fb.GetOutput(3);
    string? expected = "1 2 Fizz ";
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given5Output12Fizz4Buzz()
  {
    FizzBuzzLogic fb = new FizzBuzzLogic();
    string? actual = fb.GetOutput(5);
    string? expected = "1 2 Fizz 4 Buzz ";
    Assert.Equal(expected, actual);
  }
  
  [Fact]
  public void Given15OutputFizzBuzz()
  {
    FizzBuzzLogic fb = new FizzBuzzLogic();
    string? actual = fb.GetOutput(15);
    string? expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ";
    Assert.Equal(expected, actual);
  }

  // write a test that throws an exception if the input is a negative number
  [Fact]
  public void GivenNegativeNumberOutputException()
  {
    FizzBuzzLogic fb = new FizzBuzzLogic();
    Assert.Throws<ArgumentException>(() => fb.GetOutput(-100));
  }
  
  // write a test that throws an exception if the input is greater than 100
  [Fact]
  public void GivenGreaterThan100OutputException()
  {
    FizzBuzzLogic fb = new FizzBuzzLogic();
    Assert.Throws<ArgumentException>(() => fb.GetOutput(101));
  }

  // write a test that throws an exception if the input is null
  [Fact]
  public void GivenNullOutputException()
  {
    FizzBuzzLogic fb = new FizzBuzzLogic();
    Assert.Throws<Exception>(() => fb.GetOutput(null));
  }
}
