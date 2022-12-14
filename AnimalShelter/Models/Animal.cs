namespace AnimalShelter.Models 
{
  public class Animal
  {
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Type { get; set; }
    public int dateOfAdmittanceMonth { get; set; }
    public int dateOfAdmittanceDay { get; set; }
    public int dateOfAdmittanceYear { get; set; }
    public int AnimalId { get; set; }
    
  }
}