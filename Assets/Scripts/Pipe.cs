
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Pipe : MonoBehaviour
{
    public static float speed;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -6)
        {
            transform.position = new Vector3(6, transform.position.y);
        }
    }
}
