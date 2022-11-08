using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class HardPlane : Aircraft
{
    // POLYMORPHISM
    // TODO: set private memebers for speed, rotationSpeed, and verticalInput

    public GameObject hardPlanePrefab;
    public Camera mainCamera;
    private Vector3 offset = new Vector3(33, 2, 9);

    private void Awake()
    {
        mainCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveAircraft();
        MoveCamera();
    }

    void MoveCamera()
    {
        mainCamera.transform.position = hardPlanePrefab.transform.position + offset;
    }
}
