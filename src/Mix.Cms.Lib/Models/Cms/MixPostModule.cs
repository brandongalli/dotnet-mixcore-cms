﻿using Mix.Cms.Lib.Enums;
using Mix.Heart.Infrastructure.Entities;
using System;

namespace Mix.Cms.Lib.Models.Cms
{
    public partial class MixPostModule : AuditedEntity
    {
        public int Id { get; set; }
        public string Specificulture { get; set; }
        public int ModuleId { get; set; }
        public int PostId { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Position { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public int Priority { get; set; }
        public MixContentStatus Status { get; set; }

        public virtual MixModule MixModule { get; set; }
        public virtual MixPost MixPost { get; set; }
    }
}