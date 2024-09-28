using UnityEngine;

public class TriggerVideo : MonoBehaviour
{
    public GameObject videoObject; // Assign the video GameObject in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "documentVideo"
        if (other.CompareTag("documentVideo"))
        {
            // Set the video GameObject active
            if (videoObject != null)
            {
                videoObject.SetActive(true);
            }
        }
    }
}
