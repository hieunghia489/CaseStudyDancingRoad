using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public GameObject Congrat;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        Congrat.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = GameController.score.ToString();
    }
  public  IEnumerator Congratulation()
    {
        Congrat.SetActive(true);            
        yield return new WaitForSeconds(2f);
        Congrat.SetActive(false); 
    }
}
