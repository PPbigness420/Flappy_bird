
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;


    private void Update()
    {
        transform.position += Time.deltaTime * Vector3.left * speed;
        if (transform.position.x< -6)
        {
            transform.position = new Vector3(6, transform.position.y);
        }
    }
}
