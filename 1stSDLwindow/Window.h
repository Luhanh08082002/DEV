#pragma once
#include <Windows.h>
class Window
{
public:

	Window();

	// khởi tạo cửa sổ
	 bool init();
	bool broadcst();

	
	// thả cửa sổ
	bool release();
	bool isRun();


	// Evenr
	virtual void onCreate();
	virtual void onUpdate();
	virtual void onDestroy();


	~Window();

protected:
	 HWND m_hwnd;
	 bool m_is_run;
};

