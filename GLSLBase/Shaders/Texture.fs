#version 450

layout(location=0) out vec4 FragColor; //����ڰ� ������ ��°�

uniform sampler2D u_TexSampler;

in vec2 v_TexPos;

const float PI = 3.141592;

void main()
{
	//FragColor = vec4(1);//texture(u_TexSampler, v_TexPos);
	vec2 xy = v_TexPos;
	float maskY = xy.y * 2 * PI * 8; //0~2PI
	float sinValueY = sin(maskY);

	float maskX = xy.x * 2 * PI * 8; //0~2PI
	float sinValueX = sin(maskX);

	//FragColor = vec4(sinValueY); //�ٹ��� ����
	//FragColor = vec4(ceil(sinValueX + sinValueY)); //������ ����
	FragColor = vec4(max(sinValueX, sinValueY)); //��������
}
