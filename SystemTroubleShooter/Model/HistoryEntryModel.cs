﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTroubleShooter.Model
{
    public class HistoryEntryModel
    {
        public DateTime Timestamp { get; set; }
        public string? IssueDescription { get; set; }
        public string? ResolutionStatus { get; set; } // e.g., "Fixed", "Pending", "Failed", "Info"
                                                     
    }
}
