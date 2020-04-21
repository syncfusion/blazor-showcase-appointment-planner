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
        public AppointmentService()
        {
            this.ActivityDatas = new ActivityData().GetActivityData();
            this.startDate = new DateTime(2019, 7, 5, 0, 0, 0, 0);
            this.ActiveDoctorData = new DoctorsData().GetDoctorsData().FirstOrDefault();
            this.ActivePatientData = new PatientsData().GetPatientsData().FirstOrDefault();
            this.StartHours = new TextValueData().GetStartHours();
            this.EndHours = new TextValueData().GetEndHours();
            this.Views = new TextValueData().GetViews();
            this.ColorCategory = new TextValueData().GetColorCategory();
            this.BloodGroupData = new TextValueData().GetBloodGroupData();
            this.DayOfWeekList = new TextValueNumericData().GetDayOfWeekList();
            this.TimeSlot = new TextValueNumericData().GetTimeSlot();
            this.HospitalDatas = new HospitalData().GetHospitalData();
            this.PatientsDatas = new PatientsData().GetPatientsData();
            this.DoctorsDatas = new DoctorsData().GetDoctorsData();
            this.WaitingLists = new WaitingList().GetWaitingList();
            this.SpecializationDatas = new SpecializationData().GetSpecializationData();
            this.DutyTimings = new TextIdData().DutyTimingsData();
            this.ExperienceData = new TextIdData().ExperienceData();
            this.NavigationMenuDatas = new NavigationMenuData().GetNavigationItems();
            this.CalendarSettings = new CalendarSetting { bookingColor = "Doctors", calendar = new AppointmentPlanner.Models.Calendar { start = "08:00", end = "21:00" }, currentView = "Week", interval = 60, firstDayOfWeek = 0 };
        }
        public DateTime startDate { get; set; }
        public DoctorsData ActiveDoctorData { get; set; }

        public PatientsData ActivePatientData { get; set; }
        public List<TextValueData> StartHours { get; set; } 
        public List<TextValueData> EndHours { get; set; }
        public List<TextValueData> Views { get; set; }
        public List<TextValueData> ColorCategory { get; set; }
        public List<TextValueData> BloodGroupData { get; set; }
        public List<TextValueNumericData> DayOfWeekList { get; set; }
        public List<TextValueNumericData> TimeSlot { get; set; }
        public List<HospitalData> HospitalDatas { get; set; }
        public List<PatientsData> PatientsDatas { get; set; }
        public List<DoctorsData> DoctorsDatas { get; set; }
        public List<WaitingList> WaitingLists { get; set; }
        public List<SpecializationData> SpecializationDatas { get; set; }
        public List<TextIdData> DutyTimings { get; set; }
        public List<TextIdData> ExperienceData { get; set; }
        public List<ActivityData> ActivityDatas { get; set; }
        public List<NavigationMenuData> NavigationMenuDatas { get; set; }
        public CalendarSetting CalendarSettings { get; set; }

        public DateTime GetWeekFirstDate(DateTime date)
        { 
            return date.AddDays(DayOfWeek.Monday - date.DayOfWeek);
        }

        public string GetFormatDate(DateTime date, string type)
        {
            return date.ToString(type, CultureInfo.InvariantCulture);
        }

        public string timeSlince(DateTime activityTime)
        {
            if(Math.Round((DateTime.Now - activityTime).Days / (365.25 / 12)) > 0)
            {
                return Math.Round((DateTime.Now - activityTime).Days / (365.25 / 12)).ToString() + " months ago";
            } else if(Math.Round((DateTime.Now - activityTime).TotalDays) > 0)
            {
                return Math.Round((DateTime.Now - activityTime).TotalDays).ToString() + " days ago";
            } else if(Math.Round((DateTime.Now - activityTime).TotalHours) > 0)
            {
                return Math.Round((DateTime.Now - activityTime).TotalHours).ToString() + " hours ago";
            } else if (Math.Round((DateTime.Now - activityTime).TotalMinutes) > 0)
            {
                return Math.Round((DateTime.Now - activityTime).TotalMinutes).ToString() + " mins ago";
            } else if (Math.Round((DateTime.Now - activityTime).TotalSeconds) > 0)
            {
                return Math.Round((DateTime.Now - activityTime).TotalSeconds).ToString() + " seconds ago";
            }
            return Math.Round((DateTime.Now - activityTime).TotalMilliseconds).ToString() + " milliSeconds ago";
        }

        public DoctorsData getDoctorDetails(int id)
        {
            List<DoctorsData> doctors = this.DoctorsDatas;

            DoctorsData filteredItems = doctors.Where(i => i.Id.Equals(id)).FirstOrDefault();

            return filteredItems;
        }

        public string getSpecializationText(string text)
        {
            var data = this.SpecializationDatas;
            SpecializationData specText = data.Where(item => item.Id.Equals(text)).FirstOrDefault();
            return specText.Text;
        }
        public string getAvailability(DoctorsData data)
        {
            var workDays = data.WorkDays;
            if (workDays != null)
            {
                List<WorkDaysData> filteredData = workDays.Where(item => item.Enable.Equals(true)).ToList();
                var result = filteredData.Select(item => item.Day.Substring(0, 3).ToUpper());
                var resultItem = String.Join(",", result);
                string.Concat("-", resultItem);
                return resultItem.ToString();
            } else
            {
                return "";
            }
        }

        public List<HospitalData> GetFilteredData(DateTime StartDate, DateTime EndDate)
        {
            return this.HospitalDatas.Where(data => (data.StartTime >= StartDate && data.EndTime <= EndDate)).ToList();
        }

        public ChartDataModel GetChartData(List<HospitalData> data, DateTime startDate)
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


        public DateTime ResetTime(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
        }

        public List<ChartDataModel> GetAllChartData(List<HospitalData> chartData, DateTime date)
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


