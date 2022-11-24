﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [Test,
         TestCase("abcd1234", false),
         TestCase("irf@uni-corvinus", false),
         TestCase("irf.uni-corvinus.hu", false),
         TestCase("irf@uni-corvinus.hu", true) ]
        
        public void TestValidateEmail(string email, bool expectedResult)
        {
            //Arrange
            var accountController = new AccountController();

            //Act
            var actualResult = accountController.ValidateEmail(email);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }

        /*[   Test,
            TestCase("abcdABCD"),
            TestCase("ABCD1234"),
            TestCase("abcd1234"),
            TestCase("Ab123"),
            TestCase("Abcd1234")]

        public bool TestValidatePassword(string password)
        {
             
            Regex regex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{7,}$");

            if (regex.IsMatch(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        } */

        [   Test,
            TestCase("irf@uni-corvinus.hu", "Abcd1234"),
            TestCase("irf@uni-corvinus.hu", "Abcd1234567")]

        public void TestRegisterHappyPath(string email, string password)
        {
            var accountController = new AccountController();

            var actualResult = accountController.Register(email, password);

            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
            
        }
    }
}
