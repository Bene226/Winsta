﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace InstaSharper.Classes.Models
{
    public class InstaStorySharing
    {
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("status_code")]
        public string StatusCode { get; set; }
        [JsonProperty("payload")]
        public InstaStorySharingPayload[] Payload { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InstaStorySharingPayload
    {
        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }
        [JsonProperty("item_id")]
        public string ItemId { get; set; }
        [JsonProperty("participant_ids")]
        public long[] ParticipantIds { get; set; }
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        [JsonProperty("client_context")]
        public object ClientContext { get; set; }
        [JsonProperty("canonical")]
        public bool Cnonical { get; set; }
    }

}
