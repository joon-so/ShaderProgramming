#version 450

layout(location=0) out vec4 FragColor; //사용자가 정의한 출력값

uniform sampler2D u_TexSampler;

in vec2 v_TexPos;

const float PI = 3.141592;

vec4 p1()
{
	vec2 newTex = v_TexPos;
	newTex.y = abs(newTex.y - 0.5) * 2;
	vec4 returnColor = texture(u_TexSampler, newTex);

	return returnColor;
}

vec4 p2()
{
	vec2 newTex = v_TexPos;
	newTex.x = fract(newTex.x * 3.0);
	newTex.y = floor(v_TexPos.x*3.0) / 3.0 + newTex.y/3.0;

	vec4 returnColor = texture(u_TexSampler, newTex);
	return returnColor;
}

vec4 SingleTexture()
{
	return texture(u_TexSampler, v_TexPos);
}

void main()
{
	//FragColor = p2();
	FragColor = SingleTexture();
}
