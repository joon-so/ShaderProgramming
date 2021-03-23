#version 450

in vec3 a_Position;  //float 3개
in vec3 a_Position1; //float 3개, 총 6개의 floats

uniform float u_Scale;

void main()
{
	gl_Position = vec4(a_Position * u_Scale, 1); //OpenGL고유의 출력값
}
