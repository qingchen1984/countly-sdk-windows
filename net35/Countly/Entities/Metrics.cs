﻿/*
Copyright (c) 2012, 2013, 2014 Countly

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace CountlySDK.Entities
{
    /// <summary>
    /// Holds device-specific info in json-ready format
    /// </summary>
    [DataContractAttribute]
    internal class Metrics
    {
        /// <summary>
        /// Name of the current operating system
        /// </summary>
        [JsonProperty("_os")]
        [DataMemberAttribute]
        public string OS { get; set; }

        /// <summary>
        /// Current operating system version
        /// </summary>
        [JsonProperty("_os_version")]
        [DataMemberAttribute]
        public string OSVersion { get; set; }

        /// <summary>
        /// Local machine name
        /// </summary>
        [JsonProperty("_device")]
        [DataMemberAttribute]
        public string Device { get; set; }

        /// <summary>
        /// Device resolution
        /// </summary>
        [JsonProperty("_resolution")]
        [DataMemberAttribute]
        public string Resolution { get; set; }

        /// <summary>
        /// Application version
        /// </summary>
        [JsonProperty("_app_version")]
        [DataMemberAttribute]
        public string AppVersion { get; set; }

        /// <summary>
        /// Creates Metrics object with provided values
        /// </summary>
        /// <param name="OS">Name of the current operating system</param>
        /// <param name="Device">Current device model</param>
        /// <param name="Resolution">Device resolution</param>
        /// <param name="AppVersion">Application version</param>
        public Metrics(string OS, string OSVersion, string DeviceName, string Resolution, string AppVersion)
        {
            this.OS = OS;
            this.OSVersion = OSVersion;
            this.Device = DeviceName;
            this.Resolution = Resolution;
            this.AppVersion = AppVersion;
        }

        /// <summary>
        /// Serializes object into json
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
