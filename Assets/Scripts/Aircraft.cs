using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    // add a variable for the prefab

    // Start is called before the first frame update
    void Start()
    {
        // in child classes, instantiate a prefab for their selected aircraft
    }

    // Move this to child classes
    void FixedUpdate()
    {
        MoveAircraft();
    }

    protected virtual void MoveAircraft()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
