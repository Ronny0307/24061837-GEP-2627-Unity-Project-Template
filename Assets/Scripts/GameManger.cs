using UnityEngine;

public class GameManger : MonoBehaviour
{
    public enum GameState {Gameplay,Pause }
    public GameState state;
    public bool statechange= false;
    public int stateid = 0; // 0 = gameplay, 1 = pause


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        state = GameState.Gameplay;
    }

    // Update is called once per frame
    void Update()
    {
        /*
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
        */
        //Debug.Log(state);
        
        switch(stateid)
        {
            case 0:
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    stateid = 1;
                    statechange = true;
                    Debug.Log("Pause");
                }
                    
                break;
            case 1:
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    stateid = 0;
                    statechange = true;
                    Debug.Log("Gameplay");
                }
                
                break;
        }

    }

    private void LateUpdate()
    {
        if(statechange)
        {
            /*
            if (state == GameState.Pause)
            {
                Time.timeScale = 0f;

            }
            else if (state == GameState.Gameplay)
            {
                Time.timeScale = 1f;

            }
            statechange = false;
            */

            switch(stateid)
            {
                case 0:
                    Time.timeScale = 1f;
                    break;
                case 1:
                    Time.timeScale = 0f;
                    break;
            }
            statechange = false;
        }


    }
}

