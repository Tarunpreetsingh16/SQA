using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Tests
{
    [TestFixture]
    class RectangleTest
    {
        Rectangle rectangle;

        /*Test cases for GetPerimeter() method*/

        /*Test case 1
         * Revision : 1.0
         * Description : To test whether the perimeter function is returning the correct value
         * Input : Default => length = 1, width = 1
         * Expected : 4
         */
        [Test]
        public void TestGetPerimeter_InputDefault_Output4()
        {
            rectangle = new Rectangle();
            int perimeter = rectangle.GetPerimeter();
            Assert.AreEqual(4,perimeter);
        }

        /*Test case 2
         * Revision : 1.0
         * Description : To test whether the perimeter function is returning the correct value
         *                  when length = 0
         * Input : length = 0, width = 5
         * Expected : 10
         */
        [Test]
        public void TestGetPerimeter_Input0_5_Output10()
        {
            rectangle = new Rectangle(0,5);
            int perimeter = rectangle.GetPerimeter();
            Assert.AreEqual(10,perimeter);
        }

        /*Test case 3
         * Revision : 1.0
         * Description : To test whether the perimeter function is returning 
         *               the correct value when passed with engative values
         * Input : length = -5, width = 0
         * Expected : -2
         */
        [Test]
        public void TestGetPerimeter_Input_neg1_0__Output_neg2()
        {
            rectangle = new Rectangle(-1,0);
            int perimeter = rectangle.GetPerimeter();
            Assert.AreEqual(-2,perimeter);
        }

        /*Test cases for GetArea() method*/

        /*Test case 1
         * Revision : 1.0
         * Description : To test whether the area function is returning the correct value
         *               when user isn't entering anything
         * Input : Default => length = 1, width = 1
         * Expected : 1
         */
        [Test]
        public void TestGetArea_InputDefault_Output1()
        {
            rectangle = new Rectangle();
            int area = rectangle.GetArea();
            Assert.AreEqual(1, area);
        }
        
        /*Test case 2
         * Revision : 1.0
         * Description : To test whether the area function is returning the correct value
         *               when the length = 0
         * Input :length = 0, width = 1
         * Expected : 0
         */
        [Test]
        public void TestGetArea_Input0_1_Output0()
        {
            rectangle = new Rectangle(0,1);
            int area = rectangle.GetArea();
            Assert.AreEqual(0, area);
        }
        
        /*Test case 3
         * Revision : 1.0
         * Description : To test whether the area function is returning the correct value
         *               when negative values are passed 
         * Input : length = -2, width = 1
         * Expected : -2
         */
        [Test]
        public void TestGetArea_Input_neg2_1_Output_neg2()
        {
            rectangle = new Rectangle(-2,1);
            int area = rectangle.GetArea();
            Assert.AreEqual(-2, area);
        }

        /*Test cases for SetLength() method*/

        /*Test case 1
         * Revision : 1.0
         * Description : To test whether the SetLength() method is working fine or not by passing positive value
         * Input : length = 2
         * Expected : 2
         */
        [Test]
        public void TestSetLength_Input2_Output2()
        {
            rectangle = new Rectangle();
            int lengthSet = rectangle.SetLength(2);
            Assert.AreEqual(2, lengthSet);
        }

        /*Test case 2
         * Revision : 1.0
         * Description : To test whether the SetLength() method is working fine or not by passing negative value
         * Input :  length = -5
         * Expected : -5
         */
        [Test]
        public void TestSetLength_Input_neg2_Output_neg2()
        {
            rectangle = new Rectangle();
            int lengthSet = rectangle.SetLength(-5);
            Assert.AreEqual(-5, lengthSet);
        }

        /*Test case 3
         * Revision : 1.0
         * Description : To test whether the SetLength() method is working fine or not by passing 0
         * Input :length = 0
         * Expected : 0
         */
        [Test]
        public void TestSetLength_Input0_Output0()
        {
            rectangle = new Rectangle();
            int lengthSet = rectangle.SetLength(0);
            Assert.AreEqual(0, lengthSet);
        }
        
        /*Test cases for SetWidth() method*/

        /*Test case 1
         * Revision : 1.0
         * Description : To test whether the SetWidth() method is working fine or not by passing positive value
         * Input : width = 2
         * Expected : 2
         */
        [Test]
        public void TestSetWidth_Input2_Output2()
        {
            rectangle = new Rectangle();
            int widthSet = rectangle.SetWidth(2);
            Assert.AreEqual(2, widthSet);
        }

        /*Test case 2
         * Revision : 1.0
         * Description : To test whether the SetWidth() method is working fine or not by passing negative value
         * Input :  width = -5
         * Expected : -5
         */
        [Test]
        public void TestSetWidth_Input_neg5_Output_neg5()
        {
            rectangle = new Rectangle();
            int widthSet = rectangle.SetWidth(-5);
            Assert.AreEqual(-5, widthSet);
        }

        /*Test case 3
         * Revision : 1.0
         * Description : To test whether the SetWidth() method is working fine or not by passing 0
         * Input :width = 0
         * Expected : 0
         */
        [Test]
        public void TestSetWidth_Input0_Output0()
        {
            rectangle = new Rectangle();
            int widthSet = rectangle.SetWidth(0);
            Assert.AreEqual(0, widthSet);
        }

        /*Test cases for GetLength() method*/

        /*Test case 1
         * Revision : 1.0
         * Description : To test whether the GetLength() method is working fine or not by passing positive value
         * Input : length = 2
         * Expected : 2
         */
        [Test]
        public void TestGetLength_Input2_Output2()
        {
            rectangle = new Rectangle();
            rectangle.SetLength(2);
            int length = rectangle.GetLength();
            Assert.AreEqual(2, length);
        }

        /*Test case 2
         * Revision : 1.0
         * Description : To test whether the GetLength() method is working fine or not by passing negative value
         * Input : length = -2
         * Expected : -2
         */
        [Test]
        public void TestGetLength_Input_neg2_Output_neg2()
        {
            rectangle = new Rectangle();
            rectangle.SetLength(-2);
            int length = rectangle.GetLength();
            Assert.AreEqual(-2, length);
        }

        /*Test case 3
         * Revision : 1.0
         * Description : To test whether the GetLength() method is working fine or not by passing 0
         * Input : length = 0
         * Expected : 0
         */
        [Test]
        public void TestGetLength_Input0_Output0()
        {
            rectangle = new Rectangle();
            rectangle.SetLength(0);
            int length = rectangle.GetLength();
            Assert.AreEqual(0, length);
        }


        /*Test cases for GetWidth() method*/

        /*Test case 1
         * Revision : 1.0
         * Description : To test whether the GetWidth() method is working fine or not by passing positive value
         * Input : width = 2
         * Expected : 2
         */
        [Test]
        public void TestGetWidth_Input2_Output2()
        {
            rectangle = new Rectangle();
            rectangle.SetWidth(2);
            int width = rectangle.GetWidth();
            Assert.AreEqual(2, width);
        }

        /*Test case 2
         * Revision : 1.0
         * Description : To test whether the GetWidth() method is working fine or not by passing negative value
         * Input : length = -2
         * Expected : -2
         */
        [Test]
        public void TestGetWidth_Input_neg2_Output_neg2()
        {
            rectangle = new Rectangle();
            rectangle.SetWidth(-2);
            int width= rectangle.GetWidth();
            Assert.AreEqual(-2, width);
        }

        /*Test case 3
         * Revision : 1.0
         * Description : To test whether the GetWidth() method is working fine or not by passing 0
         * Input : length = 0
         * Expected : 0
         */
        [Test]
        public void TestGetWidth_Input0_Output0()
        {
            rectangle = new Rectangle();
            rectangle.SetWidth(0);
            int width = rectangle.GetWidth();
            Assert.AreEqual(0, width);
        }

    }
}
