using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject _pipe;
    [SerializeField] private Game _game;
    [SerializeField] private float _spawnRate = 2;

    private float _heightOffset = 1;
    private float _timer = 0;

    private void Start()
    {
        SpawnPipe();
        int savedDificulty = PlayerPrefs.GetInt(Constants.GameDificulty, 1);
        _heightOffset = savedDificulty;
    }

    private void Update()
    {
        if (_timer < _spawnRate)
        {
            _timer += Time.deltaTime;
        }
        else {
            SpawnPipe();
            _timer = 0;
        }
    }

   
    private void SpawnPipe()
    {
        float lowestPoint = transform.position.y - _heightOffset;
        float highestPoint = transform.position.y + _heightOffset;
        PipeMoveScript pipeMover = Instantiate(
            _pipe,
            new Vector3(transform.position.x,Random.Range(lowestPoint, highestPoint)),
            transform.rotation)
            .GetComponent<PipeMoveScript>();
    }
}
