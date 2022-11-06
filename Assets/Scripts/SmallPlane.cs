using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPlane : Aircraft
{
    public GameObject smallPlanePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(smallPlanePrefab, transform.position, smallPlanePrefab.transform.rotation);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveAircraft();
    }
}
