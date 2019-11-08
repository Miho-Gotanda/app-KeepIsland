using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellCtl : MonoBehaviour
{
    private Rigidbody rigid;
    [SerializeField]
    private float forceMagnitude;
    public GameObject explosion;
    private int count = 0;
    private GameManager gameManager;
    private BlockCtl blockCtl;
    private float[] randomMagnitude = { 7f, 7.5f, 8f, 8.5f, 9f, 9.5f };
    
    

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        var gameManagerObj = GameObject.Find("GameManager");
        gameManager = gameManagerObj.GetComponent<GameManager>();
        blockCtl = gameManagerObj.GetComponent<BlockCtl>();
    }
    void Start()
    {
        ShellImpu();
    }

    private void ShellImpu()
    {
        //力を加える向き
        Vector3 forceDirection = new Vector3(0f, 1.05f, 1f);
        Vector3 force = randomMagnitude[Random.Range(0,6)] * forceDirection;
        rigid.AddForce(force, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Block"&&count==0||collision.gameObject.tag=="DestroyArea"||collision.gameObject.tag=="Player")
        {
            if(collision.gameObject.tag == "Block")
            {
                blockCtl.BlockBool(collision.gameObject.transform.position);
            }
            else if (collision.gameObject.tag == "Player")
            {
                PlayerCtl playerCtl = collision.gameObject.GetComponent<PlayerCtl>();
                if (playerCtl.GetState() != PlayerCtl.PlayerState.Damage)
                {
                    playerCtl.SetState(PlayerCtl.PlayerState.Damage);
                }
               
            }
            count++;
            if (!gameManager.gameClear)
            {
                Instantiate(explosion, this.transform.position, Quaternion.identity);
                gameManager.positionShell();
            }
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Soil")
        {
            Destroy(other.gameObject);
        }
    }

}
