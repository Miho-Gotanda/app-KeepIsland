using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverFadeManager1 : MonoBehaviour
{
    private float alfa;
    private float speed = 0.005f;
   

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().color = new Color(255f, 255f, 255f, alfa);
        alfa += speed;
    }
}
