using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float mouseSensitivity;
    [SerializeField] GameObject cameraHolder;
    float verticalLookRotation;

    private void Update()
    {
        if (transform.position.y < -10f)
        {
            Die();
        }

        Look();
    }
    void Look()
    {
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * mouseSensitivity);

        verticalLookRotation += Input.GetAxisRaw("Mouse Y") * mouseSensitivity;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

        cameraHolder.transform.localEulerAngles = Vector3.left * verticalLookRotation;
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
