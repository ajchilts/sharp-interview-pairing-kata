using StringLibrary;

namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
   [TestMethod]
    public void Zero_Returns_Empty_String()
    {
        Assert.AreEqual(string.Empty, RomanNumerals.ToRoman(0));
    }
    
    [TestMethod]
    public void One_Returns_Single_I()
    {
        Assert.AreEqual("I", RomanNumerals.ToRoman(1));
    }
 
    [TestMethod]
    public void Three_Returns_Three_Is()
    {
        Assert.AreEqual("III", RomanNumerals.ToRoman(3));
    }

    [TestMethod]
    public void Four_Returns_IV()
    {
        Assert.AreEqual("IV", RomanNumerals.ToRoman(4));
    }

    [TestMethod]
    public void Five_Returns_V()
    {
        Assert.AreEqual("V", RomanNumerals.ToRoman(5));
    }

    [TestMethod]
    public void Six_Returns_VI()
    {
        Assert.AreEqual("VI", RomanNumerals.ToRoman(6));
    }

    [TestMethod]
    public void Nine_Returns_IX()
    {
        Assert.AreEqual("IX", RomanNumerals.ToRoman(9));
    }

    [TestMethod]
    public void Ten_Returns_X()
    {
        Assert.AreEqual("X", RomanNumerals.ToRoman(10));
    }

    [TestMethod]
    public void Twenty_Seventeen_Returns_Lots_Of_Letters()
    {
        Assert.AreEqual("MMXVII", RomanNumerals.ToRoman(2017));
    }
}