using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtl : MonoBehaviour
{
    public enum PlayerState
    {
        Run,
        Hole,
        Criate,
        Damage,
        Die,
        Clear
    }
    private PlayerState playerState;
    [SerializeField]
    private GameObject soilPrefab;
    [SerializeField]
    private Transform[] soilPosition;
    [SerializeField]
    private float speed = 5.0f;
    private Rigidbody rigid;
    private float rotateSpeed = 180.0f;
    private Animator anim;
    [SerializeField]
    private GameObject scoop;
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip holeClip;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerState = PlayerState.Run;
        rigid = GetComponent<Rigidbody>();
        scoop.SetActive(false);
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //何もしてない状態の場合の処理
        if (playerState == PlayerState.Run)
        {
            //移動
            float x = Input.GetAxis("Horizontal") * speed;
            float z = Input.GetAxis("Vertical") * speed;
            if (x != 0 || z != 0)
            {
                anim.SetBool("RunBool", true);
            }
            else if (x == 0 && z == 0)
            {
                anim.SetBool("RunBool", false);
            }
            rigid.velocity = new Vector3(x, rigid.velocity.y, z);
            Vector3 move = new Vector3(x, 0.0f, z);

            //回転
            Vector3 playerDir = move;
            if (playerDir.magnitude > 0.1f)
            {
                Quaternion q = Quaternion.LookRotation(playerDir);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, q, rotateSpeed * Time.deltaTime * 5f);
            }
            if (Input.GetMouseButtonDown(0))
            {
                SetState(PlayerState.Hole);
            }
            if (this.transform.position.y <=0.86)
            {
                SetState(PlayerState.Die);
            }
        }
        if (playerState == PlayerState.Die)
        {
            rigid.velocity = new Vector3(0f, -5f, 0f);
        }
    }

    #region Methods

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DestroyArea")
        {
            Invoke("OverSceneLoad", 0.5f);
        }
    }
    public void SetState(PlayerState state)
    {
        switch (state)
        {
            case PlayerState.Run:
                playerState = state;
                break;
            case PlayerState.Criate:
                break;
            case PlayerState.Hole:
                playerState = state;
                scoop.SetActive(true);
                anim.SetBool("RunBool", false);
                anim.SetTrigger("HoleTrigger");
                break;
            case PlayerState.Damage:
                playerState = state;
                anim.SetBool("RunBool", false);
                anim.SetTrigger("DamageTrigger");
                break;
            case PlayerState.Clear:
                playerState = state;
                anim.SetBool("RunBool", false);
                break;
            case PlayerState.Die:
                anim.SetTrigger("DownTrigger");
                playerState = state;
                break;

        }
    }
    public PlayerState GetState()
    {
        return playerState;
    }

    //土採掘
    public void HoleEnd()
    {
        SetState(PlayerState.Run);
        scoop.SetActive(false);
        Debug.Log("呼ばれた");
    }
    public void SoilCreate()
    {
        audioSource.PlayOneShot(holeClip);
        Instantiate(soilPrefab, soilPosition[0].position, Quaternion.identity);
    }
    public void SoilCreate1()
    {
        audioSource.PlayOneShot(holeClip);
        Instantiate(soilPrefab, soilPosition[1].position, Quaternion.identity);
    }
    public void SoilCreate2()
    {
        audioSource.PlayOneShot(holeClip);
        Instantiate(soilPrefab, soilPosition[2].position, Quaternion.identity);
    }

    //ダメージを受けたとき
    public void DamageEnd()
    {
        playerState = PlayerState.Run;
    }

    private void OverSceneLoad()
    {
        SceneManager.LoadScene("GameOver");
    }
    #endregion
}
