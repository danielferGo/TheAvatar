using Oculus.Interaction.Input;
using UnityEngine;
using UnityEngine.XR.Hands;

public class HandContext: MonoBehaviour
{
    public string gestureId;
    public HandRef HandRef;
    public Transform spawnPoint;
    public XRHandJointID handJoint;
}