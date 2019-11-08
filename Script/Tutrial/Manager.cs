using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private GameObject firstPanel;
    [SerializeField]
    private GameObject shipCanvas;
    [SerializeField]
    private GameObject chatImage;
    [SerializeField]
    private GameObject shipChatImage;
    [SerializeField]
    private Text chatText;
    [SerializeField]
    private Text shipChatText;
    [SerializeField]
    private GameObject RuleCanvas;
    private int touchCount=0;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& !EventSystem.current.IsPointerOverGameObject())
        {
            
                touchCount++;
                Debug.Log(touchCount);
                if (touchCount == 1)
                {
                    firstPanel.SetActive(false);
                    audioSource.Play();
                    shipCanvas.SetActive(true);
                }
                else
                {
                    if (touchCount == 2)
                    {
                        chatText.text = "海賊団は笑いながら叫んだ";
                    }
                    else if (touchCount == 3)
                    {
                        chatImage.SetActive(false);
                        shipChatImage.SetActive(true);
                    }
                    else if (touchCount == 4)
                    {
                        shipChatText.text = "お前みたいなちびにできるかな？";
                    }
                    else if (touchCount == 5)
                    {
                        shipChatImage.SetActive(false);
                        chatImage.SetActive(true);
                        chatText.fontSize = 36;
                        chatText.text = "砲弾に耐えて島を危機から救い出せ！";
                    }
                    else if (touchCount == 6)
                    {
                        shipCanvas.SetActive(false);
                        RuleCanvas.SetActive(true);
                    }
                    else if (touchCount == 7)
                    {
                        SceneManager.LoadScene("Main");
                    }
                }
        }
    }
    public void SkipButton()
    {
        SceneManager.LoadScene("Main");
    }
}
