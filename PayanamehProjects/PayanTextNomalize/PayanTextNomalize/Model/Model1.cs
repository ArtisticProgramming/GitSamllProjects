namespace PayanTextNomalize.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Fidello")
        {
        }

        public virtual DbSet<MemberComment> MemberComments { get; set; }
        public virtual DbSet<MemberRating> MemberRatings { get; set; }
        public virtual DbSet<MemberUser> MemberUsers { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }
        public virtual DbSet<MemberComment_W> MemberComment_W { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberUser>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<MemberUser>()
                .Property(e => e.PasswordHash)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MemberUser>()
                .Property(e => e.Latitude)
                .HasPrecision(17, 14);

            modelBuilder.Entity<MemberUser>()
                .Property(e => e.Longitude)
                .HasPrecision(17, 14);

            modelBuilder.Entity<MemberUser>()
                .HasMany(e => e.MemberComments)
                .WithRequired(e => e.MemberUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MemberUser>()
                .HasMany(e => e.Venues)
                .WithOptional(e => e.MemberUser)
                .HasForeignKey(e => e.VenueModeratorMemberUserId);

            modelBuilder.Entity<MemberUser>()
                .HasMany(e => e.Venues1)
                .WithOptional(e => e.MemberUser1)
                .HasForeignKey(e => e.AddedByMemberUserId);

            modelBuilder.Entity<Venue>()
                .Property(e => e.Slug)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.Langitude)
                .HasPrecision(17, 14);

            modelBuilder.Entity<Venue>()
                .Property(e => e.Latitude)
                .HasPrecision(17, 14);

            modelBuilder.Entity<Venue>()
                .Property(e => e.FoursquareVenueId)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.VenueManagerCellPhone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.TwitterUsername)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.InstagramUsername)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Venue>()
                .Property(e => e.EnglishWorkingHours)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .Property(e => e.SanaId)
                .IsUnicode(false);

            modelBuilder.Entity<Venue>()
                .HasMany(e => e.MemberComments)
                .WithOptional(e => e.Venue)
                .HasForeignKey(e => e.ItemId);

            modelBuilder.Entity<Venue>()
                .HasMany(e => e.MemberRatings)
                .WithOptional(e => e.Venue)
                .HasForeignKey(e => e.ItemId);
        }
    }
}
