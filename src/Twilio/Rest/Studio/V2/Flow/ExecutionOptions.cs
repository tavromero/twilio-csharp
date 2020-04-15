/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Studio.V2.Flow
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Retrieve a list of all Executions for the Flow.
    /// </summary>
    public class ReadExecutionOptions : ReadOptions<ExecutionResource>
    {
        /// <summary>
        /// The SID of the Flow
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// Only show Executions that started on or after this ISO 8601 date-time
        /// </summary>
        public DateTime? DateCreatedFrom { get; set; }
        /// <summary>
        /// Only show Executions that started before this ISO 8601 date-time
        /// </summary>
        public DateTime? DateCreatedTo { get; set; }

        /// <summary>
        /// Construct a new ReadExecutionOptions
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        public ReadExecutionOptions(string pathFlowSid)
        {
            PathFlowSid = pathFlowSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DateCreatedFrom != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedFrom", Serializers.DateTimeIso8601(DateCreatedFrom)));
            }

            if (DateCreatedTo != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedTo", Serializers.DateTimeIso8601(DateCreatedTo)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Retrieve an Execution
    /// </summary>
    public class FetchExecutionOptions : IOptions<ExecutionResource>
    {
        /// <summary>
        /// The SID of the Flow
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The SID of the Execution resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchExecutionOptions
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathSid"> The SID of the Execution resource to fetch </param>
        public FetchExecutionOptions(string pathFlowSid, string pathSid)
        {
            PathFlowSid = pathFlowSid;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Triggers a new Execution for the Flow
    /// </summary>
    public class CreateExecutionOptions : IOptions<ExecutionResource>
    {
        /// <summary>
        /// The SID of the Flow
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The Contact phone number to start a Studio Flow Execution
        /// </summary>
        public Types.PhoneNumber To { get; }
        /// <summary>
        /// The Twilio phone number to send messages or initiate calls from during the Flow Execution
        /// </summary>
        public Types.PhoneNumber From { get; }
        /// <summary>
        /// JSON data that will be added to the Flow's context
        /// </summary>
        public object Parameters { get; set; }

        /// <summary>
        /// Construct a new CreateExecutionOptions
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="to"> The Contact phone number to start a Studio Flow Execution </param>
        /// <param name="from"> The Twilio phone number to send messages or initiate calls from during the Flow Execution
        ///            </param>
        public CreateExecutionOptions(string pathFlowSid, Types.PhoneNumber to, Types.PhoneNumber from)
        {
            PathFlowSid = pathFlowSid;
            To = to;
            From = from;
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

            if (Parameters != null)
            {
                p.Add(new KeyValuePair<string, string>("Parameters", Serializers.JsonObject(Parameters)));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Delete the Execution and all Steps relating to it.
    /// </summary>
    public class DeleteExecutionOptions : IOptions<ExecutionResource>
    {
        /// <summary>
        /// The SID of the Flow
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The SID of the Execution resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteExecutionOptions
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathSid"> The SID of the Execution resource to delete </param>
        public DeleteExecutionOptions(string pathFlowSid, string pathSid)
        {
            PathFlowSid = pathFlowSid;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Update the status of an Execution to `ended`.
    /// </summary>
    public class UpdateExecutionOptions : IOptions<ExecutionResource>
    {
        /// <summary>
        /// The SID of the Flow
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// The SID of the Execution resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The status of the Execution
        /// </summary>
        public ExecutionResource.StatusEnum Status { get; }

        /// <summary>
        /// Construct a new UpdateExecutionOptions
        /// </summary>
        /// <param name="pathFlowSid"> The SID of the Flow </param>
        /// <param name="pathSid"> The SID of the Execution resource to update </param>
        /// <param name="status"> The status of the Execution </param>
        public UpdateExecutionOptions(string pathFlowSid, string pathSid, ExecutionResource.StatusEnum status)
        {
            PathFlowSid = pathFlowSid;
            PathSid = pathSid;
            Status = status;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            return p;
        }
    }

}