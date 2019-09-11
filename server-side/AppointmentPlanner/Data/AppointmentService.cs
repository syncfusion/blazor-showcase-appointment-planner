using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using AppointmentPlanner.Models;

namespace AppointmentPlanner.Data
{ 
    public class AppointmentService
    {
        public static DateTime startDate { get; set; } = new DateTime(2018, 7, 5, 0, 0, 0, 0);
        public static DoctorsData ActiveDoctorData { get; set; } = DoctorsData.GetDoctorsData().FirstOrDefault();

        public static PatientsData ActivePatientData = PatientsData.GetPatientsData().FirstOrDefault();
        public static List<TextValueData> StartHours { get; set; } = TextValueData.GetStartHours();
        public static List<TextValueData> EndHours { get; set; } = TextValueData.GetEndHours();
        public static List<TextValueData> Views { get; set; } = TextValueData.GetViews();
        public static List<TextValueData> ColorCategory { get; set; } = TextValueData.GetColorCategory();
        public static List<TextValueData> BloodGroupData { get; set; } = TextValueData.GetBloodGroupData();
        public static List<TextValueNumericData> DayOfWeekList { get; set; } = TextValueNumericData.GetDayOfWeekList();
        public static List<TextValueNumericData> TimeSlot { get; set; } = TextValueNumericData.GetTimeSlot();
        public static List<HospitalData> HospitalDatas { get; set; } = HospitalData.GetHospitalData();
        public static List<PatientsData> PatientsDatas { get; set; } = PatientsData.GetPatientsData();
        public static List<DoctorsData> DoctorsDatas { get; set; } = DoctorsData.GetDoctorsData();
        public static List<WaitingList> WaitingLists { get; set; } = WaitingList.GetWaitingList();
        public static List<SpecializationData> SpecializationDatas { get; set; } = SpecializationData.GetSpecializationData();
        public static List<TextIdData> DutyTimings { get; set; } = TextIdData.DutyTimingsData();
        public static List<TextIdData> ExperienceData { get; set; } = TextIdData.ExperienceData();
        public static List<ActivityData> ActivityDatas { get; set; } = ActivityData.GetActivityData();
        public static List<NavigationMenuData> NavigationMenuDatas { get; set; } = NavigationMenuData.GetNavigationItems();
        public static CalendarSetting CalendarSettings { get; set; } = new CalendarSetting { bookingColor = "Doctors", calendar = new AppointmentPlanner.Models.Calendar { start = "08:00", end = "21:00" }, currentView = "Week", interval = 60, firstDayOfWeek = 0 };

        public static DateTime GetWeekFirstDate(DateTime date)
        { 
            return date.AddDays(DayOfWeek.Sunday - date.DayOfWeek);
        }

        public static string GetFormatDate(DateTime date, string type)
        {
            return date.ToString(type, CultureInfo.InvariantCulture);
        }

        public static DoctorsData getDoctorDetails(int id)
        {
            List<DoctorsData> doctors = AppointmentService.DoctorsDatas;

            DoctorsData filteredItems = doctors.Where(i => i.Id.Equals(id)).FirstOrDefault();

            return filteredItems;
        }

        public static string getSpecializationText(string text)
        {
            var data = AppointmentService.SpecializationDatas;
            SpecializationData specText = data.Where(item => item.Id.Equals(text)).FirstOrDefault();
            return specText.Text;
        }
        public static string getAvailability(DoctorsData data)
        {
            var workDays = data.WorkDays;
            List<WorkDaysData> filteredData = workDays.Where(item => item.Enable.Equals(true)).ToList();
            var result = filteredData.Select(item => item.Day.Substring(0, 3).ToUpper());
            var resultItem = String.Join(",", result);
            string.Concat("-", resultItem);
            return resultItem.ToString(); ;
        }

        public static List<HospitalData> GetFilteredData(DateTime StartDate, DateTime EndDate)
        {
            return HospitalData.GetHospitalData().Where(data => (data.StartTime >= StartDate && data.EndTime <= EndDate)).ToList();
        }

        public static ChartDataModel GetChartData(List<HospitalData> data, DateTime startDate)
        {
            List<HospitalData> chartData = new List<HospitalData>();
            for (int i = 0; i < data.Count(); i++)
            {
                if (DateTime.Compare(ResetTime(data[i].StartTime), ResetTime(startDate)) == 0)
                {
                    chartData.Add(data[i]);
                }
            }
            return new ChartDataModel() { Date = startDate, EventCount = chartData.Count() };
        }


        public static DateTime ResetTime(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
        }

        public static List<ChartDataModel> GetAllChartData(List<HospitalData> chartData, DateTime date)
        {
            List<ChartDataModel> data = new List<ChartDataModel>();
            for (int i = 0; i < 7; i++)
            {
                data.Add(GetChartData(chartData, date));
                date = date.AddDays(1);
            }
            return data;
        }

        
    } 
}


