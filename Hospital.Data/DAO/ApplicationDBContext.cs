using Microsoft.EntityFrameworkCore;
using Hospital.Data.Entities;

namespace Hospital.Data.DAO;

public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : DbContext(options)
{

    public DbSet<Patient> Patients { get; set; }
    public DbSet<DiagnosisRecord> DiagnosisRecords { get; set; }

}