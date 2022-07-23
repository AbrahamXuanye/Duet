using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float rotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow ) && player != null)
        {
            player.transform.Rotate(0, 0, rotationSpeed);
            
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) && player != null)
        {
            player.transform.Rotate(0, 0, -1 * rotationSpeed);
        }
    }

}
