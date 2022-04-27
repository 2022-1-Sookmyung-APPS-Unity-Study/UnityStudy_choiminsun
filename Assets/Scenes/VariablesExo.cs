using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesExo : MonoBehaviour
{
    public string FirstName = "Liam";
    public string LastName;
    public int birthYear;

    // Start is called before the first frame update
    void Start()
    {
        print("Your name is: " + FirstName + "" + LastName);
        print("Your initials are: " + FirstName[0] + LastName[0]);
        print("The length of you full name is " + (FirstName + LastName).Length);

        int randomnum = Random.Range(0, FirstName.Length);
        print("Here is a random number from your first name: " + FirstName[randomnum]);

        print("You were birth in " + birthYear.ToString() + " witch means  that You are " + (2022 - birthYear).ToString() + " years old");
        print("You have been alive for " + (birthYear*365).ToString() + " days");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
