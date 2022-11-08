using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class EasyPlane : Aircraft
{
    public GameObject easyPlanePrefab;
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
        mainCamera.transform.position = easyPlanePrefab.transform.position + offset;
    }
}
