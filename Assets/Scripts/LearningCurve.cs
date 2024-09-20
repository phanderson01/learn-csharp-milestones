using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    // hello and welcome to learningcurve smile
    public int CurrentAge = 30;
    public int AddedAge = 1;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
    }
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
