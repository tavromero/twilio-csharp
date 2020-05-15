/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Supersim.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// CreateNetworkAccessProfileOptions
    /// </summary>
    public class CreateNetworkAccessProfileOptions : IOptions<NetworkAccessProfileResource>
    {
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The networks
        /// </summary>
        public List<string> Networks { get; set; }

        /// <summary>
        /// Construct a new CreateNetworkAccessProfileOptions
        /// </summary>
        public CreateNetworkAccessProfileOptions()
        {
            Networks = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (Networks != null)
            {
                p.AddRange(Networks.Select(prop => new KeyValuePair<string, string>("Networks", prop.ToString())));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// FetchNetworkAccessProfileOptions
    /// </summary>
    public class FetchNetworkAccessProfileOptions : IOptions<NetworkAccessProfileResource>
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchNetworkAccessProfileOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public FetchNetworkAccessProfileOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// UpdateNetworkAccessProfileOptions
    /// </summary>
    public class UpdateNetworkAccessProfileOptions : IOptions<NetworkAccessProfileResource>
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; set; }

        /// <summary>
        /// Construct a new UpdateNetworkAccessProfileOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public UpdateNetworkAccessProfileOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// ReadNetworkAccessProfileOptions
    /// </summary>
    public class ReadNetworkAccessProfileOptions : ReadOptions<NetworkAccessProfileResource>
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}