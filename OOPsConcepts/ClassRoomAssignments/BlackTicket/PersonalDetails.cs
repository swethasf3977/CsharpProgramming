namespace BlackTicket;
public class PersonalDetails
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }

    public PersonalDetails(string name , int age , string phoneNumber)
    {
        Name = name ;
        Age = age;
        PhoneNumber = phoneNumber ;
    }
     public PersonalDetails(string data)
        {
            string[] value = data.Split(",");
            
            Name = value[0];
            Age = int.Parse(value[1]);
            PhoneNumber = value[2];
          
        }

}