using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 { 
    //property
    public string Number { get; init; }

            // constructor
    public SSN() { }
    public string GenerateInvaildSSN()
{
    // create a variable to store the value we will return
    string invalidSSN = String.Empty;
    Random random = new Random();

    //generate a random number form 900-999 and convert it to a string
    var nineHundredSeries = random.Next(900, 1000).ToString();
    var firstThreeArray = new string[] {"000", "666", nineHundredSeries};
    var firstThree = firstThreeArray[random.Next(3)];
    var secondTwo = "00";
    var lastFour = "0000";

    GenerateInvaildSSN = string.Concat(firstThree, secondTwo, lastFour);
    return invalidSSN;

}

    public overide string ToString()
{
    string socialSecurityNumber = RandomNumberGenerator;
    socialSecurityNumber = socialSecurityNumber.Insert(3, "-");
    socialSecurityNumber = socialSecurityNumber.Insert(6, "-");
    return socialSecurityNumber;
}