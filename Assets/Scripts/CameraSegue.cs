using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    public GameObject player;
    public float pX;
    public float pY;
    public Vector3 posInicial;
    void Start()
    {
        posInicial = transform.position;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            pX = player.transform.position.x;
            pY = player.transform.position.y;
        }

        if(pX > 10 && pY > -15 && pX < 40)
        {
            transform.position = new Vector3(pX, 5, -7);
        }

        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            transform.position = posInicial;
        }
    }
}