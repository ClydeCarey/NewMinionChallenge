using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _minionPrefab;
    [SerializeField]
    private GameObject _minionStartPosition;
    // Start is called before the first frame update
    void Start()
    {
        _minionStartPosition = GameObject.Find("Spawn_Position");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_minionPrefab, _minionStartPosition.transform.position, Quaternion.identity);
        }
    }
}
