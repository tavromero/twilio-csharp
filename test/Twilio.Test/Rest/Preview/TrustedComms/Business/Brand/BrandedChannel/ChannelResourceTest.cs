/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Preview.TrustedComms.Business.Brand.BrandedChannel;

namespace Twilio.Tests.Rest.Preview.TrustedComms.Business.Brand.BrandedChannel
{

    [TestFixture]
    public class ChannelTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Preview,
                "/TrustedComms/Businesses/BXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Brands/BZXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/BrandedChannels/BWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Channels",
                ""
            );
            request.AddPostParam("PhoneNumberSid", Serialize("PNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ChannelResource.Create("BXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "BZXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "BWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "PNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"business_sid\": \"BXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"brand_sid\": \"BZaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"branded_channel_sid\": \"BWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"phone_number_sid\": \"PNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"phone_number\": \"+15000000000\",\"url\": \"https://preview.twilio.com/TrustedComms/Businesses/BXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Brands/BZaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/BrandedChannels/BWaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Channels\"}"
                                     ));

            var response = ChannelResource.Create("BXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "BZXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "BWXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "PNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}