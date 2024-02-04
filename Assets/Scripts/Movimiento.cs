using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour
{
    public float speed = 5f;


    void Start()
    {


    }

    void Update()
    {

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {

            SceneManager.LoadScene("winScene");


        }
    }
}