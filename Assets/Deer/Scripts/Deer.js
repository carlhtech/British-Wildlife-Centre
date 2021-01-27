#pragma strict
var deer : Animator;
function Start () {

}

function Update () {
if(Input.GetKey("up")){
deer.SetBool("Walking",true);
deer.SetBool("Backward",false);
deer.SetBool("Trotting",false);
deer.SetBool("Galloping",false);
deer.SetBool("Eating",false);
deer.SetBool("Up",false);
}
if(Input.GetKey("down")){
deer.SetBool("Backward",true);
deer.SetBool("Walking",false);
}
if(Input.GetKey(KeyCode.Keypad5)){
deer.SetBool("Trotting",true);
deer.SetBool("Backward",false);
deer.SetBool("Walking",false);
deer.SetBool("Galloping",false);
}
if(Input.GetKey(KeyCode.Keypad8)){
deer.SetBool("Galloping",true);
deer.SetBool("Trotting",false);
deer.SetBool("Walking",false);
}
if(Input.GetKey(KeyCode.Alpha1)){
deer.SetBool("Galloping",false);
deer.SetBool("Eating",true);
deer.SetBool("Walking",false);
}
if(Input.GetKey(KeyCode.Alpha2)){
deer.SetBool("Lay",true);
deer.SetBool("Eating",false);
}
if(Input.GetKey(KeyCode.Alpha3)){
deer.SetBool("Lay",false);
deer.SetBool("Up",true);
deer.SetBool("Walking",false);
}
if(Input.GetKey(KeyCode.Alpha4)){
deer.SetBool("Up",false);
deer.SetBool("Attack",true);
}
if(Input.GetKey(KeyCode.Alpha5)){
deer.SetBool("Attack",false);
deer.SetBool("Jumping",true);
}
if(Input.GetKey(KeyCode.Alpha6)){
deer.SetBool("Jumping",false);
deer.SetBool("Died",true);
}
if(Input.GetKey("left")){
deer.SetBool("turnleft",true);
deer.SetBool("Walking",false);
walk();
}
if(Input.GetKey("right")){
deer.SetBool("turnright",true);
deer.SetBool("Walking",false);
walk();
}
if(Input.GetKey(KeyCode.Keypad4)){
deer.SetBool("trotleft",true);
deer.SetBool("Trotting",false);
trot();
}
if(Input.GetKey(KeyCode.Keypad6)){
deer.SetBool("trotright",true);
deer.SetBool("Trotting",false);
trot();
}
}

function walk(){
yield WaitForSeconds(1.4);
deer.SetBool("Walking",true);
deer.SetBool("turnleft",false);
deer.SetBool("turnright",false);
}
function trot(){
yield WaitForSeconds(0.4);
deer.SetBool("Trotting",true);
deer.SetBool("trotleft",false);
deer.SetBool("trotright",false);
}

