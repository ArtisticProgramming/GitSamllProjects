namespace FerdosiDLL.DbModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberUser")]
    public partial class MemberUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MemberUser()
        {
            MemberComments = new HashSet<MemberComment>();
            MemberRatings = new HashSet<MemberRating>();
            Venues = new HashSet<Venue>();
            Venues1 = new HashSet<Venue>();
        }

        public Guid MemberUserId { get; set; }

        [StringLength(128)]
        public string Username { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [Required]
        [StringLength(32)]
        public string PasswordHash { get; set; }

        [StringLength(128)]
        public string City { get; set; }

        [StringLength(128)]
        public string Country { get; set; }

        public bool IsVerified { get; set; }

        public bool IsLockedOut { get; set; }

        public DateTime RegistrationDate { get; set; }

        [StringLength(128)]
        public string FirstName { get; set; }

        [StringLength(128)]
        public string LastName { get; set; }

        [StringLength(128)]
        public string CellPhone { get; set; }

        public DateTime? BirthDate { get; set; }

        public short? EducationLevel { get; set; }

        public int Gender { get; set; }

        public int? MunicipalityRegion { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public DateTime? LastLoginDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdentifierNumber { get; set; }

        public bool IsFidilioStaff { get; set; }

        [StringLength(256)]
        public string AboutMe { get; set; }

        public bool AreCheckinsPrivate { get; set; }

        public Guid? CityId { get; set; }

        public int? Tastes { get; set; }

        public int? PullNotificationSettings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberComment> MemberComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberRating> MemberRatings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venue> Venues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venue> Venues1 { get; set; }
    }
}
