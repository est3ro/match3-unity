using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    private Board board;
    public float hintDelay;
    private float hintDelaySeconds;
    public GameObject hintParticle;
    public GameObject currentHint;
    
    // Start is called before the first frame update
    void Start()
    {
        board = FindObjectOfType<Board>();
        hintDelaySeconds = hintDelay;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Find all possible matches on the board
    /*
    List<GameObject> FindAllMatches(){
        List<GameObject> possibleMoves = new List<GameObject>();
        for(int i = 0; i < board.width; i++){
            for(int j = 0; j < board.height; j++){
                if(board.allDots[i, j] != null){
                    if (i < board.width - 1){
                        if(board.SwitchAndCheck(i,j, Vector2.right)){
                            return false;
                        }
                    }
                    if(j<height - 1){
                        if(board.SwitchAndCheck(i,j, Vector2.up)){

                        }
                    }
                }
            }
        }
    }
    */
    //Pick one randomly
    //create the hint behind the chosen matches
    //Destroy the hint
}
