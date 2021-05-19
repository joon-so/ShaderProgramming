#version 450

in vec3 a_Position;		//float position 3��

uniform float u_Time;	//�����ð�

const float PI = 3.141592;

void main()
{
	vec3 newPos = vec3(0);

	newPos.x = a_Position.x;

	float sinValue = 2*PI*(a_Position.x + 0.5);
	newPos.y = a_Position.y + 0.2 * sin(sinValue + u_Time);
	gl_Position = vec4(newPos, 1); //OpenGL������ ��°�
}
