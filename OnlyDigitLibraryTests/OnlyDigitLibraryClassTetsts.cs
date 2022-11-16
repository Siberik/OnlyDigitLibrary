using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlyDigitLibrary;
using System;
using System.Collections.Generic;

namespace OnlyDigitLibraryTests
{
    [TestClass]
    public class OnlyDigitLibraryClassTetsts
    {
        //проверка на пустую строку
        [TestMethod]
        public void GetDigit_StringEmpty_EmptyListReturned()
        {
            //Arrange
            string textString="56";
            List<char> chars=new List<char>() {};
            //Act
            List<char> actual = OnlyDigitLibraryClass.GetDigit(textString);
            //Assert
            CollectionAssert.AreEqual(chars, actual);
        }
    }
}
