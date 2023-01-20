using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicaScript : MonoBehaviour
{
  public int PlayScorer;
  public Text scoreText;
  public GameObject gameOverScr;
  

  public void addScore(int scoreToAdd) 
  {
    PlayScorer = PlayScorer + scoreToAdd;
    scoreText.text = PlayScorer.ToString();
  }

  public void RestartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void gameOver() 
  {
    gameOverScr.SetActive(true);
  }

}
