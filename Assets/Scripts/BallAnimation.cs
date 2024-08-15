using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAnimation : MonoBehaviour
{
    public  string color;
    public Material[] materials;
   public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
       rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
        ChangeColor("Blue");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ChangeColor(string newcolor)
    {
        if (newcolor == "Blue")
        {
            color = "Blue";
            rend.sharedMaterial = materials[0];
        }
        else if (newcolor == "Red")
        {
            color = "Red";
            rend.sharedMaterial = materials[1];
        }else if (newcolor == "Yellow")
        {
            color = "Yellow";
            rend.sharedMaterial = materials[2];

        }
    }
}
