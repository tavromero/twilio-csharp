using System;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account 
{

    public class ShortCodeUpdater : Updater<ShortCodeResource> 
    {
        public string AccountSid { get; set; }
        public string Sid { get; }
        public string FriendlyName { get; set; }
        public string ApiVersion { get; set; }
        public Uri SmsUrl { get; set; }
        public Twilio.Http.HttpMethod SmsMethod { get; set; }
        public Uri SmsFallbackUrl { get; set; }
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }
    
        /// <summary>
        /// Construct a new ShortCodeUpdater
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        public ShortCodeUpdater(string sid)
        {
            Sid = sid;
        }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the update
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Updated ShortCodeResource </returns> 
        public override async System.Threading.Tasks.Task<ShortCodeResource> UpdateAsync(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.POST,
                Domains.Api,
                "/2010-04-01/Accounts/" + (AccountSid ?? client.GetAccountSid()) + "/SMS/ShortCodes/" + Sid + ".json"
            );
            AddPostParams(request);
            
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("ShortCodeResource update failed: Unable to connect to server");
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
                    restException.Message ?? "Unable to update record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return ShortCodeResource.FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the update
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Updated ShortCodeResource </returns> 
        public override ShortCodeResource Update(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.POST,
                Domains.Api,
                "/2010-04-01/Accounts/" + (AccountSid ?? client.GetAccountSid()) + "/SMS/ShortCodes/" + Sid + ".json"
            );
            AddPostParams(request);
            
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("ShortCodeResource update failed: Unable to connect to server");
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
                    restException.Message ?? "Unable to update record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return ShortCodeResource.FromJson(response.Content);
        }
    
        /// <summary>
        /// Add the requested post parameters to the Request
        /// </summary>
        ///
        /// <param name="request"> Request to add post params to </param>
        private void AddPostParams(Request request)
        {
            if (FriendlyName != null)
            {
                request.AddPostParam("FriendlyName", FriendlyName);
            }
            
            if (ApiVersion != null)
            {
                request.AddPostParam("ApiVersion", ApiVersion);
            }
            
            if (SmsUrl != null)
            {
                request.AddPostParam("SmsUrl", SmsUrl.ToString());
            }
            
            if (SmsMethod != null)
            {
                request.AddPostParam("SmsMethod", SmsMethod.ToString());
            }
            
            if (SmsFallbackUrl != null)
            {
                request.AddPostParam("SmsFallbackUrl", SmsFallbackUrl.ToString());
            }
            
            if (SmsFallbackMethod != null)
            {
                request.AddPostParam("SmsFallbackMethod", SmsFallbackMethod.ToString());
            }
        }
    }
}