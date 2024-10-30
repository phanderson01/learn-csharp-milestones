using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    // hello and welcome to learningcurve smile
    public int CurrentAge = 30;
    public int AddedAge = 1;

    private int PhoebesFavoriteNumber = 8;
    public float HeresAnotherNumber = 1.4141414f;
    private string Introduction = "Hi! My name is Phoebe.";
    public string MyName = "Phoebe";
    public bool DoesPhoebeLikeThisClass = true;
    public string HowAreYou = "How are you today? ";
    public string ImGood = "I'm good, how are you?";
    int[] NewArray = { 17, 45, 6 };
    list<string> PhoebesNewList = newList<string>()
    {
        "Hi, My name is Phoebe."
        "I'm an art history major."
        "I really like tabletop games."
        "I also like coding, even though it's intimidating."
    };

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
        CreateCharacter("Phoebe", 20);
        EnjoymentofClass();
        Debug.Log(TestMethod(PhoebesFavoriteNumber, PhoebesFavoriteNumber));
        Debug.Log(ConditionalTest(PhoebesFavoriteNumber, PhoebesFavoriteNumber));
        SwitchTest();
        Debug.LogFormat("I have this many different introductions: {0}.", PhoebesNewList.Count)

    }

    /// <summary>
    /// this is a summary comment. this method calculates age using variables
    /// and simple arithmetic and prints a bunch of variables to the debug log
    /// </summary>

    public void CreateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);
    }

    public int TestMethod(int number, int secondnumber)
    {
       /* Debug.LogFormat(0 + 1, number, secondnumber);*/

        return (number + secondnumber);
    }

    public void EnjoymentofClass()
    {
        if(DoesPhoebeLikeThisClass)
        {
            Debug.Log("Phoebe likes this class.");

            if(PhoebesFavoriteNumber > 10)
            {
            Debug.Log("Your favorite number is really big!");
            }
        else if(PhoebesFavoriteNumber < 2)
            {
            Debug.Log("Your favorite number is really small!");
            }
        else
            {
            Debug.Log("Your favorite number is just right :)");
            }

        }
        else
        {
            Debug.Log("Phoebe does not like this class.");
        }

    }

    public bool ConditionalTest(int onenumber, int anothernumber)
    {
        if(onenumber >= anothernumber)
        {
            return true;
        }
        else
        {
            return !true;
        }
    }

    void SwitchTest()
    {
        switch(MyName)
        {
            case "Phoebe":
                Debug.Log("Your name is Phoebe.");
                break;

            case "Owen":
                Debug.Log("Your name is Owen.");
                break;

            default:
                Debug.Log("I don't know your name.");
                break;

        }
    }

    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);

        Debug.Log(PhoebesFavoriteNumber);
        Debug.Log(HeresAnotherNumber);
        Debug.Log(Introduction);
        Debug.Log(DoesPhoebeLikeThisClass);

        Debug.Log(HowAreYou + ImGood);
        Debug.Log($"Hello, my name is Phoebe. My favorite number is {PhoebesFavoriteNumber}.");
    }

    /* the difference between public and private variables is that public variables
        can be altered outside of the script (by programs like unity), while private
        variables can only be changed within the script */

    /*this is a multi line comment
        hello :) */

    // Update is called once per frame
    void Update()
    {
        
    }
}
