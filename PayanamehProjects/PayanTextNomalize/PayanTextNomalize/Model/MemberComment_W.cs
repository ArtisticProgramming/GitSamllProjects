namespace PayanTextNomalize.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MemberComment_W
    {
        [Key]
        [Column(Order = 0)]
        public Guid MemberCommentId { get; set; }

        public string Body { get; set; }

        public string Body_After_Standardization { get; set; }

        public string Body_After_Cleaning { get; set; }

        public string Body_After_Steaming { get; set; }

        public string Body_After_RemovingStopWords { get; set; }

        public string PreProcessedBody { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime AddedDate { get; set; }

        public Guid? ItemId { get; set; }

        public bool? IsConfirmed { get; set; }

        [Key]
        [Column(Order = 2)]
        public Guid MemberUserId { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsFeatured { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short SentVia { get; set; }
    }
}
