using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playbtn : MonoBehaviour
{

    public string scenename;


    private void OnMouseDown()
    {
        transform.position += Vector3.down * 0.1f;
    }
    private void OnMouseUp()
    {
        transform.position += Vector3.up * 0.1f;
        if (scenename!="")
        {
            SceneManager.LoadScene(scenename);
        }
        
    }
}
