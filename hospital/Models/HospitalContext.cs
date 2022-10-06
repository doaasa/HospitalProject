using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace hospital.Models
{
    public partial class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }

        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<Operation> Operations { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientDisease> PatientDiseases { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-SFDKHS6\\SQLEXPRESS; Database=Hospital;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__Departme__72E12F1A70A4A5C7");

                entity.ToTable("Department");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .HasColumnName("location");

                entity.Property(e => e.MSsn)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("M_SSN");

                entity.HasOne(d => d.MSsnNavigation)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.MSsn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("M_SSN_FK");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__Disease__72E12F1A7A222972");

                entity.ToTable("Disease");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.Ssn)
                    .HasName("PK__Doctor__CA1E8E3DF86CB585");

                entity.ToTable("Doctor");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(15)
                    .HasColumnName("SSN");

                entity.Property(e => e.Adress)
                    .HasMaxLength(50)
                    .HasColumnName("adress");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dept_name");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("fname");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .HasColumnName("lname");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Qualifications)
                    .HasMaxLength(50)
                    .HasColumnName("qualifications");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.HasOne(d => d.DeptNameNavigation)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.DeptName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Dept_name_FK");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.HasKey(e => e.Ssn)
                    .HasName("PK__Manager__CA1E8E3DE67B5E65");

                entity.ToTable("Manager");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(15)
                    .HasColumnName("SSN");

                entity.Property(e => e.Adress)
                    .HasMaxLength(50)
                    .HasColumnName("adress");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("fname");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .HasColumnName("lname");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.Sex).HasColumnName("sex");
            });

            modelBuilder.Entity<Nurse>(entity =>
            {
                entity.HasKey(e => e.Ssn)
                    .HasName("PK__Nurse__CA1E8E3D7038A344");

                entity.ToTable("Nurse");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(15)
                    .HasColumnName("SSN");

                entity.Property(e => e.Adress)
                    .HasMaxLength(50)
                    .HasColumnName("adress");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dept_name");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("fname");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .HasColumnName("lname");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.HasOne(d => d.DeptNameNavigation)
                    .WithMany(p => p.Nurses)
                    .HasForeignKey(d => d.DeptName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Dept_name_FK_N");
            });

            modelBuilder.Entity<Operation>(entity =>
            {
                entity.ToTable("Operation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dept_name");

                entity.Property(e => e.DocSsn)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Doc_SSN");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.HasOne(d => d.DeptNameNavigation)
                    .WithMany(p => p.Operations)
                    .HasForeignKey(d => d.DeptName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Dept_name_FK_O");

                entity.HasOne(d => d.DocSsnNavigation)
                    .WithMany(p => p.Operations)
                    .HasForeignKey(d => d.DocSsn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Doc_SSN_FK_D");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Ssn)
                    .HasName("PK__Patient__CA1E8E3DB6D221CA");

                entity.ToTable("Patient");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(15)
                    .HasColumnName("SSN");

                entity.Property(e => e.Adress)
                    .HasMaxLength(50)
                    .HasColumnName("adress");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Dept_name");

                entity.Property(e => e.DocSsn)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Doc_SSN");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("fname");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .HasColumnName("lname");

                entity.Property(e => e.NurseSsn)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Nurse_SSN");

                entity.Property(e => e.OpeId).HasColumnName("Ope_id");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");

                entity.Property(e => e.RoomId).HasColumnName("Room_id");

                entity.Property(e => e.Sex).HasColumnName("sex");

                entity.HasOne(d => d.DeptNameNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DeptName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Dept_name_FK_P");

                entity.HasOne(d => d.DocSsnNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DocSsn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Doc_SSN_FK");

                entity.HasOne(d => d.NurseSsnNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.NurseSsn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Nurse_SSN_FK");

                entity.HasOne(d => d.Ope)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.OpeId)
                    .HasConstraintName("Ope_id_FK");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Room_id_FK");
            });

            modelBuilder.Entity<PatientDisease>(entity =>
            {
                entity.HasKey(e => new { e.PSsn, e.DisName })
                    .HasName("PK__Patient___7361C4916A50B5AA");

                entity.ToTable("Patient_Disease");

                entity.Property(e => e.PSsn)
                    .HasMaxLength(15)
                    .HasColumnName("P_SSN");

                entity.Property(e => e.DisName)
                    .HasMaxLength(50)
                    .HasColumnName("Dis_name");

                entity.HasOne(d => d.DisNameNavigation)
                    .WithMany(p => p.PatientDiseases)
                    .HasForeignKey(d => d.DisName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Patient_D__Dis_n__5165187F");

                entity.HasOne(d => d.PSsnNavigation)
                    .WithMany(p => p.PatientDiseases)
                    .HasForeignKey(d => d.PSsn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Patient_D__P_SSN__5070F446");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.DocSsn)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Doc_SSN");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.HasOne(d => d.DocSsnNavigation)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.DocSsn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Doc_SSN_FK_Room");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
