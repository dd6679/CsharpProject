﻿using Newtonsoft.Json;

namespace VMS.Client2.Net
{
    public class StreamInfo
    {
        [JsonProperty("cmd")]
        public int Cmd { get; set; }

        [JsonProperty("val")]
        public int Value { get; set; }

        [JsonProperty("dch_ch")]
        public int DchCh { get; set; }

        [JsonProperty("dev_serial")]

        public int DevSerial { get; set; }
        [JsonProperty("dchm_serial")]

        public int DchmSerial { get; set; }
        [JsonProperty("size")]

        public int Size { get; set; }
        [JsonProperty("type")]
        public StreamTypes SteamType { get; set; }

        [JsonProperty("vms_id")]
        public int VmsId { get; set; }

        [JsonProperty("vop")]
        public FrameTypes FrameType { get; set; }
    }
}
