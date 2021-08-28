using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMove playermove;//
    void Start()
    {
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        bool FallFlag;//
        FallFlag = playermove.fallFlag;//
        if(FallFlag == true)
        {
            this.gameObject.SetActive(true);//
        }
    }

    private void OnCollisionStay(Collision col)
    {
        //Destroy(this.gameObject);
        this.gameObject.SetActive(false);
    }
}
