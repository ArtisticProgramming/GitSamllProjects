namespace PayanTextNomalize.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Venue")]
    public partial class Venue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venue()
        {
            MemberComments = new HashSet<MemberComment>();
            MemberRatings = new HashSet<MemberRating>();
        }

        public Guid VenueId { get; set; }

        [Required]
        [StringLength(128)]
        public string Slug { get; set; }

        [StringLength(512)]
        public string MetaTagTitle { get; set; }

        public string MetaTagDescription { get; set; }

        public bool IsActive { get; set; }

        [StringLength(256)]
        public string Country { get; set; }

        public string SideFeatures { get; set; }

        public string Description { get; set; }

        public int BinaryType { get; set; }

        [Required]
        [StringLength(128)]
        public string Code { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(512)]
        public string KidsPlayGround { get; set; }

        public bool HasWiFiInternet { get; set; }

        public bool HasPos { get; set; }

        public int? DeliveryType { get; set; }

        public int? ParkingPlaceType { get; set; }

        public bool IsTwentyFourHours { get; set; }

        [StringLength(512)]
        public string WorkingHours { get; set; }

        public int? PriceClass { get; set; }

        public int? UrbanDistrict { get; set; }

        public bool IsSuggestedByFidilio { get; set; }

        [StringLength(256)]
        public string Phone { get; set; }

        public string Address { get; set; }

        [StringLength(128)]
        public string ManagerName { get; set; }

        [StringLength(128)]
        public string ManagerPhone { get; set; }

        [StringLength(64)]
        public string ManagerMobile { get; set; }

        [StringLength(256)]
        public string ManagerEmail { get; set; }

        [StringLength(1024)]
        public string Website { get; set; }

        public decimal? Langitude { get; set; }

        public decimal? Latitude { get; set; }

        public int? FidilioRating { get; set; }

        public string FidilioAssesmentPageContent { get; set; }

        public DateTime? LastModificationDate { get; set; }

        public short? Priority { get; set; }

        public bool FidilioReservation { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime? AddedDate { get; set; }

        public int? MunicipalCode { get; set; }

        [StringLength(512)]
        public string PointsOffer { get; set; }

        public int? UpdateInterval { get; set; }

        [StringLength(128)]
        public string FoursquareVenueId { get; set; }

        public bool IsFeaturedOnMobileNearMe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FeaturedOnMobileNearMeStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FeaturedOnMobileNearMeEndDate { get; set; }

        public short? FeaturedOnMobileNearMeRadius { get; set; }

        [StringLength(256)]
        public string FeaturedOnMobileNearMeText { get; set; }

        public bool IsPremium { get; set; }

        public Guid? PremiumPlanId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PremiumFromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PremiumToDate { get; set; }

        [StringLength(128)]
        public string VenueEmail { get; set; }

        public Guid? VenueModeratorMemberUserId { get; set; }

        [StringLength(10)]
        public string VenueManagerCellPhone { get; set; }

        [StringLength(128)]
        public string FacebookLink { get; set; }

        [StringLength(128)]
        public string TwitterUsername { get; set; }

        [StringLength(128)]
        public string InstagramUsername { get; set; }

        public int? MaxAllowedSmsPerDay { get; set; }

        [StringLength(512)]
        public string AdReportageLink { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] RowVersion { get; set; }

        [StringLength(128)]
        public string PremiumBannerLink { get; set; }

        [StringLength(512)]
        public string EnglishWorkingHours { get; set; }

        [StringLength(1024)]
        public string PromotionText { get; set; }

        public DateTime? PromotionStartDate { get; set; }

        public DateTime? PromotionEndDate { get; set; }

        public int PointFactor { get; set; }

        [StringLength(1024)]
        public string ZoodFoodUrl { get; set; }

        public bool IsAddedByUser { get; set; }

        public Guid? AddedByMemberUserId { get; set; }

        public bool IsOpen { get; set; }

        public DateTime? LastGeoUpdate { get; set; }

        public Guid? LastModifiedByUserId { get; set; }

        public string Details { get; set; }

        public DateTime? PromotionImageStartDate { get; set; }

        public DateTime? PromotionImageEndDate { get; set; }

        public Guid? PromotionImagePhotoId { get; set; }

        [StringLength(128)]
        public string PromotionTitle { get; set; }

        public string Neighbourhood { get; set; }

        public Guid? CityId { get; set; }

        public DateTime? CheckinOfferStartDate { get; set; }

        public DateTime? CheckinOfferEndDate { get; set; }

        [StringLength(512)]
        public string CheckinOfferTitle { get; set; }

        public string CheckinOfferDescription { get; set; }

        public int? CheckinOfferCoins { get; set; }

        public Guid? MayorshipMemberUserId { get; set; }

        public short? MealTime { get; set; }

        [StringLength(256)]
        public string SanaId { get; set; }

        public bool? HasReservation { get; set; }

        public DateTime? ReservationStartDate { get; set; }

        public DateTime? ReservationEndDate { get; set; }

        public int? ReservationFee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberComment> MemberComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberRating> MemberRatings { get; set; }

        public virtual MemberUser MemberUser { get; set; }

        public virtual MemberUser MemberUser1 { get; set; }
    }
}
