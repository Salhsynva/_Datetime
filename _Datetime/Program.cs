using _Datetime.Claasses;
using System;

namespace _Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fromDate = new DateTime(2020, 10, 6);
            DateTime toDate = new DateTime(2020, 10, 11);

            DateTime fromDate2 = new DateTime(2020, 10, 9);
            DateTime toDate2 = new DateTime(2020, 10, 12);

            DateTime fromDate3 = new DateTime(2022, 10, 9);
            DateTime toDate3 = new DateTime(2022, 10, 10);

            DateTime fromDate4 = new DateTime(2022, 10, 15);
            DateTime toDate4 = new DateTime(2022, 10, 16);

            MeetingSchedule meetingSchedule1 = new MeetingSchedule();
            meetingSchedule1.SetMeeting("gorus 1", fromDate, toDate);
            meetingSchedule1.SetMeeting("gorus 2", fromDate2, toDate2);
            meetingSchedule1.SetMeeting("gorus 3", fromDate3, toDate3);
            meetingSchedule1.SetMeeting("gorus 4", fromDate4, toDate4);

            DateTime dateTime = new DateTime(2021, 9, 9);

            Console.WriteLine(meetingSchedule1.FindMeetingsCount(dateTime));
            Console.WriteLine(meetingSchedule1.IsExistMeetingByName("gorus 7"));

            foreach (var item in meetingSchedule1.GetExistMeetings("gorus"))
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
