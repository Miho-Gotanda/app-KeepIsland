using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearManager : MonoBehaviour
{
    private float timer = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var timers = timer += Time.deltaTime;
        Debug.Log(timers);
        if (Input.GetMouseButton(0)&&timers>=3.5f)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
