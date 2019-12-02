using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DanceMoves : MonoBehaviour
{
    public GameObject Senku;
    public GameObject Target;

    private Animator _animator;
    private AudioSource _audioSource;
    private TrackableBehaviour.Status _targetStatus;

    public AudioClip BreakDanceClip;
    public AudioClip HipHopClip;
    public AudioClip SwingClip;

    
    // Start is called before the first frame update
    void Start()
    {
        _animator = Senku.GetComponent<Animator>();
        _audioSource = Target.GetComponent<AudioSource>();
        _targetStatus = Target.GetComponent<DefaultTrackableEventHandler>().GetComponent<TrackableBehaviour>().CurrentStatus;
    }

    public void BreakDance()
    {
        _animator.SetTrigger("breakdance");
        _audioSource.clip = BreakDanceClip;
        Reproducir();
    }

    public void HipHop()
    {
        _animator.SetTrigger("hiphop");
        _audioSource.clip = HipHopClip;
        Reproducir();
    }

    public void Swing()
    {
        _animator.SetTrigger("swing");
        _audioSource.clip = SwingClip;
        Reproducir();
    }

    public void Parar()
    {
        _audioSource.Stop();
        _audioSource.clip = null;
    }

    private void Reproducir()
    {
        /*if (_targetStatus == TrackableBehaviour.Status.DETECTED ||
            _targetStatus == TrackableBehaviour.Status.TRACKED ||
            _targetStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)*/

            _audioSource.Play();
    }

}
