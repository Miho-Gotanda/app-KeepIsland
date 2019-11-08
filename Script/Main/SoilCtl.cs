using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoilCtl : MonoBehaviour
{
    private Text soilCounttext;
    public int soilcounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        soilCounttext = GameObject.Find("SoilCountText").GetComponent<Text>(); ;
    }

    // Update is called once per frame
    void Update()
    {
        soilCounttext.text = "土×" + soilcounter.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Soil")
        {
            soilcounter++;
            Destroy(other.gameObject);
        }
    }
}
