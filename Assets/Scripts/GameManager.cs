using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Aircraft playerAircraft;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetPlayerAircraft(int difficulty)
    {
        if (difficulty == 1)
        {
            // if easy, select plane prefab and have game manager instantiate it and assign it to the player
            // playerAircraft = 
        }
        if (difficulty == 2)
        {
            // if medium, select prop plane 
            // playerAircraft = 
        }
        if (difficulty == 3)
        {
            // if hard, select jet
            // playerAircraft = 
        }
        // set up an else statement for internal error
    }
    
    // pass in the player's aircraft instead of difficulty
    public void StartGame(Aircraft playerAircraft)
    {
        SceneManager.LoadScene(1);

    }
}
