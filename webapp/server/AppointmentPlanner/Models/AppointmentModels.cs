using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppointmentPlanner.Models
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Disease { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public string RecurrenceRule { get; set; }
        public string Symptoms { get; set; }
        public bool? IsAllDay { get; set; }
        public string ElementType { get; set; }
        public bool IsBlock { get; set; }
        public Nullable<int> RecurrenceID { get; set; }
        public string RecurrenceException { get; set; }
        public string StartTimezone { get; set; }
        public string EndTimezone { get; set; }
        public string Location { get; set; }

        public Hospital() { }

        public Hospital(int Id, string Name, DateTime StartTime, DateTime EndTime, string Disease, string DepartmentName, int DepartmentId, int DoctorId, int PatientId, string Symptoms)
        {
            this.Id = Id;
            this.Name = Name;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Disease = Disease;
            this.DepartmentName = DepartmentName;
            this.DepartmentId = DepartmentId;
            this.DoctorId = DoctorId;
            this.PatientId = PatientId;
            this.Symptoms = Symptoms;
        }

        public List<Hospital> GetHospitalData()
        {
            List<Hospital> data = new List<Hospital>
            {
                new Hospital(1000, "Milka", new DateTime(2020, 2, 5, 10, 30, 0), new DateTime(2020, 2, 5, 11, 30, 0), "Bone Fracture", "ORTHOPEDICS", 4, 5, 2, "Swelling or bruising over a bone, Pain in the injured area"),
                new Hospital(1001, "Janet", new DateTime(2020, 2, 3, 11, 0, 0), new DateTime(2020, 2, 3, 12, 0, 0), "Biological Problems", "GENERAL", 1, 3, 4, "Physical aches or pain, Memory difficulties or personality changes"),
                new Hospital(1002, "Mercy", new DateTime(2020, 2, 2, 10, 0, 0), new DateTime(2020, 2, 2, 11, 0, 0), "Skin Problem", "DERMATOLOGY", 3, 4, 5, "outbreak of swollen, pale red bumps or plaques"),
                new Hospital(1003, "Laura", new DateTime(2020, 2, 9, 10, 0, 0), new DateTime(2020, 2, 9, 11, 0, 0), "Feeling very hungry - even though you are eating", "DIABETOLOGY", 5, 6, 1, "Urinating often, Extreme fatigue, Blurry vision"),
                new Hospital(1004, "Richa", new DateTime(2020, 2, 7, 10, 0, 0), new DateTime(2020, 2, 7, 11, 0, 0), "Skin care treatment", "DERMATOLOGIST", 3, 4, 2, "Scaly or rough skin, Peeling skin, open sores or lesions"),
                new Hospital(1005, "Adams", new DateTime(2020, 2, 7, 13, 30, 0), new DateTime(2020, 2, 7, 14, 0, 0), "General Checkup", "GENERAL", 1, 1, 3, "Decreased energy, Chronic fatigue, Difficulty concentrating"),
                new Hospital(1006, "Richa", new DateTime(2020, 2, 7, 16, 0, 0), new DateTime(2020, 2, 7, 17, 0, 0), "Left Arm Fracture", "ORTHOPEDICS", 4, 5, 6, "Swelling, warmth, or redness in the joint"),
                new Hospital(1007, "Adams", new DateTime(2020, 2, 13, 11, 0, 0), new DateTime(2020, 2, 13, 11, 30, 0), "Chest Pain", "CARDIOLOGY", 6, 7, 2, "Shortness of breath, Swollen feet or ankles"),
                new Hospital(1008, "Milka", new DateTime(2020, 2, 13, 9, 0, 0), new DateTime(2020, 2, 13, 10, 0, 0), "Skin Care Treatment", "DERMATOLOGIST", 3, 4, 2, "a rash, which might be painful or itchy"),
                new Hospital(1009, "Adams", new DateTime(2020, 2, 10, 14, 0, 0), new DateTime(2020, 2, 10, 16, 0, 0), "Surgery Treatment", "GENERAL", 1, 1, 3, "Pain at Site, Swelling/Hardening"),
                new Hospital(1010, "Adams", new DateTime(2020, 2, 11, 11, 0, 0), new DateTime(2020, 2, 11, 13, 0, 0), "Bone Problem", "ORTHOPEDICS", 4, 5, 3, "Recurring or constant joint pain or tenderness"),

                new Hospital(1011, "Adams", new DateTime(2020, 2, 1, 11, 0, 0), new DateTime(2020, 2, 1, 12, 0, 0), "General Checkup", "GENERAL", 1, 3, 1, "a pulsating feeling in the head, sensitivity to sound and light"),
                new Hospital(1012, "Janet", new DateTime(2020, 2, 1, 16, 0, 0), new DateTime(2020, 2, 1, 17, 0, 0), "Complete loss of sensation", "NEUROLOGY", 2, 2, 4, "Partial or complete paralysis, Muscle weakness"),
                new Hospital(1013, "Laura", new DateTime(2020, 2, 5, 13, 0, 0), new DateTime(2020, 2, 5, 14, 0, 0), "Health Checkup", "GENERAL", 1, 1, 1, "Sweating, Chills and Shivering"),
                new Hospital(1014, "Adams", new DateTime(2020, 2, 5, 16, 0, 0), new DateTime(2020, 2, 5, 17, 0, 0), "Eye and Spectacles Checkup", "GENERAL", 1, 3, 3, "Frequent squinting, Eye fatigue or strain"),
                new Hospital(1015, "Milka", new DateTime(2020, 2, 6, 12, 0, 0), new DateTime(2020, 2, 6, 13, 0, 0), "Feeling very hungry - even though you are eating", "DIABETOLOGY", 5, 6, 2, "Urinating often, Extreme fatigue, Blurry vision"),
                new Hospital(1016, "Adams", new DateTime(2020, 2, 6, 18, 0, 0), new DateTime(2020, 2, 6, 18, 30, 0), "Kidney disease", "DIABETOLOGY", 5, 6, 3, "Decreased urine output"),
                new Hospital(1017, "Janet", new DateTime(2020, 2, 4, 14, 0, 0), new DateTime(2020, 2, 4, 14, 30, 0), "Gastroparesis", "DIABETOLOGY", 5, 6, 4, "A feeling of fullness after eating just a few bites"),
                new Hospital(1018, "Laura", new DateTime(2020, 2, 4, 12, 0, 0), new DateTime(2020, 2, 4, 13, 0, 0), "Sleep apnea", "DIABETOLOGY", 5, 6, 1, "Gasping for air during sleep"),
                new Hospital(1019, "Milka", new DateTime(2020, 2, 4, 10, 0, 0), new DateTime(2020, 2, 4, 11, 0, 0), "Vision problems", "DIABETOLOGY", 5, 6, 2, "Severe, sudden eye pain"),
                new Hospital(1020, "Milka", new DateTime(2020, 2, 2, 12, 0, 0), new DateTime(2020, 2, 2, 13, 0, 0), "Feeling very hungry - even though you are eating", "DIABETOLOGY", 5, 6, 2, "Urinating often, Extreme fatigue, Blurry vision"),

                new Hospital(1021, "Adams", new DateTime(2020, 2, 6, 10, 0, 0), new DateTime(2020, 2, 6, 11, 0, 0), "Bone Fracture", "ORTHOPEDICS", 4, 5, 3, "Swelling or bruising over a bone, Pain in the injured area"),
                new Hospital(1022, "Mercy", new DateTime(2020, 2, 2, 15, 0, 0), new DateTime(2020, 2, 2, 15, 30, 0), "Left Arm Fracture", "ORTHOPEDICS", 4, 5, 5, "Deformity, such as a bent arm or wrist"),
                new Hospital(1023, "Milka", new DateTime(2020, 2, 6, 14, 0, 0), new DateTime(2020, 2, 6, 14, 30, 0), "Rapid heartbeat", "CARDIOLOGY", 6, 7, 2, "Fluttering sensation in the chest"),
                new Hospital(1024, "Adams", new DateTime(2020, 2, 4, 17, 30, 0), new DateTime(2020, 2, 4, 18, 30, 0), "Lightheadedness", "CARDIOLOGY", 6, 7, 3, "Sudden drop in blood pressure"),
                new Hospital(1025, "Janet", new DateTime(2020, 2, 4, 15, 0, 0), new DateTime(2020, 2, 4, 15, 30, 0), "Shortness of breath", "CARDIOLOGY", 6, 7, 4, "Nasal congestion, runny nose, itchy or watery eyes"),

                new Hospital(1026, "Milka", new DateTime(2020, 2, 3, 17, 0, 0), new DateTime(2020, 2, 3, 18, 30, 0), "Chest pain or discomfort", "CARDIOLOGY", 6, 7, 2, "Fast heart beat, and trouble breathing"),
                new Hospital(1027, "Milka", new DateTime(2020, 2, 6, 15, 30, 0), new DateTime(2020, 2, 6, 16, 0, 0), "Racing heartbeat", "CARDIOLOGY", 6, 7, 2, "A fluttering in your chest"),
                new Hospital(1028, "Milka", new DateTime(2020, 2, 3, 14, 0, 0), new DateTime(2020, 2, 3, 14, 30, 0), "Heart Problem", "CARDIOLOGY", 6, 7, 2, "Fluid buildup from being overweight"),
                new Hospital(1029, "Milka", new DateTime(2020, 2, 5, 19, 0, 0), new DateTime(2020, 2, 5, 19, 30, 0), "Dizziness", "DIABETOLOGY", 5, 6, 2, "Feeling of lightheadedness or nearly fainting")
            };
            return data;
        }
    }

    public class Patient
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter a valid name.")]
        public string Name { get; set; }
        public string Text { get; set; }
        [Required(ErrorMessage = "Select a valid DOB.")]
        public DateTime? DOB { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Enter a valid mobile number.")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "A valid email address is required.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "A valid email address is required.")]
        public string Email { get; set; }
        public string Address { get; set; }
        public string Disease { get; set; }
        public string DepartmentName { get; set; }
        [Required]
        public string BloodGroup { get; set; } = "AB +ve";
        public string Gender { get; set; } = "Male";
        public string Symptoms { get; set; }
        public Patient()
        {

        }

        public Patient(int Id, string Name, string Text, DateTime? DOB, string Mobile, string Email, string Address, string Disease, string DepartmentName, string BloodGroup, string Gender, string Symptoms)
        {
            this.Id = Id;
            this.Name = Name;
            this.Text = Text;
            this.DOB = DOB;
            this.Mobile = Mobile;
            this.Email = Email;
            this.Address = Address;
            this.Disease = Disease;
            this.DepartmentName = DepartmentName;
            this.BloodGroup = BloodGroup;
            this.Gender = Gender;
            this.Symptoms = Symptoms;
        }

        public List<Patient> GetPatientsData()
        {
            List<Patient> data = new List<Patient>
            {
                new Patient(1, "Laura", "Laura", new DateTime(1980, 8, 3), "(071) 555-4444", "laura90@mail.com", "507 - 20th Ave. E.\r\nApt. 2A", "Eye Checkup", "GENERAL", "O +ve", "Female", "Sweating, Chills and Shivering"),
                new Patient(2, "Milka", "Milka", new DateTime(2000, 3, 5), "(071) 555-4445", "milka40@sample.com", "908 W. Capital Way", "Bone Fracture", "ORTHOPEDICS", "AB +ve", "Female", "Swelling or bruising over a bone, Pain in the injured area"),
                new Patient(3, "Adams", "Adams", new DateTime(1985, 2, 3), "(071) 555-4454", "adams89@rpy.com", "722 Moss Bay Blvd.", "Eye and Spectactles", "GENERAL", "B +ve", "Male", "Frequent squinting, Eye fatigue or strain"),
                new Patient(4, "Janet", "Janet", new DateTime(2000, 7, 3), "(071) 555-4544", "janet79@rpy.com", "4110 Old Redmond Rd.", "Biological Problem", "GENERAL", "B +ve", "Male", "Physical aches or pain, Memory difficulties or personality change"),
                new Patient(5, "Mercy", "Mercy", new DateTime(2005, 4, 29), "(071) 555-5444", "mercy60@sample.com", "14 Garrett Hill", "Skin Hives", "DERMATOLOGY", "AB -ve", "Female", "outbreak of swollen, pale red bumps or plaques"),
                new Patient(6, "Richa", "Richa", new DateTime(1989, 10, 29), "(206) 555-4444", "richa46@mail.com", "Coventry House\r\nMiner Rd.", "Arm Fracture", "ORTHOPEDICS", "B +ve", "Female", "Swelling, warmth, or redness in the joint"),
                new Patient(7, "Maud Oliver", "Maud Oliver", new DateTime(1989, 10, 29), "(206) 666-4444", "moud46@rpy.com", "Coventry House\r\nMiner Rd.", "Racing heartbeat", "CARDIOLOGY", "B +ve", "Male", "A fluttering in your chest")
            };
            return data;
        }

    }
    public class Appointment
    {
        public string Time { get; set; }
        public string Name { get; set; }
        public string DoctorName { get; set; }
        public string Symptoms { get; set; }
        public int DoctorId { get; set; }

        public Appointment() { }

        public Appointment(string Time, string Name, string DoctorName, string Symptoms, int DoctorId)
        {
            this.Time = Time;
            this.Name = Name;
            this.DoctorName = DoctorName;
            this.Symptoms = Symptoms;
            this.DoctorId = DoctorId;
        }
    }


    public class Doctor
    {
        [Required(ErrorMessage = "Enter a valid name.")]
        public string Name { get; set; }
        public string Gender { get; set; } = "Male";
        public string Text { get; set; }
        public int Id { get; set; }
        public int DepartmentId { get; set; } = 1;
        public string Color { get; set; }
        public string Education { get; set; }
        public string Specialization { get; set; } = "generalmedicine";
        public string Experience { get; set; } = "1+ years";
        public string Designation { get; set; }
        public string DutyTiming { get; set; } = "Shift1";
        [Required(ErrorMessage = "A valid email address is required.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "A valid email address is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter a valid mobile number.")]
        public string Mobile { get; set; }
        public string Availability { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
        public int[] AvailableDays { get; set; }
        public List<WorkDay> WorkDays { get; set; }

        public Doctor() { }

        public Doctor(string Name, string Gender, string Text, int Id, int DepartmentId, string Color, string Education, string Specialization, string Experience, string Designation, string DutyTiming, string Email, string Mobile, string Availability, string StartHour, string EndHour, int[] AvailableDays, List<WorkDay> WorkDays)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Text = Text;
            this.Id = Id;
            this.DepartmentId = DepartmentId;
            this.Color = Color;
            this.Education = Education;
            this.Specialization = Specialization;
            this.Experience = Experience;
            this.Designation = Designation;
            this.DutyTiming = DutyTiming;
            this.Email = Email;
            this.Mobile = Mobile;
            this.Availability = Availability;
            this.StartHour = StartHour;
            this.EndHour = EndHour;
            this.AvailableDays = AvailableDays;
            this.WorkDays = WorkDays;
        }


        public List<Doctor> GetDoctorsData()
        {
            List<WorkDay> workDays = new List<WorkDay>
            {
                new WorkDay("Sunday", 0, true, new DateTime(2020, 2, 01, 08, 0, 0), new DateTime(2020, 2, 01, 17, 0, 0), new DateTime(2020, 2, 01, 12, 0, 0), new DateTime(2020, 2, 01, 13, 0, 0), "AddBreak"),
                new WorkDay("Monday", 1, false, new DateTime(2020, 2, 2, 8, 0, 0), new DateTime(2020, 2, 2, 17, 0, 0), new DateTime(2020, 2, 2, 12, 0, 0), new DateTime(2020, 2, 2, 13, 0, 0), "TimeOff"),
                new WorkDay("Tuesday", 2, true, new DateTime(2020, 2, 3, 8, 0, 0), new DateTime(2020, 2, 3, 17, 0, 0), new DateTime(2020, 2, 3, 12, 0, 0), new DateTime(2020, 2, 3, 13, 0, 0), "AddBreak"),
                new WorkDay("Wednesday", 3, true, new DateTime(2020, 2, 4, 8, 0, 0), new DateTime(2020, 2, 4, 17, 0, 0), new DateTime(2020, 2, 4, 12, 0, 0), new DateTime(2020, 2, 4, 13, 0, 0), "AddBreak"),
                new WorkDay("Thursday", 4, true, new DateTime(2020, 2, 5, 08, 0, 0), new DateTime(2020, 2, 5, 17, 0, 0), new DateTime(2020, 2, 5, 12, 0, 0), new DateTime(2020, 2, 5, 13, 0, 0), "AddBreak"),
                new WorkDay("Friday", 5, true, new DateTime(2020, 2, 6, 8, 0, 0), new DateTime(2020, 2, 6, 17, 0, 0), new DateTime(2020, 2, 6, 12, 0, 0), new DateTime(2020, 2, 6, 13, 0, 0), "RemoveBreak"),
                new WorkDay("Saturday", 6, false, new DateTime(2020, 2, 7, 8, 0, 0), new DateTime(2020, 2, 7, 17, 0, 0), new DateTime(2020, 2, 7, 12, 0, 0), new DateTime(2020, 2, 7, 13, 0, 0), "TimeOff")
            };

            List<WorkDay> workDays1 = new List<WorkDay>
            {
                new WorkDay("Sunday", 0, true, new DateTime(2020, 2, 01, 10, 0, 0), new DateTime(2020, 2, 01, 19, 0, 0), new DateTime(2020, 2, 01, 14, 0, 0), new DateTime(2020, 2, 01, 15, 0, 0), "AddBreak"),
                new WorkDay("Monday", 1, true, new DateTime(2020, 2, 2, 10, 0, 0), new DateTime(2020, 2, 2, 19, 0, 0), new DateTime(2020, 2, 2, 14, 0, 0), new DateTime(2020, 2, 2, 15, 0, 0), "RemoveBreak"),
                new WorkDay("Tuesday", 2, true, new DateTime(2020, 2, 3, 10, 0, 0), new DateTime(2020, 2, 3, 19, 0, 0), new DateTime(2020, 2, 3, 14, 0, 0), new DateTime(2020, 2, 3, 15, 0, 0), "AddBreak"),
                new WorkDay("Wednesday", 3, true, new DateTime(2020, 2, 4, 10, 0, 0), new DateTime(2020, 2, 4, 19, 0, 0), new DateTime(2020, 2, 4, 14, 0, 0), new DateTime(2020, 2, 4, 15, 0, 0), "AddBreak"),
                new WorkDay("Thursday", 4, true, new DateTime(2020, 2, 5, 10, 0, 0), new DateTime(2020, 2, 5, 19, 0, 0), new DateTime(2020, 2, 5, 14, 0, 0), new DateTime(2020, 2, 5, 15, 0, 0), "RemoveBreak"),
                new WorkDay("Friday", 5, false, new DateTime(2020, 2, 6, 10, 0, 0), new DateTime(2020, 2, 6, 19, 0, 0), new DateTime(2020, 2, 6, 14, 0, 0), new DateTime(2020, 2, 6, 15, 0, 0), "TimeOff"),
                new WorkDay("Saturday", 6, false, new DateTime(2020, 2, 7, 10, 0, 0), new DateTime(2020, 2, 7, 19, 0, 0), new DateTime(2020, 2, 7, 14, 0, 0), new DateTime(2020, 2, 7, 15, 0, 0), "TimeOff")
            };

            List<WorkDay> workDays2 = new List<WorkDay>
            {
                new WorkDay("Sunday", 0, false, new DateTime(2020, 2, 01, 12, 0, 0), new DateTime(2020, 2, 01, 21, 0, 0), new DateTime(2020, 2, 01, 16, 0, 0), new DateTime(2020, 2, 01, 17, 0, 0), "TimeOff"),
                new WorkDay("Monday", 1, true, new DateTime(2020, 2, 2, 12, 0, 0), new DateTime(2020, 2, 2, 21, 0, 0), new DateTime(2020, 2, 2, 16, 0, 0), new DateTime(2020, 2, 2, 17, 0, 0), "AddBreak"),
                new WorkDay("Tuesday", 2, true, new DateTime(2020, 2, 3, 12, 0, 0), new DateTime(2020, 2, 3, 21, 0, 0), new DateTime(2020, 2, 3, 16, 0, 0), new DateTime(2020, 2, 3, 17, 0, 0), "AddBreak"),
                new WorkDay("Wednesday", 3, true, new DateTime(2020, 2, 4, 12, 0, 0), new DateTime(2020, 2, 4, 21, 0, 0), new DateTime(2020, 2, 4, 16, 0, 0), new DateTime(2020, 2, 4, 17, 0, 0), "AddBreak"),
                new WorkDay("Thursday", 4, true, new DateTime(2020, 2, 5, 12, 0, 0), new DateTime(2020, 2, 5, 21, 0, 0), new DateTime(2020, 2, 5, 16, 0, 0), new DateTime(2020, 2, 5, 17, 0, 0), "AddBreak"),
                new WorkDay("Friday", 5, true, new DateTime(2020, 2, 6, 12, 0, 0), new DateTime(2020, 2, 6, 21, 0, 0), new DateTime(2020, 2, 6, 16, 0, 0), new DateTime(2020, 2, 6, 17, 0, 0), "RemoveBreak"),
                new WorkDay("Saturday", 6, false, new DateTime(2020, 2, 7, 12, 0, 0), new DateTime(2020, 2, 7, 21, 0, 0), new DateTime(2020, 2, 7, 16, 0, 0), new DateTime(2020, 2, 7, 17, 0, 0), "TimeOff")
            };

            List<WorkDay> workDays3 = new List<WorkDay>
            {
                new WorkDay("Sunday", 0, false, new DateTime(2020, 2, 01, 8, 0, 0), new DateTime(2020, 2, 01, 17, 0, 0), new DateTime(2020, 2, 01, 12, 0, 0), new DateTime(2020, 2, 01, 13, 0, 0), "TimeOff"),
                new WorkDay("Monday", 1, false, new DateTime(2020, 2, 2, 8, 0, 0), new DateTime(2020, 2, 2, 17, 0, 0), new DateTime(2020, 2, 2, 12, 0, 0), new DateTime(2020, 2, 2, 13, 0, 0), "TimeOff"),
                new WorkDay("Tuesday", 2, true, new DateTime(2020, 2, 3, 8, 0, 0), new DateTime(2020, 2, 3, 17, 0, 0), new DateTime(2020, 2, 3, 12, 0, 0), new DateTime(2020, 2, 3, 13, 0, 0), "AddBreak"),
                new WorkDay("Wednesday", 3, true, new DateTime(2020, 2, 4, 8, 0, 0), new DateTime(2020, 2, 4, 17, 0, 0), new DateTime(2020, 2, 4, 12, 0, 0), new DateTime(2020, 2, 4, 13, 0, 0), "AddBreak"),
                new WorkDay("Thursday", 4, true, new DateTime(2020, 2, 5, 8, 0, 0), new DateTime(2020, 2, 5, 17, 0, 0), new DateTime(2020, 2, 5, 12, 0, 0), new DateTime(2020, 2, 5, 13, 0, 0), "AddBreak"),
                new WorkDay("Friday", 5, true, new DateTime(2020, 2, 6, 8, 0, 0), new DateTime(2020, 2, 6, 17, 0, 0), new DateTime(2020, 2, 6, 12, 0, 0), new DateTime(2020, 2, 6, 13, 0, 0), "RemoveBreak"),
                new WorkDay("Saturday", 6, true, new DateTime(2020, 2, 7, 8, 0, 0), new DateTime(2020, 2, 7, 17, 0, 0), new DateTime(2020, 2, 7, 12, 0, 0), new DateTime(2020, 2, 7, 13, 0, 0), "AddBreak")
            };

            List<WorkDay> workDays4 = new List<WorkDay>
            {
                new WorkDay("Sunday", 0, true, new DateTime(2020, 2, 01, 10, 0, 0), new DateTime(2020, 2, 01, 19, 0, 0), new DateTime(2020, 2, 01, 14, 0, 0), new DateTime(2020, 2, 01, 15, 0, 0), "AddBreak"),
                new WorkDay("Monday", 1, false, new DateTime(2020, 2, 2, 10, 0, 0), new DateTime(2020, 2, 2, 19, 0, 0), new DateTime(2020, 2, 2, 14, 0, 0), new DateTime(2020, 2, 2, 15, 0, 0), "TimeOff"),
                new WorkDay("Tuesday", 2, true, new DateTime(2020, 2, 3, 10, 0, 0), new DateTime(2020, 2, 3, 19, 0, 0), new DateTime(2020, 2, 3, 14, 0, 0), new DateTime(2020, 2, 3, 15, 0, 0), "AddBreak"),
                new WorkDay("Wednesday", 3, true, new DateTime(2020, 2, 4, 10, 0, 0), new DateTime(2020, 2, 4, 19, 0, 0), new DateTime(2020, 2, 4, 14, 0, 0), new DateTime(2020, 2, 4, 15, 0, 0), "AddBreak"),
                new WorkDay("Thursday", 4, true, new DateTime(2020, 2, 5, 10, 0, 0), new DateTime(2020, 2, 5, 19, 0, 0), new DateTime(2020, 2, 5, 14, 0, 0), new DateTime(2020, 2, 5, 15, 0, 0), "AddBreak"),
                new WorkDay("Friday", 5, true, new DateTime(2020, 2, 6, 10, 0, 0), new DateTime(2020, 2, 6, 19, 0, 0), new DateTime(2020, 2, 6, 14, 0, 0), new DateTime(2020, 2, 6, 15, 0, 0), "RemoveBreak"),
                new WorkDay("Saturday", 6, false, new DateTime(2020, 2, 7, 10, 0, 0), new DateTime(2020, 2, 7, 19, 0, 0), new DateTime(2020, 2, 7, 14, 0, 0), new DateTime(2020, 2, 7, 15, 0, 0), "TimeOff")
            };

            List<WorkDay> workDays5 = new List<WorkDay>
            {
                new WorkDay("Sunday", 0, false, new DateTime(2020, 2, 01, 10, 0, 0), new DateTime(2020, 2, 01, 19, 0, 0), new DateTime(2020, 2, 01, 14, 0, 0), new DateTime(2020, 2, 01, 15, 0, 0), "TimeOff"),
                new WorkDay("Monday", 1, false, new DateTime(2020, 2, 2, 10, 0, 0), new DateTime(2020, 2, 2, 19, 0, 0), new DateTime(2020, 2, 2, 14, 0, 0), new DateTime(2020, 2, 2, 15, 0, 0), "TimeOff"),
                new WorkDay("Tuesday", 2, true, new DateTime(2020, 2, 3, 10, 0, 0), new DateTime(2020, 2, 3, 19, 0, 0), new DateTime(2020, 2, 3, 14, 0, 0), new DateTime(2020, 2, 3, 15, 0, 0), "AddBreak"),
                new WorkDay("Wednesday", 3, true, new DateTime(2020, 2, 4, 10, 0, 0), new DateTime(2020, 2, 4, 19, 0, 0), new DateTime(2020, 2, 4, 14, 0, 0), new DateTime(2020, 2, 4, 15, 0, 0), "AddBreak"),
                new WorkDay("Thursday", 4, true, new DateTime(2020, 2, 5, 10, 0, 0), new DateTime(2020, 2, 5, 19, 0, 0), new DateTime(2020, 2, 5, 14, 0, 0), new DateTime(2020, 2, 5, 15, 0, 0), "AddBreak"),
                new WorkDay("Friday", 5, true, new DateTime(2020, 2, 6, 10, 0, 0), new DateTime(2020, 2, 6, 19, 0, 0), new DateTime(2020, 2, 6, 14, 0, 0), new DateTime(2020, 2, 6, 15, 0, 0), "RemoveBreak"),
                new WorkDay("Saturday", 6, true, new DateTime(2020, 2, 7, 10, 0, 0), new DateTime(2020, 2, 7, 19, 0, 0), new DateTime(2020, 2, 7, 14, 0, 0), new DateTime(2020, 2, 7, 15, 0, 0), "AddBreak")
            };

            List<WorkDay> workDays6 = new List<WorkDay>
            {
                new WorkDay("Sunday", 0, true, new DateTime(2020, 2, 01, 12, 0, 0), new DateTime(2020, 2, 01, 21, 0, 0), new DateTime(2020, 2, 01, 16, 0, 0), new DateTime(2020, 2, 01, 17, 0, 0), "AddBreak"),
                new WorkDay("Monday", 1, false, new DateTime(2020, 2, 2, 12, 0, 0), new DateTime(2020, 2, 2, 21, 0, 0), new DateTime(2020, 2, 2, 16, 0, 0), new DateTime(2020, 2, 2, 17, 0, 0), "TimeOff"),
                new WorkDay("Tuesday", 2, false, new DateTime(2020, 2, 3, 12, 0, 0), new DateTime(2020, 2, 3, 21, 0, 0), new DateTime(2020, 2, 3, 16, 0, 0), new DateTime(2020, 2, 3, 17, 0, 0), "TimeOff"),
                new WorkDay("Wednesday", 3, true, new DateTime(2020, 2, 4, 12, 0, 0), new DateTime(2020, 2, 4, 21, 0, 0), new DateTime(2020, 2, 4, 16, 0, 0), new DateTime(2020, 2, 4, 17, 0, 0), "AddBreak"),
                new WorkDay("Thursday", 4, true, new DateTime(2020, 2, 5, 12, 0, 0), new DateTime(2020, 2, 5, 21, 0, 0), new DateTime(2020, 2, 5, 16, 0, 0), new DateTime(2020, 2, 5, 17, 0, 0), "AddBreak"),
                new WorkDay("Friday", 5, true, new DateTime(2020, 2, 6, 12, 0, 0), new DateTime(2020, 2, 6, 21, 0, 0), new DateTime(2020, 2, 6, 16, 0, 0), new DateTime(2020, 2, 6, 17, 0, 0), "RemoveBreak"),
                new WorkDay("Saturday", 6, true, new DateTime(2020, 2, 7, 12, 0, 0), new DateTime(2020, 2, 7, 21, 0, 0), new DateTime(2020, 2, 7, 16, 0, 0), new DateTime(2020, 2, 7, 17, 0, 0), "AddBreak")
            };

            List<Doctor> doctors = new List<Doctor>
            {
                new Doctor("Nembo Lukeni", "Male", "NemboLukni", 1, 1, "#ea7a57", "MBBS, DMRD", "generalmedicine", "10+ years", "Senior Specialist", "Shift1", "nembo36@sample.com", "(206) 555-9482", "busy", "08:00", "17:00", new int[] { 0, 2, 3, 4, 5 }, workDays),
                new Doctor("Mollie Cobb", "Female", "MollieCobb", 2, 2, "#7fa900", "MBBS, MD PAEDIATRICS, DM NEUROLOGY", "neurology", "2+ years", "Junior Specialist", "Shift2", "mollie65@rpy.com", "(206) 555-3412", "available", "10:00", "19:00", new int[] { 0, 1, 2, 3, 4 }, workDays1),
                new Doctor("Yara Barros", "Female", "YaraBarros", 3, 1, "#fec200", "MBBS, DNB (FAMILY MEDICINE)", "generalmedicine", "5+ years", "Senior Specialist", "Shift3", "yara105@sample.com", "(206) 555-8122", "away", "12:00", "21:00", new int[] { 1, 2, 3, 4, 5 }, workDays2),
                new Doctor("Paul Walker", "Male", "PaulWalker", 4, 3, "#865fcf", "MBBS, MD (Dermatology)", "dermatology", "10+ years", "Senior Specialist", "Shift1", "paul39@mail.com", "(071) 555-4848", "busy", "08:00", "17:00", new int[] { 2, 3, 4, 5, 6 }, workDays3),
                new Doctor("Amelia Edwards", "Female", "AmeliaEdwards", 5, 4, "#1aaa55", "MBBS, MD", "orthopedics", "10+ years", "Junior Specialist", "Shift2", "amelia101@rpy.com", "(071) 555-7773", "available", "10:00", "19:00", new int[] { 0, 2, 3, 4, 5 }, workDays4),
                new Doctor("Alexa Richardson", "Female", "AlexaRichardson", 6, 5, "#1aaa55", "MBBS, MD", "diabetology", "1+ years", "Practitioner", "Shift2", "alexa55@sample.com", "(071) 555-5598", "busy", "10:00", "19:00", new int[] { 2, 3, 4, 5, 6 }, workDays5),
                new Doctor("Amelia Nout Golstein", "Male", "NoutGolstein", 7, 6, "#00bdae", "MS", "cardiology", "2+ years", "Junior Specialist", "Shift3", "nout49@rpy.com", "(206) 555-1189", "busy", "12:00", "21:00", new int[] { 0, 3, 4, 5, 6 }, workDays6)
            };

            return doctors;
        }

    }

    public class WorkDay
    {
        public string Day { get; set; }
        public int Index { get; set; }
        public bool Enable { get; set; }
        public DateTime? WorkStartHour { get; set; }
        public DateTime? WorkEndHour { get; set; }
        [Required(ErrorMessage = "Enter valid Hour")]
        public DateTime? BreakStartHour { get; set; } = new DateTime(2020, 2, 01, 12, 0, 0);
        [Required(ErrorMessage = "Enter valid Hour")]
        public DateTime? BreakEndHour { get; set; } = new DateTime(2020, 2, 01, 13, 0, 0);
        public string State { get; set; }

        public WorkDay() { }

        public WorkDay(string Day, int Index, bool Enable, DateTime? WorkStartHour, DateTime? WorkEndHour, DateTime? BreakStartHour, DateTime? BreakEndHour, string State)
        {
            this.Day = Day;
            this.Index = Index;
            this.Enable = Enable;
            this.WorkStartHour = WorkStartHour;
            this.WorkEndHour = WorkEndHour;
            this.BreakStartHour = BreakStartHour;
            this.BreakEndHour = BreakEndHour;
            this.State = State;
        }
    }

    public class WaitingList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Disease { get; set; }
        public string DepartmentName { get; set; }
        public string Treatment { get; set; }
        public int DepartmentId { get; set; }
        public int PatientId { get; set; }

        public List<WaitingList> GetWaitingList()
        {

            List<WaitingList> wait = new List<WaitingList>()
            {
                new WaitingList {Id= 1, Name= "Laura", StartTime= new DateTime(2020, 2, 3, 8, 30, 0), EndTime= new DateTime(2020, 2, 3, 9, 30, 0), Disease= "Sudden loss of vision", DepartmentName= "GENERAL", Treatment= "CHECKUP", DepartmentId= 1, PatientId= 1},
                new WaitingList { Id= 2,Name= "Milka", StartTime= new DateTime(2020, 2, 4, 8, 30, 0), EndTime= new DateTime(2020, 2, 4, 10, 30, 0), Disease= "Bone Fracture", DepartmentName= "ORTHOPEDICS", Treatment= "SURGERY", DepartmentId= 4, PatientId= 2 },
                new WaitingList { Id= 3, Name= "Adams", StartTime= new DateTime(2020, 2, 4, 9, 30, 0), EndTime= new DateTime(2020, 2, 4, 10, 30, 0), Disease= "Skin Hives", DepartmentName= "DERMATOLOGY", Treatment= "CHECKUP", DepartmentId= 3, PatientId= 3 },
                new WaitingList { Id= 4, Name= "Janet", StartTime= new DateTime(2020, 2, 3, 11, 0, 0), EndTime= new DateTime(2020, 2, 3, 12, 30, 0), Disease= "Frequent urination", DepartmentName= "DIABETALOGY", Treatment= "DIALOGIS", DepartmentId= 5, PatientId= 4 },
                new WaitingList { Id= 5, Name= "Mercy", StartTime= new DateTime(2020, 2, 3, 11, 0, 0), EndTime= new DateTime(2020, 2, 3, 12, 30, 0), Disease= "Muscle weakness", DepartmentName= "NEUROLOGY", Treatment= "DIAGNOSIS", DepartmentId= 2, PatientId= 5 },
                new WaitingList { Id= 6, Name= "Richa", StartTime= new DateTime(2020, 2, 3, 11, 0, 0), EndTime= new DateTime(2020, 2, 3, 12, 30, 0), Disease= "Shortness of breath", DepartmentName= "CARDIOLOGY", Treatment= "REGULAR CHECKUP", DepartmentId= 6, PatientId= 6 },
                new WaitingList { Id= 7, Name= "Richa", StartTime= new DateTime(2020, 2, 3, 8, 30, 0), EndTime= new DateTime(2020, 2, 3, 9, 30, 0), Disease= "Sudden loss of vision", DepartmentName= "GENERAL", Treatment= "CHECKUP", DepartmentId= 1, PatientId= 6 },
                new WaitingList { Id= 8, Name= "Mercy", StartTime= new DateTime(2020, 8, 4, 8, 30, 0), EndTime= new DateTime(2020, 8, 4, 10, 30, 0), Disease= "Bone Fracture", DepartmentName= "ORTHOPEDICS", Treatment= "SURGERY", DepartmentId= 4, PatientId= 5},
                new WaitingList { Id= 9, Name= "Janet", StartTime= new DateTime(2020, 2, 4, 9, 30, 0), EndTime= new DateTime(2020, 2, 4, 10, 30, 0), Disease= "Skin Hives", DepartmentName= "DERMATOLOGY", Treatment= "CHECKUP", DepartmentId= 3, PatientId= 4 }

            };
            return wait;

        }
    }

    public class Specialization
    {
        public int? DepartmentId { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string Color { get; set; }

        public Specialization() { }

        public Specialization(int? DepartmentId, string Id, string Text, string Color)
        {
            this.DepartmentId = DepartmentId;
            this.Id = Id;
            this.Text = Text;
            this.Color = Color;
        }


        public List<Specialization> GetSpecializationData()
        {
            List<Specialization> data = new List<Specialization>
            {
                new Specialization(1, "generalmedicine", "General Medicine", "#F538B2"),
                new Specialization(2, "neurology", "Neurology", "#33C7E8"),
                new Specialization(3, "dermatology", "Dermatology", "#916DE4"),
                new Specialization(4, "orthopedics", "Orthopedics", "#388CF5"),
                new Specialization(5, "diabetology", "Diabetology", "#60F238"),
                new Specialization(6, "cardiology", "Cardiology", "#F29438")
            };

            return data;
        }
    }


    public class TextIdData
    {
        public string Id { get; set; }
        public string Text { get; set; }

        public TextIdData() { }

        public TextIdData(string Id, string Text)
        {
            this.Id = Id;
            this.Text = Text;
        }

        public List<TextIdData> ExperienceData()
        {
            List<TextIdData> data = new List<TextIdData>
            {
                new TextIdData("1+ years", "1+ years"),
                new TextIdData("2+ years", "2+ years"),
                new TextIdData("5+ years", "5+ years"),
                new TextIdData("10+ years", "10+ years"),
                new TextIdData("15+ years", "15+ years"),
                new TextIdData("20+ years", "20+ years")
            };
            return data;
        }
        public List<TextIdData> DutyTimingsData()
        {
            List<TextIdData> data = new List<TextIdData>
            {
                new TextIdData("Shift1", "08:00 AM - 5:00 PM"),
                new TextIdData("Shift2", "10:00 AM - 7:00 PM"),
                new TextIdData("Shift3", "12:00 PM - 9:00 PM")
            };
            return data;
        }
    }

    public class TextValueData
    {
        public string Value { get; set; }
        public string Text { get; set; }

        public TextValueData() { }

        public TextValueData(string Value, string Text)
        {
            this.Value = Value;
            this.Text = Text;
        }

        public List<TextValueData> GetStartHours()
        {
            List<TextValueData> data = new List<TextValueData>
            {
                new TextValueData("08:00", "8.00 AM"),
                new TextValueData("9:00", "9.00 AM"),
                new TextValueData("10:00", "10.00 AM"),
                new TextValueData("11:00", "11.00 AM"),
                new TextValueData("12:00", "12.00 AM")
            };
            return data;
        }
        public List<TextValueData> GetEndHours()
        {
            List<TextValueData> data = new List<TextValueData>
            {
                new TextValueData("16:00", "4.00 PM"),
                new TextValueData("17:00", "5.00 PM"),
                new TextValueData("18:00", "6.00 PM"),
                new TextValueData("19:00", "7.00 PM"),
                new TextValueData("20:00", "8.00 PM"),
                new TextValueData("21:00", "9.00 PM")
            };
            return data;
        }
        public List<TextValueData> GetViews()
        {
            List<TextValueData> data = new List<TextValueData>
            {
                new TextValueData("Day", "Daily"),
                new TextValueData("Week", "Weekly"),
                new TextValueData("Month", "Monthly")
            };
            return data;
        }
        public List<TextValueData> GetColorCategory()
        {
            List<TextValueData> data = new List<TextValueData>
            {
                new TextValueData("Departments", "Department Colors"),
                new TextValueData("Doctors", "Doctors Colors")
            };
            return data;
        }
        public List<TextValueData> GetBloodGroupData()
        {
            List<TextValueData> data = new List<TextValueData>
            {
                new TextValueData("AB +ve", "AB +ve"),
                new TextValueData("A +ve", "A +ve"),
                new TextValueData("B +ve", "B +ve"),
                new TextValueData("O +ve", "O +ve"),
                new TextValueData("AB -ve", "AB -ve"),
                new TextValueData("A -ve", "A -ve"),
                new TextValueData("B -ve", "B -ve"),
                new TextValueData("O -ve", "O -ve")
            };
            return data;
        }
    }
    public class TextValueNumericData
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public TextValueNumericData() { }

        public TextValueNumericData(int Value, string Text)
        {
            this.Value = Value;
            this.Text = Text;
        }

        public List<TextValueNumericData> GetTimeSlot()
        {
            List<TextValueNumericData> data = new List<TextValueNumericData>
            {
                new TextValueNumericData(10, "10 mins"),
                new TextValueNumericData(20, "20 mins"),
                new TextValueNumericData(30, "30 mins"),
                new TextValueNumericData(60, "60 mins"),
                new TextValueNumericData(120, "120 mins")
            };
            return data;
        }

        public List<TextValueNumericData> GetDayOfWeekList()
        {
            List<TextValueNumericData> data = new List<TextValueNumericData>
            {
                new TextValueNumericData(0, "Sunday"),
                new TextValueNumericData(1, "Monday"),
                new TextValueNumericData(2, "Tuesday"),
                new TextValueNumericData(3, "Wednesday"),
                new TextValueNumericData(4, "Thursday"),
                new TextValueNumericData(5, "Friday"),
                new TextValueNumericData(6, "Saturday")
            };
            return data;
        }
    }
    public class Activity
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public DateTime ActivityTime { get; set; }

        public Activity() { }

        public Activity(string Name, string Message, string Time, string Type, DateTime ActivityTime)
        {
            this.Name = Name;
            this.Message = Message;
            this.Time = Time;
            this.Type = Type;
            this.ActivityTime = ActivityTime;
        }
        public List<Activity> GetActivityData()
        {
            List<Activity> data = new List<Activity>
            {
                new Activity("Added New Doctor", "Dr.Johnson James, Cardiologist", "5 mins ago", "doctor", new DateTime(2020, 2, 1, 9, 0, 0)),
                new Activity("Added New Appointment", "Laura for General Checkup on 7th March, 2020 @ 8.30 AM with Dr.Molli Cobb, Cardiologist", "5 mins ago", "appointment", new DateTime(2020, 2, 1, 11, 0, 0)),
                new Activity("Added New Patient", "James Richard for Fever and cold", "5 mins ago", "patient", new DateTime(2020, 2, 1, 10, 0, 0)),
                new Activity("Added New Appointment", "Joseph for consultation on 7th Feb, 2020 @ 11.10 AM with Dr.Molli Cobb", "5 mins ago", "appointment", new DateTime(2020, 2, 1, 11, 0, 0))
            };
            return data;
        }
    }

    public class Block
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string RecurrenceRule { get; set; }
        public bool IsAllDay { get; set; }
        public bool IsBlock { get; set; }
        public int[] DoctorId { get; set; }

        public Block() { }

        public Block(int Id, string Name, string StartTime, string EndTime, string RecurrenceRule, bool IsAllDay, bool IsBlock, int[] DoctorId)
        {
            this.Id = Id;
            this.Name = Name;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.RecurrenceRule = RecurrenceRule;
            this.IsAllDay = IsAllDay;
            this.IsBlock = IsBlock;
            this.DoctorId = DoctorId;

        }
    }
    public class ChartData
    {
        public DateTime Date { get; set; }
        public int? EventCount { get; set; }
    }

    public class NavigationMenu
    {
        public string Text { get; set; }
        public string Value { get; set; } = "dashboard";
        public string Icon { get; set; }

        public NavigationMenu() { }

        public NavigationMenu(string Text, string Value, string Icon)
        {
            this.Text = Text;
            this.Value = Value;
            this.Icon = Icon;
        }
        public List<NavigationMenu> GetNavigationMenuItems()
        {
            List<NavigationMenu> data = new List<NavigationMenu>
            {
                new NavigationMenu("Dashboard", "dashboard", "icon-dashboard"),
                new NavigationMenu("Schedule", "schedule", "icon-schedule"),
                new NavigationMenu("Doctors", "doctors", "icon-doctors"),
                new NavigationMenu("Patients", "patients", "icon-patients"),
                new NavigationMenu("Preference", "preference", "icon-preference"),
                new NavigationMenu("About", "about", "icon-about")
            };
            return data;
        }
    }
    public class CalendarSetting
    {
        public string BookingColor { get; set; }
        public Calendar Calendar { get; set; }
        public string CurrentView { get; set; }
        public int Interval { get; set; } = 60;
        public int FirstDayOfWeek { get; set; } = 1;
    }

    public class Calendar
    {
        public string Start { get; set; }
        public string End { get; set; }
        public bool? Highlight { get; set; }
    }
    public class TemplateArgs
    {
        public string ElementType { get; set; }
        public DateTime? Date { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Disease { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public string Symptoms { get; set; }
    }

    public class TimeSheetGroupData
    {
        public int DepartmentId { get; set; }
        public int DoctorId { get; set; }
    }

}