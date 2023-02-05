using Lab2.Models;

namespace Lab2.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<About> about { get; set; }
        public List<Counts>  counts { get; set; }
        public List<Courses>  courses { get; set; }
        public List<Events> events  { get; set; }
        public List<Features>  features { get; set; }
        public List<Images>  images { get; set; }
        public List<Pricing>  pricing { get; set; }
        public List<Trainers>  trainers { get; set; }
        public List<Home> home { get; set; }
        public List<WhyUs> whyUs { get; set; }
        public List<WhyUsBoxes> whyUsBoxes { get; set; }
    }
}
