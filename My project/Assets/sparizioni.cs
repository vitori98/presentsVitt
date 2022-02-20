using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparizioni : MonoBehaviour
{
    //private GameObject[] pg;
    private GameObject playground;
    private Transform[] pg;
    private DissolveSphere[] dis;
    private int i=0,j=0;
    public float distance = 3f;
    // Start is called before the first frame update
    void Start()
    {
        playground = GameObject.Find("Playground");
        pg = playground.GetComponentsInChildren<Transform>();
        dis = playground.GetComponentsInChildren<DissolveSphere>();
        
        foreach (Transform child in pg)
        {
            child.gameObject.SetActive(false);
        }

        pg[i++].gameObject.SetActive(true);
        pg[i].gameObject.SetActive(true);
        j = i;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("i " + i);
        //Debug.Log("j " + i);
        //Debug.Log("lunghezza giochi " + pg.Length);
        switch (i) //per i casi in cui far spawnare a canone
        {

            case 1: //scomparsa girandola
                //Debug.Log("CASE 1 ");
                if (i < pg.Length && distanza(pg[j]) <= distance)
                {
                    dissolve(dis[j++]);
                    i++;
                    pg[i++].gameObject.SetActive(true);
                    //dissolve(dis[j++]);
                    pg[i++].gameObject.SetActive(true);
                    //dissolve(dis[j++]);
                    pg[i++].gameObject.SetActive(true);
                }
                break;

            case 5: //alberi
                if (i < pg.Length &&
                    (distanza(pg[j]) <= distance || distanza(pg[j + 1]) <= distance || distanza(pg[j + 2]) <= distance))
                {
                    dissolve(dis[j++]);
                    //pg[i].gameObject.SetActive(true);
                    dissolve(dis[j++]);
                    //pg[i].gameObject.SetActive(true);
                    dissolve(dis[j++]);

                    pg[i++].gameObject.SetActive(true);
                }
                break;

            case 6:
                Debug.Log("caso 6");
                if (i < pg.Length && distanza(pg[j]) <= distance)
                {
                    dissolve(dis[j++]);

                    pg[i++].gameObject.SetActive(true);
                }
                break;
            case 7: //scomparsa slide
                if (i < pg.Length && distanza(pg[j]) <= distance)
                {
                    dissolve(dis[j++]);

                    pg[i++].gameObject.SetActive(true);
                    //dissolve(dis[j++]);
                    pg[i++].gameObject.SetActive(true);
                    //dissolve(dis[j++]);
                    pg[i++].gameObject.SetActive(true);
                }
                break;

            case 9: //cavallucci
                if (i < pg.Length &&
                    (distanza(pg[j]) <= distance || distanza(pg[j + 1]) <= distance || distanza(pg[j + 2]) <= distance))
                {
                    dissolve(dis[j++]);
                    //pg[i].gameObject.SetActive(true);
                    dissolve(dis[j++]);
                    dissolve(dis[j++]);
                    i = 10;
                    pg[i].gameObject.SetActive(true);
                }
                break;

            case 10: //cazzafa
                if (i < pg.Length && distanza(pg[j]) <= distance)
                {
                    dissolve(dis[j++]);
                    i = 11;
                    pg[i].gameObject.SetActive(true);
                }
                break;

            case 11: //basculant
                if (i < pg.Length && distanza(pg[j]) <= distance)
                {
                    dissolve(dis[j++]);
                    i = 12;
                    pg[i++].gameObject.SetActive(true);
                    pg[i].gameObject.SetActive(true);
                }
                break;

            case 13: //streetlamps
                if (i < pg.Length &&
                    (distanza(pg[j]) <= distance || distanza(pg[j + 1]) <= distance || distanza(pg[j + 2]) <= distance))
                {
                    dissolve(dis[j++]);
                    dissolve(dis[j++]);
                    //pg[i++].gameObject.SetActive(true);
                }
                break;

            default:
                //if (i < pg.Length && distanza(pg[j]) <= distance)
                //{
                //    dissolve(dis[j++]);

                //    pg[i++].gameObject.SetActive(true);
                //}
                break;
        }
    }

    void dissolve(DissolveSphere go)
    {
        //Debug.Log("dissolvenza");
        go.setDissolve(true);
    }

    float distanza(Transform go)
    {
        //Debug.Log("DISTANZA" + Vector3.Distance(go.position, transform.position));
        return Vector3.Distance(go.position, transform.position);
    }
}
