﻿using System;
using System.Collections.Generic;

namespace Mix.Cms.Lib.Models.Cms
{
    public partial class MixRelatedAttributeSet
    {
        public int Id { get; set; }
        public string Specificulture { get; set; }
        public int AttributeSetId { get; set; }
        public string ParentId { get; set; }
        public string ParentType { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }

        public virtual MixAttributeSet IdNavigation { get; set; }
    }
}
