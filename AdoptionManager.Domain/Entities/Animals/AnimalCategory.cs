namespace AdoptionManager.Domain.Entities.Animals
{
    public class AnimalCategory
    {
        public int AnimalCategoryId { get; set; }
        public int ParentCategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
