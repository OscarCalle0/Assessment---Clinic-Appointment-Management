using Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Management.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<AvailabilitySchedule> AvailabilitySchedules { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Log> Logs { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Specialty> Specialties { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // call of the sedders
       
    }
}