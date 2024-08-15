using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static bool isGameStarted;
  public  GameObject guide;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        isGameStarted = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (SwipeManager.tap)
        {
            isGameStarted = true;
            FindObjectOfType<AudioManager>().PlaySound("Theme");
            Destroy(guide);
        }
    }
}
