using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // ENCAPSULATION
    public static GameManager Instance { get; private set; }
    public int playerSelectedDifficulty;

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
        playerSelectedDifficulty = difficulty;
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
