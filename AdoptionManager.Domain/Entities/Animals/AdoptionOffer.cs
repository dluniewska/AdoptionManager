namespace AdoptionManager.Domain.Entities.Animals
{
    public class AdoptionOffer
    {
        public int AdoptionOfferId { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int SKU { get; set; }
        public int QuatntityInStock { get; set; }
    }
}
