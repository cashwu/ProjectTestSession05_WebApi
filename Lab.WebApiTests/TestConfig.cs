using System;

namespace Lab.WebApiTests
{
    internal class TestConfig
    {
        /// Gets the base web address.
        /// <summary>
        /// </summary>
        /// <value>
        /// The base web address.
        /// </value>
        public static Uri BaseWebAddress => new Uri("http://localhost:33245/");
    }
}