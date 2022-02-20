using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postManager : MonoBehaviour
{
    public GameObject prefab;
    private GameObject foto, finale;
    private bool spawned = false;
    public float distance = 20f;

    // Start is called before the first frame update
    void Start()
    {
        //foto = GameObject.Find("foto");
    }

    // Update is called once per frame
    void Update()
    {
        if(!spawned && Input.GetKey("space"))
        {
            foto = Instantiate(prefab) as GameObject;
            foto.transform.position = transform.position;
            finale = GameObject.Find("finale");
            spawned = true;
        }
        else if(spawned)
        {
            Debug.Log("foto "+ finale.transform.position.z);
            Debug.Log("camera "+ transform.position.x);
            if (distanzaFinale() == distance)
                GetComponent<MainCamera>().sensitivity /= 2;
            else if (distanzaFinale() == distance / 1.5)
                GetComponent<MainCamera>().sensitivity /= 2;
            else if (distanzaFinale() == distance / 2)
                GetComponent<MainCamera>().sensitivity /= 2;
            else if (distanzaFinale() == 1)
                fade();
        }
    }

    float distanzaFinale()
    {
        return Mathf.Abs(finale.transform.position.z - transform.position.x);
    }

    void fade()
    {
        //todo
        Debug.Log("Finale");
    }
}
