using UnityEngine;

public class S_PlayerManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _player;
    private Vector3 _initialPosition;
    private Quaternion _initialRotation;

    private void Awake()
    {
        _initialPosition= transform.position;
        _initialRotation= transform.rotation;

        S_Actions.ResetPlayer += ResetPlayer;
    }

    private void ResetPlayer()
    {
        _player.transform.position = _initialPosition;
        _player.transform.rotation = _initialRotation;

        Component[] components = _player.GetComponentsInChildren<Component>(true);

        foreach (Component component in components) {
            component.transform.position = _initialPosition;
            component.transform.rotation = _initialRotation;
        }
    }
}
