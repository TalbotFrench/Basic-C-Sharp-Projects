using System;

namespace Insurance.ViewModels { 
public class UserInputVm
{
	public int Id { get; set; }
    public string FirstName{ get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public int DateOfBirth { get; set; }
    public int CarYear { get; set; }
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public bool Dui { get; set; }
    public int SpeedingTickets { get; set; }
    public bool FullCoverage { get; set; }

}

}
