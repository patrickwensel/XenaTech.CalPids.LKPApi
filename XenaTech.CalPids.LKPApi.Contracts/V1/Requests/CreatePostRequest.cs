﻿using System.Collections.Generic;

namespace XenaTech.CalPids.LKPApi.Contracts.V1.Requests
{
    public class CreatePostRequest
    {
        public string Name { get; set; }

        public IEnumerable<string> Tags { get; set; }
    }
}