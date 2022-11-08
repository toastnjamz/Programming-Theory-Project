using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public int difficulty;
    public EasyPlane playerEasyPlane;
    public MediumPlane playerMediumPlane;
    public HardPlane playerHardPlane;
    
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.Instance != null)
        {
            difficulty = GameManager.Instance.playerSelectedDifficulty;
            Debug.Log("Difficulty set from GameManager instance");
            InstantiatePlayerAircraft(difficulty);
        }
    }

    private void InstantiatePlayerAircraft(int difficulty)
    {
        if (difficulty == 1)
        {
            // if easy, instantiate new EasyPlane object
            Instantiate(playerEasyPlane, transform.position, transform.rotation);
        }
        if (difficulty == 2)
        {
            // if medium, instantiate new MediumPlane object
            Instantiate(playerMediumPlane, transform.position, transform.rotation);
        }
        if (difficulty == 3)
        {
            // if hard, instantiate new HardPlane object
            Instantiate(playerHardPlane, transform.position, transform.rotation);
        }
        // set up an else statement for error handling
    }
}
