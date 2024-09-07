#version 330 core
out vec4 fragColor;

uniform vec3 hitBoxColor;

void main(){
	fragColor = vec4(hitBoxColor,1.0);
}