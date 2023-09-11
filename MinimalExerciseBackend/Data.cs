namespace MinimalExerciseBackend
{
    public class Data
    {
        public List<object> folders { get; set; }
        public List<Content> contents { get; set; }
        public int returnedContents { get; set; }
        public int returnedFolders { get; set; }
        public ContentCount contentCount { get; set; }
    }

}
