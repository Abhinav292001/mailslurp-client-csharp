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
    ///  Class for testing CreateConnectorOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateConnectorOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateConnectorOptions
        //private CreateConnectorOptions instance;

        public CreateConnectorOptionsTests()
        {
            // TODO uncomment below to create an instance of CreateConnectorOptions
            //instance = new CreateConnectorOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateConnectorOptions
        /// </summary>
        [Fact]
        public void CreateConnectorOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateConnectorOptions
            //Assert.IsType<CreateConnectorOptions>(instance);
        }


        /// <summary>
        /// Test the property 'ConnectorType'
        /// </summary>
        [Fact]
        public void ConnectorTypeTest()
        {
            // TODO unit test for the property 'ConnectorType'
        }
        /// <summary>
        /// Test the property 'ConnectorAuthType'
        /// </summary>
        [Fact]
        public void ConnectorAuthTypeTest()
        {
            // TODO unit test for the property 'ConnectorAuthType'
        }
        /// <summary>
        /// Test the property 'ImapSettings'
        /// </summary>
        [Fact]
        public void ImapSettingsTest()
        {
            // TODO unit test for the property 'ImapSettings'
        }
        /// <summary>
        /// Test the property 'InboxId'
        /// </summary>
        [Fact]
        public void InboxIdTest()
        {
            // TODO unit test for the property 'InboxId'
        }
        /// <summary>
        /// Test the property 'SyncEnabled'
        /// </summary>
        [Fact]
        public void SyncEnabledTest()
        {
            // TODO unit test for the property 'SyncEnabled'
        }
        /// <summary>
        /// Test the property 'SyncScheduleType'
        /// </summary>
        [Fact]
        public void SyncScheduleTypeTest()
        {
            // TODO unit test for the property 'SyncScheduleType'
        }
        /// <summary>
        /// Test the property 'SyncInterval'
        /// </summary>
        [Fact]
        public void SyncIntervalTest()
        {
            // TODO unit test for the property 'SyncInterval'
        }
        /// <summary>
        /// Test the property 'FetchSettings'
        /// </summary>
        [Fact]
        public void FetchSettingsTest()
        {
            // TODO unit test for the property 'FetchSettings'
        }

    }

}
