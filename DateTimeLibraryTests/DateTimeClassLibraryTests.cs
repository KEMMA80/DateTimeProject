using DateTimeClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DateTimeLibraryTests
{
    [TestClass]
  
    public class DateTimeClassLibraryTests
    {
        DateTimeClass testedObject = new DateTimeClass();

        /// <summary>
        /// тест исключение пустой строки предыдущего дня
        /// </summary>
        [TestMethod]
        public void PrevDate_NullDate_ThrowException()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.PrevDate(entryDateTime));
        }

        /// <summary>
        /// тест проверяющий дату предыдущего дня
        /// </summary>
        [TestMethod]
        
        public void PrevDate_RightDay_ReturnPreviousDate()
        {

            //Arrange
            DateTime entryDateTime = (new DateTime(1984, 03, 28));
            DateTime expectDateTime = (new DateTime(1984, 03, 27));
            //Act
            DateTime actualDateTime = testedObject.PrevDate(entryDateTime);
            //Assert
            Assert.AreEqual(actualDateTime, expectDateTime);
        }

        /// <summary>
        /// тест исключение пустой строки след. дня
        /// </summary>
        [TestMethod]
        public void NextDate_NullDate_ThrowException()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.NextDate(entryDateTime));
        }

        /// <summary>
        /// тест проверяющий дату след. дня
        /// </summary>
        [TestMethod]

        public void NextDate_RightDay_ReturnNextDate()
        {

            //Arrange
            DateTime entryDateTime = (new DateTime(1984, 03, 28));
            DateTime expectDateTime = (new DateTime(1984, 03, 29));
            //Act
            DateTime actualDateTime = testedObject.NextDate(entryDateTime);
            //Assert
            Assert.AreEqual(actualDateTime, expectDateTime);
        }

        /// <summary>
        /// тест исключение пустой строки даты до конца месяца
        /// </summary>
        [TestMethod]
        public void DaysUntilEndMonth_NullDate_ThrowException()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.DaysUntilEndMonth(entryDateTime));
        }

        /// <summary>
        /// тест проверяющий дни до конца месяца
        /// </summary>
        [TestMethod]
        public void DaysUntilEndMonth_RightDay_ReturnDaysUntilEndMonth()
        {

            //Arrange
            DateTime entryDateTime = (new DateTime(1984, 04, 10));
            int expectDays = 20;
            //Act
            int actualDays = testedObject.DaysUntilEndMonth(entryDateTime);
            //Assert
            Assert.AreEqual(actualDays, expectDays);
        }

        /// <summary>
        /// тест исключение пустой строки високосного года
        /// </summary>
        [TestMethod]
        public void LeapYearCheck_NullDate_ThrowException()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.LeapYearCheck(entryDateTime));
        }

        /// <summary>
        /// тест проверяющий високосный год
        /// </summary>
        [TestMethod]
        public void LeapYearCheck_RightDay_ReturnLeapYearCheck()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(1985, 04, 10));        
            //Assert
            Assert.IsFalse(testedObject.LeapYearCheck(entryDateTime));
        }

        ///// <summary>
        ///// тест исключение пустой строки для некоторой по счету даты
        ///// </summary>
        [TestMethod]
        public void FindDate_NullDate_ThrowException()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            int entryDays = 0;
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.FindDate(entryDateTime, entryDays));
        }

        /// <summary>
        /// тест проверяющий дату некоторого по счету дня относительно установленной даты
        /// </summary>
        [TestMethod]
        public void FindDate_daysforward_ReturnFindDate()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(1984, 04, 10));
            int entryDays = 10;
            DateTime expectedDateTime = (new DateTime(1984, 04, 20));
            //Act
            DateTime actualDate = testedObject.FindDate(entryDateTime, entryDays);
            //Assert
            Assert.AreEqual(actualDate, expectedDateTime);
        }

        /// <summary>
        /// тест исключение пустой строки последнего дня месяца
        /// </summary>
        [TestMethod]
        public void LastDayOfMonthCheck_NullDate_ThrowException()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.LastDayOfMonthCheck(entryDateTime));
        }

        /// <summary>
        /// тест проверяющий последний день месяца
        /// </summary>
        [TestMethod]
        public void LastDayOfMonthCheck_LastDay_ReturnTrue()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2020, 10, 31));
            //Assert
            Assert.IsTrue(testedObject.LastDayOfMonthCheck(entryDateTime));
        }

        /// <summary>
        /// тест исключение пустой строки первого дня месяца
        /// </summary>
        [TestMethod]
        public void FirstDayOfMonthCheck_NullDate_ThrowException()
        {
            //Arrange
            DateTime entryDateTime = new DateTime();
            //Assert
            Assert.ThrowsException<Exception>(() => testedObject.FirstDayOfMonthCheck(entryDateTime));
        } 

        /// <summary>
        /// тест проверяющий первый день месяца
        /// </summary>
        [TestMethod]
        public void FirstDayOfMonthCheck_FirstDay_ReturnTrue()
        {
            //Arrange
            DateTime entryDateTime = (new DateTime(2020, 1, 1));
            //Assert
            Assert.IsTrue(testedObject.FirstDayOfMonthCheck(entryDateTime));
        }

        
    }
}
