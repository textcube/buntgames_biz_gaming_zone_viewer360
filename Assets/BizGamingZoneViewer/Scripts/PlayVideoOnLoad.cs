using UnityEngine;
using System.Collections;

public class PlayVideoOnLoad : MonoBehaviour {
    public MovieTexture _movie;
    private AudioSource _audio;
    public AudioClip _clip;

    void Start () {
        _audio = gameObject.AddComponent<AudioSource>();
        _audio.clip = _clip;
        _audio.loop = true;
        _movie.loop = true;
        _audio.Play();
        _movie.Play();
	}
}
