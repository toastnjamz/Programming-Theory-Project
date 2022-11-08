using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class HardPlane : Aircraft
{
    // TODO: set private memebers for speed, rotationSpeed, and verticalInput

    public GameObject hardPlanePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(hardPlanePrefab, transform.position, hardPlanePrefab.transform.rotation);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveAircraft();
    }
}
