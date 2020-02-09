namespace DoAtaApi.Models
{
    public class DoAtaItem{
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public Type Type { get; set; }
    }
}