using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player1Controller : MonoBehaviour
{

	public Animator anim;

	// Controls facing direction
	public bool facingRight;


	public LineScript drawControl;
	public float speed =10f;

	Vector3[] positions;
	bool StartMovement = false;
	int MoveIndex  =0;
	private void OnMouseDown()
	{
		drawControl.StartLine(transform.position);
	}

	private void OnMouseDrag()
	{
		drawControl.UpdateLine();
	}

	private void OnMouseUp()
	{
		positions = new Vector3[drawControl.line.positionCount];

		drawControl.line.GetPositions(positions);
		StartMovement = true;
		MoveIndex = 0;
	}

	private void Update(){
		if(StartMovement == true){

			Vector2 currentPos = positions[MoveIndex];
			transform.position = Vector2.MoveTowards(transform.position, currentPos, speed * Time.deltaTime);

			float distance = Vector2.Distance( currentPos,transform.position);
			if(distance < 0.05f){
				MoveIndex++;
			}

			if(MoveIndex > positions.Length - 1){
				StartMovement = false;
			}
			
		}
	}
	 
	public void Jump()
    {
		anim.SetBool("Jump", true) ;
	}

	public void JumpOff()
    {
		anim.SetBool("Jump", false);
	}

	public void Dead()
	{
		anim.SetBool("Dead" , true);
	}

	public void DeadOff()
	{
		anim.SetBool("Dead", false);
	}
	public void Walk()
	{
		anim.SetBool("Walk" , true);
	}

	public void WalkOff()
	{
		anim.SetBool("Walk", false);
	}
	public void Run()
	{
		anim.SetBool("Run" , true);
	}
	public void RunOff()
	{
		anim.SetBool("Run", false);
	}
	public void Attack()
	{
		anim.SetBool("Attack" , true);
	}
	public void AttackOff()
	{
		anim.SetBool("Attack", false);
	}





	

}



