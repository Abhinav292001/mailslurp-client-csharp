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
    ///  Class for testing CreateDomainOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateDomainOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateDomainOptions
        //private CreateDomainOptions instance;

        public CreateDomainOptionsTests()
        {
            // TODO uncomment below to create an instance of CreateDomainOptions
            //instance = new CreateDomainOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateDomainOptions
        /// </summary>
        [Fact]
        public void CreateDomainOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateDomainOptions
            //Assert.IsType<CreateDomainOptions>(instance);
        }


        /// <summary>
        /// Test the property 'Domain'
        /// </summary>
        [Fact]
        public void DomainTest()
        {
            // TODO unit test for the property 'Domain'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'CreatedCatchAllInbox'
        /// </summary>
        [Fact]
        public void CreatedCatchAllInboxTest()
        {
            // TODO unit test for the property 'CreatedCatchAllInbox'
        }
        /// <summary>
        /// Test the property 'DomainType'
        /// </summary>
        [Fact]
        public void DomainTypeTest()
        {
            // TODO unit test for the property 'DomainType'
        }

    }

}
