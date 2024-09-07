#version 330 core
out vec4 FragColor;


uniform vec3 aColor;
uniform vec3 lightColor;

void main()
{
    FragColor = vec4(aColor*lightColor, 1.0f);
}