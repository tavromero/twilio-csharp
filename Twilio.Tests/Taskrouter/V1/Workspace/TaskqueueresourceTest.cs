using NSubstitute;
using NUnit.Framework;
using System;
using Twilio;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Taskrouter.V1.Workspace;

namespace Twilio.Tests.Taskrouter.V1.Workspace {

    [TestFixture]
    public class TaskQueueTest : TwilioTest {
        [SetUp]
        public void SetUp() {
        }
    
        [Test]
        public async void TestFetchRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(System.Net.Http.HttpMethod.Get,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues/WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            
            
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.OK, null));
            
            try {
                var task = TaskQueueResource.Fetch("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").ExecuteAsync(twilioRestClient);
            task.Wait();
                Assert.Fail("Expected TwilioException to be thrown for 500");
            } catch (TwilioException e) {}
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestFetchResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                     "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assignment_activity_name\": \"817ca1c5-3a05-11e5-9292-98e0d9a1eb73\",\"assignment_activity_sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-08-03T17:31:41Z\",\"date_updated\": \"2015-08-03T17:31:41Z\",\"friendly_name\": \"81f96435-3a05-11e5-9f81-98e0d9a1eb73\",\"max_reserved_workers\": 1,\"links\": {\"assignment_activity\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Activities/WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"reservation_activity\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Activities/WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},\"reservation_activity_name\": \"80fa2beb-3a05-11e5-8fc8-98e0d9a1eb73\",\"reservation_activity_sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"target_workers\": null,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues/WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"));
            
            var task = TaskQueueResource.Fetch("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").ExecuteAsync(twilioRestClient);
            task.Wait();
            Assert.NotNull(task.Result);
        }
    
        [Test]
        public async void TestUpdateRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(System.Net.Http.HttpMethod.Post,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues/WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            
            
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.OK, null));
            
            try {
                var task = TaskQueueResource.Update("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").ExecuteAsync(twilioRestClient);
            task.Wait();
                Assert.Fail("Expected TwilioException to be thrown for 500");
            } catch (TwilioException e) {}
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestUpdateResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                     "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assignment_activity_name\": \"817ca1c5-3a05-11e5-9292-98e0d9a1eb73\",\"assignment_activity_sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-08-03T17:31:41Z\",\"date_updated\": \"2015-08-03T17:31:41Z\",\"friendly_name\": \"81f96435-3a05-11e5-9f81-98e0d9a1eb73\",\"max_reserved_workers\": 1,\"links\": {\"assignment_activity\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Activities/WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"reservation_activity\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Activities/WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},\"reservation_activity_name\": \"80fa2beb-3a05-11e5-8fc8-98e0d9a1eb73\",\"reservation_activity_sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"target_workers\": null,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues/WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"));
            
            var task = TaskQueueResource.Update("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").ExecuteAsync(twilioRestClient);
            task.Wait();
        }
    
        [Test]
        public async void TestReadRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(System.Net.Http.HttpMethod.Get,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues");
            
            request.AddQueryParam("PageSize", "50");
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.OK, null));
            
            try {
                var task = TaskQueueResource.Read("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").ExecuteAsync(twilioRestClient);
            task.Wait();
                Assert.Fail("Expected TwilioException to be thrown for 500");
            } catch (TwilioException e) {}
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestReadFullResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                     "{\"meta\": {\"first_page_url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues?PageSize=50&Page=0\",\"key\": \"task_queues\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues?PageSize=50&Page=0\"},\"task_queues\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assignment_activity_name\": \"817ca1c5-3a05-11e5-9292-98e0d9a1eb73\",\"assignment_activity_sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-08-03T17:31:41Z\",\"date_updated\": \"2015-08-03T17:31:41Z\",\"friendly_name\": \"81f96435-3a05-11e5-9f81-98e0d9a1eb73\",\"max_reserved_workers\": 1,\"links\": {\"assignment_activity\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Activities/WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"reservation_activity\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Activities/WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},\"reservation_activity_name\": \"80fa2beb-3a05-11e5-8fc8-98e0d9a1eb73\",\"reservation_activity_sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"target_workers\": null,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues/WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"));
            
            var task = TaskQueueResource.Read("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").ExecuteAsync(twilioRestClient);
            task.Wait();
            Assert.NotNull(task.Result);
        }
    
        [Test]
        public void TestReadEmptyResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.OK,
                                     "{\"meta\": {\"first_page_url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues?PageSize=50&Page=0\",\"key\": \"task_queues\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues?PageSize=50&Page=0\"},\"task_queues\": []}"));
            
            var task = TaskQueueResource.Read("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").ExecuteAsync(twilioRestClient);
            task.Wait();
            Assert.NotNull(task.Result);
        }
    
        [Test]
        public async void TestCreateRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
                        Request request = new Request(System.Net.Http.HttpMethod.Post,
                                                      Domains.TASKROUTER,
                                                      "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues");
                        request.AddPostParam("FriendlyName", Serialize("friendlyName"));
            request.AddPostParam("ReservationActivitySid", Serialize("WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            request.AddPostParam("AssignmentActivitySid", Serialize("WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
                        
                        twilioRestClient.Request(request)
                                        .Returns(new Response(System.Net.HttpStatusCode.OK, null));
            
            try {
                var task = TaskQueueResource.Create("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "friendlyName", "WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").ExecuteAsync(twilioRestClient);
            task.Wait();
                Assert.Fail("Expected TwilioException to be thrown for 500");
            } catch (TwilioException e) {}
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestCreateResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.Created,
                                     "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"assignment_activity_name\": \"817ca1c5-3a05-11e5-9292-98e0d9a1eb73\",\"assignment_activity_sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-08-03T17:31:41Z\",\"date_updated\": \"2015-08-03T17:31:41Z\",\"friendly_name\": \"81f96435-3a05-11e5-9f81-98e0d9a1eb73\",\"max_reserved_workers\": 1,\"links\": {\"assignment_activity\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Activities/WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"reservation_activity\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Activities/WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"},\"reservation_activity_name\": \"80fa2beb-3a05-11e5-8fc8-98e0d9a1eb73\",\"reservation_activity_sid\": \"WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"target_workers\": null,\"url\": \"https://taskrouter.twilio.com/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues/WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"workspace_sid\": \"WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"));
            
            var task = TaskQueueResource.Create("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "friendlyName", "WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").ExecuteAsync(twilioRestClient);
            task.Wait();
        }
    
        [Test]
        public async void TestDeleteRequest() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            Request request = new Request(System.Net.Http.HttpMethod.Delete,
                                          Domains.TASKROUTER,
                                          "/v1/Workspaces/WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/TaskQueues/WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            
            
            twilioRestClient.Request(request)
                            .Returns(new Response(System.Net.HttpStatusCode.OK, null));
            
            try {
                var task = TaskQueueResource.Delete("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").ExecuteAsync(twilioRestClient);
            task.Wait();
                Assert.Fail("Expected TwilioException to be thrown for 500");
            } catch (TwilioException e) {}
            twilioRestClient.Received().Request(request);
        }
    
        [Test]
        public void TestDeleteResponse() {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(System.Net.HttpStatusCode.NoContent,
                                     "null"));
            
            var task = TaskQueueResource.Delete("WSaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "WQaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa").ExecuteAsync(twilioRestClient);
            task.Wait();
        }
    }
}