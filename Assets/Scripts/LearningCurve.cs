using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    // hello and welcome to learningcurve smile
    public int CurrentAge = 30;
    public int AddedAge = 1;

    public int PhoebesFavoriteNumber = 8;
    public F HeresAnotherNumber = 1.4141414;
    private string Introduction = "Hi! My name is Phoebe.";
    public bool DoesPhoebeLikeThisClass = true;


    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
    }

    /// <summary>
    /// this is a summary comment. this method calculates age using variables
    /// and simple arithmetic
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    /*this is a multi line comment
        hello :) */

    // Update is called once per frame
    void Update()
    {
        
    }
}
