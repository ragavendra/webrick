﻿using System.Collections.Generic;

namespace AppName.Models
{
    public class GetShiftsWithSettingsByDate
    {
        public List<object> shifts { get; set; }
        public Settings settings { get; set; }
    }

    public class Settings
    {
        public List<string> cars { get; set; }
        public List<string> roles { get; set; }
        public List<ShiftHour> shiftHours { get; set; }
        public List<string> patrolHubs { get; set; }
        public List<string> patrolAreas { get; set; }
        public List<Member> members { get; set; }
    }
}