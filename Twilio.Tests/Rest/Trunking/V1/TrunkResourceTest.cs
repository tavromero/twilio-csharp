using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest;
using Twilio.Rest.Trunking.V1;

namespace Twilio.Tests.Rest.Trunking.V1 
{

    [TestFixture]
    public class TrunkTest : TwilioTest 
    {
        [SetUp]
        public void SetUp()
        {
        }
    
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(HttpMethod.GET,
                                      Domains.Trunking,
                                      "/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.GetAccountSid().Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try
            {
                TrunkResource.Fetcher("TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Fetch(twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (AggregateException ae)
            {
                ae.Handle((e) =>
                {
                    if (e.GetType() != typeof(ApiException))
                    {
                        throw e;
                    }
            
                    return true;
                });
            }
            catch (ApiException)
            {
            }
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.GetAccountSid().Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                                  "{\"sid\": \"TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"domain_name\": \"test.pstn.twilio.com\",\"disaster_recovery_method\": \"POST\",\"disaster_recovery_url\": \"http://disaster-recovery.com\",\"friendly_name\": \"friendly_name\",\"secure\": false,\"recording\": {\"mode\": \"do-not-record\",\"trim\": \"do-not-trim\"},\"auth_type\": \"\",\"auth_type_set\": [],\"date_created\": \"2015-01-02T11:23:45Z\",\"date_updated\": \"2015-01-02T11:23:45Z\",\"url\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"origination_urls\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/OriginationUrls\",\"credential_lists\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/CredentialLists\",\"ip_access_control_lists\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/IpAccessControlLists\",\"phone_numbers\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/PhoneNumbers\"}}"));
            
            var response = TrunkResource.Fetcher("TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Fetch(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(HttpMethod.DELETE,
                                      Domains.Trunking,
                                      "/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.GetAccountSid().Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try
            {
                TrunkResource.Deleter("TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Delete(twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (AggregateException ae)
            {
                ae.Handle((e) =>
                {
                    if (e.GetType() != typeof(ApiException))
                    {
                        throw e;
                    }
            
                    return true;
                });
            }
            catch (ApiException)
            {
            }
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.GetAccountSid().Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.NoContent,
                                                  "null"));
            
            TrunkResource.Deleter("TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Delete(twilioRestClient);
        }
    
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(HttpMethod.POST,
                                      Domains.Trunking,
                                      "/v1/Trunks");
            twilioRestClient.GetAccountSid().Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try
            {
                TrunkResource.Creator().Create(twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (AggregateException ae)
            {
                ae.Handle((e) =>
                {
                    if (e.GetType() != typeof(ApiException))
                    {
                        throw e;
                    }
            
                    return true;
                });
            }
            catch (ApiException)
            {
            }
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.GetAccountSid().Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.Created,
                                                  "{\"sid\": \"TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"domain_name\": \"test.pstn.twilio.com\",\"disaster_recovery_method\": \"POST\",\"disaster_recovery_url\": \"http://disaster-recovery.com\",\"friendly_name\": \"friendly_name\",\"secure\": false,\"recording\": {\"mode\": \"do-not-record\",\"trim\": \"do-not-trim\"},\"auth_type\": \"\",\"auth_type_set\": [],\"date_created\": \"2015-01-02T11:23:45Z\",\"date_updated\": \"2015-01-02T11:23:45Z\",\"url\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"origination_urls\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/OriginationUrls\",\"credential_lists\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/CredentialLists\",\"ip_access_control_lists\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/IpAccessControlLists\",\"phone_numbers\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/PhoneNumbers\"}}"));
            
            var response = TrunkResource.Creator().Create(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(HttpMethod.GET,
                                      Domains.Trunking,
                                      "/v1/Trunks");
            twilioRestClient.GetAccountSid().Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try
            {
                TrunkResource.Reader().Read(twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (AggregateException ae)
            {
                ae.Handle((e) =>
                {
                    if (e.GetType() != typeof(ApiException))
                    {
                        throw e;
                    }
            
                    return true;
                });
            }
            catch (ApiException)
            {
            }
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.GetAccountSid().Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                                  "{\"meta\": {\"first_page_url\": \"https://trunking.twilio.com/v1/Trunks?PageSize=1&Page=0\",\"key\": \"trunks\",\"next_page_url\": null,\"page\": 0,\"page_size\": 1,\"previous_page_url\": null,\"url\": \"https://trunking.twilio.com/v1/Trunks?PageSize=1&Page=0\"},\"trunks\": [{\"sid\": \"TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"domain_name\": \"test.pstn.twilio.com\",\"disaster_recovery_method\": \"POST\",\"disaster_recovery_url\": \"http://disaster-recovery.com\",\"friendly_name\": \"friendly_name\",\"secure\": false,\"recording\": {\"mode\": \"do-not-record\",\"trim\": \"do-not-trim\"},\"auth_type\": \"\",\"auth_type_set\": [],\"date_created\": \"2015-01-02T11:23:45Z\",\"date_updated\": \"2015-01-02T11:23:45Z\",\"url\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"origination_urls\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/OriginationUrls\",\"credential_lists\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/CredentialLists\",\"ip_access_control_lists\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/IpAccessControlLists\",\"phone_numbers\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/PhoneNumbers\"}}]}"));
            
            var response = TrunkResource.Reader().Read(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.GetAccountSid().Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                                  "{\"meta\": {\"first_page_url\": \"https://trunking.twilio.com/v1/Trunks?PageSize=1&Page=0\",\"key\": \"trunks\",\"next_page_url\": null,\"page\": 0,\"page_size\": 1,\"previous_page_url\": null,\"url\": \"https://trunking.twilio.com/v1/Trunks?PageSize=1&Page=0\"},\"trunks\": []}"));
            
            var response = TrunkResource.Reader().Read(twilioRestClient);
            Assert.NotNull(response);
        }
    
        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(HttpMethod.POST,
                                      Domains.Trunking,
                                      "/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.GetAccountSid().Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.InternalServerError,
                                                  "null"));
            
            try
            {
                TrunkResource.Updater("TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Update(twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (AggregateException ae)
            {
                ae.Handle((e) =>
                {
                    if (e.GetType() != typeof(ApiException))
                    {
                        throw e;
                    }
            
                    return true;
                });
            }
            catch (ApiException)
            {
            }
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.GetAccountSid().Returns("ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                                  "{\"sid\": \"TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"domain_name\": \"test.pstn.twilio.com\",\"disaster_recovery_method\": \"GET\",\"disaster_recovery_url\": \"http://updated-recovery.com\",\"friendly_name\": \"updated_name\",\"secure\": true,\"recording\": {\"mode\": \"do-not-record\",\"trim\": \"do-not-trim\"},\"auth_type\": \"\",\"auth_type_set\": [],\"date_created\": \"2015-01-02T11:23:45Z\",\"date_updated\": \"2015-01-02T11:23:45Z\",\"url\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"origination_urls\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/OriginationUrls\",\"credential_lists\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/CredentialLists\",\"ip_access_control_lists\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/IpAccessControlLists\",\"phone_numbers\": \"http://trunking.twilio.com/v1/Trunks/TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/PhoneNumbers\"}}"));
            
            var response = TrunkResource.Updater("TRaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").Update(twilioRestClient);
            Assert.NotNull(response);
        }
    }
}