#version 450

layout(location=0) out vec4 FragColor; //사용자가 정의한 출력값

uniform sampler2D u_TexSampler;

uniform float u_Step;

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

vec4 p3()
{
	vec2 newTex = v_TexPos;
	newTex.x = fract(v_TexPos.x*3.0);
	newTex.y = newTex.y / 3.0 + floor(-v_TexPos.x*3.0) / 3.0;

	vec4 returnColor = texture(u_TexSampler,newTex);
	return returnColor;
}

vec4 p4()
{
	vec2 newTex = v_TexPos;
	newTex.y = fract(v_TexPos.y * 3.0) / 3.0 + floor(-v_TexPos.y*3.0) / 3.0;

	vec4 returnColor = texture(u_TexSampler, newTex);
	return returnColor;
}

vec4 p5() 
{
	vec2 newTex = v_TexPos;
	newTex.x = newTex.x * 2.0 + floor(v_TexPos.y * 2.0)/2.0;
	newTex.y = newTex.y * 2.0;

	vec4 returnColor = texture(u_TexSampler, newTex);
	return returnColor;
}

vec4 p6() 
{
	vec2 newTex = v_TexPos;
	newTex.x = newTex.x * 2.0;
	newTex.y = newTex.y * 2.0 + floor(v_TexPos.x * 2.0)/2.0;

	vec4 returnColor = texture(u_TexSampler, newTex);
	return returnColor;
}

vec4 SingleTexture()
{
	return texture(u_TexSampler, v_TexPos);
}

vec4 SpriteTexture()
{
	vec2 newTex = vec2(v_TexPos.x, u_Step/6.0 + v_TexPos.y/6.0);
	return texture(u_TexSampler, newTex);
}

void main()
{
	//FragColor = p2();
	//FragColor = SpriteTexture();
	FragColor = SingleTexture();
}
