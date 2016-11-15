using Newtonsoft.Json;
using System;
using Twilio.Base;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Conference 
{

    public class ParticipantResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
        
            public static StatusEnum Queued = new StatusEnum("queued");
            public static StatusEnum Connecting = new StatusEnum("connecting");
            public static StatusEnum Ringing = new StatusEnum("ringing");
            public static StatusEnum Connected = new StatusEnum("connected");
            public static StatusEnum Complete = new StatusEnum("complete");
            public static StatusEnum Failed = new StatusEnum("failed");
        }
    
        public sealed class BeepEnum : StringEnum 
        {
            private BeepEnum(string value) : base(value) {}
            public BeepEnum() {}
        
            public static BeepEnum True = new BeepEnum("true");
            public static BeepEnum False = new BeepEnum("false");
            public static BeepEnum Onenter = new BeepEnum("onEnter");
            public static BeepEnum Onexit = new BeepEnum("onExit");
        }
    
        public sealed class ConferenceRecordEnum : StringEnum 
        {
            private ConferenceRecordEnum(string value) : base(value) {}
            public ConferenceRecordEnum() {}
        
            public static ConferenceRecordEnum DoNotRecord = new ConferenceRecordEnum("do-not-record");
            public static ConferenceRecordEnum RecordFromStart = new ConferenceRecordEnum("record-from-start");
        }
    
        /// <summary>
        /// Fetch an instance of a participant
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="callSid"> The call_sid </param>
        /// <returns> ParticipantFetcher capable of executing the fetch </returns> 
        public static ParticipantFetcher Fetcher(string conferenceSid, string callSid)
        {
            return new ParticipantFetcher(conferenceSid, callSid);
        }
    
        /// <summary>
        /// Update the properties of this participant
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="callSid"> The call_sid </param>
        /// <returns> ParticipantUpdater capable of executing the update </returns> 
        public static ParticipantUpdater Updater(string conferenceSid, string callSid)
        {
            return new ParticipantUpdater(conferenceSid, callSid);
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="conferenceSid"> The conference_sid </param>
        /// <param name="from"> The from </param>
        /// <param name="to"> The to </param>
        /// <returns> ParticipantCreator capable of executing the create </returns> 
        public static ParticipantCreator Creator(string conferenceSid, Types.PhoneNumber from, Types.PhoneNumber to)
        {
            return new ParticipantCreator(conferenceSid, from, to);
        }
    
        /// <summary>
        /// Kick a participant from a given conference
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="callSid"> The call_sid </param>
        /// <returns> ParticipantDeleter capable of executing the delete </returns> 
        public static ParticipantDeleter Deleter(string conferenceSid, string callSid)
        {
            return new ParticipantDeleter(conferenceSid, callSid);
        }
    
        /// <summary>
        /// Retrieve a list of participants belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <returns> ParticipantReader capable of executing the read </returns> 
        public static ParticipantReader Reader(string conferenceSid)
        {
            return new ParticipantReader(conferenceSid);
        }
    
        /// <summary>
        /// Converts a JSON string into a ParticipantResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ParticipantResource object represented by the provided JSON </returns> 
        public static ParticipantResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ParticipantResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        public string AccountSid { get; set; }
        [JsonProperty("call_sid")]
        public string CallSid { get; set; }
        [JsonProperty("conference_sid")]
        public string ConferenceSid { get; set; }
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; set; }
        [JsonProperty("end_conference_on_exit")]
        public bool? EndConferenceOnExit { get; set; }
        [JsonProperty("muted")]
        public bool? Muted { get; set; }
        [JsonProperty("hold")]
        public bool? Hold { get; set; }
        [JsonProperty("start_conference_on_enter")]
        public bool? StartConferenceOnEnter { get; set; }
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ParticipantResource.StatusEnum Status { get; set; }
        [JsonProperty("uri")]
        public string Uri { get; set; }
    
        public ParticipantResource()
        {
        
        }
    
        private ParticipantResource([JsonProperty("account_sid")]
                                    string accountSid, 
                                    [JsonProperty("call_sid")]
                                    string callSid, 
                                    [JsonProperty("conference_sid")]
                                    string conferenceSid, 
                                    [JsonProperty("date_created")]
                                    string dateCreated, 
                                    [JsonProperty("date_updated")]
                                    string dateUpdated, 
                                    [JsonProperty("end_conference_on_exit")]
                                    bool? endConferenceOnExit, 
                                    [JsonProperty("muted")]
                                    bool? muted, 
                                    [JsonProperty("hold")]
                                    bool? hold, 
                                    [JsonProperty("start_conference_on_enter")]
                                    bool? startConferenceOnEnter, 
                                    [JsonProperty("status")]
                                    ParticipantResource.StatusEnum status, 
                                    [JsonProperty("uri")]
                                    string uri)
                                    {
            AccountSid = accountSid;
            CallSid = callSid;
            ConferenceSid = conferenceSid;
            DateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            DateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            EndConferenceOnExit = endConferenceOnExit;
            Muted = muted;
            Hold = hold;
            StartConferenceOnEnter = startConferenceOnEnter;
            Status = status;
            Uri = uri;
        }
    }
}