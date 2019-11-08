using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCountCtl : MonoBehaviour
{
    [SerializeField]
    private GameObject timeText;
    private Text timetext;
    private float count=120f;
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AudioClip clip;
    [SerializeField]
    private GameObject clearText;
    [SerializeField]
    private GameObject musicObj;
    [SerializeField]
    private PlayerCtl playerCtl;

    void Start()
    {
        timetext = timeText.GetComponent<Text>();
        timetext.text = "Time:" + count;
    }

    // Update is called once per frame
    void Update()
    {
        count -= Time.deltaTime;
        var fCount=count.ToString("F1");
        timetext.text = "Time:" + fCount;

        //クリア時処理
        if (count <= 0)
        {
            playerCtl.SetState(PlayerCtl.PlayerState.Clear);
            timetext.text = "Time" + 0.ToString();
            gameManager.gameClear = true;
            musicObj.SetActive(false);
            source.PlayOneShot(clip);
            clearText.SetActive(true);
            Invoke("ClearLoad", 5f);
        }
    }

    private void ClearLoad()
    {
        SceneManager.LoadScene("Clear");
    }
   
}
