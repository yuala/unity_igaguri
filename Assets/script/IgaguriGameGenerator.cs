using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGameGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject igaguri=Instantiate(igaguriPrefab);
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 wolrdDir = ray.direction;
            igaguri.GetComponent<IgaguriController>().Shoot( wolrdDir.normalized*2000);
        }
    }
}
