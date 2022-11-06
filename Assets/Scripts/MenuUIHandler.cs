using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // not sure I even need this or this whole class...
    public void NewAircraftSelected(Aircraft aircraft)
    {
        GameManager.Instance.playerAircraft = aircraft;
    }
}
