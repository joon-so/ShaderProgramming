#version 450

layout(location=0) out vec4 FragColor; //����ڰ� ������ ��°�

varying vec4 v_Color;

const vec3 circle = vec3(0.5, 0.5 ,0.0);
const float PI = 3.141592;

uniform vec3 u_Point;
uniform vec3 u_Points[10];
uniform float u_Time;

vec4 CenteredCircle()
{
	float d = length(v_Color.rgb - circle);
	float count = 1;
	float rad = d * 2.0 * 2.0  * PI * count;
	float greyScale = sin(rad);
	float width = 200;
	greyScale = pow(greyScale, width);
	return vec4(greyScale);
}

vec4 IndicatePoint()
{
	vec4 returnColor = vec4(0);
	float d = length(v_Color.rg - u_Point.xy);
	if(d<u_Point.z)
	{
		returnColor = vec4(1);
	}
	return returnColor;
}

vec4 IndicatePoints()
{
	vec4 returnColor = vec4(0);
	for(int i = 0; i<10; i++)
	{
		float d = length(v_Color.rg - u_Points[i].xy);
		if(d<u_Points[i].z)
		{
			returnColor = vec4(1);
		}
	}
	return returnColor;
}

vec4 Radar()
{
	float d = length(v_Color.rg - vec2(0, 0));
	vec4 returnColor = vec4(0);
	returnColor.a = 0.4;
	float ringRadius = mod(u_Time, 0.7);
	float radarWidth = 0.015;

	if(d > ringRadius && d < ringRadius + radarWidth )
	{
		returnColor = vec4(d / ringRadius - 0.5);

		for(int i =0; i<10; i++)
		{
			float pointDistance = length(u_Points[i].xy - v_Color.rg);
			if(pointDistance < 0.05)
			{
				pointDistance = 0.05 - pointDistance;
				pointDistance *= 20;
				returnColor += vec4(pointDistance);
			}
		}
	}
	return returnColor;
}

void main()
{
	//FragColor = CenteredCircle();
	//FragColor = IndicatePoint();
	//FragColor = IndicatePoints();
	FragColor = Radar();
}
