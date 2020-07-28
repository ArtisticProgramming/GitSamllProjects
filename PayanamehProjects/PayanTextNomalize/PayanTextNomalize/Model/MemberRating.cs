namespace PayanTextNomalize.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberRating")]
    public partial class MemberRating
    {
        public Guid MemberRatingId { get; set; }

        public int Rating { get; set; }

        public int RatingType { get; set; }

        public DateTime AddedDate { get; set; }

        public Guid? ItemId { get; set; }

        public Guid? MemberUserId { get; set; }

        public Guid MemberCommentId { get; set; }

        public virtual MemberComment MemberComment { get; set; }

        public virtual MemberUser MemberUser { get; set; }

        public virtual Venue Venue { get; set; }
    }
}
