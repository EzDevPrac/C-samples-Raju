using DesignPatterns.Factory;
using Factory;
using System;
using System.Collections.Generic;
using Xunit;

namespace DesignPatterns.Factory.Test
{
    public class FactoryPattern
    {
        [Fact]
        public void Test1()
        {
            ObjectFactory Objectfactory = new ObjectFactory();
            var expected = Objectfactory.GetObject();

           // Assert.Equal(expected, expected);
            Dictionary<string, object> data = new Dictionary<string, object>();
        //     expected = Objectfactory.Get(ObjectType.gmail,data);
        //    Assert.Equal(expected,
        //                 "Emailid is { 0 }.Name of sender is { 1 }. Phone number of the sender is { 2 }.");
        }
    }
}
