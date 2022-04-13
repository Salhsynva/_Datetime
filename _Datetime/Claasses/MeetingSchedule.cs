using System;
using System.Collections.Generic;
using System.Text;

namespace _Datetime.Claasses
{
    class MeetingSchedule
    {
        public List<Meeting> Meetings = new List<Meeting>();
        public void SetMeeting(string name, DateTime initDate, DateTime endDate)
        {
            if (Meetings.Exists(x => x.Name == name && x.FromDate == initDate && x.ToDate == endDate))
            {
                throw new Exception("meeting already exist");
            }
            if (!Meetings.Exists(x => x.Name == name && x.FromDate == initDate &&  x.ToDate == endDate))
            {
                if (!Meetings.Exists(x => (x.FromDate > initDate && x.FromDate < endDate) || (x.ToDate < endDate && x.ToDate > initDate) || (initDate > x.FromDate && initDate < x.ToDate) || (endDate < x.ToDate && endDate > x.FromDate)))
                {
                    Meeting meeting = new Meeting()
                    {
                        Name = name,
                        FromDate = initDate,
                        ToDate = endDate
                    };
                    Meetings.Add(meeting);
                }
               
            }
        }
        public int FindMeetingsCount(DateTime date)
        {
            List<Meeting> newMeetings = Meetings.FindAll(x => x.FromDate > date);
            return newMeetings.Count;
        }
        public bool IsExistMeetingByName(string name)
        {
            return Meetings.Exists(x => x.Name == name);
        }
        public List<Meeting> GetExistMeetings(string name)
        {
            return Meetings.FindAll(x => x.Name.ToLower().Contains(name.ToLower()));
        }
    }
}
