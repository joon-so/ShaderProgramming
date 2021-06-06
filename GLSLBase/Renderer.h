#pragma once

#include <string>
#include <cstdlib>
#include <fstream>
#include <iostream>

#include "Dependencies\glew.h"
#include "Dependencies\wglew.h"
#include "Dependencies\glm/glm.hpp"
#include "Dependencies\glm/gtc/matrix_transform.hpp"
#include "Dependencies\glm/gtx/euler_angles.hpp"

class Renderer
{
public:
	Renderer(int windowSizeX, int windowSizeY);
	~Renderer();

	GLuint CreatePngTexture(char * filePath);
	GLuint CreateBmpTexture(char * filePath);
	   
	void Test();
	void Particle();
	void FSSandBox();
	void VSGridMeshSandBox();
	void DrawSimpleTexture();

private:
	void Initialize(int windowSizeX, int windowSizeY);
	bool ReadFile(char* filename, std::string *target);
	void AddShader(GLuint ShaderProgram, const char* pShaderText, GLenum ShaderType);
	GLuint CompileShaders(char* filenameVS, char* filenameFS);
	void CreateVertexBufferObjects(); 
	unsigned char * Renderer::loadBMPRaw(const char * imagepath, unsigned int& outWidth, unsigned int& outHeight);
	void CreateParticle(int count);
	void CreateGridGeometry();
	void CreateTextures();
	GLuint CreateFBO(int sx, int sy, GLuint* tex, GLuint* depthTex);

	bool m_Initialized = false;
	
	unsigned int m_WindowSizeX = 0;
	unsigned int m_WindowSizeY = 0;

	//camera position
	glm::vec3 m_v3Camera_Position;
	//camera lookat position
	glm::vec3 m_v3Camera_Lookat;
	//camera up vector
	glm::vec3 m_v3Camera_Up;

	glm::mat4 m_m4OrthoProj;
	glm::mat4 m_m4PersProj;
	glm::mat4 m_m4Model;
	glm::mat4 m_m4View;
	glm::mat4 m_m4ProjView;

	GLuint m_VBORect = 0;
	GLuint m_SolidRectShader = 0;
	GLuint m_FSSandboxShader = 0;
	GLuint m_VSGridMeshSandboxShader = 0;

	GLuint m_VBO = 0;
	GLuint m_VBO1 = 0;
	GLuint m_VBOManyParticle = 0;
	GLuint m_VBOManyparticleCount = 0;
	GLuint m_VBOFSSandBox = 0;

	GLuint m_VBO_GridGeo = 0;
	GLuint m_Count_GridGeo = 0;

	GLuint m_TextureCheckerBoard = 0;
	GLuint m_TextureRGB = 0;
	GLuint m_SimpleTextureShader = 0;
	GLuint m_VBORect_PosTex = 0;

	GLuint m_TextureID0 = 0;
	GLuint m_TextureID1 = 0;
	GLuint m_TextureID2 = 0;
	GLuint m_TextureID3 = 0;
	GLuint m_TextureID4 = 0;
	GLuint m_TextureID5 = 0;
	GLuint m_TextureIDTotal = 0;

	GLuint m_FBO_0 = 0;
	GLuint m_FBOTexture_0 = 0;
	GLuint m_FBO_Depth_0 = 0;

	GLuint m_FBO_P = 0;
	GLuint m_FBOTexture_P = 0;
	GLuint m_FBO_Depth_P = 0;

	GLuint m_FBO_F = 0;
	GLuint m_FBOTexture_F = 0;
	GLuint m_FBO_Depth_F = 0;

	GLuint m_FBO_G = 0;
	GLuint m_FBOTexture_G = 0;
	GLuint m_FBO_Depth_G = 0;
};

