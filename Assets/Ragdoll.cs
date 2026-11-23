using StarterAssets;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ragdoll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody[] bones;
    public TextMeshProUGUI text;
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
        text.SetText("Bro fell");
    }

    public void OnWeird()
    {
        Debug.Log("Weird");
        gameObject.GetComponent<Animator>().SetTrigger("doSomething");
    }

    public void JumpPeakHeight()
    {
        Debug.Log("Jump Peak Height");
        text.SetText("Bro jumped");
    }

    public void KickLegUp()
    {
        Debug.Log("Kick Right Leg Up");
        text.SetText("Bro walks");
    }
}
