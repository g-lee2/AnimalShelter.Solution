namespace AnimalShelter.Models 
{
  public class Animal
  {
    public string Name { get; set; }
    public string Breed { get; set; }
    public string Type { get; set; }
    public int DateOfAdmittanceMonth { get; set; }
    public int DateOfAdmittanceDay { get; set; }
    public int DateOfAdmittanceYear { get; set; }
    public int AnimalId { get; set; }
  }
}
