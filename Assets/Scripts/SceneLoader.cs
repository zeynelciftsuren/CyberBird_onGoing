using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // bu kütüphane ile scenelere müdahale ediyoruz

public class SceneLoader : MonoBehaviour
{
    public void LoadScreen(string screnName) // method a girilen scene name ile o scene çağırılıyor
    {
        SceneManager.LoadScene(screnName);
    }
}
