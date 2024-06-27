using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using AppointmentPlanner.Models;

namespace AppointmentPlanner.Data
{
    public class AppointmentService
    {
        public AppointmentService()
        {
            this.Activities = new Activity().GetActivityData();
            this.StartDate = new DateTime(2020, 2, 5, 0, 0, 0, 0);
            this.ActiveDoctors = new Doctor().GetDoctorsData().FirstOrDefault();
            this.ActivePatients = new Patient().GetPatientsData().FirstOrDefault();
            this.StartHours = new TextValueData().GetStartHours();
            this.EndHours = new TextValueData().GetEndHours();
            this.Views = new TextValueData().GetViews();
            this.ColorCategory = new TextValueData().GetColorCategory();
            this.BloodGroups = new TextValueData().GetBloodGroupData();
            this.DayOfWeekList = new TextValueNumericData().GetDayOfWeekList();
            this.TimeSlot = new TextValueNumericData().GetTimeSlot();
            this.Hospitals = new Hospital().GetHospitalData();
            this.Patients = new Patient().GetPatientsData();
            this.Doctors = new Doctor().GetDoctorsData();
            this.WaitingLists = new WaitingList().GetWaitingList();
            this.Specializations = new Specialization().GetSpecializationData();
            this.DutyTimings = new TextIdData().DutyTimingsData();
            this.Experience = new TextIdData().ExperienceData();
            this.NavigationMenu = new NavigationMenu().GetNavigationMenuItems();
            this.CalendarSettings = new CalendarSetting { BookingColor = "Doctors", Calendar = new AppointmentPlanner.Models.Calendar { Start = "08:00", End = "21:00" }, CurrentView = "Week", Interval = 60, FirstDayOfWeek = 0 };
        }
        public DateTime StartDate { get; set; }
        public Doctor ActiveDoctors { get; set; }

        public Patient ActivePatients { get; set; }
        public List<TextValueData> StartHours { get; set; } 
        public List<TextValueData> EndHours { get; set; }
        public List<TextValueData> Views { get; set; }
        public List<TextValueData> ColorCategory { get; set; }
        public List<TextValueData> BloodGroups { get; set; }
        public List<TextValueNumericData> DayOfWeekList { get; set; }
        public List<TextValueNumericData> TimeSlot { get; set; }
        public List<Hospital> Hospitals { get; set; }
        public List<Patient> Patients { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<WaitingList> WaitingLists { get; set; }
        public List<Specialization> Specializations { get; set; }
        public List<TextIdData> DutyTimings { get; set; }
        public List<TextIdData> Experience { get; set; }
        public List<Activity> Activities { get; set; }
        public List<NavigationMenu> NavigationMenu { get; set; }
        public CalendarSetting CalendarSettings { get; set; }
        public bool ShowDeleteMsg { get; set; }

        public DateTime GetWeekFirstDate(DateTime date)
        { 
            return date.AddDays(DayOfWeek.Monday - date.DayOfWeek);
        }

        public string GetFormatDate(DateTime date, string type)
        {
            return date.ToString(type, CultureInfo.InvariantCulture);
        }

        public string TimeSince(DateTime activityTime)
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

        public Doctor GetDoctorDetails(int id)
        {
            return Doctors.Where(i => i.Id.Equals(id)).FirstOrDefault();
        }

        public string GetSpecializationText(string text)
        {
            return Specializations.Where(item => item.Id.Equals(text)).FirstOrDefault().Text;
        }
        public string GetAvailability(Doctor doctor)
        {
            var workDays = doctor.WorkDays;
            if (workDays != null)
            {
                var result = workDays.Where(item => item.Enable.Equals(true)).Select(item => item.Day.Substring(0, 3).ToUpper());
                return string.Join(",", result).ToString();
                
            }
            return string.Empty;
        }

        public List<Hospital> GetFilteredData(DateTime StartDate, DateTime EndDate)
        {
            return this.Hospitals.Where(hospital => (hospital.StartTime >= StartDate && hospital.EndTime <= EndDate)).ToList();
        }

        public ChartData GetChartData(List<Hospital> hospitals, DateTime startDate)
        {
            List<Hospital> chartData = new List<Hospital>();
            var eventCount = hospitals.Where(hospital => ResetTime(hospital.StartTime) == ResetTime(startDate)).Count();
            return new ChartData() { Date = startDate, EventCount = eventCount };
        }


        public DateTime ResetTime(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
        }

        public List<ChartData> GetAllChartPoints(List<Hospital> hospitals, DateTime date)
        {
            List<ChartData> chartPoints = new List<ChartData>();
            for (int i = 0; i < 7; i++)
            {
                chartPoints.Add(GetChartData(hospitals, date));
                date = date.AddDays(1);
            }
            return chartPoints;
        }

        
    } 
}