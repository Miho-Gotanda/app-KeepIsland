using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCtl : MonoBehaviour
{
    [SerializeField]
    private GameObject[] blockPrefab;
    int posNumber;
    private bool[] hitBool;
    private SoilCtl soilCtl;
    [SerializeField]
    private AudioClip clip;
    [SerializeField]
    private AudioClip badClip;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        soilCtl = GameObject.FindGameObjectWithTag("Player").GetComponent<SoilCtl>();
        hitBool = new bool[48];
    }

    // Update is called once per frame
    void Update()
    {
        //左クリックでブロック生成
        if (Input.GetMouseButtonDown(1))
        {
            if(soilCtl.soilcounter >= 3)
            {
                Ray();
            }
            else if (soilCtl.soilcounter <= 3)
            {
                audioSource.PlayOneShot(badClip);
            }

        }
    }

    #region Methods
    //レイを飛ばしてクリック位置確認
    void Ray()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        int layerMask = (1 << LayerMask.NameToLayer("Block"));

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
        {
            Vector3 pos = new Vector3(hit.point.x, 0f, hit.point.z);
            SetPosNumber(pos);
        }
    }
   //マスごとに番号をセット
    void SetPosNumber(Vector3 pos)
    {
        if (-0.75f <= pos.x&&pos.x<=0.75f)
        {
            if(-0.75f <= pos.z && pos.z <= 0.75f)
            {
                posNumber = 1;
                SetPosition(posNumber);
            }
            else if (0.76f <= pos.z && pos.z <= 2.25f)
            {
                posNumber = 2;
                SetPosition(posNumber);
            }
            else if (2.26f <= pos.z && pos.z <= 3.75f)
            {
                posNumber = 3;
                SetPosition(posNumber);
            }
            else if (3.76f <= pos.z && pos.z <= 5.25f)
            {
                posNumber = 4;
                SetPosition(posNumber);
            }
            else if (5.26f <= pos.z && pos.z <= 6.75f)
            {
                posNumber = 5;
                SetPosition(posNumber);
            }
            else if (6.76f <= pos.z && pos.z <= 8.25f)
            {
                posNumber = 6;
                SetPosition(posNumber);
            }
            else
            {
                Debug.Log("None!");
                audioSource.PlayOneShot(badClip);
            }

        }
        else if (0.76f <= pos.x && pos.x <= 2.25f)
        {
            if (-0.75f <= pos.z && pos.z <= 0.75f)
            {
                posNumber = 7;
                SetPosition(posNumber);
            }
            else if (0.76f <= pos.z && pos.z <= 2.25f)
            {
                posNumber = 8;
                SetPosition(posNumber);
            }
            else if (2.26f <= pos.z && pos.z <= 3.75f)
            {
                posNumber = 9;
                SetPosition(posNumber);
            }
            else if (3.76f <= pos.z && pos.z <= 5.25f)
            {
                posNumber = 10;
                SetPosition(posNumber);
            }
            else if (5.26f <= pos.z && pos.z <= 6.75f)
            {
                posNumber = 11;
                SetPosition(posNumber);
            }
            else if (6.76f <= pos.z && pos.z <= 8.25f)
            {
                posNumber = 12;
                SetPosition(posNumber);
            }
            else
            {
                Debug.Log("None!");
                audioSource.PlayOneShot(badClip);
            }
        }
        else if (2.26f <= pos.x && pos.x <= 3.75f)
        {
            if (-0.75f <= pos.z && pos.z <= 0.75f)
            {
                posNumber = 13;
                SetPosition(posNumber);
            }
            else if (0.76f <= pos.z && pos.z <= 2.25f)
            {
                posNumber = 14;
                SetPosition(posNumber);
            }
            else if (2.26f <= pos.z && pos.z <= 3.75f)
            {
                posNumber = 15;
                SetPosition(posNumber);
            }
            else if (3.76f <= pos.z && pos.z <= 5.25f)
            {
                posNumber = 16;
                SetPosition(posNumber);
            }
            else if (5.26f <= pos.z && pos.z <= 6.75f)
            {
                posNumber = 17;
                SetPosition(posNumber);
            }
            else if (6.76f <= pos.z && pos.z <= 8.25f)
            {
                posNumber = 18;
                SetPosition(posNumber);
            }
            else
            {
                Debug.Log("None!");
                audioSource.PlayOneShot(badClip);
            }
        }
        else if (3.76f <= pos.x && pos.x <= 5.25f)
        {
            if (-0.75f <= pos.z && pos.z <= 0.75f)
            {
                posNumber = 19;
                SetPosition(posNumber);
            }
            else if (0.76f <= pos.z && pos.z <= 2.25f)
            {
                posNumber = 20;
                SetPosition(posNumber);
            }
            else if (2.26f <= pos.z && pos.z <= 3.75f)
            {
                posNumber = 21;
                SetPosition(posNumber);
            }
            else if (3.76f <= pos.z && pos.z <= 5.25f)
            {
                posNumber = 22;
                SetPosition(posNumber);
            }
            else if (5.26f <= pos.z && pos.z <= 6.75f)
            {
                posNumber = 23;
                SetPosition(posNumber);
            }
            else if (6.76f <= pos.z && pos.z <= 8.25f)
            {
                posNumber = 24;
                SetPosition(posNumber);
            }
            else
            {
                Debug.Log("None!");
                audioSource.PlayOneShot(badClip);
            }
        }
        else if (5.26f <= pos.x && pos.x <= 6.75f)
        {
            if (-0.75f <= pos.z && pos.z <= 0.75f)
            {
                posNumber = 25;
                SetPosition(posNumber);
            }
            else if (0.76f <= pos.z && pos.z <= 2.25f)
            {
                posNumber = 26;
                SetPosition(posNumber);
            }
            else if (2.26f <= pos.z && pos.z <= 3.75f)
            {
                posNumber = 27;
                SetPosition(posNumber);
            }
            else if (3.76f <= pos.z && pos.z <= 5.25f)
            {
                posNumber = 28;
                SetPosition(posNumber);
            }
            else if (5.26f <= pos.z && pos.z <= 6.75f)
            {
                posNumber = 29;
                SetPosition(posNumber);
            }
            else if (6.76f <= pos.z && pos.z <= 8.25f)
            {
                posNumber = 30;
                SetPosition(posNumber);
            }
            else
            {
                Debug.Log("None!");
                audioSource.PlayOneShot(badClip);
            }
        }
        else if (6.76f <= pos.x && pos.x <= 8.25f)
        {
            if (-0.75f <= pos.z && pos.z <= 0.75f)
            {
                posNumber = 31;
                SetPosition(posNumber);
            }
            else if (0.76f <= pos.z && pos.z <= 2.25f)
            {
                posNumber = 32;
                SetPosition(posNumber);
            }
            else if (2.26f <= pos.z && pos.z <= 3.75f)
            {
                posNumber = 33;
                SetPosition(posNumber);
            }
            else if (3.76f <= pos.z && pos.z <= 5.25f)
            {
                posNumber = 34;
                SetPosition(posNumber);
            }
            else if (5.26f <= pos.z && pos.z <= 6.75f)
            {
                posNumber = 35;
                SetPosition(posNumber);
            }
            else if (6.76f <= pos.z && pos.z <= 8.25f)
            {
                posNumber = 36;
                SetPosition(posNumber);
            }
            else
            {
                Debug.Log("None!");
                audioSource.PlayOneShot(badClip);
            }
        }
        else if (8.26f <= pos.x && pos.x <= 9.75f)
        {
            if (-0.75f <= pos.z && pos.z <= 0.75f)
            {
                posNumber = 37;
                SetPosition(posNumber);
            }
            else if (0.76f <= pos.z && pos.z <= 2.25f)
            {
                posNumber = 38;
                SetPosition(posNumber);
            }
            else if (2.26f <= pos.z && pos.z <= 3.75f)
            {
                posNumber = 39;
                SetPosition(posNumber);
            }
            else if (3.76f <= pos.z && pos.z <= 5.25f)
            {
                posNumber = 40;
                SetPosition(posNumber);
            }
            else if (5.26f <= pos.z && pos.z <= 6.75f)
            {
                posNumber = 41;
                SetPosition(posNumber);
            }
            else if (6.76f <= pos.z && pos.z <= 8.25f)
            {
                posNumber = 42;
                SetPosition(posNumber);
            }
            else
            {
                Debug.Log("None!");
                audioSource.PlayOneShot(badClip);
            }
        }
        else if (9.76f <= pos.x && pos.x <= 11.25f)
        {
            if (-0.75f <= pos.z && pos.z <= 0.75f)
            {
                posNumber = 43;
                SetPosition(posNumber);
            }
            else if (0.76f <= pos.z && pos.z <= 2.25f)
            {
                posNumber = 44;
                SetPosition(posNumber);
            }
            else if (2.26f <= pos.z && pos.z <= 3.75f)
            {
                posNumber = 45;
                SetPosition(posNumber);
            }
            else if (3.76f <= pos.z && pos.z <= 5.25f)
            {
                posNumber = 46;
                SetPosition(posNumber);
            }
            else if (5.26f <= pos.z && pos.z <= 6.75f)
            {
                posNumber = 47;
                SetPosition(posNumber);
            }
            else if (6.76f <= pos.z && pos.z <= 8.25f)
            {
                posNumber = 48;
                SetPosition(posNumber);
            }
            else
            {
                Debug.Log("None!");
                audioSource.PlayOneShot(badClip);
            }
        }
        else
        {
            Debug.Log("None!");
            audioSource.PlayOneShot(badClip);
        }
 
    }
    //番号付近のタッチで番号の位置にインスタンス
    void SetPosition(int Number)
    {
        int randomValue = Random.Range(0, 4);
        switch (posNumber)
        {
            case 1:
                if (hitBool[0])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(0, 0, 0), Quaternion.identity);
                    hitBool[0] = false;
                }
                break;
            case 2:
                if (hitBool[1])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(0f, 0f, 1.5f), Quaternion.identity);
                    hitBool[1] = false;
                }
                break;
            case 3:
                if (hitBool[2])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(0f, 0f, 3f), Quaternion.identity);
                    hitBool[2] = false;
                }
                break;
            case 4:
                if (hitBool[3])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(0f, 0f, 4.5f), Quaternion.identity);
                    hitBool[3] = false;
                }
                break;
            case 5:
                if (hitBool[4])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(0f, 0f, 6f), Quaternion.identity);
                    hitBool[4] = false;
                }
                break;
            case 6:
                if (hitBool[5])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(0f, 0f, 7.5f), Quaternion.identity);
                    hitBool[5] = false;
                }
                break;
            case 7:
                if (hitBool[6])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(1.5f, 0f, 0f), Quaternion.identity);
                    hitBool[6] = false;
                }
                break;
            case 8:
                if (hitBool[7])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(1.5f, 0f, 1.5f), Quaternion.identity);
                    hitBool[7] = false;
                }
                break;
            case 9:
                if (hitBool[8])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(1.5f, 0f, 3f), Quaternion.identity);
                    hitBool[8] = false;
                }
                break;
            case 10:
                if (hitBool[9])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(1.5f, 0f, 4.5f), Quaternion.identity);
                    hitBool[9] = false;
                }
                break;
            case 11:
                if (hitBool[10])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(1.5f, 0f, 6f), Quaternion.identity);
                    hitBool[10] = false;
                }
                break;
            case 12:
                if (hitBool[11])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(1.5f, 0f, 7.5f), Quaternion.identity);
                    hitBool[11] = false;
                }
                break;
            case 13:
                if (hitBool[12])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(3f, 0f, 0f), Quaternion.identity);
                    hitBool[12] = false;
                }
                break;
            case 14:
                if (hitBool[13])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(3f, 0f, 1.5f), Quaternion.identity);
                    hitBool[13] = false;
                }
                break;
            case 15:
                if (hitBool[14])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(3f, 0f, 3f), Quaternion.identity);
                    hitBool[14] = false;
                }
                break;
            case 16:
                if (hitBool[15])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(3f, 0f, 4.5f), Quaternion.identity);
                    hitBool[15] = false;
                }
                break;
            case 17:
                if (hitBool[16])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(3f, 0f, 6f), Quaternion.identity);
                    hitBool[16] = false;
                }
                break;
            case 18:
                if (hitBool[17])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(3f, 0f, 7.5f), Quaternion.identity);
                    hitBool[17] = false;
                }
                break;
            case 19:
                if (hitBool[18])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(4.5f, 0f, 0f), Quaternion.identity);
                    hitBool[18] = false;
                }
                break;
            case 20:
                if (hitBool[19])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(4.5f, 0f, 1.5f), Quaternion.identity);
                    hitBool[19] = false;
                }
                break;
            case 21:
                if (hitBool[20])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(4.5f, 0f, 3f), Quaternion.identity);
                    hitBool[20] = false;
                }
                break;
            case 22:
                if (hitBool[21])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(4.5f, 0f, 4.5f), Quaternion.identity);
                    hitBool[21] = false;
                }
                break;
            case 23:
                if (hitBool[22])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(4.5f, 0f, 6f), Quaternion.identity);
                    hitBool[22] = false;
                }
                break;
            case 24:
                if (hitBool[23])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(4.5f, 0f, 7.5f), Quaternion.identity);
                    hitBool[23] = false;
                }
                break;
            case 25:
                if (hitBool[24])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(6f, 0f, 0f), Quaternion.identity);
                    hitBool[24] = false;
                }
                break;
            case 26:
                if (hitBool[25])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(6f, 0f, 1.5f), Quaternion.identity);
                    hitBool[25] = false;
                }
                break;
            case 27:
                if (hitBool[26])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(6f, 0f, 3f), Quaternion.identity);
                    hitBool[26] = false;
                }
                break;
            case 28:
                if (hitBool[27])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(6f, 0f, 4.5f), Quaternion.identity);
                    hitBool[27] = false;
                }
                break;
            case 29:
                if (hitBool[28])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(6f, 0f, 6f), Quaternion.identity);
                    hitBool[28] = false;
                }
                break;
            case 30:
                if (hitBool[29])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(6f, 0f, 7.5f), Quaternion.identity);
                    hitBool[29] = false;
                }
                break;
            case 31:
                if (hitBool[30])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(7.5f, 0f, 0f), Quaternion.identity);
                    hitBool[30] = false;
                }
                break;
            case 32:
                if (hitBool[31])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(7.5f, 0f, 1.5f), Quaternion.identity);
                    hitBool[31] = false;
                }
                break;
            case 33:
                if (hitBool[32])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(7.5f, 0f, 3f), Quaternion.identity);
                    hitBool[32] = false;
                }
                break;
            case 34:
                if (hitBool[33])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(7.5f, 0f, 4.5f), Quaternion.identity);
                    hitBool[33] = false;
                }
                break;
            case 35:
                if (hitBool[34])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(7.5f, 0f, 6f), Quaternion.identity);
                    hitBool[34] = false;
                }
                break;
            case 36:
                if (hitBool[35])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(7.5f, 0f, 7.5f), Quaternion.identity);
                    hitBool[35] = false;
                }
                break;
            case 37:
                if (hitBool[36])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(9f, 0f, 0f), Quaternion.identity);
                    hitBool[36] = false;
                }
                break;
            case 38:
                if (hitBool[37])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(9f, 0f, 1.5f), Quaternion.identity);
                    hitBool[37] = false;
                }
                break;
            case 39:
                if (hitBool[38])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(9f, 0f, 3f), Quaternion.identity);
                    hitBool[38] = false;
                }
                break;
            case 40:
                if (hitBool[39])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(9f, 0f, 4.5f), Quaternion.identity);
                    hitBool[39] = false;
                }
                break;
            case 41:
                if (hitBool[40])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(9f, 0f, 6f), Quaternion.identity);
                    hitBool[40] = false;
                }
                break;
            case 42:
                if (hitBool[41])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(9f, 0f, 7.5f), Quaternion.identity);
                    hitBool[41] = false;
                }
                break;
            case 43:
                if (hitBool[42])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(10.5f, 0f, 0f), Quaternion.identity);
                    hitBool[42] = false;
                }
                break;
            case 44:
                if (hitBool[43])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(10.5f, 0f, 1.5f), Quaternion.identity);
                    hitBool[43] = false;
                }
                break;
            case 45:
                if (hitBool[44])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(10.5f, 0f, 3f), Quaternion.identity);
                    hitBool[44] = false;
                }
                break;
            case 46:
                if (hitBool[45])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(10.5f, 0f, 4.5f), Quaternion.identity);
                    hitBool[45] = false;
                }
                break;
            case 47:
                if (hitBool[46])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(10.5f, 0f, 6f), Quaternion.identity);
                    hitBool[46] = false;
                }
                break;
            case 48:
                if (hitBool[47])
                {
                    soilCtl.soilcounter -= 3;
                    audioSource.PlayOneShot(clip);
                    Instantiate(blockPrefab[randomValue], new Vector3(10.5f, 0f, 7.5f), Quaternion.identity);
                    hitBool[47] = false;
                }
                break;
        }
    }
    //同じ座標にブロックを生成しないための判定メソッド
    public void BlockBool(Vector3 hitPos)
    {
        if(hitPos==new Vector3(0f, 0f, 0f))
        {
            hitBool[0] = true;
        }
        else if(hitPos==new Vector3(0f, 0f, 1.5f))
        {
            hitBool[1] = true;
        }
        else if (hitPos == new Vector3(0f, 0f, 3f))
        {
            hitBool[2] = true;
        }
        else if (hitPos == new Vector3(0f, 0f, 4.5f))
        {
            hitBool[3] = true;
        }
        else if (hitPos == new Vector3(0f, 0f, 6f))
        {
            hitBool[4] = true;
        }
        else if (hitPos == new Vector3(0f, 0f, 7.5f))
        {
            hitBool[5] = true;
        }
        else if (hitPos == new Vector3(1.5f, 0f, 0f))
        {
            hitBool[6] = true;
        }
        else if (hitPos == new Vector3(1.5f, 0f, 1.5f))
        {
            hitBool[7] = true;
        }
        else if (hitPos == new Vector3(1.5f, 0f, 3f))
        {
            hitBool[8] = true;
        }
        else if (hitPos == new Vector3(1.5f, 0f, 4.5f))
        {
            hitBool[9] = true;
        }
        else if (hitPos == new Vector3(1.5f, 0f, 6f))
        {
            hitBool[10] = true;
        }
        else if (hitPos == new Vector3(1.5f, 0f, 7.5f))
        {
            hitBool[11] = true;
        }
        else if (hitPos == new Vector3(3f, 0f, 0f))
        {
            hitBool[12] = true;
        }
        else if (hitPos == new Vector3(3f, 0f, 1.5f))
        {
            hitBool[13] = true;
        }
        else if (hitPos == new Vector3(3f, 0f, 3f))
        {
            hitBool[14] = true;
        }
        else if (hitPos == new Vector3(3f, 0f, 4.5f))
        {
            hitBool[15] = true;
        }
        else if (hitPos == new Vector3(3f, 0f, 6f))
        {
            hitBool[16] = true;
        }
        else if (hitPos == new Vector3(3f, 0f, 7.5f))
        {
            hitBool[17] = true;
        }
        else if (hitPos == new Vector3(4.5f, 0f, 0f))
        {
            hitBool[18] = true;
        }
        else if (hitPos == new Vector3(4.5f, 0f, 1.5f))
        {
            hitBool[19] = true;
        }
        else if (hitPos == new Vector3(4.5f, 0f, 3f))
        {
            hitBool[20] = true;
        }
        else if (hitPos == new Vector3(4.5f, 0f, 4.5f))
        {
            hitBool[21] = true;
        }
        else if (hitPos == new Vector3(4.5f, 0f, 6f))
        {
            hitBool[22] = true;
        }
        else if (hitPos == new Vector3(4.5f, 0f, 7.5f))
        {
            hitBool[23] = true;
        }
        else if (hitPos == new Vector3(6f, 0f, 0f))
        {
            hitBool[24] = true;
        }
        else if (hitPos == new Vector3(6f, 0f, 1.5f))
        {
            hitBool[25] = true;
        }
        else if (hitPos == new Vector3(6f, 0f, 3f))
        {
            hitBool[26] = true;
        }
        else if (hitPos == new Vector3(6f, 0f, 4.5f))
        {
            hitBool[27] = true;
        }
        else if (hitPos == new Vector3(6f, 0f, 6f))
        {
            hitBool[28] = true;
        }
        else if (hitPos == new Vector3(6f, 0f, 7.5f))
        {
            hitBool[29] = true;
        }
        else if (hitPos == new Vector3(7.5f, 0f, 0f))
        {
            hitBool[30] = true;
        }
        else if (hitPos == new Vector3(7.5f, 0f, 1.5f))
        {
            hitBool[31] = true;
        }
        else if (hitPos == new Vector3(7.5f, 0f, 3f))
        {
            hitBool[32] = true;
        }
        else if (hitPos == new Vector3(7.5f, 0f, 4.5f))
        {
            hitBool[33] = true;
        }
        else if (hitPos == new Vector3(7.5f, 0f, 6f))
        {
            hitBool[34] = true;
        }
        else if (hitPos == new Vector3(7.5f, 0f, 7.5f))
        {
            hitBool[35] = true;
        }
        else if (hitPos == new Vector3(9f, 0f, 0f))
        {
            hitBool[36] = true;
        }
        else if (hitPos == new Vector3(9f, 0f, 1.5f))
        {
            hitBool[37] = true;
        }
        else if (hitPos == new Vector3(9f, 0f, 3f))
        {
            hitBool[38] = true;
        }
        else if (hitPos == new Vector3(9f, 0f, 4.5f))
        {
            hitBool[39] = true;
        }
        else if (hitPos == new Vector3(9f, 0f, 6f))
        {
            hitBool[40] = true;
        }
        else if (hitPos == new Vector3(9f, 0f, 7.5f))
        {
            hitBool[41] = true;
        }
        else if (hitPos == new Vector3(10.5f, 0f, 0f))
        {
            hitBool[42] = true;
        }
        else if (hitPos == new Vector3(10.5f, 0f, 1.5f))
        {
            hitBool[43] = true;
        }
        else if (hitPos == new Vector3(10.5f, 0f, 3f))
        {
            hitBool[44] = true;
        }
        else if (hitPos == new Vector3(10.5f, 0f, 4.5f))
        {
            hitBool[45] = true;
        }
        else if (hitPos == new Vector3(10.5f, 0f, 6f))
        {
            hitBool[46] = true;
        }
        else if (hitPos == new Vector3(10.5f, 0f, 7.5f))
        {
            hitBool[47] = true;
        }

    }
    #endregion
}
