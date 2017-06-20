﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void CalculatePriceTest_Buy_Book_Number1_Quantity1_TotalPrice100()
        {
            //arrange
            var shoppingcart = new ShoppingCart(GetBook());
            List<BuyBook> buybook = new List<BuyBook>()
            {
                new BuyBook() { Serial="B001",Name="哈利波特第一集",Price=100,volume=1,Quantity=1 }
            };
            var expected = 100;
            //act
            var actual = shoppingcart.CalculatePrice(buybook);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Buy_Book_volume1_Quantity1＿volume2＿Quantity1_TotalPrice190()
        {
            //arrange
            var shoppingcart = new ShoppingCart(GetBook());
            List<BuyBook> buybook = new List<BuyBook>()
            {
                new BuyBook() { Serial="B001",Name="哈利波特第一集",Price=100,volume=1,Quantity=1 },
                new BuyBook() { Serial="B002",Name="哈利波特第二集",Price=100,volume=2,Quantity=1 }
            };
            double expected = 190;
            //act
            double actual = shoppingcart.CalculatePrice(buybook);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Buy_Book_volume1_Quantity1＿volume2＿Quantity1_volume3_Quantity1＿TotalPrice270＿discount＿90()
        {
            //arrange
            var shoppingcart = new ShoppingCart(GetBook());
            List<BuyBook> buybook = new List<BuyBook>()
            {
                new BuyBook() { Serial="B001",Name="哈利波特第一集",Price=100,volume=1,Quantity=1 },
                new BuyBook() { Serial="B002",Name="哈利波特第二集",Price=100,volume=2,Quantity=1 },
                new BuyBook() { Serial="B003",Name="哈利波特第三集",Price=100,volume=3,Quantity=1 }
            };
            double expected = 270;
            //act
            double actual = shoppingcart.CalculatePrice(buybook);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Buy_Book_volume1_Quantity1＿volume2＿Quantity1_volume3_Quantity1＿volume4_Quantity1＿TotalPrice320＿discount＿80()
        {
            //arrange
            var shoppingcart = new ShoppingCart(GetBook());
            List<BuyBook> buybook = new List<BuyBook>()
            {
                new BuyBook() { Serial="B001",Name="哈利波特第一集",Price=100,volume=1,Quantity=1 },
                new BuyBook() { Serial="B002",Name="哈利波特第二集",Price=100,volume=2,Quantity=1 },
                new BuyBook() { Serial="B003",Name="哈利波特第三集",Price=100,volume=3,Quantity=1 },
                new BuyBook() { Serial="B004",Name="哈利波特第四集",Price=100,volume=4,Quantity=1 }
            };
            double expected = 320;
            //act
            double actual = shoppingcart.CalculatePrice(buybook);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Buy_Book_volume1_Quantity1＿volume2＿Quantity1_volume3_Quantity1＿volume4_Quantity1＿volume5_Quantity1＿TotalPrice357＿discount＿75()
        {
            //arrange
            var shoppingcart = new ShoppingCart(GetBook());
            List<BuyBook> buybook = new List<BuyBook>()
            {
                new BuyBook() { Serial="B001",Name="哈利波特第一集",Price=100,volume=1,Quantity=1 },
                new BuyBook() { Serial="B002",Name="哈利波特第二集",Price=100,volume=2,Quantity=1 },
                new BuyBook() { Serial="B003",Name="哈利波特第三集",Price=100,volume=3,Quantity=1 },
                new BuyBook() { Serial="B004",Name="哈利波特第四集",Price=100,volume=4,Quantity=1 },
                new BuyBook() { Serial="B005",Name="哈利波特第五集",Price=100,volume=5,Quantity=1 }
            };
            double expected = 375;
            //act
            double actual = shoppingcart.CalculatePrice(buybook);

            //assert
            Assert.AreEqual(expected, actual);
        }

        public IEnumerable<Book> GetBook()
        {
            return new List<Book>()
            {
                new Book() { Serial="B001",Name="哈利波特第一集",volume=1,Price=100 },
                new Book() { Serial="B002",Name="哈利波特第二集",volume=1,Price=100 },
                new Book() { Serial="B003",Name="哈利波特第三集",volume=1,Price=100 },
                new Book() { Serial="B004",Name="哈利波特第四集",volume=1,Price=100 },
                new Book() { Serial="B005",Name="哈利波特第五集",volume=1,Price=100 }
            };
        }
    }

}