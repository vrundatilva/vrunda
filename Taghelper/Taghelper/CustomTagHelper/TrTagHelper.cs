﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taghelper.CustomTagHelper
{
    [HtmlTargetElement("tr", ParentTag = "thead")]
    public class TrTagHelper: TagHelper
    {
        public string BgColor { get; set; } = "dark";
        public string TextColor { get; set; } = "White";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"bg-{BgColor} text-center text-{TextColor}");
        }
    }

}
