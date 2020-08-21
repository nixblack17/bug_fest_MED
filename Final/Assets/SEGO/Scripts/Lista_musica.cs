using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SWNetwork;

public class Lista_musica : MonoBehaviour 
{
	public AudioClip[] Clips;
	private AudioSource Player;

	public GameObject PanelAudioMusica;
	public GameObject BAbrirPanel;
	public GameObject BCerrarPanel;
    public bool AudioAct = false;

    //NetworkID networkID;

    //private int index = 0;
    void Start () 
	{
        //networkID = GetComponent<NetworkID>();
    }

	void Update () 
	{
        /*if (networkID.IsMine)
        {
           ///AAA 
        }*/

    }

	public void BotonAudio1()
	{
		Player = GetComponent<AudioSource>();
		Player.clip = Clips[0];
		Player.Play();
	}
	public void BotonAudio2()
	{
		Player = GetComponent<AudioSource>();
		Player.clip = Clips[1];
		Player.Play();
	}
	public void BotonAudio3()
	{
		Player = GetComponent<AudioSource>();
		Player.clip = Clips[2];
		Player.Play();
	}
	public void BotonAudio4()
	{
		Player = GetComponent<AudioSource>();
		Player.clip = Clips[3];
		Player.Play();
	}
	public void OffAudio()
	{
		Player = GetComponent<AudioSource>();
		Player.Stop();
	}

	//Mostrar panel de audio
	public void MostrarPanelAudio()
	{
		PanelAudioMusica.SetActive (true);
		BAbrirPanel.SetActive (false);
		BCerrarPanel.SetActive (true);
	}

	public void CerrarPanelAudio()
	{
		PanelAudioMusica.SetActive (false);
		BAbrirPanel.SetActive (true);
		BCerrarPanel.SetActive (false);
	}
}
