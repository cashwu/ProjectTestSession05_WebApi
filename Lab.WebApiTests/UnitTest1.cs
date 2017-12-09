using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace Lab.WebApiTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var client = new RestClient($"{TestConfig.BaseWebAddress}api/Customer");
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            // act
            var actual = response.Content;

            // assert
            actual.Should().NotBeEmpty();
        }
    }
}
