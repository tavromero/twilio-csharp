/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account
{

    /// <summary>
    /// Create a new outgoing call to phones, SIP-enabled endpoints or Twilio Client connections
    /// </summary>
    public class CreateCallOptions : IOptions<CallResource>
    {
        /// <summary>
        /// The SID of the Account that will create the resource
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Phone number, SIP address, or client identifier to call
        /// </summary>
        public IEndpoint To { get; }
        /// <summary>
        /// Twilio number from which to originate the call
        /// </summary>
        public IEndpoint From { get; }
        /// <summary>
        /// The absolute URL that returns TwiML for this call
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// TwiML instructions for the call
        /// </summary>
        public Types.Twiml Twiml { get; set; }
        /// <summary>
        /// The SID of the Application resource that will handle the call
        /// </summary>
        public string ApplicationSid { get; set; }
        /// <summary>
        /// HTTP method to use to fetch TwiML
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Fallback URL in case of error
        /// </summary>
        public Uri FallbackUrl { get; set; }
        /// <summary>
        /// HTTP Method to use with fallback_url
        /// </summary>
        public Twilio.Http.HttpMethod FallbackMethod { get; set; }
        /// <summary>
        /// The URL we should call to send status information to your application
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The call progress events that we send to the `status_callback` URL.
        /// </summary>
        public List<string> StatusCallbackEvent { get; set; }
        /// <summary>
        /// HTTP Method to use with status_callback
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// The digits to dial after connecting to the number
        /// </summary>
        public string SendDigits { get; set; }
        /// <summary>
        /// Number of seconds to wait for an answer
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Whether to record the call
        /// </summary>
        public bool? Record { get; set; }
        /// <summary>
        /// The number of channels in the final recording
        /// </summary>
        public string RecordingChannels { get; set; }
        /// <summary>
        /// The URL that we call when the recording is available to be accessed
        /// </summary>
        public string RecordingStatusCallback { get; set; }
        /// <summary>
        /// The HTTP method we should use when calling the `recording_status_callback` URL
        /// </summary>
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// The username used to authenticate the caller making a SIP call
        /// </summary>
        public string SipAuthUsername { get; set; }
        /// <summary>
        /// The password required to authenticate the user account specified in `sip_auth_username`.
        /// </summary>
        public string SipAuthPassword { get; set; }
        /// <summary>
        /// Enable machine detection or end of greeting detection
        /// </summary>
        public string MachineDetection { get; set; }
        /// <summary>
        /// Number of seconds to wait for machine detection
        /// </summary>
        public int? MachineDetectionTimeout { get; set; }
        /// <summary>
        /// The recording status events that will trigger calls to the URL specified in `recording_status_callback`
        /// </summary>
        public List<string> RecordingStatusCallbackEvent { get; set; }
        /// <summary>
        /// Set this parameter to control trimming of silence on the recording.
        /// </summary>
        public string Trim { get; set; }
        /// <summary>
        /// The phone number, SIP address, or Client identifier that made this call. Phone numbers are in E.164 format (e.g., +16175551212). SIP addresses are formatted as `name@company.com`.
        /// </summary>
        public string CallerId { get; set; }
        /// <summary>
        /// Number of milliseconds for measuring stick for the length of the speech activity
        /// </summary>
        public int? MachineDetectionSpeechThreshold { get; set; }
        /// <summary>
        /// Number of milliseconds of silence after speech activity
        /// </summary>
        public int? MachineDetectionSpeechEndThreshold { get; set; }
        /// <summary>
        /// Number of milliseconds of initial silence
        /// </summary>
        public int? MachineDetectionSilenceTimeout { get; set; }
        /// <summary>
        /// Enable asynchronous AMD
        /// </summary>
        public string AsyncAmd { get; set; }
        /// <summary>
        /// The URL we should call to send amd status information to your application
        /// </summary>
        public Uri AsyncAmdStatusCallback { get; set; }
        /// <summary>
        /// HTTP Method to use with async_amd_status_callback
        /// </summary>
        public Twilio.Http.HttpMethod AsyncAmdStatusCallbackMethod { get; set; }
        /// <summary>
        /// BYOC trunk SID (Beta)
        /// </summary>
        public string Byoc { get; set; }
        /// <summary>
        /// Reason for the call (Branded Calls Beta)
        /// </summary>
        public string CallReason { get; set; }

        /// <summary>
        /// Construct a new CreateCallOptions
        /// </summary>
        /// <param name="to"> Phone number, SIP address, or client identifier to call </param>
        /// <param name="from"> Twilio number from which to originate the call </param>
        public CreateCallOptions(IEndpoint to, IEndpoint from)
        {
            To = to;
            From = from;
            StatusCallbackEvent = new List<string>();
            RecordingStatusCallbackEvent = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }

            if (Url != null)
            {
                p.Add(new KeyValuePair<string, string>("Url", Serializers.Url(Url)));
            }

            if (Twiml != null)
            {
                p.Add(new KeyValuePair<string, string>("Twiml", Twiml.ToString()));
            }

            if (ApplicationSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ApplicationSid", ApplicationSid.ToString()));
            }

            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method.ToString()));
            }

            if (FallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackUrl", Serializers.Url(FallbackUrl)));
            }

            if (FallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackMethod", FallbackMethod.ToString()));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackEvent != null)
            {
                p.AddRange(StatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("StatusCallbackEvent", prop)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (SendDigits != null)
            {
                p.Add(new KeyValuePair<string, string>("SendDigits", SendDigits));
            }

            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.ToString()));
            }

            if (Record != null)
            {
                p.Add(new KeyValuePair<string, string>("Record", Record.Value.ToString().ToLower()));
            }

            if (RecordingChannels != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingChannels", RecordingChannels));
            }

            if (RecordingStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallback", RecordingStatusCallback));
            }

            if (RecordingStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("RecordingStatusCallbackMethod", RecordingStatusCallbackMethod.ToString()));
            }

            if (SipAuthUsername != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthUsername", SipAuthUsername));
            }

            if (SipAuthPassword != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthPassword", SipAuthPassword));
            }

            if (MachineDetection != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetection", MachineDetection));
            }

            if (MachineDetectionTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionTimeout", MachineDetectionTimeout.ToString()));
            }

            if (RecordingStatusCallbackEvent != null)
            {
                p.AddRange(RecordingStatusCallbackEvent.Select(prop => new KeyValuePair<string, string>("RecordingStatusCallbackEvent", prop)));
            }

            if (Trim != null)
            {
                p.Add(new KeyValuePair<string, string>("Trim", Trim));
            }

            if (CallerId != null)
            {
                p.Add(new KeyValuePair<string, string>("CallerId", CallerId));
            }

            if (MachineDetectionSpeechThreshold != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionSpeechThreshold", MachineDetectionSpeechThreshold.ToString()));
            }

            if (MachineDetectionSpeechEndThreshold != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionSpeechEndThreshold", MachineDetectionSpeechEndThreshold.ToString()));
            }

            if (MachineDetectionSilenceTimeout != null)
            {
                p.Add(new KeyValuePair<string, string>("MachineDetectionSilenceTimeout", MachineDetectionSilenceTimeout.ToString()));
            }

            if (AsyncAmd != null)
            {
                p.Add(new KeyValuePair<string, string>("AsyncAmd", AsyncAmd));
            }

            if (AsyncAmdStatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("AsyncAmdStatusCallback", Serializers.Url(AsyncAmdStatusCallback)));
            }

            if (AsyncAmdStatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("AsyncAmdStatusCallbackMethod", AsyncAmdStatusCallbackMethod.ToString()));
            }

            if (Byoc != null)
            {
                p.Add(new KeyValuePair<string, string>("Byoc", Byoc.ToString()));
            }

            if (CallReason != null)
            {
                p.Add(new KeyValuePair<string, string>("CallReason", CallReason));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete a Call record from your account. Once the record is deleted, it will no longer appear in the API and Account
    /// Portal logs.
    /// </summary>
    public class DeleteCallOptions : IOptions<CallResource>
    {
        /// <summary>
        /// The SID of the Account that created the resource(s) to delete
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies this resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteCallOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        public DeleteCallOptions(string pathSid)
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
    /// Fetch the call specified by the provided Call SID
    /// </summary>
    public class FetchCallOptions : IOptions<CallResource>
    {
        /// <summary>
        /// The SID of the Account that created the resource(s) to fetch
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The SID of the Call resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchCallOptions
        /// </summary>
        /// <param name="pathSid"> The SID of the Call resource to fetch </param>
        public FetchCallOptions(string pathSid)
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
    /// Retrieves a collection of calls made to and from your account
    /// </summary>
    public class ReadCallOptions : ReadOptions<CallResource>
    {
        /// <summary>
        /// The SID of the Account that created the resource(s) to read
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Phone number or Client identifier of calls to include
        /// </summary>
        public Types.PhoneNumber To { get; set; }
        /// <summary>
        /// Phone number or Client identifier to filter `from` on
        /// </summary>
        public Types.PhoneNumber From { get; set; }
        /// <summary>
        /// Parent call SID to filter on
        /// </summary>
        public string ParentCallSid { get; set; }
        /// <summary>
        /// The status of the resources to read
        /// </summary>
        public CallResource.StatusEnum Status { get; set; }
        /// <summary>
        /// Only include calls that started on this date
        /// </summary>
        public DateTime? StartTimeBefore { get; set; }
        /// <summary>
        /// Only include calls that started on this date
        /// </summary>
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// Only include calls that started on this date
        /// </summary>
        public DateTime? StartTimeAfter { get; set; }
        /// <summary>
        /// Only include calls that ended on this date
        /// </summary>
        public DateTime? EndTimeBefore { get; set; }
        /// <summary>
        /// Only include calls that ended on this date
        /// </summary>
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Only include calls that ended on this date
        /// </summary>
        public DateTime? EndTimeAfter { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To.ToString()));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From.ToString()));
            }

            if (ParentCallSid != null)
            {
                p.Add(new KeyValuePair<string, string>("ParentCallSid", ParentCallSid.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (StartTime != null)
            {
                p.Add(new KeyValuePair<string, string>("StartTime", Serializers.DateTimeIso8601(StartTime)));
            }
            else
            {
                if (StartTimeBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("StartTime<", Serializers.DateTimeIso8601(StartTimeBefore)));
                }

                if (StartTimeAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("StartTime>", Serializers.DateTimeIso8601(StartTimeAfter)));
                }
            }

            if (EndTime != null)
            {
                p.Add(new KeyValuePair<string, string>("EndTime", Serializers.DateTimeIso8601(EndTime)));
            }
            else
            {
                if (EndTimeBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("EndTime<", Serializers.DateTimeIso8601(EndTimeBefore)));
                }

                if (EndTimeAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("EndTime>", Serializers.DateTimeIso8601(EndTimeAfter)));
                }
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Initiates a call redirect or terminates a call
    /// </summary>
    public class UpdateCallOptions : IOptions<CallResource>
    {
        /// <summary>
        /// The SID of the Account that created the resource(s) to update
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The unique string that identifies this resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The absolute URL that returns TwiML for this call
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// HTTP method to use to fetch TwiML
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// The new status to update the call with.
        /// </summary>
        public CallResource.UpdateStatusEnum Status { get; set; }
        /// <summary>
        /// Fallback URL in case of error
        /// </summary>
        public Uri FallbackUrl { get; set; }
        /// <summary>
        /// HTTP Method to use with fallback_url
        /// </summary>
        public Twilio.Http.HttpMethod FallbackMethod { get; set; }
        /// <summary>
        /// The URL we should call to send status information to your application
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// HTTP Method to use to call status_callback
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// TwiML instructions for the call
        /// </summary>
        public Types.Twiml Twiml { get; set; }

        /// <summary>
        /// Construct a new UpdateCallOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies this resource </param>
        public UpdateCallOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Url != null)
            {
                p.Add(new KeyValuePair<string, string>("Url", Serializers.Url(Url)));
            }

            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (FallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackUrl", Serializers.Url(FallbackUrl)));
            }

            if (FallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("FallbackMethod", FallbackMethod.ToString()));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (Twiml != null)
            {
                p.Add(new KeyValuePair<string, string>("Twiml", Twiml.ToString()));
            }

            return p;
        }
    }

}