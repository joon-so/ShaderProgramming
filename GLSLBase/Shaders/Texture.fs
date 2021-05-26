#version 450

layout(location=0) out vec4 FragColor; //사용자가 정의한 출력값

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

	//FragColor = vec4(sinValueY); //줄무의 패턴
	//FragColor = vec4(ceil(sinValueX + sinValueY)); //마름모 패턴
	FragColor = vec4(max(sinValueX, sinValueY)); //감옥패턴
}
