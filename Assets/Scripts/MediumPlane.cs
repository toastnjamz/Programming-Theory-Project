using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class MediumPlane : Aircraft
{
    // TODO: set private memebers for speed, rotationSpeed, and verticalInput

    public GameObject mediumPlanePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(mediumPlanePrefab, transform.position, mediumPlanePrefab.transform.rotation);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveAircraft();
    }
}
