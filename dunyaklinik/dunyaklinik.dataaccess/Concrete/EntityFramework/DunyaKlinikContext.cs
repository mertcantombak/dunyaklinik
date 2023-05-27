using dunyaklinik.entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.dataaccess.Concrete.EntityFramework
{
    public partial class DunyaKlinikContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=77.92.97.2;User ID=db_admin;Password=^4k648awD;Database=dunyaklinik_main");
            //optionsBuilder.UseMySQL("Server=localhost; Port=3306;User ID=db_admin;Password=^4k648awD; Database=dunyaklinik_main");
        }

        public virtual DbSet<Appointment> Appointments { get; set; }

        public virtual DbSet<Deneme> Denemes { get; set; }

        public virtual DbSet<LogLogin> LogLogins { get; set; }

        public virtual DbSet<ServiceBranchDocument> ServiceBranchDocuments { get; set; }

        public virtual DbSet<ServiceBranchGeneral> ServiceBranchGenerals { get; set; }

        public virtual DbSet<ServiceOrganisation> ServiceOrganisations { get; set; }

        public virtual DbSet<ServiceOrganisationDocument> ServiceOrganisationDocuments { get; set; }

        public virtual DbSet<ServiceUser> ServiceUsers { get; set; }

        public virtual DbSet<ServiceUserDocument> ServiceUserDocuments { get; set; }

        public virtual DbSet<ServiceUserProfession> ServiceUserProfessions { get; set; }

        public virtual DbSet<ServiceUserTitleName> ServiceUserTitleNames { get; set; }

        public virtual DbSet<Treatment> Treatments { get; set; }

        public virtual DbSet<TreatmentClientRating> TreatmentClientRatings { get; set; }

        public virtual DbSet<TreatmentDocument> TreatmentDocuments { get; set; }

        public virtual DbSet<TreatmentExercise> TreatmentExercises { get; set; }

        public virtual DbSet<TreatmentServiceRating> TreatmentServiceRatings { get; set; }

        public virtual DbSet<TreatmentType> TreatmentTypes { get; set; }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("appointments");

                entity.HasIndex(e => e.UserId, "appointment_FK");

                entity.HasIndex(e => e.ServiceUserId, "appointment_FK_1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.AppointmentTime)
                    .HasColumnType("datetime")
                    .HasColumnName("appointment_time");
                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.IsActive).HasColumnName("is_active");
                entity.Property(e => e.IsConfirmed).HasColumnName("is_confirmed");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.ServiceUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("service_user_id");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");

            });

            modelBuilder.Entity<Deneme>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("deneme", tb => tb.HasComment("database proje baglanti deneme icin"));

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Active)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("active");
                entity.Property(e => e.Ad)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("ad");
            });

            modelBuilder.Entity<LogLogin>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("log_logins");

                entity.HasIndex(e => e.UserId, "log_login_FK");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.LastFailedLoginTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("last_failed_login_time");
                entity.Property(e => e.LastSuccessfulLoginTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("last_successful_login_time");
                entity.Property(e => e.LoginTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("login_time");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.User).WithMany(p => p.LogLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("log_login_FK");
            });

            modelBuilder.Entity<ServiceBranchDocument>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("service_branch_documents");

                entity.HasIndex(e => e.BranchId, "service_branch_documents_FK");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BranchId)
                    .HasColumnType("int(11)")
                    .HasColumnName("branch_id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.DocumentPath)
                    .HasMaxLength(250)
                    .HasColumnName("document_path");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");

                entity.HasOne(d => d.Branch).WithMany(p => p.ServiceBranchDocuments)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("service_branch_documents_FK");
            });

            modelBuilder.Entity<ServiceBranchGeneral>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("service_branch_generals");

                entity.HasIndex(e => e.OrganisationId, "service_branch_general_FK");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("address");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("fax");
                entity.Property(e => e.IsActive).HasColumnName("is_active");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.MailAddress)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("mail_address");
                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");
                entity.Property(e => e.OrganisationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("organisation_id");
                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("phone");
                entity.Property(e => e.PhoneCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("phone_code");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");

                entity.HasOne(d => d.Organisation).WithMany(p => p.ServiceBranchGenerals)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("service_branch_general_FK");
            });

            modelBuilder.Entity<ServiceOrganisation>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("service_organisations");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("address");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("description");
                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("fax");
                entity.Property(e => e.IsActive).HasColumnName("is_active");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.MailAddress)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("mail_address");
                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");
                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("phone");
                entity.Property(e => e.PhoneCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("phone_code");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<ServiceOrganisationDocument>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("service_organisation_documents");

                entity.HasIndex(e => e.OrganisationId, "service_organisation_documents_FK");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.DocumentPath)
                    .HasMaxLength(250)
                    .HasColumnName("document_path");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.OrganisationId)
                    .HasColumnType("int(11)")
                    .HasColumnName("organisation_id");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");

                entity.HasOne(d => d.Organisation).WithMany(p => p.ServiceOrganisationDocuments)
                    .HasForeignKey(d => d.OrganisationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("service_organisation_documents_FK");
            });

            modelBuilder.Entity<ServiceUser>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("service_users");

                entity.HasIndex(e => e.BranchId, "service_users_FK");

                entity.HasIndex(e => e.UserId, "service_users_documents_FK");

                entity.HasIndex(e => e.ProfessionId, "service_users_profession_FK");

                entity.HasIndex(e => e.TitleId, "service_users_title_FK");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.BranchId)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("int(11)")
                    .HasColumnName("branch_id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("description");
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("'1'")
                    .HasColumnName("is_active");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.ProfessionId)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("int(11)")
                    .HasColumnName("profession_id");
                entity.Property(e => e.ProfileImagePath)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("profile_image_path");
                entity.Property(e => e.TitleId)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("int(11)")
                    .HasColumnName("title_id");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Branch).WithMany(p => p.ServiceUsers)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("service_users_FK");
            });

            modelBuilder.Entity<ServiceUserDocument>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("service_user_documents");

                entity.HasIndex(e => e.UserId, "service_user_documents_FK");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.DocumentPath)
                    .HasMaxLength(250)
                    .HasColumnName("document_path");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");

                entity.HasOne(d => d.User).WithMany(p => p.ServiceUserDocuments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("service_user_documents_FK");
            });

            modelBuilder.Entity<ServiceUserProfession>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("service_user_professions");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("description");
                entity.Property(e => e.IsActive).HasColumnName("is_active");
                entity.Property(e => e.ProfessionName)
                    .HasMaxLength(100)
                    .HasColumnName("profession_name");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<ServiceUserTitleName>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("service_user_title_names");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.IsActive).HasColumnName("is_active");
                entity.Property(e => e.TitleName)
                    .HasMaxLength(100)
                    .HasColumnName("title_name");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("treatments");

                entity.HasIndex(e => e.TreatmentTypeId, "treatment_FK");

                entity.HasIndex(e => e.ServiceUserId, "treatment_FK_1");

                entity.HasIndex(e => e.UserId, "treatment_FK_2");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.EndTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("end_time");
                entity.Property(e => e.Explanation)
                    .HasMaxLength(1500)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("explanation");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.IsFinished).HasColumnName("is_finished");
                entity.Property(e => e.IsTransferred).HasColumnName("is_transferred");
                entity.Property(e => e.ServiceUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("service_user_id");
                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");
                entity.Property(e => e.TreatmentTypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("treatment_type_id");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<TreatmentClientRating>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("treatment_client_ratings");

                entity.HasIndex(e => e.TreatmentId, "treatment_client_rating_FK");

                entity.HasIndex(e => e.UserId, "treatment_client_rating_FK_1");

                entity.HasIndex(e => e.ServiceUserId, "treatment_client_rating_FK_2");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.Explanation)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("explanation");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
                entity.Property(e => e.ServiceUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("service_user_id");
                entity.Property(e => e.TreatmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("treatment_id");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<TreatmentDocument>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("treatment_documents");

                entity.HasIndex(e => e.TreatmentId, "treatment_documents_FK");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.DocumentExplanation)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("document_explanation");
                entity.Property(e => e.DocumentName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("document_name");
                entity.Property(e => e.DocumentPath)
                    .HasMaxLength(500)
                    .HasColumnName("document_path");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.TreatmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("treatment_id");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<TreatmentExercise>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("treatment_exercises");

                entity.HasIndex(e => e.TreatmentId, "treatment_exercises_FK");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.ExerciseExplanation)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("exercise_explanation");
                entity.Property(e => e.ExerciseFilePath)
                    .HasMaxLength(500)
                    .HasColumnName("exercise_file_path");
                entity.Property(e => e.ExerciseName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("exercise_name");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.TreatmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("treatment_id");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<TreatmentServiceRating>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("treatment_service_ratings");

                entity.HasIndex(e => e.UserId, "treatment_service_rating_FK");

                entity.HasIndex(e => e.ServiceUserId, "treatment_service_rating_FK_1");

                entity.HasIndex(e => e.TreatmentId, "treatment_service_rating_FK_2");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.UserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.Explanation)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("explanation");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.Rate)
                    .HasColumnType("int(11)")
                    .HasColumnName("rate");
                entity.Property(e => e.ServiceUserId)
                    .HasColumnType("int(11)")
                    .HasColumnName("service_user_id");
                entity.Property(e => e.TreatmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("treatment_id");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<TreatmentType>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");

                entity.ToTable("treatment_types");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("PRIMARY");

                entity.ToTable("users", tb => tb.HasComment("Kullanıcıların yer aldığı tablo"));

                entity.Property(e => e.UserId)
                    .HasComment("ID")
                    .HasColumnType("int(11)")
                    .HasColumnName("user_id");
                entity.Property(e => e.BirthDate)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Doğum Tarihi")
                    .HasColumnType("datetime")
                    .HasColumnName("birth_date");
                entity.Property(e => e.CreatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Oluşturulduğu zaman")
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");
                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Adı")
                    .HasColumnName("firstname");
                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Cinsiyet")
                    .HasColumnName("gender");
                entity.Property(e => e.IdentityCardNo)
                    .HasMaxLength(11)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Kimlik Numarası")
                    .HasColumnName("identity_card_no");
                entity.Property(e => e.IsActive)
                    .HasDefaultValueSql("'0'")
                    .HasComment("Kullanıcı aktif mi?")
                    .HasColumnName("is_active");
                entity.Property(e => e.IsMailVerified)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Mail adresi onaylı mı?")
                    .HasColumnName("is_mail_verified");
                entity.Property(e => e.IsPhoneVerified)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Telefon onaylı mı?")
                    .HasColumnName("is_phone_verified");
                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Soyadı")
                    .HasColumnName("lastname");
                entity.Property(e => e.MailAddress)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Mail Adresi")
                    .HasColumnName("mail_address");
                entity.Property(e => e.Nationality)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Ülke/Köken")
                    .HasColumnName("nationality");
                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Şifre")
                    .HasColumnName("password");
                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Telefon Numarası")
                    .HasColumnName("phone");
                entity.Property(e => e.PhoneCode)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Telefon Alan Kodu")
                    .HasColumnName("phone_code");
                entity.Property(e => e.ProfileImagePath)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("'NULL'")
                    .HasColumnName("profile_image_path");
                entity.Property(e => e.UpdatedTime)
                    .HasDefaultValueSql("'NULL'")
                    .HasComment("Son değişiklik zamanı")
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
                entity.Property(e => e.UserType)
                    .HasComment("Tipi")
                    .HasColumnType("int(11)")
                    .HasColumnName("user_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
