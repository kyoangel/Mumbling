using Microsoft.VisualStudio.TestTools.UnitTesting;
using RefactorMumbling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorMumbling.Tests
{
    [TestClass()]
    public class MumblingTests
    {
        [TestMethod()]
        public void InputEmptyString_Should_ReturnEmptyString()
        {
            CheckExpectString("", "");
        }
        [TestMethod]
        public void InputOneChar_Should_ReturnOneUpperString()
        {
            CheckExpectString("a", "A");
        }

        [TestMethod]
        public void InputAB_should_Return_A_dash_Bb()
        {
            CheckExpectString("AB", "A-Bb");
        }

        [TestMethod]
        public void InputABC_Should_Return_A_dash_Bb_Dash_Ccc()
        {
            CheckExpectString("ABC", "A-Bb-Ccc");
        }
        [TestMethod]
        public void CodeWarsTests()
        {
            CheckExpectString("ZpglnRxqenU", "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu");
            CheckExpectString("NyffsGeyylB", "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb");
            CheckExpectString("MjtkuBovqrU", "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu");
            CheckExpectString("EvidjUnokmM", "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm");
            CheckExpectString("HbideVbxncC", "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc");
        }

        private static void CheckExpectString(string actual, string expect)
        {
            Mumbling mubling = new Mumbling();
            Assert.AreEqual(expect, mubling.Accum(actual));
        }

    }
}