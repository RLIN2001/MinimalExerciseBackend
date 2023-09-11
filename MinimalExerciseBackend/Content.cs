namespace MinimalExerciseBackend
{
    public class Content
    {
        public bool liveStatusOnAir { get; set; }
        public bool liveStatusRecording { get; set; }
        public string onDemandFileName { get; set; }
        public string onDemandEncodingDescription { get; set; }
        public string onDemandDuration { get; set; }
        public string gidEncodingProfileOnDemand { get; set; }
        public bool liveMultibitrate { get; set; }
        public string title { get; set; }
        public bool trash { get; set; }
        public bool hasPoster { get; set; }
        public int onDemandEncodingStatus { get; set; }
        public string gidProperty { get; set; }
        public string contentId { get; set; }
        public int contentType { get; set; }
        public int deliveryStatus { get; set; }
        public bool protectedEmbed { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime updateDate { get; set; }
        public DateTime publishDateUTC { get; set; }
        public int publishStatus { get; set; }
        public string imageUrl { get; set; }
    }

  
}
