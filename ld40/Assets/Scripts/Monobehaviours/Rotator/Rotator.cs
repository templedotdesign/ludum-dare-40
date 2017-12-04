using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour 
{
    [SerializeField] float speed = 50f;
    [SerializeField] GameData data;

	void Update () 
    {
        if(data.gameOver) {
            return;
        }
        transform.Rotate(0,0,speed * Time.deltaTime * -1);
	}
}
