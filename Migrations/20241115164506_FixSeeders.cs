using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Appointment_Management.Migrations
{
    /// <inheritdoc />
    public partial class FixSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Doctor" },
                    { 3, "Patient" }
                });

            migrationBuilder.InsertData(
                table: "specialties",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Heart specialist", "Cardiology" },
                    { 2, "Brain and nervous system specialist", "Neurology" },
                    { 3, "Children's healthcare specialist", "Pediatrics" },
                    { 4, "Bone and joint specialist", "Orthopedics" },
                    { 5, "Skin specialist", "Dermatology" },
                    { 6, "Women's reproductive health specialist", "Gynecology" },
                    { 7, "Mental health specialist", "Psychiatry" },
                    { 8, "Teeth and mouth care specialist", "Dentistry" },
                    { 9, "Eye health specialist", "Ophthalmology" },
                    { 10, "Ear, nose, and throat specialist", "ENT" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "Name", "Password", "RoleId" },
                values: new object[,]
                {
                    { 1, "johndoe@example.com", "John Doe", "1234", 2 },
                    { 2, "janesmith@example.com", "Jane Smith", "1234", 2 },
                    { 3, "mikejohnson@example.com", "Mike Johnson", "1234", 2 },
                    { 4, "emilydavis@example.com", "Emily Davis", "1234", 2 },
                    { 5, "sarahwilson@example.com", "Sarah Wilson", "1234", 2 },
                    { 6, "davidbrown@example.com", "David Brown", "1234", 2 },
                    { 7, "lisawhite@example.com", "Lisa White", "1234", 2 },
                    { 8, "tomclark@example.com", "Tom Clark", "1234", 2 },
                    { 9, "rachelee@example.com", "Rachel Lee", "1234", 2 },
                    { 10, "paulharris@example.com", "Paul Harris", "1234", 2 },
                    { 11, "annabrown@example.com", "Anna Brown", "1234", 3 },
                    { 12, "benjohnson@example.com", "Ben Johnson", "1234", 3 },
                    { 13, "clarawilson@example.com", "Clara Wilson", "1234", 3 },
                    { 14, "danielgreen@example.com", "Daniel Green", "1234", 3 },
                    { 15, "ellawhite@example.com", "Ella White", "1234", 3 },
                    { 16, "fionaturner@example.com", "Fiona Turner", "1234", 3 },
                    { 17, "georgeharris@example.com", "George Harris", "1234", 3 },
                    { 18, "helenclark@example.com", "Helen Clark", "1234", 3 },
                    { 19, "ivycooper@example.com", "Ivy Cooper", "1234", 3 },
                    { 20, "jackmoore@example.com", "Jack Moore", "1234", 3 },
                    { 21, "oscarcalle0@gmail.com", "Oscar Calle", "1234", 1 }
                });

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "Id", "Availability", "SpecialtyId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, true, 1, "Active", 1 },
                    { 2, true, 2, "Active", 2 },
                    { 3, true, 3, "Active", 3 },
                    { 4, true, 4, "Active", 4 },
                    { 5, true, 5, "Active", 5 },
                    { 6, true, 6, "Active", 6 },
                    { 7, true, 7, "Active", 7 },
                    { 8, true, 8, "Active", 8 },
                    { 9, true, 9, "Active", 9 },
                    { 10, true, 10, "Active", 10 }
                });

            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "Id", "Address", "BirthDate", "MedicalHistory", "UserId" },
                values: new object[,]
                {
                    { 11, "123 Main St", new DateTime(1985, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "No known allergies", 11 },
                    { 12, "456 Elm St", new DateTime(1990, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asthma", 12 },
                    { 13, "789 Oak St", new DateTime(2000, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diabetes type 1", 13 },
                    { 14, "101 Pine St", new DateTime(1995, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "High blood pressure", 14 },
                    { 15, "202 Birch St", new DateTime(1980, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "History of heart disease", 15 },
                    { 16, "303 Cedar St", new DateTime(1975, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allergic to penicillin", 16 },
                    { 17, "404 Maple St", new DateTime(2005, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "No known medical issues", 17 },
                    { 18, "505 Ash St", new DateTime(2010, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "History of asthma", 18 },
                    { 19, "606 Willow St", new DateTime(2002, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "No known allergies", 19 }
                });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "Id", "AvailabilityScheduleId", "Date", "DoctorId", "EndTime", "Notes", "PatientId", "Reason", "StartTime", "Status" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeSpan(0, 9, 30, 0, 0), "First appointment of the day", 11, "Routine check-up", new TimeSpan(0, 9, 0, 0, 0), "Scheduled" },
                    { 2, null, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new TimeSpan(0, 10, 30, 0, 0), "Follow-up consultation", 12, "Follow-up for previous diagnosis", new TimeSpan(0, 10, 0, 0, 0), "Scheduled" },
                    { 3, null, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new TimeSpan(0, 11, 30, 0, 0), "Routine check-up", 13, "General check-up", new TimeSpan(0, 11, 0, 0, 0), "Scheduled" },
                    { 4, null, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new TimeSpan(0, 12, 30, 0, 0), "Consultation for lab results", 14, "Lab result discussion", new TimeSpan(0, 12, 0, 0, 0), "Scheduled" },
                    { 5, null, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new TimeSpan(0, 13, 30, 0, 0), "Consultation for follow-up", 15, "Follow-up consultation", new TimeSpan(0, 13, 0, 0, 0), "Scheduled" },
                    { 6, null, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new TimeSpan(0, 14, 30, 0, 0), "New patient consultation", 16, "Initial consultation", new TimeSpan(0, 14, 0, 0, 0), "Scheduled" },
                    { 7, null, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new TimeSpan(0, 15, 30, 0, 0), "Consultation for chronic condition", 17, "Management of chronic illness", new TimeSpan(0, 15, 0, 0, 0), "Scheduled" },
                    { 8, null, new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new TimeSpan(0, 16, 30, 0, 0), "Routine follow-up", 18, "Check-up after treatment", new TimeSpan(0, 16, 0, 0, 0), "Scheduled" },
                    { 9, null, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new TimeSpan(0, 17, 30, 0, 0), "Consultation for test results", 19, "Discuss test results", new TimeSpan(0, 17, 0, 0, 0), "Scheduled" },
                    { 10, null, new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new TimeSpan(0, 18, 30, 0, 0), "Routine check-up", 11, "General health check", new TimeSpan(0, 18, 0, 0, 0), "Scheduled" }
                });

            migrationBuilder.InsertData(
                table: "availability_schedules",
                columns: new[] { "Id", "DayOfWeek", "DoctorId", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), true },
                    { 2, 2, 2, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), true },
                    { 3, 3, 3, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), true },
                    { 4, 4, 4, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), true },
                    { 5, 5, 5, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), true },
                    { 6, 6, 6, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), true },
                    { 7, 0, 7, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), true },
                    { 8, 1, 8, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), true },
                    { 9, 2, 9, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), true },
                    { 10, 3, 10, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), true }
                });

            migrationBuilder.InsertData(
                table: "logs",
                columns: new[] { "Id", "Action", "AppointmentId", "TimeStamp", "UserId" },
                values: new object[,]
                {
                    { 1, "Created", 1, new DateTime(2024, 11, 15, 11, 45, 5, 881, DateTimeKind.Local).AddTicks(6801), 1 },
                    { 2, "Updated", 2, new DateTime(2024, 11, 15, 11, 45, 5, 881, DateTimeKind.Local).AddTicks(6822), 2 },
                    { 3, "Deleted", 3, new DateTime(2024, 11, 15, 11, 45, 5, 881, DateTimeKind.Local).AddTicks(6823), 3 },
                    { 4, "Created", 4, new DateTime(2024, 11, 15, 11, 45, 5, 881, DateTimeKind.Local).AddTicks(6825), 4 },
                    { 5, "Updated", 5, new DateTime(2024, 11, 15, 11, 45, 5, 881, DateTimeKind.Local).AddTicks(6826), 5 },
                    { 6, "Created", 6, new DateTime(2024, 11, 15, 11, 45, 5, 881, DateTimeKind.Local).AddTicks(6828), 6 },
                    { 7, "Updated", 7, new DateTime(2024, 11, 15, 11, 45, 5, 881, DateTimeKind.Local).AddTicks(6829), 7 },
                    { 8, "Created", 8, new DateTime(2024, 11, 15, 11, 45, 5, 881, DateTimeKind.Local).AddTicks(6830), 8 },
                    { 9, "Updated", 9, new DateTime(2024, 11, 15, 11, 45, 5, 881, DateTimeKind.Local).AddTicks(6832), 9 },
                    { 10, "Deleted", 10, new DateTime(2024, 11, 15, 11, 45, 5, 881, DateTimeKind.Local).AddTicks(6833), 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "availability_schedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "availability_schedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "availability_schedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "availability_schedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "availability_schedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "availability_schedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "availability_schedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "availability_schedules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "availability_schedules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "availability_schedules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "logs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "logs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "logs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "logs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "logs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "logs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "logs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "logs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "logs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "logs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "appointments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "specialties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "roles",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
