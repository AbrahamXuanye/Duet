using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public float rotationSpeed = 1f;
    private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        RotationController();
    }
    void RotationController()
    {
        float v = Input.GetAxis("Horizontal");
        player.transform.Rotate(0, 0, -1 * v * rotationSpeed * Time.timeScale);
    }
}
