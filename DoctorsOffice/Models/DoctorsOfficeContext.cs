using Microsoft.EntityFrameworkCore;
using DoctorsOffice.Models;

namespace DoctorsOffice.Models
{
  public class DoctorsOfficeContext : DbContext
  {
    public virtual DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<DoctorPatient> DoctorPatient { get; set; }
    
    public DoctorsOfficeContext(DbContextOptions options) : base(options) { }
  }
}