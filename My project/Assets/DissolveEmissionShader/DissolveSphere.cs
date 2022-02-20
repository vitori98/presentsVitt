using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveSphere : MonoBehaviour {

    Material[] materials;
    private bool dissolve = false;

    private void Start() {
        materials = GetComponent<Renderer>().materials;
    }

    private void Update() {
        if (dissolve)
        {
            foreach (Material mat in materials)
            {
                mat.SetFloat("_DissolveAmount ", 1f);
                Debug.Log("_DissolveAmount " + mat.GetFloat("_DissolveAmount"));
                if (mat.GetFloat("_DissolveAmount") >= 1f)
                    dissolve = false;
            }
        }
    }

    public void setDissolve(bool b){ dissolve = b; }
}