using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFlip : MonoBehaviour
{
    public GameObject coin;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        cointoss();
    }

    public void cointoss()
    {
        int jumpforce = Random.Range(500, 900);
        rb.AddForce(0, jumpforce, 0);
        int torqz = Random.Range(120, 300);
        rb.AddTorque(0, 0, torqz);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
