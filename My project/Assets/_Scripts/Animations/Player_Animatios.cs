using UnityEngine;

public class Player_Animatios : MonoBehaviour
{

    private Animator _animator;
    private NewInput _newInput;


    // Start is called before the first frame update
    void Start()
    {

        _animator = GetComponent<Animator>();

        _newInput = GetComponent<NewInput>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveAnim();
    }

    public void PlayerMoveAnim()
    {
       
     _animator.SetBool("Movings", _newInput.inputX != 0);

    }
}
