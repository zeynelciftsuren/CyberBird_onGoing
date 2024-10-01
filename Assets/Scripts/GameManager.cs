using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
  public Text scoreText;
  public GameObject gameOver;
  public GameObject playButton;
  public GameObject shopButton;
  public GameObject ready;
  public Player player;
  public GameObject coinBank;
  private int score;

  
  private void Awake() {
    Application.targetFrameRate = 60;
    player.gameObject.SetActive(false);
    gameOver.SetActive(false);
  scoreText.gameObject.SetActive(false);
  coinBank.SetActive(true);
    playButton.SetActive(true);
    shopButton.SetActive(true);
      

        Pause();
  }

  public void Play(){
    score = 0;
    scoreText.text = score.ToString();
    if(player.gameObject.activeSelf == false) player.gameObject.SetActive(true);
    coinBank.SetActive(false);
    gameOver.SetActive(false);
    playButton.SetActive(false);
    shopButton.SetActive(false);
    scoreText.gameObject.SetActive(true);
    ready.SetActive(true);
   Invoke("DisableReady",1.2f);


    Time.timeScale = 1f;
    player.enabled = true;

    Pipes[] pipes = FindObjectsOfType<Pipes>();
    for (int i = 0; i < pipes.Length; i++)
    {
      Destroy(pipes[i].gameObject);
    }
    
  }

  public void DisableReady(){
    ready.SetActive(false);
  }
  public void Pause(){
    Time.timeScale = 0f;
    player.enabled = false;

  }




  public void GameOver(){
   scoreText.gameObject.SetActive(false);
    coinBank.SetActive(true);
    gameOver.SetActive(true);
    playButton.SetActive(true);
    shopButton.SetActive(true);
    Pause();
  }
  public void IncreaseScore(){
    score++;
    scoreText.text = score.ToString();
  }
}
