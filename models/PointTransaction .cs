using System;
using System.Collections.Generic;
using System.Text;
using TalentBridge.enums;

namespace TalentBridge.models
{
    public class PointTransaction : BaseEntity
    {
        public int UserId { get; set; }
        public User? User { get; set; }

        public int PointsChanged { get; set; }
        public int CurrentPointsAfterChange { get; set; }

        public ActionType ActionType { get; set; }
        public string? Description { get; set; }
    }
}
