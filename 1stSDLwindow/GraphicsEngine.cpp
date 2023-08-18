#include "GraphicsEngine.h"

GraphicsEngine::GraphicsEngine()
{
}

bool GraphicsEngine::init()
{

	D3D_DRIVER_TYPE driver_types[] =
	{
		D3D_DRIVER_TYPE_HARDWARE,
		D3D_DRIVER_TYPE_WARP,
		D3D_DRIVER_TYPE_REFERENCE
	};
	UINT num_driver_types = ARRAYSIZE(driver_types);
	//D3D11CreateDevice(Null,);
	return true;
}

bool GraphicsEngine::release()
{
	return true;
}

GraphicsEngine::~GraphicsEngine()
{
}
