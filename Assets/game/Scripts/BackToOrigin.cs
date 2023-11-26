using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BackToOrigin : MonoBehaviour
{
    [SerializeField] private Pose originPos;
    private XRGrabInteractable _grabInteractable;

    private void Awake()
    {
        _grabInteractable = GetComponent<XRGrabInteractable>();
        originPos.position = transform.position;
        originPos.rotation = transform.rotation;
    }

    private void OnEnable()
    {
        _grabInteractable.selectExited.AddListener(LaserGunReleased);
    }

    private void OnDisable()
    {
        _grabInteractable.selectExited.RemoveListener(LaserGunReleased);
    }
    
    private void LaserGunReleased(SelectExitEventArgs arg0)
    {
        transform.position = originPos.position; 
        transform.rotation = originPos.rotation; 
    }
}
