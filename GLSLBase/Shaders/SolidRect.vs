#version 450

in vec3 a_Position;		//float position 3��
in vec3 a_Velocity;		//float velocity 3�� 
in float a_EmitTime;	//float emittime 1��

uniform float u_Time;	//�����ð�

const vec3 c_Gravity = vec3(0, -1.4, 0);

void main()
{
	float newTime = u_Time - a_EmitTime;

	vec3 newPos = a_Position;
	
	if(newTime < 0.0)
	{
		newPos = vec3(10000, 10000, 10000);
	}
	else
	{
		float t = newTime;
		float tt = newTime*newTime;
		newPos = newPos + a_Velocity * t + 0.5 * c_Gravity * tt;
	}

	gl_Position = vec4(newPos, 1); //OpenGL������ ��°�
}
