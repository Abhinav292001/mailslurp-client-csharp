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
    ///  Class for testing CreateInboxForwarderOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateInboxForwarderOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateInboxForwarderOptions
        //private CreateInboxForwarderOptions instance;

        public CreateInboxForwarderOptionsTests()
        {
            // TODO uncomment below to create an instance of CreateInboxForwarderOptions
            //instance = new CreateInboxForwarderOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateInboxForwarderOptions
        /// </summary>
        [Fact]
        public void CreateInboxForwarderOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateInboxForwarderOptions
            //Assert.IsType<CreateInboxForwarderOptions>(instance);
        }


        /// <summary>
        /// Test the property 'Field'
        /// </summary>
        [Fact]
        public void FieldTest()
        {
            // TODO unit test for the property 'Field'
        }
        /// <summary>
        /// Test the property 'Match'
        /// </summary>
        [Fact]
        public void MatchTest()
        {
            // TODO unit test for the property 'Match'
        }
        /// <summary>
        /// Test the property 'ForwardToRecipients'
        /// </summary>
        [Fact]
        public void ForwardToRecipientsTest()
        {
            // TODO unit test for the property 'ForwardToRecipients'
        }

    }

}
