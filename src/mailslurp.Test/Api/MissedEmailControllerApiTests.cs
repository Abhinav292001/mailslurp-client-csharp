/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using mailslurp.Client;
using mailslurp.Api;
// uncomment below to import models
//using mailslurp.Model;

namespace mailslurp.Test.Api
{
    /// <summary>
    ///  Class for testing MissedEmailControllerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MissedEmailControllerApiTests : IDisposable
    {
        private MissedEmailControllerApi instance;

        public MissedEmailControllerApiTests()
        {
            instance = new MissedEmailControllerApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MissedEmailControllerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MissedEmailControllerApi
            //Assert.IsType<MissedEmailControllerApi>(instance);
        }

        /// <summary>
        /// Test GetAllMissedEmails
        /// </summary>
        [Fact]
        public void GetAllMissedEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //string searchFilter = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //Guid? inboxId = null;
            //var response = instance.GetAllMissedEmails(page, size, sort, searchFilter, since, before, inboxId);
            //Assert.IsType<PageMissedEmailProjection>(response);
        }

        /// <summary>
        /// Test GetAllUnknownMissedEmails
        /// </summary>
        [Fact]
        public void GetAllUnknownMissedEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? size = null;
            //string sort = null;
            //string searchFilter = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //Guid? inboxId = null;
            //var response = instance.GetAllUnknownMissedEmails(page, size, sort, searchFilter, since, before, inboxId);
            //Assert.IsType<PageUnknownMissedEmailProjection>(response);
        }

        /// <summary>
        /// Test GetMissedEmail
        /// </summary>
        [Fact]
        public void GetMissedEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid missedEmailId = null;
            //var response = instance.GetMissedEmail(missedEmailId);
            //Assert.IsType<MissedEmailDto>(response);
        }

        /// <summary>
        /// Test RestoreMissedEmails
        /// </summary>
        [Fact]
        public void RestoreMissedEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.RestoreMissedEmails();
        }

        /// <summary>
        /// Test WaitForNthMissedEmail
        /// </summary>
        [Fact]
        public void WaitForNthMissedEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int index = null;
            //Guid? inboxId = null;
            //long? timeout = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.WaitForNthMissedEmail(index, inboxId, timeout, since, before);
            //Assert.IsType<MissedEmailDto>(response);
        }
    }
}
