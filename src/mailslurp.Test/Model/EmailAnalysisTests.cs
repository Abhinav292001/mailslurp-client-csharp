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
    ///  Class for testing EmailAnalysis
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EmailAnalysisTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EmailAnalysis
        //private EmailAnalysis instance;

        public EmailAnalysisTests()
        {
            // TODO uncomment below to create an instance of EmailAnalysis
            //instance = new EmailAnalysis();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EmailAnalysis
        /// </summary>
        [Fact]
        public void EmailAnalysisInstanceTest()
        {
            // TODO uncomment below to test "IsType" EmailAnalysis
            //Assert.IsType<EmailAnalysis>(instance);
        }


        /// <summary>
        /// Test the property 'SpamVerdict'
        /// </summary>
        [Fact]
        public void SpamVerdictTest()
        {
            // TODO unit test for the property 'SpamVerdict'
        }
        /// <summary>
        /// Test the property 'VirusVerdict'
        /// </summary>
        [Fact]
        public void VirusVerdictTest()
        {
            // TODO unit test for the property 'VirusVerdict'
        }
        /// <summary>
        /// Test the property 'SpfVerdict'
        /// </summary>
        [Fact]
        public void SpfVerdictTest()
        {
            // TODO unit test for the property 'SpfVerdict'
        }
        /// <summary>
        /// Test the property 'DkimVerdict'
        /// </summary>
        [Fact]
        public void DkimVerdictTest()
        {
            // TODO unit test for the property 'DkimVerdict'
        }
        /// <summary>
        /// Test the property 'DmarcVerdict'
        /// </summary>
        [Fact]
        public void DmarcVerdictTest()
        {
            // TODO unit test for the property 'DmarcVerdict'
        }

    }

}
