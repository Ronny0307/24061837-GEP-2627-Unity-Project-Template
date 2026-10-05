using UnityEngine;

public class GameManger : MonoBehaviour
{
    public enum GameState {Gameplay,Pause }
    public GameState state;
    public bool statechange= false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = GameState.Gameplay;
    }

    // Update is called once per frame
    void Update()
    {

        if (state == GameState.Gameplay)
        {

            if(Input.GetKeyDown(KeyCode.Escape))
            {
                state = GameState.Pause;
                statechange = true;
            }
        }
        else if (state == GameState.Pause)
        {

            if(Input.GetKeyDown(KeyCode.Escape))
            {
                state = GameState.Gameplay;
                statechange = true;
            }
        }

        //Debug.Log(state);
        

    }

    private void LateUpdate()
    {
        if(statechange)
        {
            if (state == GameState.Pause)
            {
                Time.timeScale = 0f;

            }
            else if (state == GameState.Gameplay)
            {
                Time.timeScale = 1f;

            }
            statechange = false;
        }
    }
}

