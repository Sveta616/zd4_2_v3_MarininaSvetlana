using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using PloshadLib;
using Var3;
namespace AreaTest
{
    [TestClass]
    public class TestsArea
    {
        // Тест на полное перекрытие
        [TestMethod]
        public void TestWithFullPerekritie1()
        {
            string input = "0 0 2 2\n0 0 2 2";
            int result = Area.Calculate(input);
            Assert.AreEqual(4, result); // 2*2 + 2*2 - 4 = 4
        }

        // Тест на отсутствие перекрытия
        [TestMethod]
        public void TestWithOutPerekritie2()
        {
            string input = "0 0 1 1\n2 2 3 3";
            int result = Area.Calculate(input);
            Assert.AreEqual(2, result); // 1 + 1 - 0 = 2
        }

        // Тест на частичное перекрытие
        [TestMethod]
        public void TestWithChastichnoePerekritie3()
        {
            string input = "0 0 1 2\n0 0 1 3";
            int result = Area.Calculate(input);
            Assert.AreEqual(3, result); //2+3-2=3
        }

        // Тест с отрицательными значениями
        [TestMethod]
        public void TestWithNegative4()
        {
            string input = "-5 -5 -1 -1\n-3 -3 -2 -2";
            int result = Area.Calculate(input);
            Assert.AreEqual(16, result); //16+2-2=16     
        }

        // Тест с одинаковыми прямоугольниками
        [TestMethod]
        public void TestWithSame5()
        {
            string input = "2 2 2 2\n2 2 2 2";
            int result = Area.Calculate(input);
            Assert.AreEqual(0, result); 
        }

        // Тест с одинаковыми отрицательными прямоугольниками
        [TestMethod]
        public void TestWithSameNegativ6()
        {
            string input = "-2 -2 -2 -2\n-2 -2 -2 -2";
            int result = Area.Calculate(input);
            Assert.AreEqual(0, result); 
        }


        //Тест с отрицательными и нулевыми значениями
        [TestMethod]
        public void TestWithNegativeAndZeroParam7()
        {
            string input = "-3 -3 -1 -1\n-2 -2 0 0";
            int result = Area.Calculate(input);
            Assert.AreEqual(7, result); // 4+4-1=7 

        }
        //Тест с одинаковыми линиями
        [TestMethod]
        public void TestWithSameLine8()
        {
            string input = "0 0 1 0\n0 0 1 0";
            int result = Area.Calculate(input);
            Assert.AreEqual(0, result);
        }
        //Тест с большими значениями
        [TestMethod]
        public void TestWithLargeParamZero9()
        {
            string input = "100 100 100 100\n100 100 100 100";
            int result = Area.Calculate(input);
            Assert.AreEqual(0, result);
        }
        //Тест с отрицательными и положительными значениями
        [TestMethod]
        public void TestWithNegativeAndPositive10()
        {
            string input = "-2 -1 1 1\n0 0 2 2";
            int result = Area.Calculate(input);
            Assert.AreEqual(9, result); //6+4-1=9
        }
        //Тест с нулевыми значениями
        [TestMethod]
        public void TestWithZeroS11()
        {
            string input = "0 0 0 0\n2 2 2 2";


            int result = Area.Calculate(input);
            Assert.AreEqual(0, result);
        }
        //Тест с большими отрицательными значениями
        [TestMethod]
        public void TestWithLargeNegative12()
        {

            string input = "-1000 -1000 -500 -500\n-800 -800 -600 -600";


            int result = Area.Calculate(input);
            Assert.AreEqual(250000, result); //250000+40000-0=290000

        }
        //Тест с комбинацией больших отрицательных и положительных координат
        [TestMethod]
        public void TestWithPositiveAndNegativeLargeZero13()
        {
            string input = "-100 -100 -100 -100\n100 100 100 100";

            int result = Area.Calculate(input);
            Assert.AreEqual(0, result);

        }
        //Тест с большими отрицательными и короткими положительными значениями
        [TestMethod]
        public void TestWithNegativeLargeAndPositiveShort14()
        {
            string input = "-300 2 3 4\n1 2 7 8";

            int result = Area.Calculate(input);
            Assert.AreEqual(638, result); //606+36-4=638

        }
        //Тест с короткими отрицательными и большими положительными значениями
        [TestMethod]
        public void TestWithNegativeShortAndPositiveLarge15()
        {
            string input = "-2 100 1 2\n2 3 100 8";

            int result = Area.Calculate(input);
            Assert.AreEqual(784, result); //294+490-0=784

        }
        //Тест с нулевыми и отрицательными значениями
        [TestMethod]
        public void TestWith0AndNegative16()
        {
            string input = "0 -200 0 -200\n0 -200 0 -200";

            int result = Area.Calculate(input);
            Assert.AreEqual(0, result);
        }
        //Тест,возвращающий исключение при всех значениях которые превышают по модулю 10^4
        [TestMethod]
        public void TestWithExceptionAllLargeNegative17()
        {
            string input = "-10001 -10001 -10001 -10001\n-10001 -10001 -10001 -10001";

            Assert.ThrowsException<Exception>(() => Area.Calculate(input));
        }
        //Тест,возвращающий исключение при всех значениях которые превышают по модулю 10^4
        [TestMethod]
        public void TestWithExceptionAllLargePositive18()
        {
            string input = "99999 99999 10000 10000\n99999 99999 10000 10000";

            Assert.ThrowsException<Exception>(() => Area.Calculate(input));
        }
        //Тест с большими положительными значениями
        [TestMethod]
        public void TestWithLargePositive19()
        {
            string input = "1000 1000 1500 1500\n1250 1250 1300 1300";
            int result = Area.Calculate(input);
            Assert.AreEqual(250000, result);

        }
        //Тест,возвращающий исключение при всех значениях которые превышают по модулю 10^4 (в данном случае проверка на роботоспособность при одном значении)
        [TestMethod]
        public void TestWithExceptionLargeNegative20()
        {
            string input = "-10001 -3 -4 -13\n-1 -1 -10 -10";

            Assert.ThrowsException<Exception>(() => Area.Calculate(input));
        }
        [TestInitialize]
        public void Setup()
        {
           
            string dir = @"C:\Users\Professional\Desktop\v3_4zd\Var3\bin\Debug"; 
            Directory.SetCurrentDirectory(dir);
        }

        //Тест на проверку существования
        [TestMethod]
        public void TestFileExists21()
        {
            string file = "input.txt";
            string directory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(directory, file);
            bool exists = File.Exists(filePath);
            Assert.IsTrue(exists, "Файл не существует");
        }
        //Тест на пустоту файла
        [TestMethod]
        public void TestFileNoEmpty22()
        {
            string file = "input.txt";
            string directory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(directory, file);
            // Проверяем, что файл не пустой
            long fileSize = new FileInfo(filePath).Length;
            Assert.IsTrue(fileSize > 0, "Файл пустой");
        }

    }
}
