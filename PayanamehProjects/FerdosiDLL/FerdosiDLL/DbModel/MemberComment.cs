namespace FerdosiDLL.DbModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberComment")]
    public partial class MemberComment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MemberComment()
        {
            MemberRatings = new HashSet<MemberRating>();
        }

        public Guid MemberCommentId { get; set; }

        public string Body { get; set; }

        public DateTime AddedDate { get; set; }

        public Guid? ItemId { get; set; }

        public bool? IsConfirmed { get; set; }

        public Guid MemberUserId { get; set; }

        public bool IsFeatured { get; set; }

        public short SentVia { get; set; }

        public virtual MemberUser MemberUser { get; set; }

        public virtual Venue Venue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MemberRating> MemberRatings { get; set; }
    }
}
