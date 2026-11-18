using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ragdoll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody[] bones;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnFall()
    {
        Debug.Log("Fall");
        foreach (Rigidbody rb in bones)
        {
            rb.isKinematic = false;
            rb.velocity = new Vector3(gameObject.GetComponent<CharacterController>().velocity.x, gameObject.GetComponent<CharacterController>().velocity.y, gameObject.GetComponent<CharacterController>().velocity.z);
        }
        gameObject.GetComponent<ThirdPersonController>().enabled = false;
        gameObject.GetComponent<Animator>().enabled = false;
        gameObject.GetComponent<CharacterController>().enabled = false;
    }
}
