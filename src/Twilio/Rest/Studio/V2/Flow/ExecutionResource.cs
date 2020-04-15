/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// ExecutionResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Studio.V2.Flow
{

    public class ExecutionResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Active = new StatusEnum("active");
            public static readonly StatusEnum Ended = new StatusEnum("ended");
        }

        private static Request BuildReadRequest(ReadExecutionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                "/v2/Flows/" + options.PathFlowSid + "/Executions",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Executions for the Flow.
        /// </summary>
        /// <param name="options"> Read Execution parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Execution </returns>
        public static ResourceSet<ExecutionResource> Read(ReadExecutionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ExecutionResource>.FromJson("executions", response.Content);
            return new ResourceSet<ExecutionResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Executions for the Flow.
        /// </summary>
        /// <param name="options"> Read Execution parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Execution </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ExecutionResource>> ReadAsync(ReadExecutionOptions options,
                                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ExecutionResource>.FromJson("executions", response.Content);
            return new ResourceSet<ExecutionResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Executions for the Flow.
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="dateCreatedFrom"> Only show Executions that started on or after this ISO 8601 date-time </param>
        /// <param name="dateCreatedTo"> Only show Executions that started before this ISO 8601 date-time </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Execution </returns>
        public static ResourceSet<ExecutionResource> Read(string pathFlowSid,
                                                          DateTime? dateCreatedFrom = null,
                                                          DateTime? dateCreatedTo = null,
                                                          int? pageSize = null,
                                                          long? limit = null,
                                                          ITwilioRestClient client = null)
        {
            var options = new ReadExecutionOptions(pathFlowSid){DateCreatedFrom = dateCreatedFrom, DateCreatedTo = dateCreatedTo, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Executions for the Flow.
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="dateCreatedFrom"> Only show Executions that started on or after this ISO 8601 date-time </param>
        /// <param name="dateCreatedTo"> Only show Executions that started before this ISO 8601 date-time </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Execution </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<ExecutionResource>> ReadAsync(string pathFlowSid,
                                                                                                  DateTime? dateCreatedFrom = null,
                                                                                                  DateTime? dateCreatedTo = null,
                                                                                                  int? pageSize = null,
                                                                                                  long? limit = null,
                                                                                                  ITwilioRestClient client = null)
        {
            var options = new ReadExecutionOptions(pathFlowSid){DateCreatedFrom = dateCreatedFrom, DateCreatedTo = dateCreatedTo, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<ExecutionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ExecutionResource>.FromJson("executions", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<ExecutionResource> NextPage(Page<ExecutionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Studio,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ExecutionResource>.FromJson("executions", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<ExecutionResource> PreviousPage(Page<ExecutionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Studio,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ExecutionResource>.FromJson("executions", response.Content);
        }

        private static Request BuildFetchRequest(FetchExecutionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Studio,
                "/v2/Flows/" + options.PathFlowSid + "/Executions/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve an Execution
        /// </summary>
        /// <param name="options"> Fetch Execution parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Execution </returns>
        public static ExecutionResource Fetch(FetchExecutionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve an Execution
        /// </summary>
        /// <param name="options"> Fetch Execution parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Execution </returns>
        public static async System.Threading.Tasks.Task<ExecutionResource> FetchAsync(FetchExecutionOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve an Execution
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathSid"> The SID of the Execution resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Execution </returns>
        public static ExecutionResource Fetch(string pathFlowSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchExecutionOptions(pathFlowSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve an Execution
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathSid"> The SID of the Execution resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Execution </returns>
        public static async System.Threading.Tasks.Task<ExecutionResource> FetchAsync(string pathFlowSid,
                                                                                      string pathSid,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new FetchExecutionOptions(pathFlowSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateExecutionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Studio,
                "/v2/Flows/" + options.PathFlowSid + "/Executions",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Triggers a new Execution for the Flow
        /// </summary>
        /// <param name="options"> Create Execution parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Execution </returns>
        public static ExecutionResource Create(CreateExecutionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Triggers a new Execution for the Flow
        /// </summary>
        /// <param name="options"> Create Execution parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Execution </returns>
        public static async System.Threading.Tasks.Task<ExecutionResource> CreateAsync(CreateExecutionOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Triggers a new Execution for the Flow
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="to"> The Contact phone number to start a Studio Flow Execution </param>
        /// <param name="from"> The Twilio phone number to send messages or initiate calls from during the Flow Execution
        ///            </param>
        /// <param name="parameters"> JSON data that will be added to the Flow's context </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Execution </returns>
        public static ExecutionResource Create(string pathFlowSid,
                                               Types.PhoneNumber to,
                                               Types.PhoneNumber from,
                                               object parameters = null,
                                               ITwilioRestClient client = null)
        {
            var options = new CreateExecutionOptions(pathFlowSid, to, from){Parameters = parameters};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Triggers a new Execution for the Flow
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="to"> The Contact phone number to start a Studio Flow Execution </param>
        /// <param name="from"> The Twilio phone number to send messages or initiate calls from during the Flow Execution
        ///            </param>
        /// <param name="parameters"> JSON data that will be added to the Flow's context </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Execution </returns>
        public static async System.Threading.Tasks.Task<ExecutionResource> CreateAsync(string pathFlowSid,
                                                                                       Types.PhoneNumber to,
                                                                                       Types.PhoneNumber from,
                                                                                       object parameters = null,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new CreateExecutionOptions(pathFlowSid, to, from){Parameters = parameters};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteExecutionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Studio,
                "/v2/Flows/" + options.PathFlowSid + "/Executions/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete the Execution and all Steps relating to it.
        /// </summary>
        /// <param name="options"> Delete Execution parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Execution </returns>
        public static bool Delete(DeleteExecutionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete the Execution and all Steps relating to it.
        /// </summary>
        /// <param name="options"> Delete Execution parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Execution </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteExecutionOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete the Execution and all Steps relating to it.
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathSid"> The SID of the Execution resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Execution </returns>
        public static bool Delete(string pathFlowSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteExecutionOptions(pathFlowSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete the Execution and all Steps relating to it.
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathSid"> The SID of the Execution resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Execution </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathFlowSid,
                                                                          string pathSid,
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteExecutionOptions(pathFlowSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateExecutionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Studio,
                "/v2/Flows/" + options.PathFlowSid + "/Executions/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update the status of an Execution to `ended`.
        /// </summary>
        /// <param name="options"> Update Execution parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Execution </returns>
        public static ExecutionResource Update(UpdateExecutionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update the status of an Execution to `ended`.
        /// </summary>
        /// <param name="options"> Update Execution parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Execution </returns>
        public static async System.Threading.Tasks.Task<ExecutionResource> UpdateAsync(UpdateExecutionOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update the status of an Execution to `ended`.
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathSid"> The SID of the Execution resource to update </param>
        /// <param name="status"> The status of the Execution </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Execution </returns>
        public static ExecutionResource Update(string pathFlowSid,
                                               string pathSid,
                                               ExecutionResource.StatusEnum status,
                                               ITwilioRestClient client = null)
        {
            var options = new UpdateExecutionOptions(pathFlowSid, pathSid, status);
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update the status of an Execution to `ended`.
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathSid"> The SID of the Execution resource to update </param>
        /// <param name="status"> The status of the Execution </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Execution </returns>
        public static async System.Threading.Tasks.Task<ExecutionResource> UpdateAsync(string pathFlowSid,
                                                                                       string pathSid,
                                                                                       ExecutionResource.StatusEnum status,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new UpdateExecutionOptions(pathFlowSid, pathSid, status);
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ExecutionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ExecutionResource object represented by the provided JSON </returns>
        public static ExecutionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ExecutionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The SID of the Flow
        /// </summary>
        [JsonProperty("flow_sid")]
        public string FlowSid { get; private set; }
        /// <summary>
        /// The phone number, SIP address or Client identifier that triggered the Execution
        /// </summary>
        [JsonProperty("contact_channel_address")]
        public string ContactChannelAddress { get; private set; }
        /// <summary>
        /// The current state of the flow
        /// </summary>
        [JsonProperty("context")]
        public object Context { get; private set; }
        /// <summary>
        /// The status of the Execution
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ExecutionResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The absolute URL of the resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Nested resource URLs
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private ExecutionResource()
        {

        }
    }

}