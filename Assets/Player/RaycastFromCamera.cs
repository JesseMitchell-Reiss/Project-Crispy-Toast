using UnityEngine;

public class RaycastFromCamera : MonoBehaviour
{
    public Camera playerCamera;

    [SerializeField]
    Canvas playerCanvas;

    [SerializeField]
    NPCControl npcControl;

    int state;

    private void Start()
    {
        state = 0;
    }

    void Update()
    {        
        // checking if player has clicked on stuff
        if (Input.GetMouseButtonDown(0) && state == 0)
        {
            RaycastHit hit;
            Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward,
                out hit);
            Transform objectHit = hit.collider.transform;
            Debug.Log(objectHit.name);
            switch (objectHit.tag)
            {
                case "NPC":
                    npcControl.OpenMenu();
                    Time.timeScale = 0f;
                    state = 1;
                    playerCanvas.gameObject.SetActive(false);
                    Cursor.lockState = CursorLockMode.None;
                    break;
            }
        }
    }
}