using System; 
using System.Text; 
using System.Linq; 
using NUnit.Framework; 
using System.Collections.Generic; 

namespace TestApp.Tests; 

public class DigitsExtractorTests 
{ 
[Test] 
public void Test_FindDigits_EmptyStringInput_ReturnsNoDigitsMessage() 
{ 
    // Arrange 
    string input = ""; string expected = "No digits!";  
    
    // Act 
    string result = DigitsExtractor.FindDigits(input); 
 
    // Assert 
    Assert.That(result, Is.EqualTo(expected));  
} 
 
[Test] 
public void Test_FindDigits_NoDIgitsInput_ReturnsNoDigitsMessage() 
{ 
    //Arrange 
    string input = "Dizel"; 
    string expected = "No digits!"; 
 
    //Act 
    string result = DigitsExtractor.FindDigits(input); 
 
    //Assert 
    Assert.That(result, Is.EqualTo(expected)); 
} 
 
[Test] 
public void Test_FindDigits_OnlyDigitsStringInpput_ReturnsSameDigitsString() 
{ 
    //Arrange 
    string input = "12345"; 
    string expected = "12345"; 
 
    //Act 
    string result = DigitsExtractor.FindDigits(input); 
 
    //Assert 
    Assert.That(result, Is.EqualTo(expected)); 
} 
 
[Test] 
public void Test_FindDigits_DigitsAndLetters_ReturnsOnlyDigits() 
{ 
    //Arrange 
    string input = "Dizel 123"; 
    string expected = "123"; 
 
    //Act 
    string result = DigitsExtractor.FindDigits(input); 
 
    //Assert 
    Assert.That(result, Is.EqualTo(expected)); 
} 
  

} 

 
