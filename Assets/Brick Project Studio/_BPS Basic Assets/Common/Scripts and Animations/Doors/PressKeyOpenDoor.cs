using UnityEngine;

public class PressKeyOpenDoor : MonoBehaviour
{
    public GameObject Instruction;
    private Animator doorAnimator;
    private bool isOpening = false;
    private bool isClosing = false;

    void Start()
    {
        Instruction.SetActive(false);
        doorAnimator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instruction.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        Instruction.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && !isOpening && !isClosing)
        {
            OpenDoor();
        }
        else if (Input.GetKeyDown(KeyCode.C) && !isClosing && !isOpening)
        {
            CloseDoor();
        }
    }

    public void OpenDoor()
    {
        isOpening = true;
        doorAnimator.SetTrigger("Open");
    }

    public void CloseDoor()
    {
        isClosing = true;
        doorAnimator.SetTrigger("Close");
    }

    // These methods will be called by animation events
    public void OnDoorOpened()
    {
        isOpening = false;
    }

    public void OnDoorClosed()
    {
        isClosing = false;
    }
}
