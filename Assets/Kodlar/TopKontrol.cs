using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text zaman, can;
    private Rigidbody rb;
    public float Hiz = 10000f;
    float zamanSayaci = 100;
    int canSayaci = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci-=Time.deltaTime;
        zaman.text= (int)zamanSayaci+"";

    }

    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 kuvvet = new Vector3(-dikey,0,yatay);
        rb.AddForce(kuvvet*Hiz);



    }
    private void OnCollisionEnter(Collision cls)
    {
        string obj›smi = cls.gameObject.name;
        if (obj›smi.Equals("Bitis"))
        {
            print("Oyun Tamamland˝");
        }
        else if (obj›smi.Equals("Plane"))
        {
            canSayaci -= 1;
            can.text = canSayaci + "";
        }
    }
}
