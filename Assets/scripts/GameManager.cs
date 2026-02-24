using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    [SerializeField] 
    [Range(1, 100)]
    int timeToEnd;
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
    }
        

    // Update is called once per frame
    void Update()
    {
        
    }
}
