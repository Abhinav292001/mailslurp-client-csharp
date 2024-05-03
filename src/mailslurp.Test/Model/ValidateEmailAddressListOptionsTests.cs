/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using mailslurp.Api;
using mailslurp.Model;
using mailslurp.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace mailslurp.Test.Model
{
    /// <summary>
    ///  Class for testing ValidateEmailAddressListOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ValidateEmailAddressListOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ValidateEmailAddressListOptions
        //private ValidateEmailAddressListOptions instance;

        public ValidateEmailAddressListOptionsTests()
        {
            // TODO uncomment below to create an instance of ValidateEmailAddressListOptions
            //instance = new ValidateEmailAddressListOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ValidateEmailAddressListOptions
        /// </summary>
        [Fact]
        public void ValidateEmailAddressListOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" ValidateEmailAddressListOptions
            //Assert.IsType<ValidateEmailAddressListOptions>(instance);
        }


        /// <summary>
        /// Test the property 'EmailAddressList'
        /// </summary>
        [Fact]
        public void EmailAddressListTest()
        {
            // TODO unit test for the property 'EmailAddressList'
        }
        /// <summary>
        /// Test the property 'IgnoreOldResults'
        /// </summary>
        [Fact]
        public void IgnoreOldResultsTest()
        {
            // TODO unit test for the property 'IgnoreOldResults'
        }

    }

}
