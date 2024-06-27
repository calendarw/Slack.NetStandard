﻿using System;
using System.Text;
using Newtonsoft.Json;

namespace Slack.NetStandard.Messages.Elements
{
    public class Option:IOption
    {
        [JsonProperty("text")]
        public TextObject Text { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("url",NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("description",NullValueHandling = NullValueHandling.Ignore)]
        public TextObject Description { get; set; }
    }
}
