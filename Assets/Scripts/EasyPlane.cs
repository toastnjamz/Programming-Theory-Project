using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class EasyPlane : Aircraft
{
    // TODO: set private memebers for speed, rotationSpeed, and verticalInput
    public GameObject easyPlanePrefab;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(easyPlanePrefab, transform.position, easyPlanePrefab.transform.rotation);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveAircraft();
    }
}
