#version 450

in vec3 a_Position;  //float 3��
//in vec3 a_Position1; //float 3��, �� 6���� floats

uniform float u_Scale;
uniform vec3 u_Position;

void main()
{
	vec3 temp = a_Position;
	temp = temp + u_Position;
	gl_Position = vec4(temp, 1); //OpenGL������ ��°�
}
