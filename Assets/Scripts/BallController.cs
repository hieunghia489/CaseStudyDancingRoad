using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public string color;
    // Start is called before the first frame update
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if ( other.gameObject.GetComponent<BallAnimation>().color == color)
            {
                GameController.score++;
                FindObjectOfType<AudioManager>().PlaySound("Collect");
                Destroy(gameObject);
            }

        }
    }

}