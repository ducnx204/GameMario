using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManeger : MonoBehaviour
{
    public static AudioManeger instance;

    public GameObject prefab;

    public AudioClip coin;
    private AudioSource coinsource;

    public AudioClip goomba;
    private AudioSource goombasource;

    public AudioClip breakBlock;
    private AudioSource breakBlocksource;

    public AudioClip pipe;
    private AudioSource pipesource;

    public AudioClip jump;
    private AudioSource jumpsource;

    public AudioClip megaJump;
    private AudioSource megaJumpsource;

    public AudioClip death;
    private AudioSource deathsource;

    public AudioClip flag;
    private AudioSource flagsource;

    public AudioClip win;
    private AudioSource winsource;

    public AudioClip beep;
    private AudioSource beepsource;

    public AudioClip bump;
    private AudioSource bumpsource;

    public AudioClip theme;
    private AudioSource themesource;



    private void Awake()
    {
        instance = this;
    }

    public void PlaySound(AudioClip clip,float volume,bool isLoopback)
    {
        if(clip == this.theme)
        {
            Play(clip, ref themesource, volume, isLoopback);
        }
    }
    public void PlaySound(AudioClip clip, float volume)
    {
        if(clip == this.beep)
        {
            Play(clip, ref beepsource, volume);
            return;
        }

        if (clip == this.breakBlock)
        {
            Play(clip, ref breakBlocksource, volume);
            return;
        }

        if (clip == this.bump)
        {
            Play(clip, ref bumpsource, volume);
            return;
        }

        if (clip == this.coin)
        {
            Play(clip, ref coinsource, volume);
            return;
        }

        if (clip == this.death)
        {
            Play(clip, ref deathsource, volume);
            return;
        }


        if (clip == this.flag)
        {
            Play(clip, ref flagsource, volume);
            return;
        }

        if (clip == this.pipe)
        {
            Play(clip, ref pipesource, volume);
            return;
        }

        if (clip == this.jump)
        {
            Play(clip, ref jumpsource, volume);
            return;
        }

        if (clip == this.megaJump)
        {
            Play(clip, ref megaJumpsource, volume);
            return;
        }

        if (clip == this.win)
        {
            Play(clip, ref winsource, volume);
            return;
        }

        if (clip == this.theme)
        {
            Play(clip, ref themesource, volume);
            return;
        }

    }

    private void Play(AudioClip clip,
        ref AudioSource audioSource, float volume, bool isLopback = false)
    {
        if(audioSource != null && audioSource.isPlaying)
        {
            return;
        }
        audioSource = Instantiate(instance.prefab).GetComponent<AudioSource>();

        audioSource.volume = volume;
        audioSource.loop = isLopback;
        audioSource.clip = clip;
        audioSource.Play();
        Destroy(audioSource.gameObject, audioSource.clip.length);
    }


    public void StopSound(AudioClip clip)
    {
        if(clip == this.beep)
        {
            //  ?. phương thức toán tử 
            beepsource?.Stop();
            return;
        }
        //==================
        if (clip == this.breakBlock)
        {
            //  ?. phương thức toán tử 
            breakBlocksource?.Stop();
            return;
        }

        //==================
        if (clip == this.bump)
        {
            //  ?. phương thức toán tử 
            bumpsource?.Stop();
            return;
        }

        //==================
        if (clip == this.coin)
        {
            //  ?. phương thức toán tử 
            coinsource?.Stop();
            return;
        }
        //==================
        if (clip == this.beep)
        {
            //  ?. phương thức toán tử 
            beepsource?.Stop();
            return;
        }

        //==================
        if (clip == this.flag)
        {
            //  ?. phương thức toán tử 
            flagsource?.Stop();
            return;
        }

        //==================
        if (clip == this.death)
        {
            //  ?. phương thức toán tử 
            deathsource?.Stop();
            return;
        }

        //==================
        if (clip == this.pipe)
        {
            //  ?. phương thức toán tử 
            pipesource?.Stop();
            return;
        }

        //==================
        if (clip == this.jump)
        {
            //  ?. phương thức toán tử 
            jumpsource?.Stop();
            return;
        }

        //==================
        if (clip == this.megaJump)
        {
            //  ?. phương thức toán tử 
            megaJumpsource?.Stop();
            return;
        }

        //==================
        if (clip == this.theme)
        {
            //  ?. phương thức toán tử 
            themesource?.Stop();
            return;
        }


    } 
}
