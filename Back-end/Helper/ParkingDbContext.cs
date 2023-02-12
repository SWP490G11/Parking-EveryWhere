using Back_end.Common;
using Back_end.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Back_end.Helper
{
    using BCrypt = BCrypt.Net.BCrypt;
    public class ParkingDbContext : DbContext
    {
        public ParkingDbContext(DbContextOptions options) : base(options)
        {
           
        }

        protected ParkingDbContext()
        {
        }

        

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarModel> CarModels { get; set; }

        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Dashboard> Dashboards { get; set; }

        public virtual DbSet<Image> Images { get; set; }

        public virtual DbSet<Parking> Parkings { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<MembershipPackage> MembershipPackages { get; set; }
        public virtual DbSet<Request> Requests { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            if (modelBuilder == null)
                throw new ArgumentNullException("modelBuilder");

            modelBuilder.Entity<User>()
        .HasKey(e => e.ID)
        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Car>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Parking>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Request>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<ParkingDetail>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<CarModel>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Dashboard>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Image>()
      .HasKey(e => e.ID)
      .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<MembershipPackage>()
        .HasKey(e => e.ID)
        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<Slot>()
 .HasKey(e => e.ID)
 .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity<TimeFrame>()
        .HasKey(e => e.ID)
        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity<User>(
                u=>u.HasData(new List<User>() { 
                    new User {UserName= "phucnv", HashPasword= BCrypt.HashPassword("Aa123456@")
                    ,DateOfBirth = new DateTime(2000,7,7),FirstName="Phuc", LastName=" Nguyen Van"
                    ,Gender = Gender.Male,PhoneNumber="0966416708",Email="phucnvhd772000@gmail.com",Role=Role.Admin
                    ,LastModifyAt= DateTime.Now,
                    } })
                );

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var fk in entityType.GetForeignKeys())
                {
                    fk.DeleteBehavior = DeleteBehavior.NoAction;
                }
            }

            base.OnModelCreating(modelBuilder);

        }
    }
}
