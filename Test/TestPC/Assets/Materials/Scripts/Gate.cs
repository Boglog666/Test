using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public GameObject Enemy;
    void Update()
    {
        if(Enemy==false)
        {
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }
}
