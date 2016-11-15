using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.Sync.Service 
{

    public class SyncListFetcher : Fetcher<SyncListResource> 
    {
        public string ServiceSid { get; }
        public string Sid { get; }
    
        /// <summary>
        /// Construct a new SyncListFetcher
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        /// <param name="sid"> The sid </param>
        public SyncListFetcher(string serviceSid, string sid)
        {
            ServiceSid = serviceSid;
            Sid = sid;
        }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the fetch
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Fetched SyncListResource </returns> 
        public override async System.Threading.Tasks.Task<SyncListResource> FetchAsync(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.GET,
                Domains.Preview,
                "/Sync/Services/" + ServiceSid + "/Lists/" + Sid + ""
            );
            
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("SyncListResource fetch failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to fetch record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return SyncListResource.FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the fetch
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Fetched SyncListResource </returns> 
        public override SyncListResource Fetch(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.GET,
                Domains.Preview,
                "/Sync/Services/" + ServiceSid + "/Lists/" + Sid + ""
            );
            
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("SyncListResource fetch failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to fetch record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return SyncListResource.FromJson(response.Content);
        }
    }
}