using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public int RedKey = 0;
    public int GreenKey = 0;
    public int GoldKey = 0;

    public int Points = 0;

    [SerializeField] 
    [Range(1, 100)]
    int timeToEnd;

    bool gamePaused = false;
    bool endGame = false;
    bool win = false;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        
        }
        InvokeRepeating(nameof(Stopper), 2, 1);
    }

    void Stopper()
    {
        timeToEnd--;
        Debug.Log($"Time: {timeToEnd}s");
        if (timeToEnd <= 0)
        {
            timeToEnd = 0;
            endGame = true;
        }
        if (endGame)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        CancelInvoke(nameof(Stopper));
        if (win)
        {
            Debug.Log("You Win!!! Reload?");
        }
        else
        {
            Debug.Log("You Lose!!! Reload?");
        }
    }
        
public void PauseGame()
    {
        Debug.Log("Pause game");
        Time.timeScale = 0;
        gamePaused = true;
    }

    public void ResumeGame()
    {
        Debug.Log("Resume game");
        Time.timeScale = 1;
        gamePaused = false;
    }
    void PauseCheck()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (gamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        PauseCheck();
    }

    public void AddPoints(int points)
    {
        Points += points;
    }

    public void AddTime(int addTimeValue)
    {
        timeToEnd += addTimeValue;
    }

    public void FreezeTime(int freezeDuration)
    {
        CancelInvoke(nameof(Stopper));
        InvokeRepeating(nameof(Stopper), freezeDuration, 1);
    }

public void AddKey(KeyColor color)
    {
        switch (color)
        {
            case KeyColor.Red:
                RedKey++;
                break;
            case KeyColor.Green:
                GreenKey++;
                break;
            case KeyColor.Gold:
                GoldKey++;
                break;
        }
    }



}
