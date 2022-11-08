using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class MediumPlane : Aircraft
{
    public GameObject mediumPlanePrefab;
    public Camera mainCamera;
    private Vector3 offset = new Vector3(33, 2, 9);

    private void Awake()
    {
        mainCamera = FindObjectOfType<Camera>();
    }

    // POLYMORPHISM
    private void Reset()
    {
        speed = 20f;
        rotationSpeed = 60f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveAircraft();
        MoveCamera();
    }

    void MoveCamera()
    {
        mainCamera.transform.position = mediumPlanePrefab.transform.position + offset;
    }
}
