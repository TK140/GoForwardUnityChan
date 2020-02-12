using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSound : MonoBehaviour {

    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        //衝突したオブジェクトがグランドの場合
        if (other.gameObject.name == "ground")
        {
            //音を出す 
            GetComponent<AudioSource>().Play();

        }
        //衝突したオブジェクトが箱の場合
        else if (other.gameObject.tag == "CubeTag")
         {
            //音を出す
            GetComponent<AudioSource>().Play();
        }

    }

}