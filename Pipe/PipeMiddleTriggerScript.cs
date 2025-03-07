using UnityEngine;

public class PipeMiddleTriggerScript : MonoBehaviour
{
    private Game _logic;

    private void Start()
    {
        _logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Game>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && !_logic.GameOverScreen.activeSelf) {
            _logic.AddScore(1);
        }
    }
}
