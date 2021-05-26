#version 450

layout(location=0) out vec4 FragColor; //����ڰ� ������ ��°�

uniform sampler2D u_TexSampler;

in vec2 v_TexPos;

const float PI = 3.141592;

void main()
{
	FragColor = texture(u_TexSampler, v_TexPos);
}
