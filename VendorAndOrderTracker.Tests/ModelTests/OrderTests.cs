using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesAnOrderObject_Order()
    {
      string title = "7 Bread";
      string description = "The vendor wants bread this time";
      int price = 15;
      string date = "january 12";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}

    