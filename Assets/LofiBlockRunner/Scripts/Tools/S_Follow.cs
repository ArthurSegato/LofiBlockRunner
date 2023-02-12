using UnityEngine;

public class S_Follow : MonoBehaviour
{
    [Header("Follow Settings")]
    [Tooltip("Objecta that will be followed.")]
    [SerializeField] private GameObject _target;

    private void LateUpdate() => transform.position = _target.transform.position;
}
