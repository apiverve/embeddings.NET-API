using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public double[] data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
