using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private Transform[] shellPosition;
    [SerializeField]
    private GameObject shellPrefab;
    private int randomPosition;
    private float playerX;
    public bool gameClear;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Methods
    //プレイヤーの位置情報をもとに砲弾を生成するメソッド
    public void positionShell()
    {
        playerX = GameObject.FindWithTag("Player").transform.position.x;
        if (playerX <= 0.875f)
        {
            Instantiate(shellPrefab, shellPosition[0]);
        }
        else if (playerX <= 2.35f)
        {
            Instantiate(shellPrefab, shellPosition[1]);
        }
        else if (playerX <= 3.87f)
        {
            Instantiate(shellPrefab, shellPosition[2]);
        }
        else if (playerX <= 5.39f)
        {
            Instantiate(shellPrefab, shellPosition[3]);
        }
        else if (playerX <= 6.89f)
        {
            Instantiate(shellPrefab, shellPosition[7]);
        }
        else if (playerX <= 8.38f)
        {
            Instantiate(shellPrefab, shellPosition[4]);
        }
        else if (playerX <= 9.9f)
        {
            Instantiate(shellPrefab, shellPosition[5]);
        }
        else
        {
            Instantiate(shellPrefab, shellPosition[6]);
        }
        
    }
    #endregion
}
