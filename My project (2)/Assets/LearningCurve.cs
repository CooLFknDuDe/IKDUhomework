using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int startAge = 1;
    public int currentAge;

    // Start is called before the first frame update
    void Start()
    {
        ageIncrement = startAge + currentAge;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
